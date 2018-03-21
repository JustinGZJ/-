using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace DAQ
{
    public partial class 电阻测试仪参数设置 : GZJBaseForm
    {
       readonly string[] array1 = { "ON", "OFF" };
        readonly string[] array2 = { };
        SerialPort _port=null;
        public 电阻测试仪参数设置(SerialPort port)
        {
            InitializeComponent();
            _port = port;
            this.comboBox1.SelectedIndex = 1;
            this.comboBox4.SelectedIndex = 1;
            this.comboBox5.SelectedIndex = 1;
        }
    }
}
