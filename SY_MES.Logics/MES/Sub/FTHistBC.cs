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
    public partial class FTHistBC : Base.LocalizedContainer
    {
        public FTHistBC()
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
            param.Add("IN_LINECD", BaseINF.LINECD);
            param.Add("IN_PROCCD", BaseINF.STATIONCD);
            DataTable dt = ExecuteQuery("PKG_ME_ET_TEST.GET_ET_HIST", param);
            ETGrid.SetValue(dt);
            
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
            ETGrid.ShowLastRow();
        }
    }
}
