using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SY_MES.Logics.Base;

namespace SY_MES.Logics.MES
{
    public partial class TagPrintSpecCheck : Base.LocalizedContainer
    {
        public TagPrintSpecCheck()
        {
            InitializeComponent();
        }
        
        public override void AfterBaseFormLoad(EventArgs e)
        {
            base.AfterBaseFormLoad(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            WorkState(FX.MainForm.Base.Common.WorkStateEnum.Wait);
            
        }
        public override void ReadDataFromScanner(object sender, string data)
        {
            base.ReadDataFromScanner(sender, data);
            CloseFrmMsgBox();
            if (Comm.IsOurBarcode(data) && Comm.AvailableLine(data, woPrintBC1.GetLinecd()))
            {


                string partno = Common.GetProductInfor("PARTNO");
                string alccd = Common.GetProductInfor("ALCCD");
                string lotno = Common.GetProductInfor("LOTNO");
                string line = woPrintBC1.GetLinecd();                
                WorkState(FX.MainForm.Base.Common.WorkStateEnum.Running);
                productInforBC1.ReLoadData();
                specCheckBC1.LoadStationBOM(line, partno);
                if (specCheckBC1.RowCnt <= 0)
                {
                    StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Warnning, "There is no Station BOM Data for " + partno, System.Reflection.MethodBase.GetCurrentMethod().Name, false);
                    WorkState(FX.MainForm.Base.Common.WorkStateEnum.OK_Complete);
                }
            }
            else if(specCheckBC1.RowCnt<=0)
            {
                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, "Station BOM is Empty:" + data, System.Reflection.MethodBase.GetCurrentMethod().Name, true);
                WorkState(FX.MainForm.Base.Common.WorkStateEnum.OK_Complete);
            }
            else
            {
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


        

    }
}
