using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice2
{
    public partial class Form1 : Form
    {
        private int Cost{ get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                radioButton4.Checked = true;
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
            }
            else
            {
                radioButton4.Checked = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rad = "미선택";
            foreach (RadioButton rbt in groupBox1.Controls)
            {
                if (rbt.Checked == true)
                {
                    rad = "결제 : " + rbt.Text;
                }
            }

            if (rad == "미선택" || Cost == 0)
                return;

            MessageBox.Show(rad + "\n가격 : " + Cost);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            const int Cost_JJM = 3500;
            if (checkBox1.Checked == true)
            {
                Cost += Cost_JJM;
            }
            else
            {
                Cost -= Cost_JJM;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            const int Cost_JB = 4000;
            if (checkBox2.Checked == true)
            {
                Cost += Cost_JB;
            }
            else
            {
                Cost -= Cost_JB;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            const int Cost_TS6 = 10000;
            if (checkBox2.Checked == true)
            {
                Cost += Cost_TS6;
            }
            else
            {
                Cost -= Cost_TS6;
            }
        }
    }
}
