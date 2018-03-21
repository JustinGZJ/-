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

namespace DAQ
{
    public partial class PortSetting : GZJBaseForm
    {
        string[] _ports= SerialPort.GetPortNames();
        SerialPort _portIPB = null;
        SerialPort _portCHT = null;

        public PortSetting(SerialPort portIPB,SerialPort portCHT)
        {
            InitializeComponent();
            if(_ports!=null&&_ports.Length>0)
            {
                this.comboBox1.Items.AddRange(_ports);
                this.comboBox2.Items.AddRange(_ports);
            }
            _portCHT = portCHT;
            _portIPB = portIPB;
            comboBox1.Text = portIPB.PortName;
            comboBox2.Text = portCHT.PortName;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySetting setting = MySetting.GetMySetting();
            setting.IpbCom = comboBox1.Text;
            MySetting.Serialize(setting);
        }

        private void btnlink1_Click(object sender, EventArgs e)
        {
            SerialPort port = _portIPB;
            try
            {
                port.Close();
                port.PortName = this.comboBox1.Text;
            
                try
                {
                  
                    port.Open();
                    MessageBox.Show("串口打開成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("連接失敗!! " + Environment.NewLine + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
              //  Close();
              
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort port = _portCHT;
            try
            {
                port.Close();
                port.PortName = this.comboBox2.Text;
              
                try
                {
             
                    port.Open();
                    MessageBox.Show("串口打開成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("連接失敗!! " + Environment.NewLine + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
             //   Close();
                
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySetting setting = MySetting.GetMySetting();
            setting.ChtCom= comboBox2.Text;
            MySetting.Serialize(setting);
        }
    }
}
