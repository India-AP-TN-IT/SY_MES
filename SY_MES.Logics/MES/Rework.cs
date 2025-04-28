using SY_MES.Logics.Base;
using SY_MES.Logics.MES.Sub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.Logics.MES
{
    public partial class Rework : Base.LocalizedContainer
    {
        private DateTime m_tDate;
        private const int CN_REWORK_TIME_SPAN = 10;
        public Rework()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode == false)
            {
                m_tDate = DateTime.Now;
                DispReworkQTY();
                Tmr_Rework.Start();
            }

            
        }
        public override void ReadDataFromScanner(object sender, string data)
        {
            base.ReadDataFromScanner(sender, data);
            if (Comm.IsOurBarcode(data))
            {

                string partno = Common.GetProductInfor("PARTNO");
                string alccd = Common.GetProductInfor("ALCCD");
                string lotno = Common.GetProductInfor("LOTNO");
                WorkState(FX.MainForm.Base.Common.WorkStateEnum.Running);
                productInforBC1.ReLoadData();
                inspectionBC1.LoadData();
                DispBOM(partno);
            }
        }
        private void DispBOM(string partno)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", BaseINF.CORCD);
            param.Add("IN_BIZCD", BaseINF.BIZCD);
            param.Add("IN_PARTNO", partno);

            DataTable dt = ExecuteQuery("PKG_ME_REWORK.GET_BOM_SUM", param);
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Enabled = true;
            for (int row = 0;row<dt.Rows.Count;row++)
            {
                ReworkBomUC.ReworkDataST rewokData = new ReworkBomUC.ReworkDataST();
                rewokData.partno = dt.Rows[row]["PARTNO"].ToString();
                rewokData.partnm = dt.Rows[row]["PARTNM"].ToString();
                rewokData.qty = dt.Rows[row]["USAGE"].ToString();
                ReworkBomUC reworkItem = new ReworkBomUC();

                reworkItem.Width = flowLayoutPanel1.Width - 30;
                reworkItem.Height = 90;
                reworkItem.Margin = new Padding(0, 8, 0, 8);
                reworkItem.ReworkData = rewokData;
                flowLayoutPanel1.Controls.Add(reworkItem);
            }
        }
        private DataTable GetReworkList()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", BaseINF.CORCD);
            param.Add("IN_BIZCD", BaseINF.BIZCD);
            param.Add("IN_LINECD", BaseINF.LINECD);
            param.Add("IN_INSTALL_POS", BaseINF.INSTALL_POS);

            DataTable dt = ExecuteQuery("PKG_ME_REWORK.GET_LIST", param);
            return dt;
        }
        private void DispReworkQTY()
        {
            DataTable dt = GetReworkList();
            if(dt.Rows.Count>0)
            {
                lblReQTY.Text = dt.Rows.Count.ToString();
                lblReQTY.BackColor = Color.Red;
                lblReQTY.ForeColor = Color.Yellow;
            }
            else
            {
                lblReQTY.Text = "0";
                lblReQTY.BackColor = Color.Lime;
                lblReQTY.ForeColor = Color.Black;
            }
        }
        private void Tmr_Rework_Tick(object sender, EventArgs e)
        {
            try
            {
                Tmr_Rework.Stop();
                lblTimer.Text = ((DateTime.Now - m_tDate).TotalSeconds).ToString("N0") + " / "+ CN_REWORK_TIME_SPAN.ToString();
                if ((DateTime.Now - m_tDate).TotalSeconds>CN_REWORK_TIME_SPAN)
                {
                    DispReworkQTY();
                    m_tDate = DateTime.Now;
                }
            }
            catch (Exception eLog)
            {
                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Warnning, eLog.Message);
            }
            finally
            {
                Tmr_Rework.Start();
            }
        }

        private void yButton1_Click(object sender, EventArgs e)
        {
            try
            {
                yButton1.Enabled = false;
                Dictionary<string, string> param = new Dictionary<string, string>();
                int idx = 0;
                string defcd = "";
                string reworkcd = "";
                string whorel = "";
                string qty = "";
                string defPOS = "";
                foreach (Control ctl in flowLayoutPanel1.Controls)
                {
                    if (ctl is ReworkBomUC)
                    {

                        if (((ReworkBomUC)ctl).ReworkData.chk)
                        {
                            if (string.IsNullOrEmpty(((ReworkBomUC)ctl).ReworkData.defectType))
                            {
                                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, "Defect Type is mandatory", System.Reflection.MethodBase.GetCurrentMethod().Name, true);
                                return;
                            }
                            if (string.IsNullOrEmpty(((ReworkBomUC)ctl).ReworkData.reworkType))
                            {
                                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, "Rewor Method is mandatory", System.Reflection.MethodBase.GetCurrentMethod().Name, true);
                                return;
                            }
                            if (string.IsNullOrEmpty(((ReworkBomUC)ctl).ReworkData.whoRel))
                            {
                                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, "Responsiblity is mandatory", System.Reflection.MethodBase.GetCurrentMethod().Name, true);
                                return;
                            }
                            defcd = ((ReworkBomUC)ctl).ReworkData.defectType;

                            reworkcd = ((ReworkBomUC)ctl).ReworkData.reworkType;
                            whorel = ((ReworkBomUC)ctl).ReworkData.whoRel;
                            qty = ((ReworkBomUC)ctl).ReworkData.qty;
                            defPOS = ((ReworkBomUC)ctl).ReworkData.partno;
                            param = new Dictionary<string, string>();
                            param.Add("IN_CORCD", BaseINF.CORCD);
                            param.Add("IN_BIZCD", BaseINF.BIZCD);
                            param.Add("IN_LOTNO", Common.GetProductInfor("LOTNO"));
                            param.Add("IN_PARTNO", Common.GetProductInfor("PARTNO"));
                            param.Add("IN_EMPNO", WorkerLabel.Key);
                            param.Add("IN_QTY", qty);
                            param.Add("IN_WHO_REL", whorel);
                            param.Add("IN_REWORK_CD", reworkcd);
                            param.Add("IN_DEFCD", defcd);
                            ExecuteNonQuery("PKG_ME_REWORK.SET_MPART_REPLACE", param);

                            idx++;
                        }
                    }
                }
                if (idx == 0)
                {
                    StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, "No Data to save", System.Reflection.MethodBase.GetCurrentMethod().Name, true);
                    return;
                }
                else
                {

                    param = new Dictionary<string, string>();
                    param.Add("IN_CORCD", BaseINF.CORCD);
                    param.Add("IN_BIZCD", BaseINF.BIZCD);
                    param.Add("IN_LOTNO", Common.GetProductInfor("LOTNO"));
                    param.Add("IN_DEFCD", defcd);
                    param.Add("IN_DEFPOSCD", defPOS);
                    param.Add("IN_REWORK_CD", reworkcd);
                    param.Add("IN_WHO_REL", whorel);
                    param.Add("IN_EMPNO", WorkerLabel.Key);
                    ExecuteNonQuery("PKG_ME_REWORK.SAVE_MES2104", param);

                    WorkState(FX.MainForm.Base.Common.WorkStateEnum.OK_Complete);
                    flowLayoutPanel1.Enabled = false;
                    StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Alarm, "Rework:" + Common.GetProductInfor("LOTNO"), System.Reflection.MethodBase.GetCurrentMethod().Name);
                }


            }
            catch (Exception eLog)
            {
                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, eLog.Message, System.Reflection.MethodBase.GetCurrentMethod().Name, true);
            }
            finally
            {
                yButton1.Enabled = true;
            }
        }
    }
}
