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
    public partial class OhmSetting : GZJBaseForm
    {
        MySetting setting = MySetting.GetMySetting();
        public OhmSetting()
        {
            InitializeComponent();
            this.textBox1.Text = setting.Ohmupper.ToString();
            this.textBox2.Text = setting.Ohmlower.ToString();
            this.textBox3.Text = setting.Ohmoffset.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v;
            if(double.TryParse(textBox1.Text,out v))
            {
                setting.Ohmupper = v;
            }
            else
            {
                MessageBox.Show("上限值参数有误,请输入实数");
                return;
            }
            if (double.TryParse(textBox2.Text, out v))
            {
                setting.Ohmlower = v;
            }
            else
            {
                MessageBox.Show("下限值参数有误,请输入实数");
                return;
            }

            if (double.TryParse(textBox3.Text, out v))
            {
                setting.Ohmoffset = v;
            }
            else
            {
                MessageBox.Show("偏移值参数有误,请输入实数");
                return;
            }
            MySetting.Serialize(setting);
        }
    }
}
