using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SY_MES.FX.Controls.Base;

namespace SY_MES.FX.Controls
{
    public partial class YDateTime : UserControl, FX.Controls.Base.IYControls
    {
        private DateTime m_SelDateTime = DateTime.Now;
        private string m_Key = "";
        public delegate void DateChg(object sender, DateTime date);
        [Category(Common.CN_CATEGORY_APP)]
        public event DateChg OnDateChg = null;
        private string m_Title = "";
        private string m_DateFormat = "yyyy-MM-dd";
        private bool m_bInit = false;
        private bool m_bEditDate = false;
        [Category(Common.CN_CATEGORY_APP)]
        public string Title
        {
            get { return m_Title; }
            set
            {
                m_Title = value;
                Lbl_Title.Text = value;
            }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public string DateFormat
        {
            get { return m_DateFormat; }
            set
            {
                m_DateFormat = value;
                if (Lbl_Date != null)
                {
                    Lbl_Date.Text = m_SelDateTime.ToString(DateFormat);
                    
                }
            }
        }

        public DateTime SelDateTime
        {
            get
            {
                m_SelDateTime = DateTime.ParseExact(Lbl_Date.Text, DateFormat, null);
                return m_SelDateTime;

            }
        }
        private void Btn_Prv_Click(object sender, EventArgs e)
        {
            this.Lbl_Date.Text = SelDateTime.AddDays(-1).ToString(DateFormat);
        }

        private void Btn_Nex_Click(object sender, EventArgs e)
        {
            this.Lbl_Date.Text = SelDateTime.AddDays(1).ToString(DateFormat);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            m_bInit = true;
            string SCM = string.Empty;
            base.OnLoad(e);
            if (!DesignMode)
            {
                Lbl_Date.ForeColor = Color.Black;
                Lbl_Date.BackColor = Color.PeachPuff;
                if (!m_bEditDate)
                {
                    Lbl_Date.Text = DateTime.Now.ToString(m_DateFormat);
                }
                else if (m_bEditDate && Lbl_Date.Text != DateTime.Now.ToString(DateFormat))
                {
                    Lbl_Date.BackColor = Color.Red;
                    Lbl_Date.ForeColor = Color.White;
                }


                m_bInit = false;
            }
        }

        public YDateTime()
        {
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
            get { return this.Lbl_Date.Text; }
            set { this.Lbl_Date.Text = value; }
        }
        public void SetValue(object val)
        {
            if(val is DateTime)
            {
                this.Lbl_Date.Text = ((DateTime)val).ToString(DateFormat);
            }
            else
            {
                this.Lbl_Date.Text = val.ToString();
            }
        }

        public object GetValue()
        {
            return SelDateTime.ToString(DateFormat);
        }

        public void ClearValue()
        {
            this.Lbl_Date.Text = DateTime.Now.ToString(DateFormat);
        }

        public void RefreshCtl()
        {
        }

        private void Lbl_Date_Click(object sender, EventArgs e)
        {
            ClearValue();
        }

        private void Lbl_Date_TextChanged(object sender, EventArgs e)
        {
            if (!m_bInit)
            {
                if (Lbl_Date.Text == DateTime.Now.ToString(DateFormat))
                {
                    Lbl_Date.BackColor = Color.PeachPuff;
                    Lbl_Date.ForeColor = Color.Black;
                }
                else
                {
                    Lbl_Date.BackColor = Color.Red;
                    Lbl_Date.ForeColor = Color.White;
                }
                if (OnDateChg != null)
                {
                    OnDateChg(this, SelDateTime);
                }
            }
        }
    }
}
