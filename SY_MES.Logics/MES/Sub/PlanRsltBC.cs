using SY_MES.FX.Controls.Base;
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
    public partial class PlanRsltBC : Base.LocalizedContainer
    {
        private bool m_bINIT = true;
        private bool m_bDiff = false;
        private const string CN_ASYNC_LOAD_QUERY = "MES.PKG_ME_INSPECTION.GET_PLAN_RESULT";
        public PlanRsltBC()
        {
            InitializeComponent();
        }
        public string GetLinecd()
        {
            return lbl_LINECD.Key;
        }
        public string GetPOS()
        {
            return lblPOS.Key;
        }
        public string GetWorkDate()
        {
            return yDateTime1.GetValue().ToString();
        }
        protected override void InitControls()
        {
            base.InitControls();
            lbl_LINECD.Text = "";
            lblPOS.Text = "";
            lblShift.Text = "";
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode == false)
            {
                m_bINIT = false;
                DispCodeListCtl(CodeSelectBC.CodeListEnum.ASSY_LINE, BaseINF.LINECD, lbl_LINECD);
                DispCodeListCtl(CodeSelectBC.CodeListEnum.INSTALL_POS, BaseINF.INSTALL_POS, lblPOS);
                DispCodeListCtl(CodeSelectBC.CodeListEnum.ASSY_SHIFT, GetCurrentShift(), lblShift);
                LoadData();
            }

        }
        public override void LoadData()
        {
            base.LoadData();
            string linecd = BaseINF.LINECD;
            string pos = BaseINF.INSTALL_POS;
            if (m_bINIT == false)
            {
                linecd = lbl_LINECD.Key;
                pos = lblPOS.Key == "ALL" ? "" : lblPOS.Key;
            }
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", BaseINF.CORCD);
            param.Add("IN_BIZCD", BaseINF.BIZCD);
            param.Add("IN_PLAN_DATE", yDateTime1.GetValue().ToString());
            param.Add("IN_LINECD", linecd);
            param.Add("IN_INSTALL_POS", pos);
            param.Add("IN_SHIFT", lblShift.Key.ToString().Replace("C00",""));

            param.Add("IN_REMAIN_CHK", m_bDiff ==true ? "Y" : "N");
            AsyncExecueteQuery(this, CN_ASYNC_LOAD_QUERY, param);

        }
        public override void ReadAsyncDBData(object sender, string query, Dictionary<string, string> param, DataTable dt)
        {
            this.Invoke(new MethodInvoker(
            delegate ()
            {
                if (query.Contains(CN_ASYNC_LOAD_QUERY))
                {   //Load Data
                    yDataGridView1.SetValue(dt);
                }
            }));
        }
        public override void BackgroundError(object sender, string query, Dictionary<string, string> param, DataTable dt, Exception eLog)
        {
            this.Invoke(new MethodInvoker(
            delegate ()
            {
                //base.BackgroundError(sender, query, param, dt, eLog);
                if (query.Contains(CN_ASYNC_LOAD_QUERY))
                {   //Load Data
                    yDataGridView1.SetValue(dt);
                }
            }));
        }
        private string GetCurrentShift()
        {
            return "C00" + PBaseFrm.GetShift();
        }
        private void DispCodeListCtl(SY_MES.Logics.Base.CodeSelectBC.CodeListEnum cdList, string key, IYControls ctl)
        {
            DataTable dt = GetCodeSelectData(cdList, key);
            if (dt.Rows.Count > 0)
            {
                ctl.Desc = dt.Rows[0]["NM"].ToString();
                ctl.Key = dt.Rows[0]["CD"].ToString();
            }
            else
            {
                ctl.Desc = "";
            }
        }
        private void Combo_Click(object sender, EventArgs e)
        {
            if (sender is FX.Controls.YButton)
            {
                switch (((FX.Controls.YButton)sender).Key)
                {
                    case "ASSY_LINE":
                        ShowCodeSelectDlg(Base.CodeSelectBC.CodeListEnum.ASSY_LINE, (IYControls)lbl_LINECD);

                        break;
                    case "INSTALL_POS":
                        ShowCodeSelectDlg(Base.CodeSelectBC.CodeListEnum.INSTALL_POS, (IYControls)lblPOS);

                        break;
                    case "SHIFT":
                        ShowCodeSelectDlg(Base.CodeSelectBC.CodeListEnum.ASSY_SHIFT, (IYControls)lblShift);

                        break;

                }
                LoadData();
            }

        }

        private void yDateTime1_OnDateChg(object sender, DateTime date)
        {
            LoadData();
        }

        private void yButton1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Btn_DIFF_Click(object sender, EventArgs e)
        {
            if(m_bDiff == false)
            {
                m_bDiff = true;
                Btn_DIFF.BackColor = Color.Lime;
            }
            else
            {
                m_bDiff = false;
                Btn_DIFF.BackColor = Color.Silver;
            }
            LoadData();
        }
    }
}
