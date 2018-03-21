using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQ
{
    public partial class EditPara : GZJBaseForm
    {
        Dictionary<string, string> dictionary = null;
        BindingList<KV> bindingList = null;
        public EditPara()
        {
            InitializeComponent();
            BindDictionary();
        }

        private void BindDictionary()
        {
            dictionary = MySetting.GetMySetting().Dictionary;
            bindingList = new BindingList<KV>(dictionary.Select(t => new KV() {  编号 = t.Key, 名称 = t.Value }).ToList());
            this.dataGridView1.DataSource = bindingList;
        }

        public class KV
        {
            public string 编号 { get; set; }
            public string 名称 { get; set; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           var list = bindingList.ToList();
            dictionary=new Dictionary<string,string>();
           foreach(var a in list)
            {
                dictionary.Add(a.编号, a.名称);
            }
            var setting = MySetting.GetMySetting();
            setting.Dictionary = dictionary;
            MySetting.Serialize(setting);
            BindDictionary();
        }
    }

}
