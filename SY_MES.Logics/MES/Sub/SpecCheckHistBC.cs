using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.Logics.MES.Sub
{
    public partial class SpecCheckHistBC :Base.LocalizedContainer
    {
        private const string CN_ASYNC_LOAD_QUERY = "PKG_ME_DLG.GET_PROC_SPEC_CHK";
        public SpecCheckHistBC()
        {
            InitializeComponent();
        }
        protected override void InitControls()
        {
            base.InitControls();
            yLabel2.Text = "";
            yLabel3.Text = "";
        }
        
        public override void LoadData()
        {
            base.LoadData();

            string lotno = Base.Common.GetProductInfor("LOTNO");
            string partno = Base.Common.GetProductInfor("PARTNO");
            yLabel2.SetValue(lotno);
            yLabel3.SetValue(partno);
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", BaseINF.CORCD);
            param.Add("IN_BIZCD", BaseINF.BIZCD);
            param.Add("IN_LOTNO", lotno);
            param.Add("IN_PROCCD", "");
            AsyncExecueteQuery(this,CN_ASYNC_LOAD_QUERY, param);
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
    }
}
