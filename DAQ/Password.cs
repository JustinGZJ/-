using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DAQ
{
    public partial class Password :GZJBaseForm
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = MySetting.GetMySetting().Password;
            if(password==null)
            {
                password = "12306";
            }
            if (this.textBox1.Text == password)
            {
                DialogResult = DialogResult.Yes;
            }
            else
            {
                DialogResult = DialogResult.No;
                MessageBox.Show("密码错误");
            }
        }
    }
}
