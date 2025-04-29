using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY_MES.Logics.Base
{
    public partial class LocalizedPrintHelper : FX.Devices.Printer.PrtHelper
    {
        public LocalizedPrintHelper()
        {
            InitializeComponent();
        }

        public LocalizedPrintHelper(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        private string GetZPLAsciiCVT(string data)
        {
            return data.Replace(FX.Common.ConstVars.EOT, "_04").Replace(FX.Common.ConstVars.GS, "_1D").Replace(FX.Common.ConstVars.RS, "_1E");
        }
        public virtual void PrintLabel(Dictionary<string, string> param, out string errMsg)
        {   //TODO : Need to make print format for each plant.
            errMsg = "";
            try
            {
                int xPos = 0;   //Start X Position
                int yPos = 0;   //Start Y Position
                Header(xPos, yPos);   //Header
                //<Body
                string labelType = GetParam(param, "LABEL_TYPE");
                switch(labelType)
                {
                    default:
                        Body("^BXN,3,200");
                        Body("^FO30,30^FH^FD" + GetZPLAsciiCVT(GetParam(param, "MATRIX_CODE")) + "^FS");
                        Body("^FO130,50^A0NB,22,15^FB250,0,0,L^FD" + DateTime.Parse(GetParam(param, "WORK_DATE")).ToString("dd-MM-yyyy") + " " + DateTime.Now.ToString("HH:mm") + "  S:" + GetParam(param, "SHIFT") + "^FS");
                        
                        Body("^FO130,80^A0NB,35,30^FB220,0,0,L^FD" + GetParam(param, "LOTNO") + "^FS");
                        Body("^FO30,120^A0NB,45,35^FB300,0,0,L^FD" + GetParam(param, "PARTNO") + "^FS");

                        Body("^FO290,80^A0NB,70,30^FB320,0,0,L^FD" + GetParam(param, "INSTALL_POS") + "^FS");
                        break;
                }
                //>>
                
                Footer(); //Footer
                
            }
            catch(Exception eLog)
            {
                errMsg = eLog.Message;

            }
        }
    }
}
