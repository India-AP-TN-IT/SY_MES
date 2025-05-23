﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SY_MES.FX.DB.Base;
using System.ComponentModel;

namespace SY_MES.FX.DB
{
    [ToolboxItem(true)]
    public class AccessHelper : DBComponent, IDBBase
    {
        
        
        private string m_strDB = "";
        private OleDbConnection m_DBConn = null;
        private bool m_IsOpen = false;
        private bool m_AutoCloseMode = false;

        public bool AutoCloseMode
        {
            get { return m_AutoCloseMode; }
            set { m_AutoCloseMode = value; }
        }
        public bool IsOpen
        {
            get { return m_IsOpen; }
            set { m_IsOpen = value; }
        }

         

        public AccessHelper(string strDB)
        {
            m_strDB = strDB;
        }
        public AccessHelper()
        {

        }
        public bool OpenDB()
        {
            try
            {
                m_IsOpen = false;
                if (string.IsNullOrEmpty(m_strDB))
                {
                    Debug.WriteLine("DB Path error!");
                    return false;

                }
                else if (System.IO.File.Exists(m_strDB) == false)
                {
                    Debug.WriteLine("There is no DB File");
                    return false;

                }
                string connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + m_strDB;
                m_DBConn = new OleDbConnection(connStr);
                m_DBConn.Open();
                m_IsOpen = true;
                return true;
            }
            catch
            {
                return false;
            }

        }
        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();

            try
            {
                if (m_IsOpen == false)
                {
                    OpenDB();
                }
                OleDbDataAdapter adp = new OleDbDataAdapter(query, m_DBConn);
                adp.Fill(dt);
                if (AutoCloseMode)
                {
                    CloseDB();
                }
                return dt;
            }
            catch (Exception eLog)
            {
                Debug.WriteLine(eLog.ToString());
                return null;
            }

        }
        public bool ExecuteNonQuery(string query)
        {
            try
            {
                if (m_IsOpen == false)
                {
                    OpenDB();
                }
                OleDbCommand com = new OleDbCommand(query, m_DBConn);
                com.ExecuteNonQuery();
                if (AutoCloseMode)
                {
                    CloseDB();
                }
                return true;
            }
            catch (Exception eLog)
            {
                Debug.WriteLine(eLog.ToString());
                return false;
            }


        }
        public int ExecuteNonQuery(string query, Dictionary<string, object> param)
        {
            return -1;
        }
        public void CloseDB()
        {
            m_IsOpen = false;
            m_DBConn.Close();
        }

        bool IDBBase.Open(DataTable xmlConfig)
        {
            m_strDB = xmlConfig.Rows[0]["DBNAME"].ToString();
            return OpenDB();
        }
        bool IDBBase.Open(string svr, string uid, string pwd, string dbnm, string port)
        {
            m_strDB = svr;
            return OpenDB();
        }
        bool IDBBase.Open(string svr, string uid, string pwd, string dbnm)
        {
            m_strDB = svr;
            return OpenDB();
        }

        bool IDBBase.Close()
        {
            CloseDB();
            return true;
        }

        bool IDBBase.IsOpen()
        {
            return m_IsOpen;
        }

        DataTable IDBBase.ExecuteQuery(string query, Dictionary<string, string> param)
        {
            return ExecuteQuery(query);
        }

        int IDBBase.ExecuteNonQuery(string query, Dictionary<string, string> param)
        {
            try
            {
                ExecuteNonQuery(query);

            }
            catch
            {
                return 0;
            }
            return 1;
        }

        int IDBBase.BulkInsert(string toTable, ref DataTable sendData, bool bAppend)
        {
            throw new NotImplementedException();
        }
        
    }
}
