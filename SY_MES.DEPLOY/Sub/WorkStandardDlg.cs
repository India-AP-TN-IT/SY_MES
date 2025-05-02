using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.DEPLOY.Sub
{
    public partial class WorkStandardDlg : FX.MainForm.BaseContainer
    {
        private const string CN_ASYNC_LOAD_QUERY = "MES.PKG_ME_DLG.GET_WORK_STANDARD";
        public WorkStandardDlg()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lblWarn.Visible = true;
            lblWarn.Text = "Loading..";
            lblWarn.BringToFront();
            LoadData();

        }
        public override void LoadData()
        {
            base.LoadData();
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", PBaseFrm.GetXMLConfig("CORCD"));
            param.Add("IN_BIZCD", PBaseFrm.GetXMLConfig("BIZCD"));
            param.Add("IN_LINECD", PBaseFrm.GetINI("STATION_INFOR/LINECD"));
            param.Add("IN_PROCCD", PBaseFrm.GetINI("STATION_INFOR/STATIONCD"));
            param.Add("IN_POS", PBaseFrm.GetINI("STATION_INFOR/INSTALL_POS"));
            AsyncExecueteQuery(this, CN_ASYNC_LOAD_QUERY, param, PBaseFrm.WorkStandard_CTL);
        }

        public override void ReadAsyncDBData(object sender, string query, Dictionary<string, string> param, DataTable dt)
        {
            if (PBaseFrm != null)
            {
                PBaseFrm.Invoke(new MethodInvoker(
                delegate()
                {
                    if (query.Contains(CN_ASYNC_LOAD_QUERY))
                    {   //Load Data
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            yPdfView1.ThreadPDFShow(dt.Rows[0]["FILE_IMAGE"]);
                            lblWarn.Visible = false;
                        }
                        else
                        {
                            yPdfView1.Clear();
                            lblWarn.Visible = true;
                            lblWarn.Text = "There is no WorkStandard";
                            lblWarn.BringToFront();
                        }
                    }
                }));
            }
        }
        public override void BackgroundError(object sender, string query, Dictionary<string, string> param, DataTable dt, Exception eLog)
        {
            if (PBaseFrm != null)
            {
                PBaseFrm.Invoke(new MethodInvoker(
                delegate()
                {
                    //base.BackgroundError(sender, query, param, dt, eLog);
                    if (query.Contains(CN_ASYNC_LOAD_QUERY))
                    {   //Load Data
                        yPdfView1.Clear();
                        StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, eLog.Message, System.Reflection.MethodBase.GetCurrentMethod().Name, true);
                        lblWarn.Visible = true;
                        lblWarn.Text = "Data Error";
                        lblWarn.BringToFront();
                    }
                }));
            }
        }

    }
}
