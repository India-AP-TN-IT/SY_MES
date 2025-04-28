using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using SY_MES.FX.DB.Base;
using System.Threading;

namespace SY_MES.FX.DB
{
    [ToolboxItem(true)]
    public class OracleHelper : DBComponent, IDBBase
    {
        private System.Timers.Timer m_KeepAliveTimer;
        private int m_KeepAliveTimeSpanSec = 180;
        private bool m_KeepAlive = true;
        private DateTime m_KeepAliveDT;
        private bool m_UseTransaction = false;
        public bool UseTransaction
        {
            get { return m_UseTransaction; }
            set { m_UseTransaction = value; }
        }
        public bool KeepAlive
        {
            get { return m_KeepAlive; }
            set { m_KeepAlive = value; }
        }
        private void CommonForOpen()
        {
            if(m_KeepAliveTimer == null)
            {
                m_KeepAliveTimer = new System.Timers.Timer(5000);
                m_KeepAliveDT = DateTime.Now;
                m_KeepAliveTimer.Start();
                m_KeepAliveTimer.Elapsed += KeepAliveTimer;
            }
            
        }

        private void KeepAliveTimer(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                m_KeepAliveTimer.Stop();
                if((DateTime.Now- m_KeepAliveDT).TotalSeconds > m_KeepAliveTimeSpanSec) 
                {
                    ExecuteQuery("SELECT 'ALIVE' RSLT FROM DUAL");
                    m_KeepAliveDT = DateTime.Now;
                }
            }
            catch(Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
                
            }
            finally
            {
                m_KeepAliveTimer.Start();
            }
        }

        
        private Oracle.ManagedDataAccess.Client.OracleConnection m_Conn = null;
        public bool Open(string svr, string uid, string pwd, string dbnm)
        {
            return Open(svr, uid, pwd, dbnm, "1521");
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
                string[] spDBName = svr.Split('.');
                if (spDBName.Length < 3)
                {
                    m_Conn = new OracleConnection(string.Format("Data Source={0};Persist Security Info=False;User ID={1};Password={2}", svr, uid, pwd));
                    IsOciConnect = true;
                }
                else
                {
                    string[] svrs = svr.Split(';');
                    if (svrs.Length > 1)
                    {
                        m_Conn = new OracleConnection(
                                        string.Format(
                                             @"Data Source=
                                        ( DESCRIPTION = 
                                            (FAILOVER = YES)
                                            ( ADDRESS_LIST = 
                                                ( ADDRESS =
                                                    ( PROTOCOL = TCP )
                                                    ( HOST = {0} )
                                                    ( PORT = {5} ) ) 
                                                ( ADDRESS =
                                                    ( PROTOCOL = TCP )
                                                    ( HOST = {1} )
                                                    ( PORT = {5} ) ) )
                                                ( CONNECT_DATA = 
                                                    ( SERVER = DEDICATED )
                                                    ( SERVICE_NAME = {2} ) ) )
                                        ; User Id= {3}; Password = {4};Min Pool Size=0;enlist=false;pooling=false;", svrs[0], svrs[1], dbnm, uid, pwd, port)
                                                                          );
                    }
                    else
                    {
                        m_Conn = new OracleConnection(
                                        string.Format(
                                            @"Data Source=
                                        ( DESCRIPTION = 
                                            ( ADDRESS_LIST = 
                                                ( ADDRESS =
                                                    ( PROTOCOL = TCP )
                                                    ( HOST = {0} )
                                                    ( PORT = {4} ) ) )
                                                ( CONNECT_DATA = 
                                                    ( SERVER = DEDICATED )
                                                    ( SERVICE_NAME = {1} ) ) )
                                        ; User Id= {2}; Password = {3};Min Pool Size=0;enlist=false;pooling=false;", svr, dbnm, uid, pwd, port)
                                                                            );

                    }
                    IsOciConnect = false;

                }
                m_Conn.Open();
                CommonForOpen();
                return true;

            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
                return false;

            }
        }
        public bool Open(DataTable xmlConfig)
        {
            try
            {

                
                if (xmlConfig !=null && xmlConfig.Rows.Count > 0)
                {
                    m_DBConnInfor.SVR = xmlConfig.Columns.Contains(GetXMLName(XMLConfNameEnum.dbServer)) ? xmlConfig.Rows[0][GetXMLName(XMLConfNameEnum.dbServer)].ToString() : "";
                    m_DBConnInfor.ID = xmlConfig.Columns.Contains(GetXMLName(XMLConfNameEnum.dbID)) ? xmlConfig.Rows[0][GetXMLName(XMLConfNameEnum.dbID)].ToString() : "";
                    m_DBConnInfor.PWD = xmlConfig.Columns.Contains(GetXMLName(XMLConfNameEnum.dbPWD)) ? xmlConfig.Rows[0][GetXMLName(XMLConfNameEnum.dbPWD)].ToString() : "";
                    m_DBConnInfor.SID = xmlConfig.Columns.Contains(GetXMLName(XMLConfNameEnum.dbSID)) ? xmlConfig.Rows[0][GetXMLName(XMLConfNameEnum.dbSID)].ToString() : "";
                    m_DBConnInfor.PORT = xmlConfig.Columns.Contains(GetXMLName(XMLConfNameEnum.dbPORT)) ? xmlConfig.Rows[0][GetXMLName(XMLConfNameEnum.dbPORT)].ToString() : "1521";
                    string[] spDBName = m_DBConnInfor.SVR.Split('.');
                    if (spDBName.Length < 3)
                    {
                        m_Conn = new OracleConnection(string.Format("Data Source={0};Persist Security Info=False;User ID={1};Password={2}"
                                , m_DBConnInfor.SVR, m_DBConnInfor.ID, m_DBConnInfor.PWD));
                        IsOciConnect = true;
                    }
                    else
                    {

                        string[] svrs = m_DBConnInfor.SVR.Split(';');
                        if (svrs.Length > 1)
                        {
                            m_Conn = new OracleConnection(
                                            string.Format(
                                                    @"Data Source=
                                ( DESCRIPTION = 
                                    (FAILOVER = YES)
                                    ( ADDRESS_LIST = 
                                        ( ADDRESS =
                                            ( PROTOCOL = TCP )
                                            ( HOST = {0} )
                                            ( PORT = {5} ) ) 
                                        ( ADDRESS =
                                            ( PROTOCOL = TCP )
                                            ( HOST = {1} )
                                            ( PORT = {5} ) ) )
                                        ( CONNECT_DATA = 
                                            ( SERVER = DEDICATED )
                                            ( SERVICE_NAME = {2} ) ) )
                                ; User Id= {3}; Password = {4};Min Pool Size=0;enlist=false;pooling=false;", svrs[0], svrs[1], m_DBConnInfor.SID, m_DBConnInfor.ID, m_DBConnInfor.PWD, m_DBConnInfor.PORT)
                                                                                );
                        }
                        else
                        {
                            m_Conn = new OracleConnection(
                                            string.Format(
                                                @"Data Source=
                                ( DESCRIPTION = 
                                    ( ADDRESS_LIST = 
                                        ( ADDRESS =
                                            ( PROTOCOL = TCP )
                                            ( HOST = {0} )
                                            ( PORT = {4} ) ) )
                                        ( CONNECT_DATA = 
                                            ( SERVER = DEDICATED )
                                            ( SERVICE_NAME = {1} ) ) )
                                ; User Id= {2}; Password = {3};Min Pool Size=0;enlist=false;pooling=false;", m_DBConnInfor.SVR, m_DBConnInfor.SID, m_DBConnInfor.ID, m_DBConnInfor.PWD, m_DBConnInfor.PORT)
                                                                                );

                        }
                        IsOciConnect = false;

                    }


                    m_Conn.Open();
                    CommonForOpen();
                    return true;
                }
                return false;
            }
            catch (Exception eLog)
            {
                throw new Exception("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);


            }
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
        public DataTable ExecuteQuery(string query, Dictionary<string, string> param = null)
        {

            try
            {
                
                if (m_Conn == null || m_Conn.State != ConnectionState.Open)
                {
                    if (!Open(XmlConfig))
                    {
                        System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + "DB is Closed.");
                        return new DataTable();
                    }
                }
                
                DateTime now = DateTime.Now;
                DataTable dt = new DataTable();
                Oracle.ManagedDataAccess.Client.OracleCommand cmd = new OracleCommand();
                cmd.CommandText = query;
                cmd.Connection = m_Conn;
                if (param !=null)
                {
                    
                    param = GetReservedParam(param);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (param != null)
                    {
                        foreach (KeyValuePair<string, string> pair in param)
                        {
                            OracleParameter sqlParam = new OracleParameter(pair.Key, pair.Value);
                            cmd.Parameters.Add(sqlParam);
                        }
                    }
                    OracleParameter outParam = new OracleParameter(OutRefCurString, Oracle.ManagedDataAccess.Client.OracleDbType.RefCursor, 0, ParameterDirection.Output);
                    cmd.Parameters.Add(outParam);
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                }

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                
                if (IsOpen())
                {
                    da.Fill(dt);
                }
                else
                {
                    throw new Exception("DB Connection Error!!");
                }
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
                m_KeepAliveDT = DateTime.Now;
                return dt;

            }
            catch (Exception eLog)
            {
                if (eLog.Message.Contains("ORA-03114") || eLog.Message.Contains("ORA-03113") || eLog.Message.Contains("ORA-12532")
                    || eLog.Message.Contains("ORA-12571") || eLog.Message.Contains("ORA-04063") || eLog.Message.Contains("ORA-04068")
                    || eLog.Message.Contains("ORA-03135") || eLog.Message.Contains("ORA-01092")
                    )
                {
                    try
                    {
                        Debug.WriteLine(eLog.Message.ToString());
                        m_Conn.Close();
                    }
                    catch
                    { }
                    return new DataTable();
                }
                else
                {
                     throw new Exception(eLog.Message);
                }

            }

        }
        public int ExecuteNonQueryList(string query, Dictionary<string, ArrayList> param)
        {
            OracleTransaction tran = null;
            try
            {
                if (m_Conn == null || m_Conn.State != ConnectionState.Open)
                {
                    if (!Open(XmlConfig))
                    {
                        System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + "DB is Closed.");
                        return -1;
                    }
                }
                DateTime now = DateTime.Now;
                if (UseTransaction)
                {
                    tran = m_Conn.BeginTransaction(IsolationLevel.ReadCommitted);
                }
                OracleCommand cmd = new OracleCommand();

                cmd.Connection = m_Conn;
                if (UseTransaction)
                {
                    cmd.Transaction = tran;
                }
                cmd.CommandText = query;
                cmd.BindByName = true;
                int idx = 0;
                if (param != null)
                {
                    param = GetReservedParam(param);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (KeyValuePair<string, ArrayList> pair in param)
                    {
                        if (idx == 0)
                        {
                            cmd.ArrayBindCount = pair.Value.Count;
                        }
                        OracleParameter sqlParam = new OracleParameter();
                        sqlParam.ParameterName = pair.Key;

                        sqlParam.OracleDbType = OracleDbType.Varchar2;
                        sqlParam.Value = pair.Value.ToArray();
                        sqlParam.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(sqlParam);
                        idx++;
                    }
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                    foreach (KeyValuePair<string, ArrayList> pair in param)
                    {
                        if (idx == 0)
                        {
                            cmd.ArrayBindCount = pair.Value.Count;
                        }
                        OracleParameter sqlParam = new OracleParameter();
                        sqlParam.ParameterName = pair.Key;

                        sqlParam.OracleDbType = OracleDbType.Varchar2;
                        sqlParam.Value = pair.Value.ToArray();
                        sqlParam.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(sqlParam);
                        idx++;
                    }
                }
                int nRet = cmd.ExecuteNonQuery();
                if (tran != null)
                {
                    tran.Commit();
                }
                m_KeepAliveDT = DateTime.Now;
                
                TimeSpan span = DateTime.Now - now;
                if (IsDBTrace)
                {
                    Util.WriteTxtLog(query + ":Delay[" + span.TotalMilliseconds.ToString() + "]" + ":Count[" + nRet.ToString() + "]");
                }
                return nRet;

            }
            catch (Exception eLog)
            {
                if (tran != null)
                {
                    try
                    {
                        tran.Rollback();
                    }
                    catch
                    { }
                }
                if (eLog.Message.Contains("ORA-03114") || eLog.Message.Contains("ORA-03113") || eLog.Message.Contains("ORA-12532")
                    || eLog.Message.Contains("ORA-12571") || eLog.Message.Contains("ORA-04063") || eLog.Message.Contains("ORA-04068")
                    || eLog.Message.Contains("ORA-03135") || eLog.Message.Contains("ORA-01092"))
                {
                    try
                    {
                        m_Conn.Close();
                    }
                    catch
                    { }
                    return -1;
                }
                else
                {
                    throw new Exception(eLog.Message);
                }
            }
            finally
            {
                if (tran != null)
                {
                    tran.Dispose();
                }
            }
        }
        public int ExecuteNonQuery(string query, Dictionary<string, object> param)
        {
            OracleTransaction tran = null;
            try
            {
                if (m_Conn == null || m_Conn.State != ConnectionState.Open)
                {
                    if (!Open(XmlConfig))
                    {
                        System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + "DB is Closed.");
                        return -1;
                    }
                }
                DateTime now = DateTime.Now;
                if (UseTransaction)
                {
                    tran = m_Conn.BeginTransaction(IsolationLevel.ReadCommitted);
                }
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = query;
                cmd.Connection = m_Conn;
                if (UseTransaction)
                {
                    cmd.Transaction = tran;
                }
                if (param != null)
                {
                    param = GetReservedParam(param);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (KeyValuePair<string, object> pair in param)
                    {
                        object objVal = pair.Value;
                        if (pair.Key.Contains("$") && pair.Value != null)
                        {
                            if (pair.Value is byte[])
                            {
                                Oracle.ManagedDataAccess.Types.OracleBlob blob = new Oracle.ManagedDataAccess.Types.OracleBlob(m_Conn);
                                blob.Erase();
                                blob.Write((byte[])pair.Value, 0, ((byte[])pair.Value).Length);
                                objVal = blob;
                            }
                        }

                        OracleParameter sqlParam = new OracleParameter(pair.Key, objVal);
                        if (pair.Key.Contains("$"))
                        {
                            sqlParam.OracleDbType = OracleDbType.Blob;
                        }
                        cmd.Parameters.Add(sqlParam);
                    }
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                }
                int nRet = cmd.ExecuteNonQuery();
                if(tran!=null)
                {
                    tran.Commit();
                }
                
                m_KeepAliveDT = DateTime.Now;
                TimeSpan span = DateTime.Now - now;
                if (IsDBTrace)
                {
                    Util.WriteTxtLog(query + ":Delay[" + span.TotalMilliseconds.ToString() + "]" + ":Count[" + nRet.ToString() + "]");
                }
                return nRet;

            }
            catch (Exception eLog)
            {

                if (tran != null)
                {
                    try
                    {
                        tran.Rollback();
                    }
                    catch
                    { }
                }
                if (eLog.Message.Contains("ORA-03114") || eLog.Message.Contains("ORA-03113") || eLog.Message.Contains("ORA-12532")
                    || eLog.Message.Contains("ORA-12571") || eLog.Message.Contains("ORA-04063") || eLog.Message.Contains("ORA-04068")
                    || eLog.Message.Contains("ORA-03135") || eLog.Message.Contains("ORA-01092"))
                {
                    try
                    {
                        m_Conn.Close();
                    }
                    catch
                    { }
                    return -1;
                }
                else
                {
                    throw new Exception(eLog.Message);
                }
            }
            finally
            {
                if (tran != null)
                {
                    tran.Dispose();
                }
            }
        }
        public int ExecuteNonQuery(string query, Dictionary<string, string> param = null)
        {
            Dictionary<string, object> dicRet = null;

            if (param != null)
            {
                dicRet = new Dictionary<string, object>();
                foreach (KeyValuePair<string, string> pa in param)
                {
                    dicRet.Add(pa.Key, (object)pa.Value);
                }
            }
            int rslt = ExecuteNonQuery(query, dicRet);
            
            m_KeepAliveDT = DateTime.Now;
            return rslt;
        }
        
        private bool ConnectTest(string ip, int port, int millisecondsTimeout)
        {
            bool result = false;
            System.Net.Sockets.Socket socket = null;

            try
            {
                ip = Base.Util.GetRealIP(ip);
                socket = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);
                socket.SetSocketOption(System.Net.Sockets.SocketOptionLevel.Socket, System.Net.Sockets.SocketOptionName.DontLinger, false);
                IAsyncResult ret = socket.BeginConnect((new System.Net.IPEndPoint(System.Net.IPAddress.Parse(ip), port)), null, null);

                result = ret.AsyncWaitHandle.WaitOne(millisecondsTimeout, false);
            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine(eLog.Message);
            }
            finally
            {
                if (socket != null)
                {
                    socket.Close();
                }
            }
            return result;
        }
        public bool IsOpen()
        {
            if (ConnectTest(m_DBConnInfor.SVR, Convert.ToInt32(m_DBConnInfor.PORT), 500) == false)
            {
                return false;
            }
            return true;
            /*
            if (m_Conn!=null && m_Conn.State== ConnectionState.Open)
            {
                return true;
            }
            return false;
             */
        }


        public int BulkInsert(string toTable, ref DataTable sendData, bool bAppend = true)
        {

            int nRet = -1;
            try
            {

                Dictionary<string, ArrayList> param = new Dictionary<string, ArrayList>();
                string cols = "";
                string vals = "";
                for (int row = 0; row < sendData.Rows.Count; row++)
                {
                    for (int col = 0; col < sendData.Columns.Count; col++)
                    {
                        if (row == 0)
                        {
                            if (col == 0)
                            {
                                cols += sendData.Columns[col].ColumnName;
                                vals += ":" + sendData.Columns[col].ColumnName;
                            }
                            else
                            {
                                cols += "," + sendData.Columns[col].ColumnName;
                                vals += ",:" + sendData.Columns[col].ColumnName;
                            }
                        }
                        string key = ":" + sendData.Columns[col].ColumnName;

                        if (param.ContainsKey(key) == false)
                        {
                            ArrayList arr = new ArrayList();
                            arr.Add(sendData.Rows[row][col]);
                            param.Add(key, arr);
                        }
                        else
                        {
                            param[key].Add(sendData.Rows[row][col]);
                        }
                    }
                }

                string query = "";
                query = string.Format("insert into {0}({1}) values({2})", toTable, cols, vals);
                ExecuteNonQueryList(query, param);
                m_KeepAliveDT = DateTime.Now;
            }
            catch (Exception eLog)
            {

                Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
            }

            return nRet;
        }
    }
}
