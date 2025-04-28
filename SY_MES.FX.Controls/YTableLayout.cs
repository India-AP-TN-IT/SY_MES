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
    [ToolboxBitmap(typeof(TableLayoutPanel))]
    public partial class YTableLayout : TableLayoutPanel, Base.IYControls
    {
        private string m_Key = "";
        public YTableLayout()
        {
            this.DoubleBuffered = true;
            
            InitializeComponent();
        }
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
        public void SetValue(object val)
        {
            
        }

        public object GetValue()
        {
            return null;
        }

        public void ClearValue()
        {
            this.ClearValue();
        }

        public void RefreshCtl()
        {
            
        }
    }
}
