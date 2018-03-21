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
    public partial class 密码设置 :GZJBaseForm
    {
        MySetting setting = MySetting.GetMySetting();
        public 密码设置()
        {
            InitializeComponent();
            this.textBox1.Text = setting.Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("是否将密码设置为:" + textBox1.Text,"请确认",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                setting.Password = textBox1.Text;
                MySetting.Serialize(setting);
            }       
        }
    }
}
