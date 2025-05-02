using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SY_MES.FX.DB.Base;

namespace SY_MES.FX.DB
{
    [ToolboxItem(true)]
    public  class CommonHelper
    {
        public struct QueryEventST
        {
            public string query;
            public object param;
            public double leadTimeMilSec;
        }
        public delegate void QueryEvent(object sender, QueryEventST args);
        public event QueryEvent OnQueryEvent;
        public event BackgroundError OnBackgroundError = null;
        public event BackgroundRCV OnBackgroundRCV = null;
        public event BackgroundPR OnBackgroundPR = null;
        
        public enum AsyncParamKeyEnum
        {
            Sender = 0,
            QueryString = 1,
            QueryParam = 2,
            DataSet=3,
            StartDate=4,
            RunCtl = 5

        }
        private IDBBase m_DB;
        public CommonHelper()
        {
            AssignDBType(m_DBKind);
        }
        public CommonHelper(DBKindEnum ty)
        {
            AssignDBType(ty);


        }
        Dictionary<string, BackgroundWorker> m_dicBackWorker;
        private void AssignDBType(DBKindEnum ty)
        {
            
            m_DBKind = ty;
            switch (ty)
            {
                case DBKindEnum.Oracle:
                    m_DB = new OracleHelper();
                    break;
                case DBKindEnum.MSSQL:
                    m_DB = new MSSqlHelper();
                    break;
                case DBKindEnum.WCF:
                    m_DB = new WCFHelper();
                    break;
                case DBKindEnum.ACCESS:
                    m_DB = new AccessHelper();
                    break;
            }

            
        }
        
        public void SetXMLName(string dbKind, string dbServer, string dbID, string dbPWD, string dbSID, string dbPORT)
        {
            if(m_DB is DB.Base.DBComponent)
            {
                ((DB.Base.DBComponent)m_DB).SetXMLName(dbKind, dbServer, dbID, dbPWD, dbSID, dbPORT);
            }
        }

        private DBKindEnum m_DBKind = DBKindEnum.Oracle;
        public DBKindEnum DBKind
        {
            get { return m_DBKind; }
            set { m_DBKind = value; }
        }
       
      
        public int BulkInsert(string toTable, ref DataTable sendData, bool bAppend = true)
        {
            
            return m_DB.BulkInsert(toTable, ref sendData, bAppend);
        }

        public bool Close()
        {
            return m_DB.Close();
        }

        public int ExecuteNonQuery(string query, Dictionary<string, string> param = null)
        {
            QueryEventST args = new QueryEventST();
            DateTime stDate = DateTime.Now;
            
            int rslt =  m_DB.ExecuteNonQuery(query, param);
            args.query = query;
            args.param = param;
            args.leadTimeMilSec = (DateTime.Now - stDate).TotalMilliseconds;
            if(OnQueryEvent!=null)
            {
                OnQueryEvent(this, args);
            }
            return rslt;
        }

        public int ExecuteNonQuery(string query, Dictionary<string, object> param)
        {
            QueryEventST args = new QueryEventST();
            DateTime stDate = DateTime.Now;

            int rslt= m_DB.ExecuteNonQuery(query, param);

            args.query = query;
            args.param = param;
            args.leadTimeMilSec = (DateTime.Now - stDate).TotalMilliseconds;
            if (OnQueryEvent != null)
            {
                OnQueryEvent(this, args);
            }
            return rslt;
        }

        public DataTable ExecuteQuery(string query, Dictionary<string, string> param = null)
        {
            QueryEventST args = new QueryEventST();
            DateTime stDate = DateTime.Now;
            DataTable dt = m_DB.ExecuteQuery(query, param);

            args.query = query;
            args.param = param;
            args.leadTimeMilSec = (DateTime.Now - stDate).TotalMilliseconds;
            if (OnQueryEvent != null)
            {
                OnQueryEvent(this, args);
            }
            return dt;
        }

        public bool IsOpen()
        {
            return m_DB.IsOpen();
        }

        public bool Open(DataTable xmlConfig)
        {
            if(m_DB!=null)
            {   
                if(m_DB is DBComponent)
                {
                    ((DBComponent)m_DB).XmlConfig = xmlConfig;
                }
               
            }
            return m_DB.Open(xmlConfig);
        }

