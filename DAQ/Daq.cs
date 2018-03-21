using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace DAQ
{
    public partial class Daq : GZJBaseForm
    {
        SerialPort _portCHT = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
        MySetting setting = MySetting.GetMySetting();
        static List<IPB> ipblist = new List<IPB>();
        BindingList<IPB> ipbBinding = new BindingList<IPB>(ipblist);
        static List<OhmTest> ohmlist = new List<OhmTest>();
        BindingList<OhmTest> ohmBinding = new BindingList<OhmTest>(ohmlist);
        public Daq()
        {
            try
            {
                InitializeComponent();
                StartPosition = FormStartPosition.CenterScreen;
                _portCHT.PortName = setting.ChtCom;
                _portCHT.DataReceived += _portCHT_DataReceived;
                _portCHT.Open();
                timer1.Enabled = true;
                UpdateSerialPortState();
                LoadPara();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void LoadPara()
        {
            if (setting.Ohmparas == null)
                setting.Ohmparas = new List<OhmPara>();
            setting.Ohmparas.RemoveAll(t => string.IsNullOrWhiteSpace(t.Name));
            MySetting.Serialize(setting);
            setting = MySetting.GetMySetting();
            this.dataGridView2.DataSource = ohmBinding;
            UpdateName();
            var s = setting.Ohmparas.Select(t => t.Name).ToList();
            if (s != null && s.Count() > 0)
            {
                foreach (var b in s)
                {
                    if (!string.IsNullOrWhiteSpace(b))
                        this.comboBox1.Items.Add(b);
                }
            }
            if (comboBox1.Items.Count > 0)
                this.comboBox1.SelectedIndex = setting.ModelIndex;
        }

        private void UpdateName()
        {
            this.dataGridView2.Columns[0].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";
        }


        private void _portCHT_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;
            if (port.BytesToRead > 0)
            {
                string buffer = port.ReadLine();
                if (buffer.Length > 5)
                {
                    buffer = buffer.TrimEnd('\r', '\n');
                    string[] values = buffer.Split(',', ':');
                    if (values.Length == 3)
                    {
                        double c;
                        var setting = MySetting.GetMySetting();
                        string ohm = double.TryParse(values[0], out c) ? c.ToString() : double.NaN.ToString();
                        string result = (c>= setting.Ohmlower && (c <= setting.Ohmupper))
                                        || (c >= setting.SecOhmlower && (c <= setting.SecOhmupper)) ? "OK" : "NG";
                        Invoke(new MethodInvoker(() =>
                        {
                            tbxFirstNum.Text = ohm + " Ω";
                            tbxSecondNum.Text = values[1] + " ℃";
                            ohmBinding.Add(new OhmTest { 时间 = DateTime.Now, 判定 = result, 产品型号 = setting.Ohmparas[setting.ModelIndex].Name, 温度 = values[1], 电阻值 = ohm });
                            this.dataGridView2.CurrentCell = this.dataGridView2[dataGridView2.CurrentCell.ColumnIndex, dataGridView2.Rows.Count - 1];
                        }));
                        SaveLog("电阻测试", new string[] { setting.Ohmparas[setting.ModelIndex].Name, ohm, values[1], result }, new string[] { "产品型号", "电阻", "温度", "判定" });
                    }
                }
            }
        }

        public void SaveLog(string Name, string[] values, string[] titles)
        {
            var path = MySetting.GetMySetting().BaseDir;
            var fullpath = Path.Combine(path, Name);
            if (!Directory.Exists(fullpath))
                Directory.CreateDirectory(fullpath);
            var fullname = Path.Combine(fullpath, Name + DateTime.Today.ToString("yyyyMMdd") + ".xls");
            bool Created = true;
            if (!File.Exists(fullname))
            {
                Created = false;
            }
            FileStream fs = new FileStream(fullname, FileMode.Append, FileAccess.Write);
            StreamWriter rw = new StreamWriter(fs, Encoding.Default);
            if (!Created)
            {
                var sb0 = new StringBuilder();
                sb0.Append("时间");
                sb0.Append("\t");
                foreach (var item in titles)
                {
                    sb0.Append(item);
                    sb0.Append("\t");
                }
                rw.WriteLine(sb0.ToString());
            }
            var sb1 = new StringBuilder();
            sb1.Append(DateTime.Now.ToString("HH:mm:ss"));
            sb1.Append("\t");
            foreach (var item in values)
            {
                sb1.Append(item);
                sb1.Append("\t");
            }
            rw.WriteLine(sb1.ToString());
            rw.Close();
            fs.Close();
        }

        private Control GetControlByName(Control parent, string name)
        {
            Control control = null;
            var c = parent.Controls.Find(name, true);
            if (c != null && c.Length > 0)
            {
                control = c[0];
            }
            return control;
        }


        private void 其他设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditPara().ShowDialog();
            UpdateName();
        }

        private void 串口设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PortSetting( _portCHT) { StartPosition = FormStartPosition.CenterScreen }.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateSerialPortState();
        }

        private void UpdateSerialPortState()
        {
            if (_portCHT.IsOpen)
            {
                this.toolStripStatusLabel2.Image = imageList1.Images[1];
            }
            else
            {
                this.toolStripStatusLabel2.Image = imageList1.Images[0];
            }

            statusStrip1.Invalidate();
        }

        private void 路径设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SavePath().ShowDialog();
        }

        private void 系统补偿ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new Password().ShowDialog() == DialogResult.Yes)
                new frmOhmSetting().ShowDialog();
            setting = MySetting.GetMySetting();
            if (setting.Ohmparas == null)
                setting.Ohmparas = new List<OhmPara>();
            setting.Ohmparas.RemoveAll(t => string.IsNullOrWhiteSpace(t.Name));
            MySetting.Serialize(setting);
            setting = MySetting.GetMySetting();
            var s = setting.Ohmparas.Select(t => t.Name);
            this.comboBox1.Items.Clear();
            if (s != null && s.Count() > 0)
            {
                foreach (var b in s)
                {
                    if (!string.IsNullOrWhiteSpace(b))
                        this.comboBox1.Items.Add(b);
                }
            }
            try
            {
                this.comboBox1.SelectedIndex = setting.ModelIndex;
            }
            catch (Exception)
            {
                this.comboBox1.SelectedIndex = 0;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCHTSetting();
        }

        private void UpdateCHTSetting()
        {
            setting.ModelIndex = comboBox1.SelectedIndex;
            OhmPara ohmPara = setting.Ohmparas[setting.ModelIndex];
            setting.Ohmupper = ohmPara.UpperValue;
            setting.Ohmlower = ohmPara.LowerValue;
            setting.SecOhmlower = ohmPara.SecLowerValue;
            setting.SecOhmupper = ohmPara.SecUpperValue;
            MySetting.Serialize(setting);
        }

        private void 其他设置ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void 密码设置ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (new Password().ShowDialog() == DialogResult.Yes)
                new 密码设置().ShowDialog();
        }
    }

    public class OhmTest
    {
        public DateTime 时间 { get; set; }
        public string 产品型号 { get; set; }
        public string 电阻值 { get; set; }
        public string 温度 { get; set; }
        public string 判定 { get; set; }
    }
}
