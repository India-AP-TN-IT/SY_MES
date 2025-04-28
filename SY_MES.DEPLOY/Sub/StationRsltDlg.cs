using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.DEPLOY.Sub
{
    [ToolboxItem(false)]
    public partial class StationRsltDlg : FX.MainForm.BaseContainer
    {
        public StationRsltDlg()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lbl_LINECD.Text = GetINI("STATION_INFOR/LINECD");
            lbl_STATIONCD.Text = GetINI("STATION_INFOR/STATIONCD");
            lbl_POS.Text = GetINI("STATION_INFOR/INSTALL_POS");
        }
        public override void LoadData()
        {
            base.LoadData();
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", CORCD);
            param.Add("IN_BIZCD", BIZCD);
            param.Add("IN_PROD_DATE", yDateTime1.GetValue().ToString());
            param.Add("IN_LINECD", GetINI("STATION_INFOR/LINECD"));
            param.Add("IN_STATIONCD", GetINI("STATION_INFOR/STATIONCD"));
            param.Add("IN_INSTALL_POS", GetINI("STATION_INFOR/INSTALL_POS"));
            DataTable dt = ExecuteQuery("PKG_ME_DLG.GET_STATION_RSLT", param);
            GrdRSLT.SetValue(dt);
            if(dt.Rows.Count>0)
            {
                int pend = 0;
                int rslt = 0;
                int tot = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    rslt += Convert.ToInt32(dt.Rows[i]["RSLT_QTY"]);
                    tot += Convert.ToInt32(dt.Rows[i]["TOT_QTY"]);
                    pend += Convert.ToInt32(dt.Rows[i]["PEND_QTY"]);
                }
                lbl_TOT.Text = tot.ToString();
                lbl_RSLT.Text = rslt.ToString();
                lbl_PENDING.Text = pend.ToString();
            }
            else
            {
                lbl_PENDING.Text = "";
                lbl_RSLT.Text = "";
                lbl_TOT.Text = "";
            }
            

        }

        private void yDateTime1_OnDateChg(object sender, DateTime date)
        {
            LoadData();
        }
    }
}
