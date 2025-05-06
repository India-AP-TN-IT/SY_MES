using SY_MES.FX.Controls.Base;
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
    public partial class InjectionPrint : Base.LocalizedContainer
    {
        public InjectionPrint()
        {
            InitializeComponent();
        }
        public override void ReadDataFromScanner(object sender, string data)
        {
            base.ReadDataFromScanner(sender, data);
            if(Comm.IsOurBarcode(data) && Comm.AvailableLine(data, injectionPrintBC1.GetLinecd()))
            {
                if(inspectionBC1.AutoStock)
                {
                    if(string.IsNullOrEmpty(trolleyStockBC1.TrolleyNO))
                    {
                        StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, "Trolley No is mandatory", System.Reflection.MethodBase.GetCurrentMethod().Name, true);
                        return;
                    }
                    if(trolleyStockBC1.IsQuestion)
                    {
                        trolleyStockBC1.StatusMsgForQuestion();
                        return;
                    }
                    WorkState(FX.MainForm.Base.Common.WorkStateEnum.Running);
                    productInforBC1.LoadData();
                    inspectionBC1.LoadData();

                    inspectionBC1.SetData(true, AddInspectionValid);

                    string lotno = Base.Common.GetProductInfor("LOTNO");
                    trolleyStockBC1.SetStock(lotno, TrolleyStockBC.IV_StatusEnum.Stock);
                    trolleyStockBC1.LoadData();
                }
                else
                {
                    WorkState(FX.MainForm.Base.Common.WorkStateEnum.Running);
                    productInforBC1.LoadData();
                    inspectionBC1.LoadData();
                }
                
                
            }
            else if(Comm.IsTrolleyBarcode(data))
            {   //Trolley Barcode Process
                
                trolleyStockBC1.SetTrolleyNo(data);


            }
            else if (data.Contains(Base.Common.CN_BARCODE_PASS_CHECK) && inspectionBC1.AutoStock ==false)
            {   //OK
                
                bool inspectRSLT = inspectionBC1.SetData(true, AddInspectionValid);
                if (inspectRSLT)
                {
                    string lotno = Base.Common.GetProductInfor("LOTNO");
                    trolleyStockBC1.SetStock(lotno, TrolleyStockBC.IV_StatusEnum.Stock);
                }
            }
            else if (data.Contains(Base.Common.CN_BARCODE_NG_CHECK) && inspectionBC1.AutoStock == false)
            {   //NG
                inspectionBC1.SetData(false);
            }
            else
            {
                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, "Wrong Barcode:" + data, System.Reflection.MethodBase.GetCurrentMethod().Name, true);
            }
        }
        private bool AddInspectionValid()
        {
            if (string.IsNullOrEmpty(trolleyStockBC1.TrolleyNO))
            {
                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, "Trolley No is mandatory", System.Reflection.MethodBase.GetCurrentMethod().Name, true);
                return false;
            }
            return true;
        }
        private void inspectionBC1_OnProcRSLT(object sender, bool rslt)
        {
            if(rslt)
            {
                bool inspectRSLT = inspectionBC1.SetData(true, AddInspectionValid);
                if (inspectRSLT)
                {
                    string lotno = Base.Common.GetProductInfor("LOTNO");
                    trolleyStockBC1.SetStock(lotno, TrolleyStockBC.IV_StatusEnum.Stock);
                }
            }
            else
            {
                inspectionBC1.SetData(false);
            }
        }
    }
}
