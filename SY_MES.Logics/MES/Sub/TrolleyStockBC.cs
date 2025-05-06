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
        public void SetTrolleyNo(string trolleyNo, IV_StatusEnum status)
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
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("IN_CORCD", BaseINF.CORCD);
                param.Add("IN_BIZCD", BaseINF.BIZCD);
                param.Add("IN_TRYNO", trolleyNo);
                param.Add("IN_LINECD", BaseINF.LINECD);
                param.Add("IN_INV_STATUS", Get_INVStatus(status));
                ExecuteNonQuery("PKG_ME_DLG.SET_TROLLEY_HEAD", param);
            }
            LoadData();
            
        }
        public override void LoadData()
        {
            base.LoadData();
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", BaseINF.CORCD);
            param.Add("IN_BIZCD", BaseINF.BIZCD);
            param.Add("IN_TRYNO", m_TrolleyNO);
            DataTable dt = ExecuteQuery("PKG_ME_DLG.GET_TROLLEY_HEAD", param);
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
        
    }
}
