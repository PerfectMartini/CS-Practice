using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRACTICE_LOAD
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private bool Toggle { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeBackColor();
        }

        private void ChangeBackColor()
        {
            if (Toggle)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.Blue;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Toggle ^= true;
                ChangeBackColor();
            }
        }
    }
}
