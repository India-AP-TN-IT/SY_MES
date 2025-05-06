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
    public partial class FinalInspection : Base.LocalizedContainer
    {
        public FinalInspection()
        {
            InitializeComponent();
        }
        public override void ReadDataFromScanner(object sender, string data)
        {
            base.ReadDataFromScanner(sender, data);
            if (Comm.IsOurBarcode(data) && Comm.AvailableLine(data, planRsltBC1.GetLinecd()))
            {
                WorkState(FX.MainForm.Base.Common.WorkStateEnum.Running);
                productInforBC1.LoadData();
                inspectionBC1.LoadData();

                if(inspectionBC1.GetInspectioFactorRslt() == false)
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

    }
}
