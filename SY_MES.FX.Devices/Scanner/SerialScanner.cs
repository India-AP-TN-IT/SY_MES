using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY_MES.FX.Devices.Scanner
{
    public partial class SerialScanner : SerialPort, Base.IDevice
    {
        private string m_DeviceName = "";
        public string DeviceName
        {
            get { return m_DeviceName; }
            set { m_DeviceName = value; }
        }
        private int m_BufferSize = 4096;
        public int BufferSize
        {
            get { return m_BufferSize; }
            set { m_BufferSize = value; }
        }
        public delegate void ErrorScan(object sender, string strData);
        public delegate void ScanData(object sender, string strData);

        public event ScanData OnScanData = null;
        public event ErrorScan OnErrorScan = null;

        public SerialScanner()
        {
            InitializeComponent();
        }

        public SerialScanner(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public bool CloseDevice()
        {
            try
            {
                Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool IsConnected()
        {
            return IsOpen;
        }
        /// <summary>
        /// Open Device
        /// </summary>
        /// <param name="param">PORT,BAUDRATE,BUFFER_SIZE, DATABITS</param>
        /// <returns></returns>
        public bool OpenDevice(Dictionary<string, object> param)
        {
            try
            {
                if (IsOpen == true)
                {
                    Close();
                }

                PortName = "COM" + param["PORT"];
                int nBaudRate = 9600;
                if(param.Keys.Contains("BAUDRATE"))
                {
                    nBaudRate = Convert.ToInt32(param["BAUDRATE"]);
                }
                m_BufferSize = 4096;
                if(param.Keys.Contains("BUFFER_SIZE"))
                {
                    m_BufferSize = Convert.ToInt32(param["BUFFER_SIZE"]);
                }
                BaudRate = nBaudRate;
                Parity = Parity.None;
                int nDataBits = 8;
                if (param.Keys.Contains("DATABITS"))
                {
                    nDataBits = Convert.ToInt32(param["DATABITS"]);
                }
                DataBits = nDataBits;
                StopBits = StopBits.One;

                ReadBufferSize = m_BufferSize;
                Open();
                Handshake = Handshake.XOnXOff;
                DtrEnable = true;
                RtsEnable = true;
                return true;
            }
            catch (Exception ex)
            {
                string errMsg = "[" + PortName + "][" + ex.StackTrace + "]" + ex.Message;
                throw new Exception(errMsg);
            }
        }

        private void SerialScanner_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (sender is SerialPort)
                {

                    string readData = ((SerialPort)sender).ReadTo(Base.Common.ETX) + Base.Common.ETX;   

                    
                    if (readData.Contains(Convert.ToChar(Base.Common.STX)) && readData.Contains(Convert.ToChar(Base.Common.ETX)))
                    {

                        
                        string[] spReadData = readData.Split(Convert.ToChar(Base.Common.STX));

                        if (spReadData.Length > 1)
                        {
                            string[] spProcessedData = spReadData[1].Split(Convert.ToChar(Base.Common.ETX));
                            if (string.IsNullOrEmpty(spProcessedData[0]) == false)
                            {                                
                                if (OnScanData != null)
                                {
                                    OnScanData(sender, spProcessedData[0]);
                                }

                            }
                        }

                    }
                    else
                    {
                        Debug.WriteLine("[SCAN DATA-ERROR]");
                        if (OnErrorScan != null)
                        {
                            OnErrorScan(sender, "");
                        }
                    }


                }
            }
            catch (Exception eLog)
            {
                Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.ToString());
            }
        }
    }
}
