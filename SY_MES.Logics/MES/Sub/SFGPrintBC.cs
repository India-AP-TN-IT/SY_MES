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
using SY_MES.Logics.Base;
using System.Reflection;

namespace SY_MES.Logics.MES.Sub
{
    [ToolboxItem(true)]
    public partial class SFGPrintBC : Base.LocalizedContainer
    {
        public enum SFGModeEnum
        {
            Injecion,
            Paint,
            SUB_ASSY
        }
        private SFGModeEnum m_SFGMode = SFGModeEnum.Injecion;
        public SFGModeEnum SFGMode
        {
            get { return m_SFGMode; }
            set 
            { 
                m_SFGMode = value;
                ScreenArrange();
            }
        }
        private bool m_MoldPairSelection = true;
        public delegate void SelectedWO(object sender, int row);
        public event SelectedWO OnSelectedWO = null;
        private bool m_bINIT = true;
        private const string CN_ASYNC_LOAD_QUERY = "MES.PKG_ME_TAG_PRINT_SEMI.GET_TAG_PRINT_WO";
        private const string CN_ASYNC_LOAD_QUERY_ALL = "MES.PKG_ME_TAG_PRINT_SEMI.GET_TAG_PRINT_ALL";
        private void ScreenArrange()
        {
            if(m_SFGMode == SFGModeEnum.Injecion)
            {
                ChkMoldPair.Visible = true;
                if (yDataGridView1.Columns.Contains("MOLDCD"))
                {
                    yDataGridView1.Columns["MOLDCD"].Visible = true;
                }
            }
            else if(m_SFGMode == SFGModeEnum.Paint)
            {
                ChkMoldPair.Visible = true;
                if (yDataGridView1.Columns.Contains("MOLDCD"))
                {
                    yDataGridView1.Columns["MOLDCD"].Visible = true;
                }
            }
            else if(m_SFGMode == SFGModeEnum.SUB_ASSY)
            {
                ChkMoldPair.Visible = false;
                if (yDataGridView1.Columns.Contains("MOLDCD"))
                {
                    yDataGridView1.Columns["MOLDCD"].Visible = false;
                }
            }
        }
        public bool MoldPairSelection
        {
            get { return m_MoldPairSelection; }
            set 
            { 
                m_MoldPairSelection = value;
                ChkMoldPair.Checked = true;
            }
        } 
        public string GetLinecd()
        {
            return lbl_LINECD.Key;
        }
        public string GetWorkDate()
        {
            return yDateTime1.GetValue().ToString();
        }

        
        public void PrintLabel(Dictionary<string, string> param, out string errMsg)
        {

            

            errMsg = "";
            try
            {
                PrtHelper.PrintLabel(param, out errMsg);
                
            }
            catch(Exception eLog)
            {
                PBaseFrm.StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, eLog.Message, MethodBase.GetCurrentMethod().Name, true);

            }
        }
        public SFGPrintBC()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> GetPrtParam()
        {
            string workDate = PBaseFrm.GetWorkDate();
            string clientID = GetINI("BARCODE_PRINTER/CLIENT_ID");
            string lotno =GetNewLOT(BaseINF.CORCD, BaseINF.BIZCD, workDate, clientID);
            Dictionary<string, string> prtParam = new Dictionary<string, string>();

            
            prtParam.Add("LABEL_TYPE", GetINI("BARCODE_PRINTER/PRINT_FORM_TYPE"));
            prtParam.Add("CLIENT_ID", clientID);
            prtParam.Add("LOTNO", lotno);
            prtParam.Add("WORK_DATE", workDate);
            prtParam.Add("SHIFT", PBaseFrm.GetShift());
            return prtParam;
        }
        private Dictionary<string, string> GetDeivceParam()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();

            param.Add("CONNECTION", PBaseFrm.GetINI("BARCODE_PRINTER/CONNECT_TYPE"));
            param.Add("IPCOM", PBaseFrm.GetINI("BARCODE_PRINTER/IP_OR_COMPORT"));
            param.Add("PORT", PBaseFrm.GetINI("BARCODE_PRINTER/PORT_OR_BAUDRATE"));
            param.Add("LANG", PBaseFrm.GetINI("BARCODE_PRINTER/LANGUAGE_TYPE"));

