using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SY_MES.FX.DB.Base;

namespace SY_MES.FX.DB
{
    [ToolboxItem(true)]
    public class WCFHelper : DBComponent, IDBBase
    {
        private WCF.Client m_WCF = null;
        private int m_resTime = 2000;
        private bool m_bOpen = false;
        public int ResponseTime
        {
            get { return m_resTime; }
            set { m_resTime = value; }
        }
        public bool Open(DataTable xmlConfig)
        {
            try
            {


                if (xmlConfig.Rows.Count > 0)
                {
                    string uri = xmlConfig.Columns.Contains(GetXMLName(XMLConfNameEnum.dbServer)) ? xmlConfig.Rows[0][GetXMLName(XMLConfNameEnum.dbServer)].ToString() : "";
                    string user = xmlConfig.Columns.Contains(GetXMLName(XMLConfNameEnum.dbID)) ? xmlConfig.Rows[0][GetXMLName(XMLConfNameEnum.dbID)].ToString() : "";

                    return OpenClient(uri, user);
                }
                return false;
            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);

                return false;

            }
        }
        private bool OpenClient(string uri, string user)
        {
            try
            {
                m_DBConnInfor.SVR = uri;
                m_DBConnInfor.ID = user;
                string[] parURL = uri.Trim().ToLower().Replace("http://", "").Replace("https://", "").Split(':');
                if (parURL.Length > 0)
                {
                    m_DBConnInfor.SID = parURL[0];
                    m_DBConnInfor.PORT = parURL[1].Trim().Split('/')[0];
                    m_WCF = new WCF.Client(uri, m_DBConnInfor.SVR, m_DBConnInfor.PORT, m_resTime);
                }
                else
                {
                    throw new Exception("URL Error:" + uri);
                }
                m_bOpen = true;
                return true;
            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
                return false;
            }
        }
        public int ExecuteNonQuery(string query, Dictionary<string, object> param)
        {
            return -1;
        }
        public bool Open(string svr, string uid, string pwd, string dbnm, string port)
        {
            try
            {
                return OpenClient(svr, uid);

            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);

                return false;

            }
        }
        public bool Open(string svr, string uid, string pwd, string dbnm)
        {
            return Open(svr, uid, pwd, dbnm, m_DBConnInfor.PORT);
        }

        public bool Close()
        {
            return true;
        }

        public bool IsOpen()
        {
            return m_WCF.IsConnected();
        }

        public System.Data.DataTable ExecuteQuery(string query, Dictionary<string, string> param = null)
        {
            try
            {
                if (m_bOpen == false)
                {
                    Open(XmlConfig);
                }

                return m_WCF.ExecuteQuery(query, param);
            }
            catch (Exception eLog)
            {
                Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
                return null;
            }
        }

        public int ExecuteNonQuery(string query, Dictionary<string, string> param = null)
        {
            try
            {
                if (m_bOpen == false)
                {
                    Open(XmlConfig);
                }

                return m_WCF.ExecuteNonQuery(query, param);
            }
            catch (Exception eLog)
            {
                Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
                return -1;
            }
        }

        public int BulkInsert(string toTable, ref System.Data.DataTable sendData, bool bAppend = true)
        {
            int nRet = -1;
            try
            {

                return nRet;

            }
            catch (Exception eLog)
            {

                Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
            }

            return nRet;
        }

    }
}
