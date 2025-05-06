using SY_MES.FX.Controls;
using SY_MES.FX.Controls.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.Logics.MES.Sub
{
    public partial class TrolleyStockListBC : Base.LocalizedContainer
    {
        private const string CN_ASYNC_LOAD_QUERY = "PKG_ME_DLG.GET_TROLLEY_LIST";
        private string m_TrolleyNO = "";
        private string m_TrolleyQTY = "";
        public string TrolleyNO
        {
            get { return m_TrolleyNO; }
            set
            {
                m_TrolleyNO = value;
            }
        }
        public string TrolleyQTY
        {
            get { return m_TrolleyQTY; }
            set { m_TrolleyQTY = value; }
        }
        protected override void InitControls()
        {
            base.InitControls();
            yBitLabel1.Text = "";
            yBitLabel2.Text = "";
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            yBitLabel1.Text = m_TrolleyNO;
            yBitLabel1.SetValue(true);
            yBitLabel2.Text = m_TrolleyQTY;
            if(string.IsNullOrEmpty(m_TrolleyQTY))
            {
                yBitLabel2.SetValue(false);
            }
            else
            {
                yBitLabel2.SetValue(true);
            }
            
        }
        public override void LoadData()
        {
            base.LoadData();
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", BaseINF.CORCD);
            param.Add("IN_BIZCD", BaseINF.BIZCD);
            param.Add("IN_TRYNO", TrolleyNO);
            AsyncExecueteQuery(this, CN_ASYNC_LOAD_QUERY, param);
        }
        public override void ReadAsyncDBData(object sender, string query, Dictionary<string, string> param, DataTable dt)
        {
            if (PBaseFrm != null)
            {
                PBaseFrm.Invoke(new MethodInvoker(
                delegate ()
                {
                    if (query.Contains(CN_ASYNC_LOAD_QUERY))
                    {   //Load Data
                        yDataGridView1.SetValue(dt);
                        yDataGridView1.ShowLastRow();
                    }
                }));
            }
        }
        public TrolleyStockListBC(string trolleyNO, string trolleyQTY)
        {
            InitializeComponent();
            m_TrolleyNO = trolleyNO;
            m_TrolleyQTY = trolleyQTY;
        }
    }
}