            param.Add("CLIENT_ID", PBaseFrm.GetINI("BARCODE_PRINTER/CLIENT_ID"));
            return param;
        }
        private void SetPrtDevice()
        {
            Dictionary<string, string> param = GetDeivceParam();
            PrtHelper.Start(param);
            
        }
        protected override void InitControls()
        {
            base.InitControls();
            lbl_LINECD.Text = "";
            lblPOS.Text = "";
            lblPrintedBarcode.Text = "";
            lblShift.Text = "";
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode == false)
            {
                SetPrtDevice();
                m_bINIT = false;
                DispCodeListCtl(CodeSelectBC.CodeListEnum.ASSY_LINE, BaseINF.LINECD, lbl_LINECD);
                DispCodeListCtl(CodeSelectBC.CodeListEnum.INSTALL_POS, BaseINF.INSTALL_POS, lblPOS);
                DispCodeListCtl(CodeSelectBC.CodeListEnum.ASSY_SHIFT, GetCurrentShift(), lblShift);
                DispQueryScope();
                LoadData();
                MoldPairSelection = true;
                ScreenArrange();
            }

        }
        private string GetCurrentShift()
        {
            return "C00"+PBaseFrm.GetShift();
        }
        private void DispCodeListCtl(SY_MES.Logics.Base.CodeSelectBC.CodeListEnum cdList, string key, IYControls ctl)
        {
            DataTable dt = GetCodeSelectData(cdList, key);
            if(dt.Rows.Count > 0 ) 
            {
                ctl.Desc = dt.Rows[0]["NM"].ToString();
                ctl.Key = dt.Rows[0]["CD"].ToString();
            }
            else
            {
                ctl.Desc = "";
            }
        }
        public override void AfterBaseFormLoad(EventArgs e)
        {
            base.AfterBaseFormLoad(e);
        }
        public override void LoadData()
        {
            base.LoadData();
            string linecd = BaseINF.LINECD;
            string pos = BaseINF.INSTALL_POS;
            if(m_bINIT == false)
            {
                linecd = lbl_LINECD.Key;
                pos = lblPOS.Key == "ALL" ? "" : lblPOS.Key;
            }
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", BaseINF.CORCD);
            param.Add("IN_BIZCD", BaseINF.BIZCD);
            param.Add("IN_LINECD", linecd);
            param.Add("IN_INSTALL_POS", pos);
            param.Add("IN_PLAN_DATE", yDateTime1.GetValue().ToString());
            param.Add("IN_TIME_GU", lblShift.Key.ToString());
            param.Add("IN_MOD_PAT", "");
            if(Chk_All.Checked ==false)
            {
                AsyncExecueteQuery(this, CN_ASYNC_LOAD_QUERY, param, panel2);
            }
            else
            {
                AsyncExecueteQuery(this, CN_ASYNC_LOAD_QUERY_ALL, param, panel2);
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
        public override void ReadAsyncDBData(object sender, string query, Dictionary<string, string> param, DataTable dt)
        {
            this.Invoke(new MethodInvoker(
            delegate()
            {
                if (query.Contains(CN_ASYNC_LOAD_QUERY) || query.Contains(CN_ASYNC_LOAD_QUERY_ALL))
                {   //Load Data
                    yDataGridView1.SetValue(dt);
                    DispPrintedQTY();
                }
            }));
        }
        public override void BackgroundError(object sender, string query, Dictionary<string, string> param, DataTable dt, Exception eLog)
        {
            this.Invoke(new MethodInvoker(
            delegate()
            {
                //base.BackgroundError(sender, query, param, dt, eLog);
                if (query.Contains(CN_ASYNC_LOAD_QUERY) || query.Contains(CN_ASYNC_LOAD_QUERY_ALL))
                {   //Load Data
                    yDataGridView1.SetValue(dt);
                    DispPrintedQTY();
                }
            }));
        }

        private void Combo_Click(object sender, EventArgs e)
        {
            if(sender is FX.Controls.YButton)
            {
                switch(((FX.Controls.YButton)sender).Key)
                {
                    case "SFG_LINE":
                        ShowCodeSelectDlg(Base.CodeSelectBC.CodeListEnum.SFG_LINE, (IYControls)lbl_LINECD);
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

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintBarcode();
        }

        private void PrintBarcode()
        {
            string error = "";
            if (PrintAble())
            {
                Dictionary<string, string> prtParam = GetPrtParam();
                bool bSave = SaveMES2010(prtParam);
                if (bSave)
                {
                    PrintLabel(prtParam, out error);
                }
                LoadData();
            }
            
        }
        private bool SaveMES2010(Dictionary<string, string> prtParam)
        {
            bool bRet = false;
            try
            {
                if(yDataGridView1.SelectedRowIdx<0)
                {
                    PBaseFrm.StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, "Select Work Order!!", MethodBase.GetCurrentMethod().Name, true);
                    return false;
                }
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("IN_CORCD", BaseINF.CORCD);
                param.Add("IN_BIZCD", BaseINF.BIZCD);
                param.Add("IN_LOTNO", PrtHelper.GetParam(prtParam, "LOTNO"));
                param.Add("IN_LINECD", yDataGridView1.GetValue("LINECD"));
                param.Add("IN_JOB_TYPE",  yDataGridView1.GetValue("JOB_TYPE"));
                param.Add("IN_INSTALL_POS", yDataGridView1.GetValue("INSTALL_POS"));
                param.Add("IN_ALCCD", yDataGridView1.GetValue("ALCCD"));
                param.Add("IN_PARTNO", yDataGridView1.GetValue("PARTNO"));
                param.Add("IN_PLAN_DATE", yDateTime1.GetValue().ToString());
                param.Add("IN_PLAN_TIMECD", yDataGridView1.GetValue("TIMECD"));
                param.Add("IN_WORK_ORDNO", yDataGridView1.GetValue("WORK_ORDNO"));
                param.Add("IN_STR_LOC", yDataGridView1.GetValue("STR_LOC"));
                param.Add("IN_PLANT_DIV", BaseINF.PLANTCD);
                param.Add("IN_INSPECTOR", yWorkerLabel1.Key);
                param.Add("IN_EMPNO", "");
                param.Add("IN_QTY", "1");
                ExecuteNonQuery("MES.PKG_ME_TAG_PRINT.SET_MES2010", param);
                PBaseFrm.StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Alarm, "Printed - Lot No:" + PrtHelper.GetParam(prtParam, "LOTNO"), MethodBase.GetCurrentMethod().Name, false);
                return true;
            }
            catch(Exception eLog)
            {
                PBaseFrm.StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, eLog.Message, MethodBase.GetCurrentMethod().Name, true);
            }
            return bRet;
        }


        protected string GetNewLOT(string corcd, string bizcd, string workDate, string clientID)
        {
            string errMsg = "";
            if (PBaseFrm != null)
            {
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("IN_CORCD", corcd);
                param.Add("IN_BIZCD", bizcd);
                param.Add("IN_WORK_DATE", workDate);
                param.Add("IN_CLIENT_ID", clientID);

                DataTable dt = PBaseFrm.ExcuteQuery("PKG_ME_TAG_PRINT.GET_NEWLOT", param);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["NEWLOT"].ToString();
                }
                else
                {

                    return GetClientMakeLot(corcd, bizcd,PrtHelper.MakeGetLotHeader(workDate) + clientID, ref errMsg);
                }
            }
            return GetClientMakeLot(corcd, bizcd, PrtHelper.MakeGetLotHeader(workDate) + clientID, ref errMsg);
        }

        private string GetClientMakeLot(string corcd, string bizcd, string strLotHeader, ref string strErrMsg)
        {
            try
            {
                if (PBaseFrm != null)
                {
                    Dictionary<string, string> param = new Dictionary<string, string>();
                    param.Add("IN_CORCD", corcd);
                    param.Add("IN_BIZCD", bizcd);
                    param.Add("IN_LOTHD", strLotHeader);

                    DataTable dt = PBaseFrm.ExcuteQuery("PKG_ME_TAG_PRINT.GET_MAXLOTSEQ", param);

                    string strLotNo = "";
                    if (dt.Rows.Count > 0)
                    {
                        strLotNo = dt.Rows[0]["MAXLOTSEQ"].ToString();
                    }

                    if (string.IsNullOrEmpty(strLotNo))
                    {
                        strLotNo = strLotHeader + "0001";
                    }
                    else
                    {
                        int iSeq = Convert.ToInt16(strLotNo.Substring(5, 4)) + 1;
                        strLotNo = strLotHeader + string.Format("{0:0000}", iSeq);
                    }

                    return strLotNo;
                }
                strErrMsg = "ParentForm is not define";
                return "";
            }
            catch (Exception ex)
            {
                strErrMsg = ex.Message;
                return "";
            }
        }
        
        private bool PrintAble()
        {

            int printedQTY = Convert.ToInt32(string.IsNullOrEmpty(lblPrintedBarcode.Text)?"0" : lblPrintedBarcode.Text);
            int planQTY  = Convert.ToInt32(string.IsNullOrEmpty(txtPlan.Text) ? "0" : txtPlan.Text);

            if(printedQTY>=planQTY)
            {
                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, "Printed Barcode is over QTY(" + printedQTY + "/" + planQTY + ")", MethodBase.GetCurrentMethod().Name, true);
                return false;
            }
            return true;
        }
        private void DispPrintedQTY()
        {
            lblPrintedBarcode.Text = "";
            txtPlan.Text = "";

            if (yDataGridView1.IsSelected && yDataGridView1.SelectedRowIdx >= 0)
            {
                int printed = Convert.ToInt32(yDataGridView1.GetValue("PRINT_QTY"));
                int plan = Convert.ToInt32(yDataGridView1.GetValue("PLAN_QTY"));

                lblPrintedBarcode.Text = printed.ToString();
                txtPlan.Text = plan.ToString();
            }
        }
        private void yDataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DispPrintedQTY();
            if (OnSelectedWO != null)
            {
                int row = yDataGridView1.SelectedRowIdx;
                if (row >= 0)
                {
                    OnSelectedWO(yDataGridView1, row);
                }
            }
        }

        private void DispQueryScope()
        {
            if (Chk_All.Checked)
            {
                Chk_All.BackColor = Color.Red;
                Chk_All.ForeColor = Color.White;
                Chk_All.Text = "ALL";
            }
            else
            {
                Chk_All.BackColor = Color.Lime;
                Chk_All.ForeColor = Color.Black;
                Chk_All.Text = "W/O";
            }
        }
        private void Chk_All_CheckedChanged(object sender, EventArgs e)
        {
            DispQueryScope();
            LoadData();
        }

        private void ChkMoldPair_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkMoldPair.Checked)
            {
                ChkMoldPair.BackColor = Color.Lime;
            }
            else
            {
                ChkMoldPair.BackColor = Color.Silver;
            }
        }
    }
}
