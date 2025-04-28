using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using SY_MES.FX.DB.Base;
using System.IO;
using System.Web.Services.Description;

namespace SY_MES.FX.DB
{
    [ToolboxItem(true)]
    public class MSSqlHelper : DBComponent, IDBBase
    {
 


        public int ExecuteNonQuery(string query, Dictionary<string, object> param)
        {
            return -1;
        }
        
        public bool Close()
        {
            try
            {
                m_Conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        private System.Data.SqlClient.SqlConnection m_Conn = null;
        public bool Open(string svr, string uid, string pwd, string dbnm)
        {
            return Open(svr, uid, pwd, dbnm, "1433");
        }
        public bool Open(string svr, string uid, string pwd, string dbnm, string port)
        {
            try
            {
                m_DBConnInfor.SVR = svr;
                m_DBConnInfor.ID = uid;
                m_DBConnInfor.PWD = pwd;
                m_DBConnInfor.SID = dbnm;
                m_DBConnInfor.PORT = port;
                m_Conn = new SqlConnection(string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", svr, dbnm, uid, pwd));
                m_Conn.Open();

                return true;

            }
            catch
            {
                return false;

            }
        }
        public bool Open(DataTable xmlConfig)
        {
            try
            {

                if (xmlConfig.Rows.Count > 0)
                {
                    if (xmlConfig.Rows.Count > 0)
                    {

                        m_DBConnInfor.SVR = xmlConfig.Columns.Contains("DBNAME") ? xmlConfig.Rows[0]["DBNAME"].ToString() : "";
                        m_DBConnInfor.ID = xmlConfig.Columns.Contains("DBUID") ? xmlConfig.Rows[0]["DBUID"].ToString() : "";
                        m_DBConnInfor.PWD = xmlConfig.Columns.Contains("DBPWD") ? xmlConfig.Rows[0]["DBPWD"].ToString() : "";
                        m_DBConnInfor.SID = xmlConfig.Columns.Contains("DBSERVICE") ? xmlConfig.Rows[0]["DBSERVICE"].ToString() : "";


                        m_Conn = new SqlConnection(string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}"
                            , m_DBConnInfor.SVR, m_DBConnInfor.SID, m_DBConnInfor.ID, m_DBConnInfor.PWD));
                        m_Conn.Open();

                        return true;
                    }
                }
              
                return false;
            }
            catch
            {
                return false;

            }
        }

        public DataTable ExecuteQuery(string query, Dictionary<string, string> param = null)
        {

            try
            {
                if (m_Conn == null || m_Conn.State != ConnectionState.Open)
                {
                    if (!Open(XmlConfig))
                    {
                        throw new Exception("DB is closed.");
                    }
                }
                DateTime now = DateTime.Now;
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Connection = m_Conn;
                if (param!=null)
                {
                    param = GetReservedParam(param);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (KeyValuePair<string, string> pair in param)
                    {
                        SqlParameter sqlParam = new SqlParameter(pair.Key, pair.Value);
                        cmd.Parameters.Add(sqlParam);
                    }
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                TimeSpan span = DateTime.Now - now;
                if (IsDBTrace)
                {
                    int cnt = 0;
                    if (dt != null)
                    {
                        cnt = dt.Rows.Count;
                    }
                    Util.WriteTxtLog(query + ":Delay[" + span.TotalMilliseconds.ToString() + "]" + ":Count[" + cnt.ToString() + "]");
                }
                return dt;

            }
            catch (Exception eLog)
            {
                throw new Exception(eLog.Message);
            }
        }

        public int ExecuteNonQuery(string query, Dictionary<string, string> param = null)
        {
            SqlTransaction tran = null;
            try
            {
                DateTime now = DateTime.Now;
                if (m_Conn == null || m_Conn.State != ConnectionState.Open)
                {
                    if (!Open(XmlConfig))
                    {
                        throw new Exception("DB is closed.");
                    }
                }
                tran = m_Conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Connection = m_Conn;
                cmd.Transaction = tran;
                if (param != null)
                {
                    param = GetReservedParam(param);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (KeyValuePair<string, string> pair in param)
                    {
                        SqlParameter sqlParam = new SqlParameter(pair.Key, pair.Value);
                        cmd.Parameters.Add(sqlParam);
                    }
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                }
                int nRet = cmd.ExecuteNonQuery();

                tran.Commit();

                TimeSpan span = DateTime.Now - now;
                if (IsDBTrace)
                {
                    Util.WriteTxtLog(query + ":Delay[" + span.TotalMilliseconds.ToString() + "]" + ":Count[" + nRet.ToString() + "]");
                }
                return nRet;

            }
            catch (Exception eLog)
            {
                tran.Rollback();
                throw new Exception(eLog.Message);
            }
        }


        public bool IsOpen()
        {
            if (m_Conn.State == ConnectionState.Closed)
            {
                return false;
            }
            return true;
        }

        public int BulkInsert(string toTable, ref DataTable sendData, bool bAppend = true)
        {
            SqlTransaction tran = null;
            int nRet = 0;
            try
            {
                if (m_Conn == null || m_Conn.State != ConnectionState.Open)
                {
                    if (!Open(XmlConfig))
                    {
                        throw new Exception("DB is closed.");
                    }
                }
                tran = m_Conn.BeginTransaction();
                SqlBulkCopy bulk = new SqlBulkCopy(m_Conn, SqlBulkCopyOptions.Default, tran);
                bulk.DestinationTableName = toTable;

                bulk.WriteToServer(sendData);
                nRet = sendData.Rows.Count;
                tran.Commit();
            }
            catch (Exception eLog)
            {
                tran.Rollback();
                nRet = -1;
                throw new Exception(eLog.Message);

            }
            return nRet;
        }


    }
}
