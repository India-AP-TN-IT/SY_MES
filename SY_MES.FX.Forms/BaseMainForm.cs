using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SY_MES.FX.DB;
using SY_MES.FX.MainForm.Base;
using System.Net;
using System.Reflection;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Collections;

namespace SY_MES.FX.MainForm
{
    [ToolboxItem(false)]
    public partial class BaseMainForm : Form, IMainFormDesign
    {
        private List<SY_MES.FX.MainForm.Base.Common.StatusLogST> m_StatusLogData;
        MsgBox m_MainMsg;
        public enum FormModeEnum
        {
            MES,
            TV_OUT
        }
        private int m_CntOfStatusLog = 20;
        private DateTime m_ExcutePGMStart;
        private const int CN_TIMER_CNT = 3;
        private DateTime[] m_TimerDate;
        private SY_MES.FX.DB.CommonHelper m_DBHelper = null;
        private string m_LogicFolder = "MES";

        
        private Point m_MouseMovePoint = new Point();
        private bool m_bMoveMouse = false;

        public delegate void BeepBar(object sender, bool bBeep);
        public event BeepBar OnBeepBar = null;
        
        private BaseContainer m_ChildBC = null;
        private DataTable m_XMLConfigDT = null;
        protected Dictionary<string, string> m_DicIni = null;
        private string m_RunBC = string.Empty;
        private FormModeEnum m_FormMode = FormModeEnum.MES;
        [Category(Base.Common.CN_CATEGORY_APP)]
        public int CntOfStatusLog
        {
            get { return m_CntOfStatusLog; }
            set
            {
                m_CntOfStatusLog = value;
            }
        }
        [Category(Base.Common.CN_CATEGORY_APP)]
        public FormModeEnum FormMode
        {
            get { return m_FormMode; }
            set
            {
                m_FormMode = value;
                FormModeChange(m_FormMode);
            }
        }
        [Browsable(false)]
        public List<SY_MES.FX.MainForm.Base.Common.StatusLogST> StatusLogData
        {
            get { return m_StatusLogData; }
        }
        [Browsable(false)]
        public DateTime ExcutePGMStart
        {
            get { return m_ExcutePGMStart; }
        }
        [Browsable(false)]
        public ProgressBar StatusProgressCtl
        {
            get { return StatusProgress; }
            set { StatusProgress = value; }
        }
        [Browsable(false)]
        protected Dictionary<string, string> DicIni
        {
            get { return m_DicIni; }
            set { m_DicIni = value; }
        }
        [Browsable(false)]
        public string LogicFolder
        {
            get { return m_LogicFolder; }
            set { m_LogicFolder = value; }
        }
        [Browsable(false)]
        public string RunBC
        {
            get { return m_RunBC; }
            set 
            {
                m_RunBC = value;
            }
        }
        
        
        [Browsable(false)]
        public SY_MES.FX.DB.CommonHelper DBHelper
        {
            get { return m_DBHelper; }
        }
        [Browsable(false)]
        public BaseContainer ChildBC
        {
            get { return m_ChildBC; }
            set 
            { 
                m_ChildBC = value;
                ContainsBC(m_ChildBC);
            }
        }
        [Browsable(false)]
        public Label Plant_CTL
        {
            get { return lbl_Bizcd; }
            set { lbl_Bizcd = value; }
        }
        [Browsable(false)]
        public Label WorkShift_CTL
        {
            get { return lbl_WorkShift; }
            set { lbl_WorkShift = value; }
        }
        [Browsable(false)]
        public Label Line_CTL
        {
            get { return lbl_MainTitle; }
            set { lbl_MainTitle = value; }
        }
        [Browsable(false)]
        public Label Station_CTL
        {
            get { return lbl_SubTitle; }
            set { lbl_SubTitle = value; }
        }
        [Browsable(false)]
        public Button Result_CTL
        {
            get { return Btn_ProcResult; }
            set { Btn_ProcResult = value; }
        }
        [Browsable(false)]
        public Label Date_CTL
        {
            get { return lbl_Date; }
            set { lbl_Date = value; }
        }
        [Browsable(false)]
        public Label Time_CTL
        {
            get { return lbl_Time; }
            set { lbl_Time = value; }
        }
        [Browsable(false)]
        public Label MsgTitle_CTL
        {
            get { return lbl_MsgTitle; }
            set { lbl_MsgTitle = value; }
        }
        [Browsable(false)]
        public Label StatusMsg
        {
            get { return lbl_Msg; }
            set { lbl_Msg = value; }
        }
        [Browsable(false)]
        public Label WorkState
        {
            get { return lbl_WorkStatus; }
            set { lbl_WorkStatus = value; }
        }

