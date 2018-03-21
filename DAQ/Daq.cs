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
        SerialPort _portIPB = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);
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
                _portIPB.PortName = setting.IpbCom;
                _portIPB.DataReceived += _portIPB_DataReceived;
                _portCHT.DataReceived += _portCHT_DataReceived;
                _portIPB.Open();
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
            this.dataGridView1.DataSource = ipbBinding;
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
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    string name = new string((char)('A' + j), 1);
                    if (dataGridView1.Columns[i].HeaderText == name)
                    {
                        dataGridView1.Columns[i].HeaderText = MySetting.GetMySetting().Dictionary[name];
                    }
                }
            }
            this.dataGridView1.Columns[0].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";
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
                        string ohm = double.TryParse(values[0], out c) ? (c + setting.Ohmoffset).ToString() : double.NaN.ToString();
                        string result = ((c + setting.Ohmoffset) >= setting.Ohmlower && (c + setting.Ohmoffset) <= setting.Ohmupper) ? "OK" : "NG";
                        Invoke(new MethodInvoker(() =>
                        {
                            tbxFirstNum.Text = ohm + " Ω";
                            tbxSecondNum.Text = values[1] + " ℃";
                            ohmBinding.Add(new OhmTest { 时间 = DateTime.Now, 判定 = result, 产品型号 = setting.Ohmparas[setting.ModelIndex].Name, 温度 = values[1], 电阻值 = ohm });
                            //  ohmBinding.OrderBy(T => T.时间);

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

        private void _portIPB_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;
            if (port.BytesToRead > 0)
            {
                string buffer = port.ReadLine();
                if (buffer.Length > 50 && buffer.StartsWith("!"))
                {
                    buffer = buffer.Substring(1).Insert(2, ",").TrimEnd('\r', '\n');
                    string[] values = buffer.Split(',', ':');
                    if (values.Length == 18)
                    {
                        this.Invoke(new MethodInvoker(() =>
                        {
                            ipbBinding.Add(new IPB()
                            {
                                时间 = DateTime.Now,
                                产品型号 = setting.Ohmparas[setting.ModelIndex].Name,
                                A = values[0],
                                B = values[1],
                                C = values[2],
                                D = values[3],
                                E = values[4],
                                F = values[5],
                                G = values[6],
                                H = values[7],
                                I = values[8],
                                J = values[9],
                                K = values[10],
                                L = values[11],
                                M = values[12],
                                N = values[13],
                                O = values[14],
                                P = values[15],
                                Q = values[16],
                                R = values[17]
                            });
                            this.dataGridView1.CurrentCell = this.dataGridView1[dataGridView1.CurrentCell.ColumnIndex, dataGridView1.Rows.Count - 1];
                        }));
                        var listv = new List<string>(values);
                        listv.Insert(0, setting.Ohmparas[setting.ModelIndex].Name);
                        var listt = new List<string>(MySetting.GetMySetting().Dictionary.Select(t => t.Value).ToArray());
                        listt.Insert(0, "产品型号");
                        SaveLog("点焊机", listv.ToArray(), listt.ToArray());
                    }
                }
            }
        }
        private void 其他设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditPara().ShowDialog();
            UpdateName();
        }

        private void 串口设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PortSetting(_portIPB, _portCHT) { StartPosition = FormStartPosition.CenterScreen }.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateSerialPortState();
        }

        private void UpdateSerialPortState()
        {
            if (_portCHT.IsOpen)
            {
                this.toolStripStatusLabel3.Image = imageList1.Images[1];
            }
            else
            {
                this.toolStripStatusLabel3.Image = imageList1.Images[0];
            }

            if (_portIPB.IsOpen)
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
            setting.Ohmoffset = ohmPara.Offset;
            MySetting.Serialize(setting);
            if (_portCHT.IsOpen)
            {
                _portCHT.Write(COMMANDS.CMD_AUTO_RANGE[ohmPara.AutoRange]+"\r\n");
                System.Threading.Thread.Sleep(50);
                _portCHT.Write(COMMANDS.CMD_Range[ohmPara.Range] + "\r\n");
                System.Threading.Thread.Sleep(50);
                _portCHT.Write(COMMANDS.CMD_Source[ohmPara.Source] + "\r\n");
                System.Threading.Thread.Sleep(50);
                _portCHT.Write(COMMANDS.GetCMD_HIGH(ohmPara.UpperValue - ohmPara.Offset) + "\r\n");
                System.Threading.Thread.Sleep(50);
                _portCHT.Write(COMMANDS.GetCMD_LOW(ohmPara.LowerValue - ohmPara.Offset) + "\r\n");
                System.Threading.Thread.Sleep(50);
                _portCHT.Write(COMMANDS.CMD_RATE[ohmPara.RATE] + "\r\n");
                System.Threading.Thread.Sleep(50);
                _portCHT.Write("COMParator ON\r\n");
                System.Threading.Thread.Sleep(50);
                _portCHT.Write("FUNCtion:TC ON\r\n");
            }
            else
            {
                     MessageBox.Show("电阻测试仪串口未打开");
            }
        }

        private void 其他设置ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void 密码设置ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (new Password().ShowDialog() == DialogResult.Yes)
                new 密码设置().ShowDialog();
        }

        private void 仪器设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new 电阻测试仪参数设置(_portCHT).ShowDialog();
        }
    }
    public class IPB
    {
        public DateTime 时间 { get; set; }
        public string 产品型号 { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string E { get; set; }
        public string F { get; set; }
        public string G { get; set; }
        public string H { get; set; }
        public string I { get; set; }
        public string J { get; set; }
        public string K { get; set; }
        public string L { get; set; }
        public string M { get; set; }
        public string N { get; set; }
        public string O { get; set; }
        public string P { get; set; }
        public string Q { get; set; }
        public string R { get; set; }
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
