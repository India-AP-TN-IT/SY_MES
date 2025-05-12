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
        
        public string MakeGetLotHeader(string strWorkDate)
        {
            try
            {
                string strLotnoHeader = "";

                //YEAR: 1 Digit 2000(A),...,2011(L), 2012(M), 2013(N), ..
                strLotnoHeader = strLotnoHeader + Convert.ToChar(Convert.ToInt16(strWorkDate.Substring(0, 4)) - 2000 + 65);

                //Month: Jan(1), Feb(2), ..., SEP(9), OCT(A), NOV(B), DEC(C)
                if (Convert.ToInt16(strWorkDate.Substring(5, 2)) < 10)
                {
                    strLotnoHeader = strLotnoHeader + Convert.ToInt16(strWorkDate.Substring(5, 2)).ToString();
                }
                else
                {
                    strLotnoHeader = strLotnoHeader + Convert.ToChar(Convert.ToInt16(strWorkDate.Substring(5, 2)) + 55);
                }

                //DAY: 1(1), 2(2),..., 9(9), 10(A), 11(B), 12(C),...,30(U), 31(V)
                if (Convert.ToInt16(strWorkDate.Substring(8, 2)) < 10)
                {
                    strLotnoHeader = strLotnoHeader + Convert.ToInt16(strWorkDate.Substring(8, 2)).ToString();
                }
                else
                {
                    strLotnoHeader = strLotnoHeader + Convert.ToChar(Convert.ToInt16(strWorkDate.Substring(8, 2)) + 55);
                }

                return strLotnoHeader;
            }
            catch
            {
                return "";
            }
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
                        Body("^FO80,50"); //Barcode Location(Matrix 2D)
                        Body("^BXN,7,200"); //Barcode Setting 
                        Body("^FH^FD" + GetZPLAsciiCVT(GetParam(param, "LOTNO")) + "^FS"); 
                        Body("^FO200,90^A0NB,22,15^FB250,0,0,L^FD" + DateTime.Parse(GetParam(param, "WORK_DATE")).ToString("dd-MM-yyyy") + " " + DateTime.Now.ToString("HH:mm") + "  S:" + GetParam(param, "SHIFT") + "^FS");
                        
                        Body("^FO200,120^A0NB,35,30^FB220,0,0,L^FD" + GetParam(param, "LOTNO") + "^FS");
                        Body("^FO100,160^A0NB,45,35^FB300,0,0,L^FD" + GetParam(param, "PARTNO") + "^FS");

                        Body("^FO360,120^A0NB,70,30^FB320,0,0,L^FD" + GetParam(param, "INSTALL_POS") + "^FS");
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
