using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY_MES.FX.Devices.Printer
{
    [System.Drawing.ToolboxBitmap(typeof(System.Drawing.Printing.PrintDocument))]
    public partial class PrtHelper : BasePrt
    {
        private PrtLanguageEnum m_PrtLanguage = PrtLanguageEnum.IPL;

        public string GetParam(Dictionary<string, string> param, string key)
        {
            if (param.ContainsKey(key))
            {
                return param[key];
            }
            return "";
        }
        public PrtLanguageEnum PrtLanguage
        {
            get { return m_PrtLanguage; }
            set { m_PrtLanguage = value; }
        }

        public enum PrtLanguageEnum
        {
            IPL,
            ZPL
        }
        /// <summary>
        /// Barcode Printer Helper
        /// </summary>
        /// <param name="param">Keys:CONNECTION-E/S/U, LANG-ZPL/IPL, IPCOM-IP or COM, PORT-PORT or Baudrate</param>
        public void Start(Dictionary<string, string> param)
        {
            Start(param["CONNECTION"], param["IPCOM"], param["PORT"], param["LANG"]);
        }
        protected void Start(string strConnection, string ipOrComport, string portOrBaudrate, string strLang)
        {
            SY_MES.FX.Devices.Printer.BasePrt.PrtConnectMethodEnum prtConn = FX.Devices.Printer.BasePrt.PrtConnectMethodEnum.Serial;
            PrtLanguageEnum prtLang = PrtLanguageEnum.IPL;
            switch (strConnection.ToUpper())
            {
                case "E":
                case "ETHERNET":
                    prtConn = FX.Devices.Printer.BasePrt.PrtConnectMethodEnum.TCP;
                    break;
                case "S":
                case "SERIAL":
                case "COM":
                    prtConn = FX.Devices.Printer.BasePrt.PrtConnectMethodEnum.Serial;
                    break;
                case "U":
                case "USB":
                    prtConn = FX.Devices.Printer.BasePrt.PrtConnectMethodEnum.USB;
                    break;
                default:
                    prtConn = FX.Devices.Printer.BasePrt.PrtConnectMethodEnum.Serial;
                    break;

            }

            switch (strLang.ToUpper())
            {
                case "I":
                case "IPL":
                case "INTERMEC":
                    prtLang = PrtLanguageEnum.IPL;
                    break;
                case "Z":
                case "ZPL":
                case "ZEBRA":
                    prtLang = PrtLanguageEnum.ZPL;
                    break;
            }
            Start(prtConn, ipOrComport, portOrBaudrate, prtLang);
        }
        protected void Start(PrtConnectMethodEnum connection, string ipOrComport, string portOrBaudrate, PrtLanguageEnum lang = PrtLanguageEnum.IPL)
        {
            string errMsg = "";
            bool bOpen = false;
            m_PrtConnectMethod = connection;

            try
            {
                if (connection == PrtConnectMethodEnum.Serial)
                {
                    bOpen = OpenDevice(Convert.ToInt32(ipOrComport), Convert.ToInt32(portOrBaudrate), out errMsg);
                }
                else if (connection == PrtConnectMethodEnum.TCP)
                {
                    bOpen = OpenDevice(ipOrComport, Convert.ToInt32(portOrBaudrate), out errMsg);
                }
                else if (connection == PrtConnectMethodEnum.USB)
                {
                    bOpen = OpenUSB(ipOrComport);
                }
                m_PrtLanguage = lang;
                if (bOpen == false)
                {
                    throw new Exception(errMsg);
                }
            }
            catch (Exception except)
            {
                System.Diagnostics.Debug.WriteLine(except.ToString());
            }
        }

        public void Header(int xPos = 0, int yPos = 0)
        {
            if (PrtLanguage == PrtLanguageEnum.IPL)
            {
                Write(Base.Common.STX + Base.Common.ESC + "C" + Base.Common.ETX);
                Write(Base.Common.STX + Base.Common.ESC + "P" + Base.Common.ETX);
                Write(Base.Common.STX + "E4;F4;" + Base.Common.ETX);
            }
            else if (PrtLanguage == PrtLanguageEnum.ZPL)
            {
                Write("^XA\n");
                Write("^LH" + xPos.ToString() + "," + yPos.ToString() + "\n");
            }
        }

        public void Body(string data)
        {
            if (PrtLanguage == PrtLanguageEnum.IPL)
            {
                Write(Base.Common.STX + data + Base.Common.ETX);
            }
            else if (PrtLanguage == PrtLanguageEnum.ZPL)
            {
                Write(data);
            }
        }

        public void Footer()
        {
            if (PrtLanguage == PrtLanguageEnum.IPL)
            {
                Write(Base.Common.STX + "R" + Base.Common.ETX);
                Write(Base.Common.STX + Base.Common.ESC + "E4" + Base.Common.CAN + Base.Common.ETX);
                Write(Base.Common.STX + Base.Common.SI + "d" + "8" + Base.Common.ETX);
                Write(Base.Common.STX + Base.Common.SI + "F" + "0" + Base.Common.ETX);
                Write(Base.Common.STX + Base.Common.SI + "t" + "1" + Base.Common.ETX);
                Write(Base.Common.STX + Base.Common.RS + "1" + Base.Common.ETB + Base.Common.ETX);
            }
            else if (PrtLanguage == PrtLanguageEnum.ZPL)
            {
                Write("^PQ" + "1" + "^FS");
                Write("^XZ");
            }
        }
    }
}