        [Browsable(false)]
        public Button WorkStandard_CTL
        {
            get { return btn_WorkStandard; }
            set { btn_WorkStandard = value; }
        }
        [Browsable(false)]
        public Button Exit_CTL
        {
            get { return btn_Exit; }
            set { btn_Exit = value; }
        }
        [Browsable(false)]
        public Button Config_CTL
        {
            get { return Btn_Config; }
            set { Btn_Config = value; }
        }
        [Browsable(false)]
        public PictureBox LogoImg
        {
            get
            {
                return pb_Logo;
            }
            set
            {

                pb_Logo = value;
                pb_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        [Browsable(false)]
        public Icon AppIcon
        {
            get
            {
                return this.Icon;
            }
            set
            {

                this.Icon = value;
            }
        }
        /// <summary>
        /// Get XML Value from XML File
        /// </summary>
        /// <param name="eleName">Element Name</param>
        /// <returns>XML Value</returns>
        public string GetXMLConfig(string eleName)
        {
            if (m_XMLConfigDT != null)
            {
                if (m_XMLConfigDT.Rows.Count > 0)
                {
                    if (m_XMLConfigDT.Columns.Contains(eleName))
                    {
                        return m_XMLConfigDT.Rows[0][eleName].ToString();
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            return "";
        }
        [Browsable (false)]
        public bool IsDebugMode
        {
            get
            {
                string val = GetXMLConfig(MainCtl.XMLDebugModeEleName);
                bool bret = false;
                switch(val.ToUpper().Trim())
                {
                    case "Y":
                    case "TRUE":
                    case "YES":
                    case "T":
                        bret = true;
                        break;
                }                
                return bret;
            }
        }
        /// <summary>
        /// Getting the INI Configuration
        /// </summary>
        /// <param name="iniKey">INI KEY(ex] XXX/YYY</param>
        /// <param name="defVal">Default Value</param>
        /// <returns>INI VALUE</returns>
        public string GetINI(string iniKey, string defVal = "")
        {
            if (m_DicIni != null)
            {
                return m_DicIni.ContainsKey(iniKey.Trim().Replace(" ", "")) && string.IsNullOrEmpty(m_DicIni[iniKey]) == false ? m_DicIni[iniKey] : defVal;

            }
            else
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + "There is no INI Data");
            
                return "";

            }
        }

        /// <summary>
        /// Setting the INI Configuration
        /// </summary>
        /// <param name="iniKey">INI KEY(ex] XXX/YYY</param>
        /// <param name="val">Value</param>
        public void SetINI(string iniKey, string val)
        {
            if (m_DicIni != null)
            {
                if(m_DicIni.ContainsKey(iniKey))
                {
                    m_DicIni[iniKey] = val;
                }
                else
                {
                    m_DicIni.Add(iniKey, val);
                }
            }
            else
            {
                m_DicIni = new Dictionary<string, string>();
                m_DicIni.Add(iniKey, val);

            }
        }
        #region Virtual Methods
        /// <summary>
        /// Getting Server Time 
        /// </summary>
        /// <returns>base on oracle 'YYYY-MM-DD hh24:mi:ss'</returns>
        protected virtual string GetSeverTime()
        {
            return "";
        }
        public virtual void SetDBTrace(double leadTime, string query, string strParam)
        {

        }
        protected virtual string GetLineDESC()
        {
            return "";
        }
        public virtual string GetWorkDate(bool bCat = true)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            if(bCat == false)
            {
                return date.Replace("-", "");
            }
            return date;
        }
        public virtual string GetShift()
        {
            return "1";
        }
        protected virtual void DispShift()
        {
            WorkShift_CTL.Text = "A";
        }
        protected virtual void InitDevices()
        {

        }
        protected virtual void InitDesign()
        {
            if (IsDebugMode)
            {
                lbl_Bizcd.BackColor = Color.Green;
                WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                lbl_Bizcd.BackColor = Color.Brown;
                WindowState = FormWindowState.Maximized;
            }
        }
        protected virtual DataTable GetConfig()
        {
            DataTable dt = new DataTable();
            return dt;
        }
        protected virtual void LoadINI()
        {
        }
        protected virtual void OpenInitialConfig()
        {
            try
            {
                m_XMLConfigDT = GetConfig();
            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
            }
        }
        protected virtual void OnCloseBtn(object sender, EventArgs e)
        {
            if (FrmMsgBox(Common.MsgTypeEnum.Warnning, MainCtl.Exit_Dlg_Contents, MainCtl.Exit_Dlg_Title, MsgBox.MsgBtnEnum.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
        protected virtual void OnMaxWindow(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.btn_WinMax.BackColor = SystemColors.Control;
            }
            else
            {


                this.WindowState = FormWindowState.Normal;
                this.btn_WinMax.BackColor = Color.Salmon;
                if (this.Width > Screen.AllScreens[0].Bounds.Width)
                {
                    this.Width = Screen.AllScreens[0].Bounds.Width;
                }
            }
        }
        protected virtual void OnMinWindow(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        protected virtual void OnWorkStandard(object sender, EventArgs e)
        {

        }
        protected virtual void OnResult(object sender, EventArgs e)
        {

        }
        protected virtual void OnConfig(object sender, EventArgs e)
        {

        }
        #endregion
        
        private void StartBC(out string error)
        {

            error = "";
            try
            {
                string pgmClassName = "";

                if (GetXMLConfig(MainCtl.XMLDebugClientEleName).Contains("@"))
                {
                    string bcName = GetXMLConfig(MainCtl.XMLDebugClientEleName).Substring(1);
                    RunBC = bcName;    
                }
                pgmClassName = MainCtl.LogicAppNameSpace + "." + RunBC + ", " + MainCtl.LogicAppNameSpace;
                ChildBC = (SY_MES.FX.MainForm.BaseContainer)Activator.CreateInstance(Type.GetType(pgmClassName));
            }
            catch (Exception eLog)
            {
                error = eLog.ToString();

            }

        }
        private void FormModeChange(FormModeEnum mode)
        {
            switch(mode)
            {
                case FormModeEnum.MES:
                    lbl_SubTitle.Visible = true;
                    Btn_ProcResult.Visible = true;
                    lbl_Date.Visible = true;
                    btn_WorkStandard.Visible = true;
                    lbl_MainTitle.Location = new Point(1, 1);
                    lbl_MainTitle.Size = new Size(lbl_SubTitle.Width, 37);
                    lbl_WorkShift.Location = new Point(Btn_ProcResult.Location.X, 1);
                    lbl_WorkShift.Size = new Size(Btn_ProcResult.Width, 37);
                    lbl_Time.Location = new Point(lbl_Date.Location.X, lbl_SubTitle.Location.Y);
                    lbl_Time.Size =new Size (lbl_Date.Size.Width, lbl_SubTitle.Height);
                    break;
                case FormModeEnum.TV_OUT:
                    lbl_SubTitle.Visible = false;
                    Btn_ProcResult.Visible = false;
                    btn_WorkStandard.Visible = false;
                    lbl_Date.Visible = false;
                    lbl_MainTitle.Location = new Point(1, 1);
                    lbl_MainTitle.Size = new Size(lbl_SubTitle.Width+ lbl_Date.Width+3, 37 + lbl_SubTitle.Height + 1);
                    lbl_WorkShift.Location = new Point(btn_WorkStandard.Location.X, 1);
                    lbl_WorkShift.Size = btn_WorkStandard.Size;
                    lbl_Time.Location = new Point(Btn_ProcResult.Location.X, 1);
                    lbl_Time.Size = new Size(lbl_Date.Size.Width, btn_WorkStandard.Height);
                    break;
            }
        }
        
        private void InitTimeTimes(int timerCnt)
        {
            m_TimerDate = new DateTime[timerCnt];
            for(int i=0;i<timerCnt;i++)
            {
                m_TimerDate[i] = DateTime.Now;
            }
            
            SyncSVRTime(GetSeverTime());
            DispShift();
            m_ExcutePGMStart = DateTime.Now;
        }
        
        protected override void OnLoad(EventArgs e)
        {
            string error = "";
            if (DesignMode == false)
            {
                OpenInitialConfig();
                if (ConnectDB() == false)
                {
                    error = MainCtl.Error_DB_Connection;
                    
                }
                CheckDuplicatedRun(MainCtl.AllowDuplicatedRun);
                InitDesign();
                LoadINI();
                InitTimeTimes(CN_TIMER_CNT);
                
                TmrTimeBase.Start();
                InitDevices();
                StartBC(out error);
                this.Text = Application.ProductName;

                if(string.IsNullOrEmpty(error))
                {
                    StatusBarMsg(Common.MsgTypeEnum.Alarm, ChildBC.Name);
                }
                else
                {
                    StatusBarMsg(Common.MsgTypeEnum.Error, error, System.Reflection.MethodBase.GetCurrentMethod().Name, true);
                }
            }

            base.OnLoad(e);
            FormModeChange(m_FormMode);
            Control[] ctls = GetAllControls(this);
            if(ctls.Length > 0 )
            {
                foreach(Control ctl in ctls)
                {
                    if(ctl is BaseContainer)
                    {
                        ((BaseContainer)ctl).AfterBaseFormLoad(e);
                    }
                }
            }
        }
        /// <summary>
        /// Getting Current PC's IP
        /// </summary>
        /// <returns></returns>
        public string GetCurrentIP()
        {
            try
            {
                string debugIP=GetXMLConfig(MainCtl.XMLDebugClientEleName);
                string[] spIP = debugIP.Split('.');
                if (spIP.Length >= 4)
                {
                    return debugIP;
                }
                else
                {
                    IPHostEntry oHostEntry = Dns.GetHostEntry(Dns.GetHostName());

                    string strClientIp = "";

                    for (int iLoop = 0; iLoop < oHostEntry.AddressList.Length; iLoop++)
                    {
                        if (oHostEntry.AddressList[iLoop].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            strClientIp = oHostEntry.AddressList[iLoop].ToString();
                            break;
                        }
                    }
                    return strClientIp;
                }


            }
            catch
            {

                return "";
            }
        }
        /// <summary>
        /// Getting string.split Last letters
        /// </summary>
        /// <param name="data">string data</param>
        /// <param name="spChar">split character</param>
        /// <returns></returns>
        public string GetLastSplit(string data, char spChar)
        {
            string[] spData = data.Split(spChar);
            return spData[spData.Length - 1];
        }
        /// <summary>
        /// Getting string.split first letters
        /// </summary>
        /// <param name="data">string data</param>
        /// <param name="spChar">split character
        public string GetFirstSplit(string data, char spChar)
        {
            string[] spData = data.Split(spChar);
            return spData[0];
        }
        protected Control[] GetAllControls(Control containerControl)
        {
            List<Control> allControls = new List<Control>();

            Queue<Control.ControlCollection> queue = new Queue<Control.ControlCollection>();
            queue.Enqueue(containerControl.Controls);

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
        

        private bool ConnectDB()
        {
            try
            {
                string strDBType = GetXMLConfig(MainCtl.Xml_DBKind_NM).ToUpper();
                if (string.IsNullOrEmpty(strDBType))
                {
                    throw new Exception("Config file error:" + MainCtl.XMLConfigPrivateFile);
                }
                switch (strDBType)
                {
                    case "ORACLE":
                        m_DBHelper = new CommonHelper(DB.Base.DBKindEnum.Oracle);
                        break;
                    case "MSSQL":
                        m_DBHelper = new CommonHelper(DB.Base.DBKindEnum.MSSQL);
                        break;
                    case "WCF":
                        m_DBHelper = new CommonHelper(DB.Base.DBKindEnum.WCF);
                        break;
                    case "ACCESS":
                        m_DBHelper = new CommonHelper(DB.Base.DBKindEnum.ACCESS);
                        break;
                    default:
                        throw new Exception("DB Type Error");
                }
                m_DBHelper.SetXMLName
                    (
                        MainCtl.Xml_DBKind_NM
                        , MainCtl.Xml_DBSvr_NM
                        , MainCtl.Xml_DBID_NM
                        , MainCtl.Xml_DBPWD_NM
                        , MainCtl.Xml_DBSID_NM
                        , MainCtl.Xml_DBPort_NM
                    );
                m_DBHelper.OnQueryEvent += DBHelper_OnQueryEvent;

                m_DBHelper.OnBackgroundPR += BackgroundPR;
                m_DBHelper.OnBackgroundRCV += ReadAsyncDBData;
                m_DBHelper.OnBackgroundError += BackgroundError;

                return m_DBHelper.Open(m_XMLConfigDT);
            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
            }
            return false;
        }

        

        private void CheckDuplicatedRun(bool allowDupRun)
        {
            if (allowDupRun == false)
            {
                bool isNew = true;
                System.Threading.Mutex mutex = new System.Threading.Mutex(true, Application.ProductName, out isNew);
                if (isNew == false)
                {    // Duplicated Run
                    FrmMsgBox(Common.MsgTypeEnum.Error, MainCtl.DuplicatedRunMsg, MainCtl.DuplicatedRunTitle, MsgBox.MsgBtnEnum.OK, true, true);
                    Application.Exit();
                    return;
                }
            }
        }
        private void ContainsBC(BaseContainer bc)
        {
            if (bc != null)
            {
                bc.Dock = DockStyle.Fill;
                this.Pan_Body.Controls.Clear();
                if (this.Pan_Body.Controls.Contains(bc) == false)
                {
                    this.Pan_Body.Controls.Add(bc);

                }
            }

        }
        public BaseMainForm()
        {

            InitializeComponent();
        }

        
        private void lbl_MainTitle_DoubleClick(object sender, EventArgs e)
        {
            OnMaxWindow(sender, e);
        }


        private void lbl_MainTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                m_MouseMovePoint = new Point(e.X, e.Y);
                m_bMoveMouse = true;
            }
        }

        private void lbl_MainTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_bMoveMouse)
            {
                Point pt = new Point(this.Left + e.X - m_MouseMovePoint.X, this.Top + e.Y - m_MouseMovePoint.Y);
                this.Location = pt;
            }
        }

        private void lbl_MainTitle_MouseUp(object sender, MouseEventArgs e)
        {
            m_bMoveMouse = false;
        }
        /// <summary>
        /// Write Message in StatusBar
        /// </summary>
        /// <param name="msgType">Type of Message</param>
        /// <param name="msg">Message</param>
        /// <param name="callMethodName">Called Method Name</param>
        /// <param name="beep">use the Alram Horn</param>
        /// <param name="logWrite">Trace the Log data</param>
        public virtual void StatusBarMsg(Common.MsgTypeEnum msgType, string msg, string callMethodName = "", bool beep = false, bool logWrite = true)
        {
            this.Invoke(new MethodInvoker(
            delegate ()
            {
                MainCtl.StatusMsgTitle(msgType);

                if (msgType != Common.MsgTypeEnum.Trace)
                {
                    lbl_Msg.Text = msg;
                    if (beep)
                    {
                        SetBeep(beep);
                    }
                }
                if(m_StatusLogData==null)
                {
                    m_StatusLogData = new List<SY_MES.FX.MainForm.Base.Common.StatusLogST>();
                }
                if(m_StatusLogData.Count> m_CntOfStatusLog)
                {
                    m_StatusLogData.RemoveAt(0);
                }
                SY_MES.FX.MainForm.Base.Common.StatusLogST log = new SY_MES.FX.MainForm.Base.Common.StatusLogST();
                log.LogDate = DateTime.Now;
                log.Message = msg;
                log.MsgType = msgType;
                log.Method = callMethodName;
                m_StatusLogData.Add(log);
            }));
        }
        public void CloseFrmMsgBox()
        {
            if (m_MainMsg != null && m_MainMsg.Visible)
            {
                m_MainMsg.Close();
            }
        }
        public DialogResult FrmMsgBox(Common.MsgTypeEnum msgType, string contents, string title, MsgBox.MsgBtnEnum btnty = MsgBox.MsgBtnEnum.OK, bool beep = false, bool bModal = false)
        {
            DialogResult rslt = DialogResult.OK;
            try
            {
                string msgName = "BaseMainForm_MSG";
                Form frm = Common.GetForm(msgName);
                if (frm != null)
                {
                    frm.Close();
                }


                m_MainMsg = new MsgBox(this.MainCtl);

                m_MainMsg.Name = "BaseMainForm_MSG";
                bool modal = bModal;
                if (btnty == MsgBox.MsgBtnEnum.YesNo)
                {
                    modal = true;
                }

                rslt = m_MainMsg.ShowDlg(msgType, contents, title, btnty, modal);
                m_MainMsg.BringToFront();
                if (msgType != Common.MsgTypeEnum.Trace)
                {
                    if (beep)
                    {
                        SetBeep(beep);
                    }
                }
            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
            }
            return rslt;
        }
        /// <summary>
        /// Use the Alram Horn
        /// </summary>
        /// <param name="bBeep">Run or Stop</param>
        public void SetBeep(bool bBeep = true)
        {
            if (OnBeepBar != null)
            {
                if (this.InvokeRequired == true)
                {
                    this.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        OnBeepBar(this, bBeep);
                    }));
                }
                else
                {
                    OnBeepBar(this, bBeep);
                }
            }
        }

