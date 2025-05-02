using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace SY_MES.DEPLOY.Sub
{
    [ToolboxItem(false)]
    public partial class SystemConfigDlg : FX.MainForm.BaseContainer
    {
        private const string CN_ASYNC_LOAD_QUERY = "PKG_COM.GET_SETTING_INI";
        private const string CN_DEPLOY_FILE =@".\SY_MES.DEPLOY.EXE";
        private const string CN_LOGIC_FILE = @".\SY_MES.Logics.DLL";

        public SystemConfigDlg()
        {
            InitializeComponent();
        }
        protected override void InitControls()
        {
            base.InitControls();
            lbl_BIZCD.Text = "";
            lbl_CLASS.Text = "";
            lbl_CORCD.Text = "";
            lbl_IP.Text = "";
            lbl_LINE.Text = "";
            lbl_POS.Text = "";
            lbl_STATIONCD.Text = "";
            lbl_DBU.Text = "";
            lbl_DBType.Text = "";
            lbl_SID.Text = "";
            lbl_LUPDATE.Text = "";
            lbl_LUPDATE_LOC.Text = "";
            lbl_STARTDATE.Text = "";
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode == false)
            {
                LoadBaseInfor();
                LoadINIData();
                LoadLogData();
            }
        }


        private string GetUpdateDate(string path)
        {
            if (File.Exists(path))
            {
                FileInfo infor = new FileInfo(path);
                return infor.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            return "";
        }
        private void LoadINIData()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", PBaseFrm.GetXMLConfig("CORCD"));
            param.Add("IN_BIZCD", PBaseFrm.GetXMLConfig("BIZCD"));
            param.Add("IN_IPADDR", PBaseFrm.GetCurrentIP());
            param.Add("IN_SCREEN", PBaseFrm.RunBC);
            AsyncExecueteQuery(this, CN_ASYNC_LOAD_QUERY, param, PBaseFrm.Config_CTL);
            
            
        }

        public override void ReadAsyncDBData(object sender, string query, Dictionary<string, string> param, DataTable dt)
        {
            if (PBaseFrm != null)
            {
                PBaseFrm.Invoke(new MethodInvoker(
                delegate()
                {
                    if (query.Contains(CN_ASYNC_LOAD_QUERY))
                    {
                        yDataGridView1.SetValue(dt);
                    }

                }));
            }
        }
        private void LoadBaseInfor()
        {
            lbl_BIZCD.Text = PBaseFrm.GetXMLConfig("BIZCD");
            lbl_CORCD.Text = PBaseFrm.GetXMLConfig("CORCD");
            lbl_CLASS.Text = PBaseFrm.RunBC;
            lbl_IP.Text = PBaseFrm.GetCurrentIP();
            lbl_DBType.Text = PBaseFrm.GetXMLConfig("DB_CONNECTION");
            lbl_DBU.Text = PBaseFrm.GetXMLConfig("DBUID");
            lbl_SID.Text = PBaseFrm.GetXMLConfig("DBSVR")+"@"+ PBaseFrm.GetXMLConfig("DBSERVICE");
            lbl_STATIONCD.Text = PBaseFrm.GetINI("STATION_INFOR/STATIONCD");
            lbl_LINE.Text = PBaseFrm.GetINI("STATION_INFOR/LINECD");
            lbl_POS.Text = PBaseFrm.GetINI("STATION_INFOR/INSTALL_POS");
            lbl_STARTDATE.Text = PBaseFrm.ExcutePGMStart.ToString("yyyy-MM-dd HH:mm:ss");
            lbl_LUPDATE.Text = GetUpdateDate(CN_DEPLOY_FILE);
            lbl_LUPDATE_LOC.Text = GetUpdateDate(CN_LOGIC_FILE);
            
        }
        public void LoadLogData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("LOG_DATE", typeof(string));
            dt.Columns.Add("LOG_MSG", typeof(string));
            dt.Columns.Add("LOG_TY", typeof(string));
            dt.Columns.Add("LOG_METHOD", typeof(string));
            
            int cnt = PBaseFrm.StatusLogData.Count;
            
            for (int i=0;i< cnt; i++)
            {
                SY_MES.FX.MainForm.Base.Common.StatusLogST log = PBaseFrm.StatusLogData[cnt - i - 1];
                DataRow dr = dt.NewRow();
                dr["LOG_DATE"] = log.LogDate.ToString("yyyy-MM-dd HH:mm:ss");
                dr["LOG_MSG"] = log.Message;
                dr["LOG_TY"] = log.MsgType;
                dr["LOG_METHOD"] = log.Method;
                dt.Rows.Add(dr);
            }
            GrdLog.SetValue(dt);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            yDataGridView1.ReadOnly = !checkBox1.Checked;
        }

        private void yDataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string bindNM = yDataGridView1.GetColBindNM(e.ColumnIndex);
            switch(bindNM)
            {
                case "INI_KEYVALUE":
                    e.Cancel = false;
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Dictionary<string, string> param = new Dictionary<string, string>();
                for (int i = 0; i < yDataGridView1.Rows.Count; i++)
                {

                    string sec_id = yDataGridView1.GetValue(i, "SECTION_ID");
                    string iniKey = yDataGridView1.GetValue(i, "INI_KEY");
                    string iniKeyVal = yDataGridView1.GetValue(i, "INI_KEYVALUE");
                    param = new Dictionary<string, string>();
                    param.Add("IN_CORCD", CORCD);
                    param.Add("IN_BIZCD", BIZCD);
                    param.Add("IN_IPADDR", GetCurrentIP());
                    param.Add("IN_SCREEN", RunBC);
                    param.Add("IN_SECTION_ID", sec_id);
                    param.Add("IN_INI_KEY", iniKey);
                    param.Add("IN_INI_KEYVALUE", iniKeyVal);
                    ExecuteNonQuery("PKG_COM.SET_SETTING_INI", param);
                }
                PBaseFrm.FrmMsgBox(FX.MainForm.Base.Common.MsgTypeEnum.Warnning, "MES Program has to be restarted After INI Saving!!", "INI Data Save", FX.MainForm.Base.MsgBox.MsgBtnEnum.OK, false);
                this.ParentForm.Close();
                
                
            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + "[PKG_COM.SET_SETTING_INI]" + eLog.Message);
            }
        }
        private void ReadScan(string barcode)
        {
            if(string.IsNullOrEmpty(barcode) == false)
            {
                PBaseFrm.ChildBC.ReadDataFromScanner(null, barcode);
            }
            txtScan.Text = "";
        }
        private void yTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ReadScan(txtScan.Text);
            }
        }

        private void BtnScan_Click(object sender, EventArgs e)
        {
            ReadScan(txtScan.Text);
        }
    }
}
