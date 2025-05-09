using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SY_MES.FX.MainForm;
using System.Reflection;
using System.Collections;
using SY_MES.FX.MainForm.Base;
using SY_MES.DEPLOY.Sub;
using System.Drawing.Drawing2D;
using SY_MES.FX.DB.Base;

namespace SY_MES.DEPLOY
{
    public partial class CustomizedMainFrm : BaseMainForm
    {
        private BaseDialog m_dlg;
        private List<FX.Devices.Scanner.SerialScanner> m_lstScanner = new List<FX.Devices.Scanner.SerialScanner>();
        private FX.Devices.UDio m_UDio;
        protected FX.Devices.UDio UDio
        {
            get { return m_UDio; }
        }

        public CustomizedMainFrm()
        {
            InitializeComponent();
        }
        public CustomizedMainFrm(FormModeEnum mode)
        {
            
            InitializeComponent();
            this.FormMode = mode;
        }
        private void LoadNativeLibs()
        {            
            FX.Common.Funcs.LoadNativeLibrary(@".\CLIB\pdfium.dll");    //WorkStand PDF Rendering Lib            
            FX.Devices.Base.Common.UDIO_CLIB_PATH = @".\CLIB\uio64.dll";
        }
        protected override void OnLoad(EventArgs e)
        {
            if (DesignMode == false)
            {
                LoadNativeLibs();
            }
            base.OnLoad(e);
        }
        protected override void OnResult(object sender, EventArgs e)
        {
            base.OnResult(sender, e);
            if (m_dlg != null && m_dlg.Visible)
            {
                m_dlg.Close();
            }
            m_dlg = new BaseDialog("Station Result", new StationRsltDlg(), this);
            m_dlg.Show(this);
        }
        
