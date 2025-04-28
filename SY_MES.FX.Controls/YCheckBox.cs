using SY_MES.FX.Controls.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.FX.Controls
{
    public partial class YCheckBox : CheckBox, Base.IYControls
    {
        public YCheckBox()
        {
            InitializeComponent();
        }

        private string m_Key = "";
        [Category(Common.CN_CATEGORY_APP)]
        public string Key
        {
            get
            {
                return m_Key;
            }
            set
            {
                m_Key = value;
            }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public string Desc
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        public void ClearValue()
        {

        }

        public object GetValue()
        {
            return this.Text;
        }

        public void RefreshCtl()
        {

        }

        public void SetValue(object val)
        {
            this.Text = val.ToString();
        }
    }
}