        public bool Open(string svr, string uid, string pwd, string dbnm)
        {
            return m_DB.Open(svr, uid, pwd, dbnm);
        }
        public bool Open(string svr, string uid, string pwd, string dbnm, string port)
        {
            return m_DB.Open(svr, uid, pwd, dbnm, port);
        }
        private void InitBackWorker(string query)
        {
            
            if(m_dicBackWorker== null)
            {
                m_dicBackWorker = new Dictionary<string, BackgroundWorker>();
            }
            if (m_dicBackWorker != null && m_dicBackWorker.ContainsKey(query) == false)
            {

                m_dicBackWorker.Add(query, GetBW());
            }
            else
            {
                if (m_dicBackWorker[query].IsBusy)
                {
                    m_dicBackWorker[query].CancelAsync();
                    m_dicBackWorker[query].Dispose();
                    m_dicBackWorker[query] = GetBW();
                }
            }
        }
        private BackgroundWorker GetBW()
        {
            BackgroundWorker bw = new BackgroundWorker();
            
            bw.DoWork += new DoWorkEventHandler(ExecuteBackground_DoWork);            
            bw.ProgressChanged += new ProgressChangedEventHandler(ExecuteBackground_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ExecuteBackground_RunWorkerCompleted);
           
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            
            return bw;
        }
        public void AsyncExecueteQuery(object sender, string query, Dictionary<string, string> param = null, object runCtl=null)
        {
            InitBackWorker(query);
            if(runCtl!=null && runCtl is System.Windows.Forms.Control)
            {
                ((System.Windows.Forms.Control)runCtl).Enabled = false;
            }
            if (m_dicBackWorker.ContainsKey(query) && m_dicBackWorker[query].IsBusy == false)
            {
                Dictionary<AsyncParamKeyEnum, object> rst = new Dictionary<AsyncParamKeyEnum, object>();
                rst.Add(AsyncParamKeyEnum.QueryParam, param);
                rst.Add(AsyncParamKeyEnum.QueryString, query);
                rst.Add(AsyncParamKeyEnum.Sender, sender);
                rst.Add(AsyncParamKeyEnum.StartDate, DateTime.Now);
                rst.Add(AsyncParamKeyEnum.RunCtl, runCtl);
                m_dicBackWorker[query].RunWorkerAsync(rst);
            }
        }

        #region AsyncExcueteQuery -- Additional methods
        private object GetValue(Dictionary<AsyncParamKeyEnum, object> rst, AsyncParamKeyEnum paramKey)
        {
            if(rst!=null && rst.ContainsKey(paramKey))
            {
                return rst[paramKey];
            }
            return null;
        }
        private void ExecuteBackground_DoWork(object sender, DoWorkEventArgs e)
        {

            Dictionary<AsyncParamKeyEnum, object> rst = (Dictionary<AsyncParamKeyEnum, object>)e.Argument;
            string query = "";
            Dictionary<string, string> param =new Dictionary<string,string>();
            try
            {
                
                query = GetValue(rst, AsyncParamKeyEnum.QueryString).ToString();
                param= (Dictionary<string, string>)GetValue(rst, AsyncParamKeyEnum.QueryParam);
                DataTable dt = new DataTable();
                if (!string.IsNullOrEmpty(query))
                {
                    if (m_dicBackWorker[query].CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        dt = m_DB.ExecuteQuery(query, param);
                        rst.Add(AsyncParamKeyEnum.DataSet, dt);
                    }
                    m_dicBackWorker[query].ReportProgress(5);
                }
                e.Result = rst;
            }
            catch (Exception eLog)
            {
                if (OnBackgroundError != null)
                {
                    if (rst.ContainsKey(AsyncParamKeyEnum.DataSet) == false)
                    {
                        rst.Add(AsyncParamKeyEnum.DataSet, new DataTable());
                    }
                    OnBackgroundError(this, query, param, new DataTable(), eLog);
                }
                else
                {
                    throw new Exception(eLog.Message + "[Query:" + query + "]");
                }
                //Debug.WriteLine("[Query:" + query + "]" + "[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
            }
            finally
            {

            }

        }
        private void ExecuteBackground_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (OnBackgroundPR != null)
                {
                    OnBackgroundPR(sender, e);

                }
            }
            catch (Exception eLog)
            {
                throw new Exception(eLog.Message);
            }

        }
        private void ExecuteBackground_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string query = "";
            Dictionary<string, string> param = new Dictionary<string, string>();
            object asyncSender = null;
            Dictionary<AsyncParamKeyEnum, object> rst = new Dictionary<AsyncParamKeyEnum,object>();
            try
            {
                
                
                if (e.Error != null)
                {

                }
                else if (e.Cancelled)
                {

                }
                else
                {
                    rst = (Dictionary<AsyncParamKeyEnum, object>)e.Result;
                    if (OnBackgroundRCV != null)
                    {
                        object val = GetValue(rst, AsyncParamKeyEnum.QueryString);
                        if (val != null)
                        {
                            query = val.ToString();
                            param = (Dictionary<string, string>)GetValue(rst, AsyncParamKeyEnum.QueryParam);
                            asyncSender= GetValue(rst, AsyncParamKeyEnum.Sender);
                            DataTable dt = (DataTable)GetValue(rst, AsyncParamKeyEnum.DataSet);
                            OnBackgroundRCV(asyncSender, query, param, dt);
                            if(OnQueryEvent!=null)
                            {
                                QueryEventST evtArgs = new QueryEventST();
                                evtArgs.query = query;
                                evtArgs.param = param;
                                DateTime prvDate = (DateTime)GetValue(rst, AsyncParamKeyEnum.StartDate);
                                evtArgs.leadTimeMilSec = (DateTime.Now - prvDate).TotalMilliseconds;
                                OnQueryEvent(sender, evtArgs);
                            }
                        }
                        else
                        {
                            OnBackgroundRCV(asyncSender, "", param, null);
                        }
                        
                    }
                }

            }
            catch (Exception eLog)
            {
                if(OnBackgroundError!=null)
                {
                    OnBackgroundError(sender, query, param, new DataTable(), eLog);
                }
                
            }
            finally
            {
                object runCtl = GetValue(rst, AsyncParamKeyEnum.RunCtl);
                if(runCtl!=null && runCtl is System.Windows.Forms.Control)
                {
                    ((System.Windows.Forms.Control)runCtl).Enabled = true;
                }

            }

        }
        #endregion

    }
}
