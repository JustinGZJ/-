using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQ
{
    public partial class labeledediter : UserControl
    {
        public labeledediter()
        {
            InitializeComponent();
        }
        public string Key { get { return this.label1.Text; }set { this.label1.Text = value; } }

        public  string Value { get { return tbx.Text; }set{ this.tbx.Text = value; } }

    }
}