        protected override DataTable GetConfig()
        {
            var assembly = Assembly.GetExecutingAssembly();
            string[] name = assembly.GetManifestResourceNames();
            var stream = assembly.GetManifestResourceStream(assembly.GetName().Name + "." + MainCtl.XMLConfigPrivateFile);
            DataTable dt = new DataTable();
            if (stream != null)
            {
                DataSet ds = new DataSet();
                ds.ReadXml(stream);
                if (ds.Tables.Count > 0)
                {
                    for (int row = 0; row < ds.Tables[0].Rows.Count; row++)
                    {
                        for (int col = 0; col < ds.Tables[0].Columns.Count; col++)
                        {
                            ds.Tables[0].Rows[row][col] = ds.Tables[0].Rows[row][col].ToString().Trim();
                        }
                    }
                }
                dt = ds.Tables[0];
                ds = new DataSet();
                string xmlConfigPublic = MainCtl.XMLConfigFile;
                ds.ReadXml(xmlConfigPublic);
                if (ds.Tables.Count > 0)
                {
                    DataTable dtPublic = new DataTable();
                    dtPublic = ds.Tables[0];
                    if (dtPublic.Rows.Count > 0)
                    {
                        for (int col = 0; col < dtPublic.Columns.Count; col++)
                        {
                            string colNM = dtPublic.Columns[col].ColumnName;
                            string colVal = dtPublic.Rows[0][colNM].ToString();
                            if (dt.Columns.Contains(colNM) == false)
                            {
                                //dt.Columns.Add(dtPublic.Columns[col]);
                                dt.Columns.Add(colNM,typeof(string));
                                dt.Rows[0][colNM] = colVal;
                             }

                        }
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }
        protected override void InitDesign()
        {
            base.InitDesign();
            Plant_CTL.Text = Plant_CTL.Text + Environment.NewLine + GetLastSplit(GetCurrentIP(), '.');
        }
        
        protected override string GetSeverTime()
        {
            try
            {
                DataTable dt = ExcuteQuery("PKG_COM.GET_SVR_TIME", new Dictionary<string, string>());
                if (dt !=null && dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["SVRTIME"].ToString();
                }
                else
                {
                    return base.GetSeverTime();
                }
            }
            catch(Exception eLog)
            {
                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, eLog.Message, MethodBase.GetCurrentMethod().Name, true);
                return base.GetSeverTime();
            }
        }
        
        public override void StatusBarMsg(SY_MES.FX.MainForm.Base.Common.MsgTypeEnum msgType, string msg, string callMethodName = "", bool beep = false, bool logWrite = true)
        {
            base.StatusBarMsg(msgType, msg, callMethodName, beep, logWrite);
            if (m_dlg != null  && m_dlg.Visible)
            {
                if(m_dlg.BC!=null && m_dlg.BC is SystemConfigDlg)
                {
                    ((SystemConfigDlg)m_dlg.BC).LoadLogData();
                }
            }
        }
        protected override void OnWorkStandard(object sender, EventArgs e)
        {
            base.OnWorkStandard(sender, e);
            if (m_dlg != null && m_dlg.Visible)
            {
                m_dlg.Close();
            }
            m_dlg = new BaseDialog("Work Standard for "+GetINI("STATION_INFOR/STATIONCD")+"@"+Line_CTL.Text, new WorkStandardDlg(), this, FormWindowState.Maximized);
            m_dlg.Show(this);
        }
        public override void SetDBTrace(double leadTime, string query, string strParam)
        {
            try
            {
                if (query.Contains("PKG_DB.SET_TRACE_DATA") == false)
                {
                    base.SetDBTrace(leadTime, query, strParam);

                    bool bDBTrace = FX.Common.Funcs.GetBoolStr(GetINI("STATION_INFOR/DB_TRACE_YN"));
                    double dbLimit = FX.Common.Funcs.GetO2D(GetINI("STATION_INFOR/DB_TRACE_TIME_LIMIT"));
                    if (bDBTrace)
                    {
                        if (dbLimit <= leadTime)
                        {
                            int nLT = Convert.ToInt32(leadTime);
                            Dictionary<string, string> param = new Dictionary<string, string>();
                            param.Add("IN_CORCD", GetXMLConfig("CORCD"));
                            param.Add("IN_BIZCD", GetXMLConfig("BIZCD"));
                            param.Add("IN_WHO", GetCurrentIP());
                            param.Add("IN_CLASS", RunBC);
                            param.Add("IN_LEADTIME", nLT.ToString());
                            param.Add("IN_QUERY", query);
                            param.Add("IN_PARAM", strParam);
                            DBHelper.ExecuteNonQuery("PKG_DB.SET_TRACE_DATA", param);
                        }
                    }
                }
            }
            catch(Exception eLog)
            {
                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, eLog.Message, MethodBase.GetCurrentMethod().Name, true);
            }
        }
        protected override void OnConfig(object sender, EventArgs e)
        {
            
            try
            {
                base.OnConfig(sender, e);
                if (sender is Control) { ((Control)sender).Enabled = false; };
                if (m_dlg != null && m_dlg.Visible)
                {
                    m_dlg.Close();
                }
                m_dlg = new BaseDialog("System Configuration", new SystemConfigDlg(), this);
                m_dlg.Show(this);
            }
            catch(Exception eLog)
            {
                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, eLog.Message, MethodBase.GetCurrentMethod().Name, true);
            }
            finally
            {
                if(sender is Control) { ((Control)sender).Enabled = true;};
            }
        }
        protected override string GetLineDESC()
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("IN_CORCD", GetXMLConfig("CORCD"));
                param.Add("IN_BIZCD", GetXMLConfig("BIZCD"));
                param.Add("IN_LINECD", GetINI("STATION_INFOR/LINECD"));
                param.Add("IN_STATIONCD", GetINI("STATION_INFOR/STATIONCD"));
                DataTable dt = ExcuteQuery("PKG_FX_BASE.GET_LINE_DESC", param);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["LINE_DESC"].ToString();
                }
                else
                {
                    return base.GetLineDESC();
                }
            }
            catch(Exception eLog)
            {
                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, eLog.Message, MethodBase.GetCurrentMethod().Name, true);
                return "";
            }

        }
        protected override void LoadINI()
        {
            base.LoadINI();

            try
            {
                string screenID = "";
                string ip = GetCurrentIP();

                m_DicIni = new Dictionary<string, string>();
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("IN_CORCD", GetXMLConfig("CORCD"));
                param.Add("IN_BIZCD", GetXMLConfig("BIZCD"));
                param.Add("IN_IP", GetCurrentIP());

                DataTable dt = ExcuteQuery("PKG_FX_BASE.GET_INI_DB", param);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (!m_DicIni.ContainsKey(dr["INI_KEY"].ToString()))
                        {
                            m_DicIni.Add(dr["INI_KEY"].ToString(), dr["INI_KEYVALUE"].ToString());
                        }
                    }

                    param = new Dictionary<string, string>();
                    param.Add("IN_CORCD", GetXMLConfig("CORCD"));
                    param.Add("IN_BIZCD", GetXMLConfig("BIZCD"));
                    param.Add("IN_IP", ip);
                    param.Add("IN_SUB_SCREEN", "");
                    dt = ExcuteQuery("PKG_FX_BASE.GET_SCREEN", param);
                    if (dt.Rows.Count > 0)
                    {
                        screenID = dt.Rows[0]["SCREEN"].ToString();
                        this.Station_CTL.Text = dt.Rows[0]["SCREENNM"].ToString();
                        
                        this.Line_CTL.Text = GetLineDESC();
                        string mainTitle = GetINI("STATION_INFOR/TITLE");
                        if(string.IsNullOrEmpty(mainTitle) == false)
                        {
                            this.Line_CTL.Text = mainTitle;
                        }
                        this.RunBC = screenID;
                    }
                    else
                    {
                        if (GetXMLConfig(MainCtl.XMLDebugClientEleName).Contains("@"))
                        {
                            screenID = GetXMLConfig(MainCtl.XMLDebugClientEleName).Substring(1);
                            this.RunBC = screenID;
                            this.Station_CTL.Text = screenID;
                            this.Line_CTL.Text = "Test Program";
                        }
                        else
                        {
                            throw new Exception("No screen ID:@" + ip + Environment.NewLine + "Check MES.MES0150");
                        }
                    }
                }
                else
                {
                    throw new Exception("No screen ID:@" + ip + Environment.NewLine + "Check MES.MES0150");
                }

            }
            catch(Exception eLog)
            {
                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, eLog.Message, MethodBase.GetCurrentMethod().Name, true);
            }
            
        }
        
        public override string GetWorkDate(bool bCat = true)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("IN_CORCD", GetXMLConfig("CORCD"));
                param.Add("IN_BIZCD", GetXMLConfig("BIZCD"));
                param.Add("IN_BIT_CAT", bCat ? "1" : "0");
                DataTable dt = ExcuteQuery("PKG_COM.GET_WORK_DATE", param);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["YMD"].ToString();
                }
                return base.GetWorkDate(bCat);
            }
            catch
            {
                return base.GetWorkDate(bCat);
            }
        }
        public override string GetShift()
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("IN_CORCD", GetXMLConfig("CORCD"));
                param.Add("IN_BIZCD", GetXMLConfig("BIZCD"));
                DataTable dt = ExcuteQuery("PKG_COM.GET_WORK_SHIFT", param);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["WORK_SHIFT"].ToString();
                }
                else
                {
                    return "0";
                }

            }
            catch
            {
                return "0";
            }
        }
        protected override void DispShift()
        {
            base.DispShift();
            
            
            string shift = GetShift();
            switch(shift)
            {
                case "1":
                    WorkShift_CTL.Text = "A";
                    break;
                case "2":
                    WorkShift_CTL.Text = "B";
                    break;
                case "3":
                    WorkShift_CTL.Text = "C";
                    break;
                case "4":
                    WorkShift_CTL.Text = "D";
                    break;
                default:
                    WorkShift_CTL.Text = "ERR";
                    break;
            }
            
        }
        private void SetScanners(string iniPath)
        {
            string val = GetINI(iniPath);

            string[] spVal = val.Split(',');
            int cnt = 0;
            
            foreach(string s in spVal)
            {
                if (string.IsNullOrEmpty(s) == false)
                {
                    int port = Convert.ToInt32(s.Trim());
                    FX.Devices.Scanner.SerialScanner scanner = new FX.Devices.Scanner.SerialScanner();
                    Dictionary<string, object> param = new Dictionary<string, object>();
                    param.Add("PORT", port);
                    if (IsDebugMode == false)
                    {
                        scanner.OpenDevice(param);
                        scanner.DeviceName = cnt.ToString();
                        scanner.OnScanData += Scanner_OnScanData;
                    }

                    m_lstScanner.Add(scanner);
                    cnt++;
                }
            }
        }
        
        private void Scanner_OnScanData(object sender, string strData)
        {
            this.Invoke(new MethodInvoker(
            delegate()
            {
                ChildBC.ReadDataFromScanner(sender, strData);
            }));
            
        }
        private void SetUDio(string iniPath)
        {
            bool bUSE = FX.Common.Funcs.GetBoolStr(GetINI(iniPath));
            if(bUSE)
            {
                if(m_UDio==null)
                {
                    m_UDio = new FX.Devices.UDio();

                   
                }
                Dictionary<string, object> param  = new Dictionary<string,object>();
                param.Add("PBASE", this);
                param.Add("PID", GetINI("LOCAL_IO/UDIO_PID"));
                param.Add("BID", GetINI("LOCAL_IO/UDIO_BID"));
                
                m_UDio.OpenDevice(param);
            }
            
        }
        protected override void InitDevices()
        {
            base.InitDevices();
            try
            {

                SetScanners("BARCODE_SCANNER/PORT");
                SetUDio("LOCAL_IO/UDIO_YN");
            }
            catch(Exception eLog)
            {
                this.WindowState = FormWindowState.Minimized;
                FrmMsgBox(FX.MainForm.Base.Common.MsgTypeEnum.Error, eLog.Message, "Device Open Error", FX.MainForm.Base.MsgBox.MsgBtnEnum.OK, true, true);
                Application.Exit();
            }

        }


    }
}
