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
        TcpClient client = null;
        NetworkStream stream = null;
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
            if (client == null) return;
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
                    }
                    catch (SocketException se) { break; }
                }
            });
        }

        private void Messenger_Load(object sender, EventArgs e)
        {

        }
    }
}
