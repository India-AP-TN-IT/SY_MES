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

namespace SY_MES.Logics.Base
{
    public partial class PCVisionCtl : LocalUC
    {
        public enum ConnTypeEnum
        {
            None,
            PC,
            PLC
        }
        private ConnTypeEnum m_ConnectionType = ConnTypeEnum.None;
        public ConnTypeEnum ConnectionType
        {
            get { return m_ConnectionType; }
        }
        public delegate void VisionPLCSignal(object sender, int pos, bool bVal, SY_MES.FX.PLC.Base.Common.PLC_DeviceArray[] currentBuffer);
        [Category(Base.Common.CN_CATEGORY_APP)]
        public event VisionPLCSignal OnVisionPLCSignal;

        private SimplePlcUI m_PLC;
        [Browsable(false)]
        public SimplePlcUI VisionPLC
        {
            get { return m_PLC; }
        }
        private System.Windows.Forms.Timer m_TmrVision;
        public PCVisionCtl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if(DesignMode ==false)
            {
                m_TmrVision = new Timer();
                m_TmrVision.Interval = 4000;
                m_TmrVision.Stop();
                m_TmrVision.Tick += TmrVision_Tick;
                Dictionary<string, string> dicINI= ParentBC.GetPlcInforFromINI("VISION_INFOR");
                switch (ParentBC.GetINI("VISION_INFOR/MC_TYPE").ToString().ToUpper())
                {
                    case "PC":
                        this.Visible = true;
                        m_ConnectionType = ConnTypeEnum.PC;
                        break;
                    case "PLC":
                    case "PC+PLC":
                        m_PLC = new SimplePlcUI();
                        this.Visible =true;
                        m_PLC.Start(dicINI);
                        m_PLC.OnPlcSeqSignal += OnVisionPLC;
                        m_ConnectionType = ConnTypeEnum.PLC;
                        break;
                    default:
                        this.Visible = false;
                        m_ConnectionType = ConnTypeEnum.None;
                        break;
                }
            }
            
        }

        private void OnVisionPLC(object sender, int pos, bool bVal, FX.PLC.Base.Common.PLC_DeviceArray[] currentBuffer)
        {
            if(OnVisionPLCSignal != null)
            {
                OnVisionPLCSignal(sender, pos, bVal, currentBuffer);
            }
        }

        protected override void InitControls()
        {
            base.InitControls();
            Lbl_LOT.Text = "";
            lblPartNO.Text = "";
            lblRSLT.Text = "";
            lblDate.Text = "";
            lblRSLT.SetValue(false);
        }
        public override void LoadData()
        {
 	         base.LoadData();
            if (ParentBC != null)
            {
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("IN_CORCD",ParentBC.BaseINF.CORCD);
                param.Add("IN_BIZCD", ParentBC.BaseINF.BIZCD);
                param.Add("IN_LINECD", ParentBC.BaseINF.LINECD);
                param.Add("IN_PROCCD", ParentBC.BaseINF.STATIONCD);
                param.Add("IN_INSTALL_POS", ParentBC.BaseINF.INSTALL_POS);
                DataTable dt = ParentBC.ExecuteQuery("PKG_ME_VISION.SET_INSPECT_HD", param);
                if (dt.Rows.Count > 0)
                {
                    Lbl_LOT.Text = dt.Rows[0]["LOTNO"].ToString();
                    lblPartNO.Text = dt.Rows[0]["PARTNO"].ToString();
                    lblRSLT.Text = dt.Rows[0]["RSLT"].ToString();
                    lblDate.Text = dt.Rows[0]["UPDATE_DATE"].ToString();
                    if(lblRSLT.Text.Contains("OK"))
                    {
                        lblRSLT.BackColor = Color.Lime;
                        lblRSLT.ForeColor = Color.Black;
                    }
                    else
                    {
                        lblRSLT.BackColor = Color.Red;
                        lblRSLT.ForeColor = Color.White;
                    }
                }
                else
                {
                    Lbl_LOT.Text = "";
                    lblPartNO.Text = "";
                    lblRSLT.Text = "";
                    lblDate.Text = "";
                    lblRSLT.BackColor = Color.Black;
                    lblRSLT.ForeColor = Color.White;
                }
            }
        }
            
        private void TmrVision_Tick(object sender, EventArgs e)
        {
            try
            {
                yBitLabel1.SetValue(!Convert.ToBoolean(yBitLabel1.GetValue()));
                m_TmrVision.Stop();
                LoadData();
            }
            catch(Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
            }
            finally
            {
                m_TmrVision.Start();
            }
        }
        public void Start()
        {
            m_TmrVision.Stop();
            if(this.Visible == false)
            {
                return;
            }
            LoadData();
            if (m_PLC == null)
            {
                m_TmrVision.Start();
            }
            else
            {
                yBitLabel1.OnBGColor = Color.Yellow;
                yBitLabel1.SetValue(true);
            }
        }

        public void Stop()
        {
            m_TmrVision.Stop();
        }

        private void lblDate_DoubleClick(object sender, EventArgs e)
        {
            if(m_PLC!=null && m_ConnectionType == ConnTypeEnum.PLC)
            {
                m_PLC.DispPLCTraceDlg();
            }
        }
    }
}