        private void lbl_WorkStatus_DoubleClick(object sender, EventArgs e)
        {
            if (Btn_Config.Visible == false)
            {
                Btn_Config.Visible = true;
            }
            else
            {
                Btn_Config.Visible = false;
            }
        }
        public void AddPGM(UserControl uc)
        {
            this.Pan_Body.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void TmrTimeBase_Tick(object sender, EventArgs e)
        {
            if ((DateTime.Now - m_TimerDate[0]).TotalMilliseconds >= 100)
            {
                MainCtl.SyncTIT_Date(DateTime.Now);
                m_TimerDate[0] = DateTime.Now;
            }
            if((DateTime.Now - m_TimerDate[1]).TotalSeconds >=2)
            {
                if(DBHelper.IsOpen())
                {
                    lbl_Time.BackColor = Color.Black;
                }
                else
                {
                    lbl_Time.BackColor = Color.Red;
                }
                m_TimerDate[1] = DateTime.Now;
            }
            if((DateTime.Now - m_TimerDate[2]).TotalMinutes > 30)
            {                
                SyncSVRTime(GetSeverTime());
                DispShift();
                m_TimerDate[2] = DateTime.Now;
            }


        }
        private string GetDicParam(object param)
        {
            string vals = "";
            if (param is Dictionary<string, string>)
            {
                foreach (KeyValuePair<string, string> pair in (Dictionary<string, string>)param)
                {
                    vals += "[" + pair.Key + ":" + pair.Value + "]";
                }
            }
            else if (param is Dictionary<string, object>)
            {
                foreach (KeyValuePair<string, object> pair in (Dictionary<string, object>)param)
                {
                    if (pair.Value is string)
                    {
                        vals += "[" + pair.Key + ":" + pair.Value + "]";
                    }
                    else
                    {
                        vals += "[" + pair.Key + ":" + "<BLOB>" + "]";
                    }
                }
            }

            return vals;
        }
        /// <summary>
        /// Sychronizing the PC time from Server time
        /// </summary>
        /// <param name="svrTime">format : yyyy-MM-dd HH:mm:ss</param>
        /// <param name="bCulture">false : UTC, true : local time</param>
        /// <returns></returns>
        private bool SyncSVRTime(string svrTime, bool bCulture = false)
        {
            try
            {
                if (string.IsNullOrEmpty(svrTime) == false)
                {
                    
                    DateTime tDate = DateTime.Now;
                    DateTime utcTime = DateTime.Now.ToUniversalTime();
                    DateTime lpTime = DateTime.Now.ToLocalTime();

                    //tDate = Convert.ToDateTime(dt.Rows[0]["SVRTIME"],);
                    tDate = DateTime.ParseExact(svrTime, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.CurrentUICulture);

                    tDate = tDate.Add(utcTime - lpTime);
                    //MessageBox.Show(tDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    SY_MES.FX.MainForm.Base.Common.SYSTEMTIME stDate = new SY_MES.FX.MainForm.Base.Common.SYSTEMTIME();

                    stDate.wYear = Convert.ToInt16(tDate.Year);
                    stDate.wMonth = Convert.ToInt16(tDate.Month);
                    stDate.wDay = Convert.ToInt16(tDate.Day);

                    stDate.wHour = Convert.ToInt16(tDate.Hour);
                    stDate.wMinute = Convert.ToInt16(tDate.Minute);
                    stDate.wSecond = Convert.ToInt16(tDate.Second);
                    stDate.wMilliseconds = Convert.ToInt16(tDate.Millisecond);
                    if (bCulture == false)
                    {
                        tDate = DateTime.ParseExact(svrTime, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                        stDate = new SY_MES.FX.MainForm.Base.Common.SYSTEMTIME();

                        stDate.wYear = Convert.ToInt16(tDate.ToUniversalTime().Year);
                        stDate.wMonth = Convert.ToInt16(tDate.ToUniversalTime().Month);
                        stDate.wDay = Convert.ToInt16(tDate.ToUniversalTime().Day);
                        stDate.wHour = Convert.ToInt16(tDate.ToUniversalTime().Hour);
                        stDate.wMinute = Convert.ToInt16(tDate.ToUniversalTime().Minute);
                        stDate.wSecond = Convert.ToInt16(tDate.ToUniversalTime().Second);
                        stDate.wMilliseconds = Convert.ToInt16(tDate.ToUniversalTime().Millisecond);
                    }


                    uint ret = SY_MES.FX.MainForm.Base.Common.SetSystemTime(ref stDate);
                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        #region <<DBHelper
        protected virtual void ReadAsyncDBData(object sender, string query, Dictionary<string, string> param, DataTable dt)
        {
            this.Invoke(new MethodInvoker(
                delegate ()
                {
                    this.StatusProgressCtl.Value = 100;
                    if(sender is BaseContainer)
                    {
                        ((BaseContainer)sender).ReadAsyncDBData(sender, query, param, dt);
                    }
                }));
        }
        protected virtual void BackgroundPR(object sender, ProgressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(
                delegate ()
                {
                    this.StatusProgressCtl.Value = e.ProgressPercentage;
                    if (sender is BaseContainer)
                    {
                        ((BaseContainer)sender).BackgroundPR(sender, e);
                    }
                }));

        }

        protected virtual void BackgroundError(object sender, string query, Dictionary<string, string> param, DataTable dt, Exception eLog)
        {
            if (sender is BaseContainer)
            {
                ((BaseContainer)sender).BackgroundError(sender, query, param, dt, eLog);
            }
        }

        private void DBHelper_OnQueryEvent(object sender, CommonHelper.QueryEventST args)
        {
            SetDBTrace(args.leadTimeMilSec, args.query, GetDicParam(args.param));
        }

        public DataTable ExcuteQuery(string query, Dictionary<string, string> param = null)
        {
            try
            {
                DataTable dt = DBHelper.ExecuteQuery(query, param);
                return dt;
            }
            catch(Exception eLog)
            {
                StatusBarMsg(Common.MsgTypeEnum.Error, eLog.Message + " [Query:" + query + "]", MethodBase.GetCurrentMethod().Name, true);
            }
            return new DataTable();
        }
        public int ExecuteNonQuery(string query, Dictionary<string, string> param = null)
        {
            
            try
            {
                int rslt = DBHelper.ExecuteNonQuery(query, param);
                
                return rslt;
            }
            catch(Exception eLog)
            {
                StatusBarMsg(Common.MsgTypeEnum.Error, eLog.Message + " [Query:" + query + "]", MethodBase.GetCurrentMethod().Name, true);
            }
            return -1;
        }
        public int ExecuteNonQuery(string query, Dictionary<string, object> param = null)
        {
            
            try
            {
                int rslt = DBHelper.ExecuteNonQuery(query, param);
                
                return rslt;
            }
            catch(Exception eLog)
            {
                StatusBarMsg(Common.MsgTypeEnum.Error, eLog.Message + " [Query:" + query + "]", MethodBase.GetCurrentMethod().Name, true);
            }
            return -1;
        }
        public void AsyncExecueteQuery(object sender, string query, Dictionary<string, string> param = null)
        {
            try
            {
                DBHelper.AsyncExecueteQuery(sender, query, param);
            }
            catch(Exception eLog)
            {
                StatusBarMsg(Common.MsgTypeEnum.Error, eLog.Message + " [Query:" + query + "]", MethodBase.GetCurrentMethod().Name, true);
            }
            
        }

        #endregion
    }
}
