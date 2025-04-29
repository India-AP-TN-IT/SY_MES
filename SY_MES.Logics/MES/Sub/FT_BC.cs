using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SY_MES.FX.PLC;
using System.Diagnostics;
using SY_MES.FX.Controls.Base;

namespace SY_MES.Logics.MES.Sub
{
    [ToolboxItem(true)]
    public partial class FT_BC : Base.LocalizedContainer
    {
        public delegate void ProcResult(object sender, bool result);
        [Category(Base.Common.CN_CATEGORY_APP)]
        public event ProcResult OnProcResult;


        private System.Windows.Forms.Timer m_ETTimer;
      
        public struct FTHeaderST
        {
            public string lotno;
            public string status;
            public string lseq;
            public bool allRSLT;
        }
        private FTHeaderST m_FTHeader;
        public FT_BC()
        {
            InitializeComponent();
        }
        protected override void InitControls()
        {
            base.InitControls();
            lblETCD.Text = "";
            lblStatus.Text = "";
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode == false)
            {
                SetETPLC();
                m_FTHeader = new FTHeaderST();
                m_ETTimer.Stop();
            }

        }
        private void DispStatus(FTHeaderST ftHeader)
        {
            switch(ftHeader.status)
            {
                case "W":
                    lblStatus.BackColor = Color.Red;
                    lblStatus.ForeColor = Color.White;
                    lblStatus.Text = "WAIT FOR MC(" + ftHeader.lseq + ")";
                    break;
                case "C":
                    lblStatus.BackColor = Color.Lime;
                    lblStatus.ForeColor = Color.Black;
                    lblStatus.Text = "COMPLETE";
                    break;
                default:
                    lblStatus.BackColor = Color.Yellow;
                    lblStatus.ForeColor = Color.Black;
                    lblStatus.Text = "RUNNING(" + ftHeader.lseq + ")";
                    break;
                
            }
        }
        private void StartET()
        {
            if (m_ETTimer.Enabled == false)
            {
                DispETGrid();
            }
            m_ETTimer.Start();
        }
        private void SetETPLC()
        {
            if (GetINI("ET_INFOR/ET_TYPE").ToUpper().Contains("PLC"))
            {
                simplePlcUI1.Visible = true;
                simplePlcUI1.Title = "ET PLC";
                Dictionary<string, string> plcParam = GetPlcInforFromINI("ET_INFOR");
                simplePlcUI1.Start(plcParam);
            }
            else
            {
                simplePlcUI1.Visible = false;
            }
            if(m_ETTimer==null)
            {
                m_ETTimer = new System.Windows.Forms.Timer();
                m_ETTimer.Interval = 300;
                m_ETTimer.Tick += ETTimer_Elapsed;
            }
        }

