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
        SerialPort _portIPB = new SerialPort("COM2", 9600, Parity.None,8,StopBits.One);
        SerialPort _portCHT = new SerialPort("COM1",9600,Parity.None,8,StopBits.One);
     
        public Daq()
        {
            try
            {
                InitializeComponent();
                StartPosition = FormStartPosition.CenterScreen;
                _portCHT.PortName = MySetting.GetMySetting().ChtCom;
                _portIPB.PortName = MySetting.GetMySetting().IpbCom;
                _portIPB.DataReceived += _portIPB_DataReceived;
                _portCHT.DataReceived += _portCHT_DataReceived;
                _portIPB.Open();
                _portCHT.Open();
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateUI();
            UpdateName();
        }
        private void UpdateName()
        {
           for(int i=0;i<18;i++)
           {
                string name = new string((char)('A' + i), 1);
                var control = GetControlByName(tableLayoutPanel1,name);
                if(control!=null&&control is labeledediter)
                {
                    try
                    {
                        var c = control as labeledediter;
                        c.Key = MySetting.GetMySetting().Dictionary[name];
                    }
                    catch (Exception)
                    {
                    }
                }                  
           }
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
                    string[] values = buffer.Split(',',':');
                    if (values.Length == 3)
                    {

                        double c;
                        var setting= MySetting.GetMySetting();
                        string ohm = double.TryParse(values[0], out c) ? (c+setting.Ohmoffset).ToString() : double.NaN.ToString();
                        string result = ((c+setting.Ohmoffset)>=setting.Ohmlower && (c + setting.Ohmoffset) <= setting.Ohmupper) ? "OK" : "NG";
                        Invoke(new MethodInvoker(() =>
                        {
                            tbxFirstNum.Text = ohm;
                            tbxSecondNum.Text = values[1];
                        }));
                        SaveLog("电阻测试", new string[] {setting.Ohmlower.ToString(),setting.Ohmupper.ToString() ,ohm, values[1], result },new string[] { "下限","上限","电阻","温度","判定"});
                    }
                }
            }
        }

        public void SaveLog(string Name,string[] values,string[] titles)
        {
            var path = MySetting.GetMySetting().BaseDir;
            var fullpath = Path.Combine(path, Name);
            if (!Directory.Exists(fullpath))
                Directory.CreateDirectory(fullpath);
            var fullname = Path.Combine(fullpath, Name+DateTime.Today.ToString("yyyyMMdd")+ ".xls");
            bool Created = true;
            if(!File.Exists(fullname))
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
            sb1.Append(DateTime.Now.ToString("HH:mm:dd"));
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

        private Control GetControlByName(Control parent,string name)
        {
            Control control = null;
           var c =parent.Controls.Find(name, true);
            if(c!=null&&c.Length>0)
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
                    string[] values = buffer.Split(',',':');
                    if (values.Length == 18)
                    {
                        this.Invoke(new MethodInvoker(() =>
                        {
                            A.Value = values[0];
                            B.Value = values[1];
                            C.Value = values[2];
                            D.Value = values[3];
                            E.Value = values[4];
                            F.Value = values[5];
                            G.Value = values[6];
                            H.Value = values[7];
                            I.Value = values[8];
                            J.Value = values[9];
                            K.Value = values[10];
                            L.Value = values[11];
                            M.Value = values[12];
                            N.Value = values[13];
                            O.Value = values[14];
                            P.Value = values[15];
                            Q.Value = values[16];
                            R.Value = values[17];
                        }));
                        SaveLog("点焊机", values, MySetting.GetMySetting().Dictionary.Select(t => t.Value).ToArray());
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
            new PortSetting(_portIPB, _portCHT) {StartPosition=FormStartPosition.CenterScreen}.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
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
            new OhmSetting().ShowDialog();
        }
    }


}
