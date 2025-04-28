using SY_MES.FX.Controls;
using SY_MES.FX.Controls.Base;
using SY_MES.FX.MainForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.Logics.Base
{
    [ToolboxItem(true)]
    public partial class CodeSelectBC : LocalizedContainer
    {
        
        private SelectedST m_SelectedItem;
        private CodeListEnum m_CodeListEnum = CodeListEnum.None;
        private DataTable m_DtRef = null;

        public struct SelectedST
        {
            public string Key;
            public string Desc;
        }
        public struct CodeListQueryST
        {
            public string query;
            public Dictionary<string, string> param;
        }
        public SelectedST SelectedItem
        {
            get { return m_SelectedItem; }
            set { m_SelectedItem = value; }
        }
        public enum CodeListEnum
        {
            None,
            INSTALL_POS,
            ASSY_LINE,
            ASSY_SHIFT,
            REWORK_DEF_TYPE,
            REWORK_METHOD,
            WHO_RESPONSIBILITY,
        }
        public CodeSelectBC(CodeListEnum cdList, string selectedKey)
        {
            InitializeComponent();
            m_CodeListEnum = cdList;
            m_SelectedItem.Key = selectedKey;
        }
        public CodeSelectBC()
        {
            InitializeComponent();
            m_CodeListEnum = CodeListEnum.None;
            m_SelectedItem.Key = "";
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        
        public override void LoadData()
        {
            base.LoadData();
            CodeListQueryST query = GetItemQuery(BaseINF);

            lblDesc.Text = "";
            DataTable dt = m_CodeListEnum == CodeListEnum.None ? m_DtRef : ExecuteQuery(query.query, query.param);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!string.IsNullOrEmpty(dt.Rows[i]["CD"].ToString()))
                    {
                        FX.Controls.YButton btn = new FX.Controls.YButton();
                        btn.BackColor = Color.Silver;
                        if (dt.Rows[i]["CD"].ToString() == m_SelectedItem.Key)
                        {
                            btn.BackColor = Color.Lime;
                            lblDesc.Text = dt.Rows[i]["NM"].ToString();
                            m_SelectedItem.Key = dt.Rows[i]["CD"].ToString();
                            m_SelectedItem.Desc = dt.Rows[i]["NM"].ToString();
                        }

                        btn.Size = new Size(330, 60);
                        btn.Key = dt.Rows[i]["CD"].ToString();
                        btn.Text = dt.Rows[i]["NM"].ToString();
                        btn.TextAlign = ContentAlignment.MiddleLeft;
                        btn.Click += new EventHandler(btn_Click);
                        this.FL_Pan.Controls.Add(btn);

                    }
                }
            }

        }
        private void btn_Click(object sender, EventArgs e)
        {
            if (sender is FX.Controls.YButton)
            {
                m_SelectedItem.Key = ((YButton)sender).Key;
                m_SelectedItem.Desc = ((YButton)sender).Text;
            
                this.ParentForm.Close();
            }
        }
        public CodeListQueryST GetItemQuery(BaseINFST baseINF)
        {
            CodeListQueryST rslt = new CodeListQueryST();
            Dictionary<string, string> param = new Dictionary<string, string>();

            switch (m_CodeListEnum)
            {
                
                case CodeListEnum.INSTALL_POS:
                    rslt.query = "PKG_ME_COMBO_HELP.GET_PRT_INSTALL_POS";
                    param = new Dictionary<string, string>();
                    param.Add("IN_CORCD", baseINF.CORCD);
                    param.Add("IN_BIZCD", baseINF.BIZCD);
                    param.Add("IN_LINECD", baseINF.LINECD);
                    rslt.param = param;
                    break;
                case CodeListEnum.ASSY_LINE:
                    rslt.query = "PKG_ME_COMBO_HELP.GET_ASSY_LINE";
                    param = new Dictionary<string, string>();
                    param.Add("IN_CORCD", baseINF.CORCD);
                    param.Add("IN_BIZCD", baseINF.BIZCD);
                    param.Add("IN_LINECD", baseINF.LINECD);
                    rslt.param = param;
                    break;
                case CodeListEnum.ASSY_SHIFT:
                    rslt.query = "PKG_ME_COMBO_HELP.GET_ASSY_SHIFT";
                    param = new Dictionary<string, string>();
                    param.Add("IN_CORCD", baseINF.CORCD);
                    param.Add("IN_BIZCD", baseINF.BIZCD);
                    param.Add("IN_LINECD", baseINF.LINECD);
                    rslt.param = param;
                    break;
                case CodeListEnum.REWORK_DEF_TYPE:
                    rslt.query = "PKG_ME_COMBO_HELP.GET_DEFECT_TYPE";
                    param = new Dictionary<string, string>();
                    param.Add("IN_CORCD", baseINF.CORCD);
                    param.Add("IN_BIZCD", baseINF.BIZCD);
                    param.Add("IN_LINECD", baseINF.LINECD);
                    rslt.param = param;
                    break;
                case CodeListEnum.REWORK_METHOD:
                    rslt.query = "PKG_ME_COMBO_HELP.GET_DEFECT_REWORK";
                    param = new Dictionary<string, string>();
                    param.Add("IN_CORCD", baseINF.CORCD);
                    param.Add("IN_BIZCD", baseINF.BIZCD);
                    param.Add("IN_LINECD", baseINF.LINECD);
                    rslt.param = param;
                    break;
                case CodeListEnum.WHO_RESPONSIBILITY:
                    rslt.query = "PKG_ME_COMBO_HELP.GET_DEFECT_WHO";
                    param = new Dictionary<string, string>();
                    param.Add("IN_CORCD", baseINF.CORCD);
                    param.Add("IN_BIZCD", baseINF.BIZCD);
                    param.Add("IN_LINECD", baseINF.LINECD);
                    rslt.param = param;
                    break;

            }
            return rslt;
        }
        public string GetTitle()
        {
            string title = "";
            switch (m_CodeListEnum)
            {
                case CodeListEnum.ASSY_LINE:
                    title = "Assembly Line Code List";
                    break;
                case CodeListEnum.ASSY_SHIFT:
                    title = "Assembly Shift Code List";
                    break;
                case CodeListEnum.INSTALL_POS:
                    title = "Install Position Code List";
                    break;
                case CodeListEnum.REWORK_DEF_TYPE:
                    title = "Rework Defeact Type List";
                    break;
                case CodeListEnum.REWORK_METHOD:
                    title = "Rework Method Type List";
                    break;
                case CodeListEnum.WHO_RESPONSIBILITY:
                    title = "Who's Responsiblity";
                    break;
            }
            return title;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            m_SelectedItem.Desc = "";
            m_SelectedItem.Key = "";
            lblDesc.Text = "";
            foreach (Control btn in FL_Pan.Controls)
            {
                btn.BackColor = Color.Silver;
            }
        }
    }
}