        private void DispETGrid()
        {
            DispStatus(m_FTHeader);
            DataTable dtList = GetETList(m_FTHeader);
            ETGrid.SetValue(dtList);
            ETGrid.ShowLastRow();
            
            
        }
        private void ETTimer_Elapsed(object sender, EventArgs e)
        {
            try
            {
                m_ETTimer.Stop();
                lblLoad.SetValue(true);
                m_FTHeader = GetETStatus(m_FTHeader.lotno, m_FTHeader.status, m_FTHeader.lseq, false);
                DispETGrid();
                if (m_FTHeader.status == "C")
                {
                    if (OnProcResult != null)
                    {
                        OnProcResult(this, m_FTHeader.allRSLT);
                    }
                }
            }
            catch(Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);

            }
            finally
            {
                if(m_FTHeader.status !="C")
                {
                    m_ETTimer.Start();
                }
                else
                {
                    m_ETTimer.Stop();
                }
                lblLoad.SetValue(false);
            }
        }
        private void  SetLotInforToMCData(DataRow drProd, string etcode)
        {
            try
            {
                if (drProd != null)
                {
                    Dictionary<string, string> param = new Dictionary<string, string>();
                    param.Add("IN_CORCD", BaseINF.CORCD);
                    param.Add("IN_BIZCD", BaseINF.BIZCD);
                    param.Add("IN_LOTNO", drProd["LOTNO"].ToString());
                    param.Add("IN_LINECD", BaseINF.LINECD);
                    param.Add("IN_PROCCD", BaseINF.STATIONCD);
                    param.Add("IN_INSTALL_POS", BaseINF.INSTALL_POS);
                    param.Add("IN_SPEC01", drProd["INSTALL_POS"].ToString());
                    param.Add("IN_SPEC02", "");
                    param.Add("IN_SPEC03", "");
                    param.Add("IN_SPEC04", "");
                    param.Add("IN_SPEC05", etcode);  //ET CODE
                    param.Add("IN_SPEC06", "");
                    param.Add("IN_SPEC07", "");
                    param.Add("IN_SPEC08", "");
                    param.Add("IN_SPEC09", "");
                    param.Add("IN_SPEC10", "");

                    ExecuteNonQuery("PKG_ME_MC_API.SET_LOT", param);

                }
            }
            catch(Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
            }
        }
        public override void LoadData()
        {
            base.LoadData();
            
            string lotno = Base.Common.GetProductInfor("LOTNO");

            DataTable etDT = GetETInfor(lotno);
            m_FTHeader = GetETStatus(lotno, "N", "0", true);
            if (etDT.Rows.Count > 0)
            {
                string code = etDT.Rows[0]["ET_CODE"].ToString();
                SetLotInforToMCData(Base.Common.ProductInfor, code);
                lblETCD.SetValue(code);
                if (code != "X")
                {
                    StartET();
                }
                else
                {
                    SetMES2010(lotno, "Y"); //Force OK-ET because of no ET Code;
                    if (OnProcResult != null)
                    {
                        OnProcResult(this, true);
                    }
                }

            }
            
            
        }
        private void SetMES2010(string lotno, string chket)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", BaseINF.CORCD);
            param.Add("IN_BIZCD", BaseINF.BIZCD);
            param.Add("IN_LOTNO", lotno);
            param.Add("IN_CHK_ELEC", chket);

            ExecuteNonQuery("PKG_ME_ET_TEST.SET_MES2010_CHK_ELEC", param);

        }

        private DataTable GetETList(FTHeaderST ftHeader)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", BaseINF.CORCD);
            param.Add("IN_BIZCD", BaseINF.BIZCD);
            param.Add("IN_LOTNO", ftHeader.lotno);
            param.Add("IN_LINECD", BaseINF.LINECD);
            param.Add("IN_PROCCD", BaseINF.STATIONCD);
            param.Add("IN_LSEQ", ftHeader.lseq);
            DataTable dt = ExecuteQuery("PKG_ME_ET_TEST.GET_ET_LIST", param);
            return dt;
        }
        private FTHeaderST GetETStatus(string lotno, string prvStatus = "",string prvLSEQ="0", bool scanTime = false)
        {
            FTHeaderST rslt = new FTHeaderST();
            if (scanTime)
            {
                prvStatus = "N";
            }
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", BaseINF.CORCD);
            param.Add("IN_BIZCD", BaseINF.BIZCD);
            param.Add("IN_LOTNO", lotno);
            param.Add("IN_LINECD", BaseINF.LINECD);
            param.Add("IN_PROCCD", BaseINF.STATIONCD);
            param.Add("IN_PRV_STATUS", prvStatus);
            param.Add("IN_LSEQ", prvLSEQ);
            DataTable dt = ExecuteQuery("PKG_ME_ET_TEST.GET_ET_STATUS", param);
            if(dt.Rows.Count>0)
            {
                rslt.status = dt.Rows[0]["STATUS"].ToString();
                
                rslt.lseq = dt.Rows[0]["LSEQ"].ToString();
                rslt.lotno = lotno;
                rslt.allRSLT = FX.Common.Funcs.GetBoolStr(dt.Rows[0]["ALL_RSLT"].ToString());
            }
            else
            {
                rslt.status = "C";
                rslt.lseq = "999";
                rslt.lotno = lotno;
            }
            return rslt;
        }
        private DataTable GetETInfor(string lotno)
        {       
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", BaseINF.CORCD);
            param.Add("IN_BIZCD", BaseINF.BIZCD);
            param.Add("IN_LOTNO", lotno);
            param.Add("IN_PROCCD", BaseINF.STATIONCD);
            DataTable dt = ExecuteQuery("PKG_ME_ET_TEST.GET_ET_CODE", param);
            
            if (dt.Rows.Count>0)
            {
                m_FTHeader.lotno = lotno;              

            }
            return dt;
            
        }

        private void ETGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int row = 0; row < ETGrid.Rows.Count; row++)
            {
                if (ETGrid.GetValue(row, "RSLT") == "OK")
                {
                    ETGrid.Rows[row].Cells["RSLT"].Style.BackColor = Color.Lime;
                    ETGrid.Rows[row].Cells["RSLT"].Style.ForeColor = Color.Black;
                }
                else if (ETGrid.GetValue(row, "RSLT") == "NG")
                {
                    ETGrid.Rows[row].Cells["RSLT"].Style.BackColor = Color.Red;
                    ETGrid.Rows[row].Cells["RSLT"].Style.ForeColor = Color.White;
                }
                else
                {
                    ETGrid.Rows[row].Cells["RSLT"].Style.BackColor = Color.Yellow;
                    ETGrid.Rows[row].Cells["RSLT"].Style.ForeColor = Color.Black;
                }

                ETGrid.Rows[row].Cells["MEA_VAL"].Style.ForeColor = Color.Blue;
                ETGrid.Rows[row].Cells["ITEM_DESC"].Style.BackColor = Color.Ivory;

            }
        }
    }
}
