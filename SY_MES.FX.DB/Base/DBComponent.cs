using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY_MES.FX.DB.Base
{
    [ToolboxItem(false)]
    public partial class DBComponent : Component
    {

        protected bool m_IsAsynBusy = false;
        private XMLConfEleNameST m_XMLConfConnEle =new XMLConfEleNameST();
        protected DBConntionInforST m_DBConnInfor;
        private bool m_IsOciConnect = false;
        private string m_OutRefCurString = "OUT_CURSOR";
        private const string CN_COMMANDTY = "@COMMAND_TYPE";
        private Dictionary<string, string> m_DicEmptyForSP = new Dictionary<string, string>();

        private bool m_IsDBTrace = false;
        private DBOpenEnum m_DBOpenTY = DBOpenEnum.XML;
        private DataTable m_XMLConfig = null;


        public DBConntionInforST DBConnInfor 
        { 
            get { return m_DBConnInfor; }
        }
        public XMLConfEleNameST XMLConfConnEle 
        { 
            get { return m_XMLConfConnEle; }
            set {  m_XMLConfConnEle = value;}
        }

        public DBOpenEnum DBOpenTY
        {
            get
            {
                return m_DBOpenTY;
            }
            set
            {
                m_DBOpenTY = value;
            }
        }
        public bool IsAsynBusy
        {
            get 
            {
                return m_IsAsynBusy;
            }
        }

        public bool IsDBTrace
        {
            get { return m_IsDBTrace; }
            set { m_IsDBTrace = value; }
        }
        public bool IsOciConnect 
        { 
            get { return m_IsOciConnect; }
            set {  m_IsOciConnect = value; }
        }
        public string OutRefCurString 
        {
            get
            {
                return m_OutRefCurString;
            }
            set
            {
                m_OutRefCurString = value;
            }
        }

        public Dictionary<string, string> DicEmptyForSP
        {
            get
            {
                m_DicEmptyForSP.Clear();
                m_DicEmptyForSP.Add(CN_COMMANDTY, "SP");
                return m_DicEmptyForSP;
            }
        }
        protected Dictionary<string, string> GetReservedParam(Dictionary<string, string> param)
        {
            if(param.Count ==1)
            {
                if(param.ContainsKey(CN_COMMANDTY))
                {
                    return new Dictionary<string, string>();
                }
            }
            return param;

        }
        protected Dictionary<string, object> GetReservedParam(Dictionary<string, object> param)
        {
            if (param.Count == 1)
            {
                if (param.ContainsKey(CN_COMMANDTY))
                {
                    return new Dictionary<string, object>();
                }
            }
            return param;

        }
        protected Dictionary<string, ArrayList> GetReservedParam(Dictionary<string, ArrayList> param)
        {
            if (param.Count == 1)
            {
                if (param.ContainsKey(CN_COMMANDTY))
                {
                    return new Dictionary<string, ArrayList>();
                }
            }
            return param;

        }
        public void SetXMLName(string dbKind, string dbServer, string dbID, string dbPWD, string dbSID, string dbPORT)
        {
            m_XMLConfConnEle.dbKind = dbKind;
            m_XMLConfConnEle.dbServer = dbServer;
            m_XMLConfConnEle.dbSID = dbSID;
            m_XMLConfConnEle.dbID = dbID;
            m_XMLConfConnEle.dbPWD = dbPWD; 
            m_XMLConfConnEle.dbPORT = dbPORT;
        }
        [Browsable(false)]
        public DataTable XmlConfig
        {
            get { return m_XMLConfig; }
            set { m_XMLConfig = value; }
        }
        public void SetXMLName(XMLConfNameEnum eleName, string assignName)
        {
            switch (eleName)
            {
                case XMLConfNameEnum.dbServer:
                    m_XMLConfConnEle.dbServer = assignName;
                    break;
                case XMLConfNameEnum.dbKind:
                    m_XMLConfConnEle.dbKind = assignName;
                    break;
                case XMLConfNameEnum.dbID:
                    m_XMLConfConnEle.dbID = assignName;
                    break;
                case XMLConfNameEnum.dbPWD:
                    m_XMLConfConnEle.dbPWD = assignName;
                    break;
                case XMLConfNameEnum.dbSID:
                    m_XMLConfConnEle.dbSID = assignName;
                    break;
                case XMLConfNameEnum.dbPORT:
                    m_XMLConfConnEle.dbPORT = assignName;
                    break;
            }
        }
        protected string GetXMLName(XMLConfNameEnum eleName)
        {
            string ret = "";
            switch(eleName)
            {
                case XMLConfNameEnum.dbServer:
                    ret = m_XMLConfConnEle.dbServer;
                    break;
                case XMLConfNameEnum.dbKind:
                    ret = m_XMLConfConnEle.dbKind;
                    break;
                case XMLConfNameEnum.dbID:
                    ret = m_XMLConfConnEle.dbID;
                    break;
                case XMLConfNameEnum.dbPWD:
                    ret = m_XMLConfConnEle.dbPWD;
                    break;
                case XMLConfNameEnum.dbSID:
                    ret = m_XMLConfConnEle.dbSID;
                    break;
                case XMLConfNameEnum.dbPORT:
                    ret = m_XMLConfConnEle.dbPORT;
                    break;
            }
            return ret;
        }
        public DBComponent()
        {
            InitializeComponent();
        }
        public DBComponent(DataTable xmlConfig)
        {
            InitializeComponent();
            m_XMLConfig = xmlConfig;
        }
        public DBComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
