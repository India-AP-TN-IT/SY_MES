using SY_MES.FX.Controls;
using SY_MES.FX.Controls.Base;
using SY_MES.FX.MainForm;
using SY_MES.Logics.MES.Sub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.Logics.Base
{
    [ToolboxItem(false)]
    public partial class LocalizedContainer : FX.MainForm.BaseContainer
    {
        private bool m_PrvStationRslt = false;
        [Category(Base.Common.CN_CATEGORY_APP)]
        public bool PrvStationRslt
        {
            get { return m_PrvStationRslt; }
            set { m_PrvStationRslt = value;}
        }
        protected Common m_Comm;
        

        [Browsable(false)]
        public Common Comm
        {
            get { return m_Comm; }
        }
        public struct BaseINFST
        {
            public string CORCD;
            public string BIZCD;
            public string PLANTCD;
            public string LINECD;
            public string INSTALL_POS;
            public string STATIONCD;
            public string HKMC_VENDCD;
            public string PRV_STATIONCD;
        }
        private FX.Controls.YWorkerLabel m_WorkerLabel;
        private bool m_AutoWorkerSetting = false;
        [Category(Base.Common.CN_CATEGORY_APP)]
        public bool AutoWorkerSetting
        {
            get { return m_AutoWorkerSetting; }
            set 
            { 
                m_AutoWorkerSetting = value;            
            }
        }
        [Category(Base.Common.CN_CATEGORY_APP)]
        public YWorkerLabel WorkerLabel
        {
            get { return m_WorkerLabel; }
            set { m_WorkerLabel = value; }
        }
        private BaseINFST m_BaseINF;
        [Browsable(false)]
        public BaseINFST BaseINF
        {
            get { return m_BaseINF; }            
        }
        public LocalizedContainer()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            if(DesignMode == false)
            {
                SetBaseINF();
                m_Comm = new Common(this);
                StartAutoWorker();
            }
            
            base.OnLoad(e);
        }
        protected bool CheckPrvStation(string lotno, string prvStation)
        {
            bool bCheck = Comm.GetBoolStr(GetINI("STATION_INFOR/PRV_STATION_CHECK"));
            if(string.IsNullOrEmpty(prvStation))
            {
                return true;
            }
            if (bCheck)
            {
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("IN_CORCD", BaseINF.CORCD);
                param.Add("IN_BIZCD", BaseINF.BIZCD);
                param.Add("IN_LOTNO", lotno);
                param.Add("IN_LINECD", BaseINF.LINECD);
                param.Add("IN_STATIONCD", prvStation);
                param.Add("IN_INSTALL_POS", BaseINF.INSTALL_POS);
                DataTable dt = ExecuteQuery("PKG_ME_DLG.GET_PRV_STATION_HIST", param);
                if (dt.Rows.Count > 0)
                {
                    return Comm.GetBoolStr(dt.Rows[0]["CHK_RSLT"].ToString());
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        private void StartAutoWorker()
        {
            if(m_AutoWorkerSetting)
            {
                Control[] allCtl = Comm.GetAllControls(PBaseFrm);
                foreach(Control ctl in allCtl)
                {
                    if(ctl is FX.Controls.YWorkerLabel)
                    {
                        ((FX.Controls.YWorkerLabel)ctl).OnEmpnoChanged += new FX.Controls.YWorkerLabel.EmpnoChanged(LocalizedContainer_OnEmpnoChanged);
                    }
                }
            }
        }
        protected Control[] GetAllControls()
        {
            List<Control> allControls = new List<Control>();

            Queue<Control.ControlCollection> queue = new Queue<Control.ControlCollection>();
            queue.Enqueue(this.Controls);

            while (queue.Count > 0)
            {
                Control.ControlCollection controls
                            = (Control.ControlCollection)queue.Dequeue();
                if (controls == null || controls.Count == 0) continue;

                foreach (Control control in controls)
                {
                    allControls.Add(control);
                    queue.Enqueue(control.Controls);
                }
            }
            return allControls.ToArray();
        }
        public Control[] FindYCtls(string key)
        {
            List<Control> ctls = new List<Control>();
            foreach (Control ctl in GetAllControls())
            {
                if (ctl is IYControls)
                {
                    if (((IYControls)ctl).Key == key)
                    {
                        ctls.Add(ctl);
                    }
                }               
                
            }
            return ctls.ToArray();
        }
        private void LocalizedContainer_OnEmpnoChanged(object sender, string code, string desc)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", BaseINF.CORCD);
            param.Add("IN_BIZCD", BaseINF.BIZCD);
            param.Add("IN_EMPNO", code);
            DataTable dt = ExecuteQuery("PKG_COM.GET_WORKER", param);
            if(dt.Rows.Count>0 && sender is FX.Controls.YWorkerLabel)
            {
                ((FX.Controls.YWorkerLabel)sender).Desc =dt.Rows[0]["EMPNM"].ToString();
            }
            else
            {
                ((FX.Controls.YWorkerLabel)sender).Desc = "";
            }
        }
        private void SetBaseINF()
        {
            m_BaseINF = new BaseINFST();
            m_BaseINF.CORCD = CORCD;
            m_BaseINF.BIZCD = BIZCD;
            m_BaseINF.LINECD = GetINI("STATION_INFOR/LINECD");
            m_BaseINF.INSTALL_POS = GetINI("STATION_INFOR/INSTALL_POS");
            m_BaseINF.STATIONCD = GetINI("STATION_INFOR/STATIONCD");
            m_BaseINF.PRV_STATIONCD = GetINI("STATION_INFOR/PRV_STATIONCD");
            m_BaseINF.PLANTCD = GetINI("STATION_INFOR/PLANTCD");

            m_BaseINF.HKMC_VENDCD = GetHKMCVendCD(CORCD, BIZCD);
        }
        private string GetHKMCVendCD(string corcd, string bizcd)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", corcd);
            param.Add("IN_BIZCD", bizcd);
            DataTable dt = ExecuteQuery("PKG_COM.GET_VAATZCD", param);
            if (dt!= null && dt.Rows.Count > 0)
            {
                return dt.Rows[0]["VAATZCD"].ToString();
            }
            else
            {
                return "";
            }
        }
        protected void SetINISectionForDebug(string corcd, string bizcd, string section)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", corcd);
            param.Add("IN_BIZCD", bizcd);
            param.Add("IN_SECTION", section);
            DataTable dt = ExecuteQuery("PKG_FX_BASE.GET_INI_SECTION_DEBUG", param);
            for(int row=0;row<dt.Rows.Count;row++)
            {
                PBaseFrm.SetINI(dt.Rows[row]["INI_KEY"].ToString(), dt.Rows[row]["INI_KEYVALUE"].ToString());
            }
            
        }

        public Dictionary<string, string> GetPlcInforFromINI(string sectionID = "MCPLC_INFOR")
        {
            string plcIP = GetINI(sectionID+"/DEBUG_IP");
            if(string.IsNullOrEmpty(plcIP))
            {
                plcIP = GetINI(sectionID + "/PLCIP");
            }
            
            Dictionary<string, string> dicRet = new Dictionary<string, string>();
            dicRet.Add("@PLCIP", plcIP);
            dicRet.Add("@PLC_PORT", GetINI(sectionID + "/PLC_PORT"));
            dicRet.Add("@PLC_STATION_NO", GetINI(sectionID + "/PLC_STATION_NO"));
            dicRet.Add("@PLCTYPE", GetINI(sectionID + "/PLCTYPE"));
            dicRet.Add("@PLCBASEADDR", GetINI(sectionID + "/PLCBASEADDR"));
            dicRet.Add("@BLOCK_TYPE", GetINI(sectionID + "/BLOCK_TYPE"));
            dicRet.Add("@MEMORY_TAG", GetINI(sectionID + "/MEMORY_TAG"));
            dicRet.Add("@BLOCK_SIZE", GetINI(sectionID + "/BLOCK_SIZE"));
            dicRet.Add("@MODULE_NO", GetINI(sectionID + "/MODULE_NO"));
            dicRet.Add("@PC_STATION_NO", GetINI(sectionID + "/PC_STATION_NO"));
            dicRet.Add("@NETWORK_NO", GetINI(sectionID + "/NETWORK_NO"));            
            return dicRet;
        }
        public void ShowCodeSelectDlg(SY_MES.Logics.Base.CodeSelectBC.CodeListEnum cdList, IYControls ctl)
        {
            CodeSelectBC codeBC = new CodeSelectBC(cdList, ctl.Key);
            BaseDialog dlg = new BaseDialog(codeBC.GetTitle(), codeBC, PBaseFrm);
            dlg.ShowDialog(PBaseFrm);
            ctl.Key = codeBC.SelectedItem.Key;
            ctl.Desc = codeBC.SelectedItem.Desc;
        }
        public DataTable GetCodeSelectData(SY_MES.Logics.Base.CodeSelectBC.CodeListEnum cdList, string key = "")
        {
            CodeSelectBC codeBC = new CodeSelectBC(cdList, key);
            SY_MES.Logics.Base.CodeSelectBC.CodeListQueryST query = codeBC.GetItemQuery(BaseINF);
            DataTable dt = ExecuteQuery(query.query, query.param);
            DataTable dtRet = dt.Clone();
            if (string.IsNullOrEmpty(key) == false)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["CD"].ToString() == key)
                    {
                        dtRet.ImportRow(dr);
                    }
                }
                return dtRet;
            }
            else
            {
                return dt;
            }
        }
        public override void ReadDataFromScanner(object sender, string data)
        {
            base.ReadDataFromScanner(sender, data);
            if(m_WorkerLabel!=null && string.IsNullOrEmpty(m_WorkerLabel.GetValue().ToString()))
            {
                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Warnning, m_WorkerLabel.Title + " is not inputted.", MethodBase.GetCurrentMethod().Name, true);
            }
            CloseFrmMsgBox();
            if (Comm.IsOurBarcode(data) && Comm.AvailableLine(data, BaseINF.LINECD))
            {

                DataRow dr = Comm.GetProductInfo(BaseINF.CORCD, BaseINF.BIZCD, data);                
                Common.SetProductInfor(dr);
                string lotno = Common.GetProductInfor("LOTNO");
                bool prvStation = CheckPrvStation(lotno, BaseINF.PRV_STATIONCD);
                m_PrvStationRslt = prvStation;
                if (prvStation == false)
                {
                    StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, "["+lotno+"]"+"Previous Station was not done yet.", MethodBase.GetCurrentMethod().Name, true);
                }
            }
        }
        public override void BackgroundError(object sender, string query, Dictionary<string, string> param, DataTable dt, Exception eLog)
        {
            base.BackgroundError(sender, query, param, dt, eLog);
            if (eLog.Message.Contains("ORA-01001"))
            {
                AsyncExecueteQuery(sender, query, param);
            }
            else
            {
                if (PBaseFrm != null)
                {
                    PBaseFrm.StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, eLog.Message, MethodBase.GetCurrentMethod().Name, true);
                }
            }
        }
        
        protected override void WorkState(FX.MainForm.Base.Common.WorkStateEnum state)
        {
            base.WorkState(state);
            string lotno = Common.GetProductInfor("LOTNO");
            string chk_RSLT = "S";
            string worker = "";
            if(m_WorkerLabel!=null)
            {
                worker = m_WorkerLabel.GetValue().ToString();
            }
            switch(state)
            {
                case FX.MainForm.Base.Common.WorkStateEnum.OK_Complete:
                    chk_RSLT = "OK";
                    break;
                case FX.MainForm.Base.Common.WorkStateEnum.NG_Complete:
                    chk_RSLT = "NG";
                    break;
            }
            if (string.IsNullOrEmpty(lotno) == false)
            {
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("IN_CORCD", BaseINF.CORCD);
                param.Add("IN_BIZCD", BaseINF.BIZCD);
                param.Add("IN_LOTNO", lotno);
                param.Add("IN_LINECD", BaseINF.LINECD);
                param.Add("IN_PROCCD", BaseINF.STATIONCD);
                param.Add("IN_INSTALL_POS", BaseINF.INSTALL_POS);
                param.Add("IN_PROD_DATE", PBaseFrm.GetWorkDate());
                param.Add("IN_SHIFT", PBaseFrm.GetShift());
                param.Add("IN_WORKER", worker);
                param.Add("IN_CHK_RSLT", chk_RSLT);

                switch (state)
                {
                    case FX.MainForm.Base.Common.WorkStateEnum.Wait:
                        break;
                    case FX.MainForm.Base.Common.WorkStateEnum.NG_Complete:
                    case FX.MainForm.Base.Common.WorkStateEnum.OK_Complete:
                        ExecuteNonQuery("PKG_COM.SET_PROC_HIST_END", param);
                        break;
                    case FX.MainForm.Base.Common.WorkStateEnum.Running:
                        ExecuteNonQuery("PKG_COM.SET_PROC_HIST_START", param);
                        break;
                }
            }
        }

    }
}
