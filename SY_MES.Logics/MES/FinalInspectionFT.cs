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
    public partial class FinalInspectionFT : Base.LocalizedContainer
    {
        public FinalInspectionFT()
        {
            InitializeComponent();
        }
        public override void ReadDataFromScanner(object sender, string data)
        {
            base.ReadDataFromScanner(sender, data);
            if (Comm.IsOurBarcode(data) && Comm.AvailableLine(data, BaseINF.LINECD))
            {
                WorkState(FX.MainForm.Base.Common.WorkStateEnum.Running);
                productInforBC1.LoadData();
                inspectionBC1.LoadData();
                fT_BC1.LoadData();
                string etChk = Base.Common.GetProductInfor("CHK_ELEC");
                string except = "";
                if(string.IsNullOrEmpty(etChk))
                {
                    except = "CHK_ELEC";
                    StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Alarm, "Please Start Functional Test!!", System.Reflection.MethodBase.GetCurrentMethod().Name, false);
                }
                if (inspectionBC1.GetInspectioFactorRslt(except) == false)
                {
                    StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, "Inspection Factor has problem", System.Reflection.MethodBase.GetCurrentMethod().Name, true);
                    return;
                }
                
            }
            else if (data.Contains(Base.Common.CN_BARCODE_PASS_CHECK))
            {   //OK
                
                inspectionBC1.SetData(true);
            }
            else if (data.Contains(Base.Common.CN_BARCODE_NG_CHECK))
            {   //NG
                inspectionBC1.SetData(false);
            }
            else
            {
                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, "Wrong Barcode:" + data, System.Reflection.MethodBase.GetCurrentMethod().Name, true);
            }
        }

        private void fT_BC1_OnProcResult(object sender, bool result)
        {
            inspectionBC1.SetFactor("CHK_ELEC", result);
        }
    }
}
