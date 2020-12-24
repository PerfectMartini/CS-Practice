using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace SimpleMessenger
{
    public partial class Messenger : Form
    {
        /* [TODO]
        * 클라이언트에 해당하는 폼입니다.
        * 폼 디자이너를 이용하여 적절한 컨트롤들을 배치하고 여러 상호작용 이벤트들을 처리하여 
        * 프로그램을 완성해보세요 :)
        */
        TcpClient client;
        NetworkStream stream;
        public Messenger()
        {
            InitializeComponent();
        }

        private async Task ReceiveMessage()
        {
            /* [TODO]
             * client와 stream에 적절한 값을 입력하여 서버로부터 메세지를 받아옵니다.
             * 해당 메소드를 사용하지 않아도 무방합니다.
             */
            if (client == null)
            {
                return;
            }

            await Task.Run(async () =>
            {
                byte[] data = new byte[32768];
                string responseData = "";
                while (true)
                {
                    while (stream == null)
                    {
                        await Task.Delay(10);
                    }
                    try
                    {
                        int bytes = stream.Read(data, 0, data.Length);
                        responseData = Encoding.Default.GetString(data, 0, bytes);
                        TextBox_ChatLog.Text += responseData;
                    }
                    catch (SocketException se) { break; }
                }
            });
        }

        private void Messenger_Load(object sender, EventArgs e)
        {

        }

        private void Button_Connection_Click(object sender, EventArgs e)
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            string bindIp = "";
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    bindIp = ip.ToString();
                }
            }
            int bindPort = 0;
            if (Radio_A.Checked == true)
            {
                bindPort = 5001;
            }
            else if (Radio_B.Checked == true)
            {
                bindPort = 5002;
            }
            // 일단 같은 컴퓨터 내 통신
            string serverIp = bindIp;
            const int serverPort = 5050;

            try
            {
                IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse(bindIp), bindPort);
                IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

                client = new TcpClient(clientAddress);
                client.Connect(serverAddress);
                stream = client.GetStream();
            }
            catch (SocketException se)
            {
                return;
            }

            Label_ChooseClient.Visible = false;
            Radio_A.Visible = false;
            Radio_B.Visible = false;
            Button_Connection.Visible = false;
            Label_Success.Visible = true;

            TextBox_ChatLog.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            TextBox_ChatLog.Text += "\t" + (char)((bindPort - 5001) + 'A') + "님께서 접속하셨습니다\n";
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            if (client == null) return;

            byte[] data = Encoding.Default.GetBytes(TextBox_SendMessage.Text);
            stream.Write(data, 0, data.Length);

            TextBox_ChatLog.Text += TextBox_SendMessage.Text;
            TextBox_SendMessage.Text = "";

            ReceiveMessage();
        }
    }
}
