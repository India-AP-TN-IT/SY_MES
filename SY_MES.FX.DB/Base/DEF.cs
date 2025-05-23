﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;

namespace SY_MES.FX.DB.Base
{
    public enum DBOpenEnum
    {
        XML
            , Args
    }
    public enum DBQueryTypeEnum
    {
        Get
        , Set
    }
    public struct AsyncDBST
    {
        public string query;
        public Dictionary<string, string> param;
        public DataTable dt;
        public DBQueryTypeEnum qt;
        public object sender;
    }
    public struct DBConntionInforST
    {
        public string SVR;
        public string ID;
        public string PWD;
        public string SID;
        public string PORT;

    }
    public struct XMLConfEleNameST
    {
        public string dbKind;
        public string dbServer;
        public string dbID;
        public string dbPWD;
        public string dbSID;
        public string dbPORT;
    }
        
    public enum XMLConfNameEnum
    {
        dbKind, dbServer, dbID, dbPWD, dbSID, dbPORT
    }
    public enum DBKindEnum
    {
        Oracle
        , MSSQL
        , ACCESS
        ,WCF
    }
    public delegate void BackgroundError(object sender, string query, Dictionary<string, string> param, DataTable dt, Exception eLog);
    public delegate void BackgroundRCV(object sender, string query, Dictionary<string, string> param, DataTable dt);
    public delegate void BackgroundPR(object sender, ProgressChangedEventArgs e);

}
