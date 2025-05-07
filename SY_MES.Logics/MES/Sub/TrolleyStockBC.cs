using SY_MES.FX.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.Logics.MES.Sub
{
    [ToolboxItem(true)]
    public partial class TrolleyStockBC : Base.LocalizedContainer
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Pan_QUE.Visible = false;
        }
        public enum IV_StatusEnum
        {
            Stock,
            Issue,
            Clear
        }
        private string m_TrolleyNO = "";
        public string TrolleyNO
        {
            get { return m_TrolleyNO; }
        }
        public TrolleyStockBC()
        {
            InitializeComponent();
        }
        protected override void InitControls()
        {
            base.InitControls();
            yBitLabel1.Text = "";
            yBitLabel2.Text = "";
        }
        private string Get_INVStatus(IV_StatusEnum status)
        {
            if(status == IV_StatusEnum.Stock)
            {
                return "I0";
            }
            else if(status == IV_StatusEnum.Issue)
            {
                return "O1";
            }
            else if(status == IV_StatusEnum.Clear)
            {
                return "X";
            }
            return "I1";
        }
        public void SetTrolleyNo(string trolleyNo)
        {

            yBitLabel1.Text = trolleyNo;
            m_TrolleyNO = trolleyNo;
            if(string.IsNullOrEmpty(trolleyNo))
            {
                yBitLabel1.SetValue(false);
            }
            else
            {
                yBitLabel1.SetValue(true);
                
            }
            DataTable dt = GetHeadData(trolleyNo);
            if(dt.Rows.Count>0)
            {
                int qty = FX.Common.Funcs.GetO2I(dt.Rows[0]["CNT_QTY"]);
                if(qty >0)
                {
                    Pan_QUE.Visible = true;
                    StatusMsgForQuestion();
                }
                else
                {
                    Pan_QUE.Visible = false;
                }
            }
            else
            {
                SaveHead(trolleyNo);
            }
            LoadData();
            
        }
        public void StatusMsgForQuestion()
        {
            StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Warnning, "Please choose 'Clear' or 'Continue' for trolley", System.Reflection.MethodBase.GetCurrentMethod().Name, true);
        }
        private void SaveHead(string trolleyNo)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", BaseINF.CORCD);
            param.Add("IN_BIZCD", BaseINF.BIZCD);
            param.Add("IN_TRYNO", trolleyNo);
            param.Add("IN_LINECD", BaseINF.LINECD);
            ExecuteNonQuery("PKG_ME_DLG.SET_TROLLEY_HEAD", param);
        }
        public DataTable GetHeadData(string trolleyNO)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", BaseINF.CORCD);
            param.Add("IN_BIZCD", BaseINF.BIZCD);
            param.Add("IN_TRYNO", trolleyNO);
            DataTable dt = ExecuteQuery("PKG_ME_DLG.GET_TROLLEY_HEAD", param);
            return dt;
        }
        public bool IsQuestion
        {
            get { return Pan_QUE.Visible; }
        }
        public override void LoadData()
        {
            base.LoadData();
            DataTable dt = GetHeadData(m_TrolleyNO);
            if (dt.Rows.Count > 0)
            {
                yBitLabel2.Text = dt.Rows[0]["CNT_QTY"].ToString();
                yBitLabel1.SetValue(true);
            }
            else
            {
                yBitLabel2.Text = "0";
                yBitLabel1.SetValue(false);
            }
        }  
        public void SetStock(string lotno, IV_StatusEnum status)
        {
            if(string.IsNullOrEmpty(lotno) == false)
            {
                
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("IN_CORCD", BaseINF.CORCD);
                param.Add("IN_BIZCD", BaseINF.BIZCD);
                param.Add("IN_TRYNO", m_TrolleyNO);
                param.Add("IN_LINECD", BaseINF.LINECD);
                param.Add("IN_INV_STATUS", Get_INVStatus(status));
                param.Add("IN_LOTNO", lotno);
                ExecuteNonQuery("PKG_ME_DLG.SET_TROLLEY_LOT", param);
            }

            LoadData();
        }

        private void yBitLabel2_DoubleClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(m_TrolleyNO) == false)
            {
                FX.MainForm.BaseDialog dlg = new FX.MainForm.BaseDialog("Trolley List", new Sub.TrolleyStockListBC(m_TrolleyNO, yBitLabel2.Text), this.PBaseFrm, FormWindowState.Normal);

                dlg.Show();
                dlg.BringToFront();
            }
        }

        private void CmdRun(object sender, EventArgs e)
        {
            if(sender is YButton)
            {
                if(((YButton)sender).Key == "CLEAR")
                {
                    SaveHead(m_TrolleyNO);
                    
                }
                Pan_QUE.Visible = false;
                LoadData();
            }
        }
    }
}
