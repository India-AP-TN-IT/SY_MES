using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SY_MES.FX.MainForm.Base;

namespace SY_MES.FX.MainForm
{
    [ToolboxItem(false)]
    public partial class BaseContainer : UserControl
    {
    
        
        private FX.DB.CommonHelper m_DBHelper = null;
        private bool m_AutoLoadData = true;
        public delegate void BaseFormLoad(object sender, EventArgs e);
        [Category(Base.Common.CN_CATEGORY_APP)]
        public event BaseFormLoad OnAfterBaseFormLoad = null;
        [Category(Base.Common.CN_CATEGORY_APP)]
        public bool AutoLoadData
        {
            get { return m_AutoLoadData; }
            set { m_AutoLoadData = value; }
        }
        protected FX.DB.CommonHelper DBHelper
        {
            get { return m_DBHelper; }
            set { m_DBHelper = value; }
        }
        public virtual void ReadDataFromScanner(object sender, string data)
        {
           
        }
        protected virtual void WorkState(Common.WorkStateEnum state)
        {
            if(PBaseFrm!=null)
            {
                PBaseFrm.MainCtl.WorkState(state);
            }
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitControls();
            if (DesignMode == false)
            {
                if (m_DBHelper == null)
                {
                    m_DBHelper = new DB.CommonHelper();
                    m_DBHelper = PBaseFrm.DBHelper;
                    
                }
                if (m_AutoLoadData)
                {
                    LoadData();
                }
            }
        }

        public virtual void ReadAsyncDBData(object sender, string query, Dictionary<string, string> param, DataTable dt)
        {
            
        }
        public virtual void BackgroundPR(object sender, ProgressChangedEventArgs e)
        {
            

        }

        public virtual void BackgroundError(object sender, string query, Dictionary<string, string> param, DataTable dt, Exception eLog)
        {

        }

        public virtual void AfterBaseFormLoad(EventArgs e)
        {
            
            if (OnAfterBaseFormLoad!= null)
            {
                OnAfterBaseFormLoad(this, e);
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
            return PBaseFrm.GetINI(iniKey, defVal);
        }
        public virtual void LoadData()
        {
            
        }
        protected virtual void InitControls()
        {

        }
        
        protected FX.MainForm.BaseMainForm PBaseFrm
        {
            get
            {
                if (this.ParentForm != null)
                {
                    if (ParentForm is BaseMainForm)
                    {
                        return (FX.MainForm.BaseMainForm)ParentForm;
                    }
                    else if(ParentForm is BaseDialog)
                    {
                        return ((FX.MainForm.BaseDialog)ParentForm).PBaseFrm;
                    }
                }
                return null;

            }
            set
            {
                this.PBaseFrm = value;
            }
        }

        
        #region <<BaseFrom Control
        /// <summary>
        /// Write Message in StatusBar
        /// </summary>
        /// <param name="msgType">Type of Message</param>
        /// <param name="msg">Message</param>
        /// <param name="callMethodName">Called Method Name</param>
        /// <param name="beep">use the Alram Horn</param>
        /// <param name="logWrite">Trace the Log data</param>
        public void StatusBarMsg(Common.MsgTypeEnum msgType, string msg, string callMethodName = "", bool beep = false, bool logWrite = true)
        {
            PBaseFrm.StatusBarMsg(msgType, msg, callMethodName, beep, logWrite);
        }
        public DialogResult FrmMsgBox(Common.MsgTypeEnum msgType, string contents, string title, MsgBox.MsgBtnEnum btnty = MsgBox.MsgBtnEnum.OK, bool beep = false, bool bModal = false)
        {
            return PBaseFrm.FrmMsgBox(msgType, contents, title, btnty, beep, bModal);
        }
        public void CloseFrmMsgBox()
        {
            PBaseFrm.CloseFrmMsgBox();
        }
        [Browsable(false)]
        public string CORCD
        {
            get
            {

                return PBaseFrm.GetXMLConfig("CORCD");
            }
        }
        [Browsable(false)]
        public string BIZCD
        {
            get
            {
                return PBaseFrm.GetXMLConfig("BIZCD");
            }
        }
        public BaseContainer()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
        }

        public string GetCurrentIP()
        {
            return PBaseFrm.GetCurrentIP();
        }
        [Browsable(false)]
        public string RunBC
        {
            get
            {
                return PBaseFrm.RunBC;
            }
        }
        #endregion

        #region <<DBHelper
        public DataTable ExecuteQuery(string query, Dictionary<string, string> param=null)
        {
            try
            {
                if (DBHelper != null)
                {
                    return DBHelper.ExecuteQuery(query, param);
                }
                else
                {
                    return PBaseFrm.ExcuteQuery(query, param);
                }
            }
            catch(Exception eLog)
            {
                StatusBarMsg(Common.MsgTypeEnum.Error, eLog.Message+" [Query:" + query+"]",MethodBase.GetCurrentMethod().Name, true);
            }
            return new DataTable();
        }
        public int ExecuteNonQuery(string query, Dictionary<string, string> param = null)
        {
            try
            {
                return DBHelper.ExecuteNonQuery(query, param);
            }
            catch (Exception eLog)
            {
                StatusBarMsg(Common.MsgTypeEnum.Error, eLog.Message + " [Query:" + query + "]",MethodBase.GetCurrentMethod().Name, true);
            }
            return -1;

        }
        public int ExecuteNonQuery(string query, Dictionary<string, object> param = null)
        {
            try
            {
                return DBHelper.ExecuteNonQuery(query, param);
            }
            catch (Exception eLog)
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
            catch (Exception eLog)
            {
                StatusBarMsg(Common.MsgTypeEnum.Error, eLog.Message + " [Query:" + query + "]", MethodBase.GetCurrentMethod().Name, true);
            }
        }
        #endregion
    }
}
