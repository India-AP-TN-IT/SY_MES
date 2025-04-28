using SY_MES.Logics.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.Logics.MES.Sub
{
    [ToolboxItem(true)]
    public partial class LegendUC : LocalUC
    {
        private int m_CountOfIdx = 5;
        [Category(Base.Common.CN_CATEGORY_APP)]
        public int CountOfIdx
        {
            get { return m_CountOfIdx; }
            set { m_CountOfIdx = value; }
        }
        public LegendUC()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
        }

        private DataTable GetData()
        {

            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", ParentBC.BaseINF.CORCD);
            param.Add("IN_BIZCD", ParentBC.BaseINF.BIZCD);
            param.Add("IN_PARTNO", Common.GetProductInfor("PARTNO"));
            DataTable dt = ParentBC.ExecuteQuery("PKG_ME_TAG_PRINT.GET_TAG_DET_INFOR", param);
            return dt;
        }
        public override void LoadData()
        {
            DataTable dt = GetData();
            flowLayoutPanel1.Controls.Clear();
            if(dt.Rows.Count>0)
            {
                for (int i = 0; i < m_CountOfIdx; i++)
                {
                    SpecSheetCtl ctl = new SpecSheetCtl();
                    ctl.Width = this.Size.Width - 20;
                    ctl.Height = 55;
                    ctl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                    string title = dt.Rows[0]["TIT" + (i + 1).ToString().PadLeft(2, '0')].ToString();
                    string val = dt.Rows[0]["SPC" + (i + 1).ToString().PadLeft(2, '0')].ToString();
                    if (string.IsNullOrEmpty(title) == false)
                    {
                        ctl.TitleCtl.Text = title;
                        ctl.DescCtl.Text = val;
                        this.flowLayoutPanel1.Controls.Add(ctl);
                    }
                    
                }
            }
        }

    }
}
