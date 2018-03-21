using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace DAQ
{
    public partial class SavePath : GZJBaseForm
    {
        MySetting setting = MySetting.GetMySetting();
        public SavePath()
        {
            InitializeComponent();
            this.textBox1.Text = setting.BaseDir;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.textBox1.Text = path.SelectedPath;
            setting.BaseDir = path.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySetting.Serialize(setting);
            setting = MySetting.GetMySetting();
            this.textBox1.Text = setting.BaseDir;
        }
    }
}
