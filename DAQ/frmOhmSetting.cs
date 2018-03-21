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
    public partial class frmOhmSetting : GZJBaseForm
    {
        MySetting setting = MySetting.GetMySetting();
        public frmOhmSetting()
        {
            InitializeComponent();
            if (setting.Ohmparas == null)
                setting.Ohmparas = new List<OhmPara>();
            setting.Ohmparas.RemoveAll(t => string.IsNullOrWhiteSpace(t.Name));
            MySetting.Serialize(setting);
            setting = MySetting.GetMySetting();
            this.textBox1.ReadOnly = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = this.listBox1.SelectedIndex;
            if (index >= 0)
            {
                string Name = listBox1.Items[index].ToString();
                var a = setting.Ohmparas.Where(t => t.Name == Name).First();
                this.textBox1.Text = a.Name;
                this.textBox2.Text = a.UpperValue.ToString();
                this.textBox3.Text = a.LowerValue.ToString();
                this.textBox4.Text = a.Offset.ToString();
                this.cboAutoRange.SelectedIndex = a.AutoRange;
                this.cboRange.SelectedIndex = a.Range;
                this.cboRate.SelectedIndex = a.RATE;
                this.cboSource.SelectedIndex = a.Source;
            }
        }

        private void frmOhmSetting_Load(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            setting = MySetting.GetMySetting();
            var s = setting.Ohmparas.Select(t => t.Name);
            if (s != null && s.Count() > 0)
            {
                foreach (var b in s)
                {
                    if (!string.IsNullOrWhiteSpace(b))
                        this.listBox1.Items.Add(b);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "添加")
            {
                Add();
            }
            else
            {
                Modify();
            }
        }
        private void Add()
        {
            double v;
            string name = textBox1.Text;
            if (setting.Ohmparas.Exists(t => t.Name == name))
            {
                MessageBox.Show("机种已存在");
                return;
            }
            if (!double.TryParse(this.textBox2.Text, out v))
            {
                MessageBox.Show("上限值应为实数");
                return;
            }
            var a = new OhmPara();
            a.Name = this.textBox1.Text;
            a.UpperValue = v;
            if (!double.TryParse(this.textBox3.Text, out v))
            {
                MessageBox.Show("下限值应为实数");
                return;
            }
            a.LowerValue = v;
            if (!double.TryParse(this.textBox4.Text, out v))
            {
                MessageBox.Show("偏移值应为实数");
                return;
            }

            a.Offset = v;
            a.AutoRange = cboAutoRange.SelectedIndex;
            a.Range = cboRange.SelectedIndex;
            a.RATE = cboRate.SelectedIndex;
            a.Source = cboSource.SelectedIndex;

            setting.Ohmparas.Add(a);
            MySetting.Serialize(setting);

            listBox1.Items.Clear();
            setting = MySetting.GetMySetting();
            listBox1.Items.AddRange(setting.Ohmparas.Select(t => t.Name).ToArray());
            this.textBox1.ReadOnly = true;
            button3.Text = "保存";
        }
        private void Modify()
        {
            double v;
            string name = textBox1.Text;
            if (!setting.Ohmparas.Exists(t => t.Name == name))
            {
                MessageBox.Show("机种不存在");
                return;
            }
            var para = setting.Ohmparas.Where(t => t.Name == name).First();
            var index = setting.Ohmparas.IndexOf(para);
            if (!double.TryParse(this.textBox2.Text, out v))
            {
                MessageBox.Show("上限值应为实数");
                return;
            }
            para.UpperValue = v;
            if (!double.TryParse(this.textBox3.Text, out v))
            {
                MessageBox.Show("下限值应为实数");
                return;
            }
            para.LowerValue = v;
            if (!double.TryParse(this.textBox4.Text, out v))
            {
                MessageBox.Show("偏移值应为实数");
                return;
            }
            para.Offset = v;
            para.AutoRange = cboAutoRange.SelectedIndex;
            para.Range = cboRange.SelectedIndex;
            para.RATE = cboRate.SelectedIndex;
            para.Source = cboSource.SelectedIndex;
            setting.Ohmparas[index] = para;
            MySetting.Serialize(setting);

            listBox1.Items.Clear();
            setting = MySetting.GetMySetting();
            listBox1.Items.AddRange(setting.Ohmparas.Select(t => t.Name).ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setting = MySetting.GetMySetting();
            if (this.listBox1.SelectedIndex >= 0)
            {
                string Name = listBox1.Items[listBox1.SelectedIndex].ToString();
                var a = setting.Ohmparas.Where(t => t.Name == Name).First();
                var index = setting.Ohmparas.Remove(a);
                MySetting.Serialize(setting);
            }
            listBox1.Items.Clear();
            setting = MySetting.GetMySetting();
            listBox1.Items.AddRange(setting.Ohmparas.Select(t => t.Name).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button3.Text = "添加";
            this.textBox1.ReadOnly = false;
            var a = new OhmPara();
            this.textBox1.Text = a.Name;
            this.textBox2.Text = a.UpperValue.ToString();
            this.textBox3.Text = a.LowerValue.ToString();
            this.textBox4.Text = a.Offset.ToString();
            this.cboAutoRange.SelectedIndex = a.AutoRange;
            this.cboRange.SelectedIndex = a.Range;
            this.cboRate.SelectedIndex = a.RATE;
            this.cboSource.SelectedIndex = a.Source;
        }
    }
}
