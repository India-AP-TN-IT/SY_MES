using SY_MES.Logics.Base;
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
    public partial class SpecCheck : Base.LocalizedContainer
    {
        public SpecCheck()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            pcVisionCtl1.Start();
        }
        public override void ReadDataFromScanner(object sender, string data)
        {
            base.ReadDataFromScanner(sender, data);
            if (Comm.IsOurBarcode(data) && Comm.AvailableLine(data, BaseINF.LINECD))
            {

                string partno = Common.GetProductInfor("PARTNO");
                string alccd = Common.GetProductInfor("ALCCD");
                string lotno = Common.GetProductInfor("LOTNO");
                WorkState(FX.MainForm.Base.Common.WorkStateEnum.Running);
                productInforBC1.ReLoadData();
                specCheckBC1.LoadStationBOM(BaseINF.LINECD, partno);
                specDetUC1.LoadData();
                if (specCheckBC1.RowCnt <= 0)
                {
                    StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Warnning, "There is no Station BOM Data for " + partno, System.Reflection.MethodBase.GetCurrentMethod().Name, false);
                    WorkState(FX.MainForm.Base.Common.WorkStateEnum.OK_Complete);
                }
            }
            else if (specCheckBC1.RowCnt <= 0)
            {
                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, "Station BOM is Empty:" + data, System.Reflection.MethodBase.GetCurrentMethod().Name, true);
                WorkState(FX.MainForm.Base.Common.WorkStateEnum.OK_Complete);
            }
            else
            {
                if(PrvStationRslt == false)
                {
                    FrmMsgBox(FX.MainForm.Base.Common.MsgTypeEnum.Error, "Previous Station was not done", "Previous Station", FX.MainForm.Base.MsgBox.MsgBtnEnum.OK, true);
                    return;
                }
                string msg = "";
                bool allOK = false;
                bool rslt = specCheckBC1.PartCheckWithGrid(data, Common.GetProductInfor("LOTNO"), yWorkerLabel1.GetValue().ToString(), out msg, out allOK);
                if (rslt == false)
                {
                    StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, msg, System.Reflection.MethodBase.GetCurrentMethod().Name, true);
                }
                else
                {
                    if (allOK)
                    {
                        FrmMsgBox(FX.MainForm.Base.Common.MsgTypeEnum.Alarm, "All Parts are checked!!", "Specification Check");
                        WorkState(FX.MainForm.Base.Common.WorkStateEnum.OK_Complete);
                    }
                }
            }

        }

        private void pcVisionCtl1_OnVisionPLCSignal(object sender, int pos, bool bVal, FX.PLC.Base.Common.PLC_DeviceArray[] currentBuffer)
        {   //If We use VisonPLC, We can get siginal from here

        }
    }
}
