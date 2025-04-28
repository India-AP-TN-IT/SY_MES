using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Data;
using System.Net.Sockets;
using System.Net;

namespace SY_MES.FX.Devices.Printer
{
    public partial class BasePrt :Component, Base.IDevice
    {
        private string m_DeviceName = "";
        public string DeviceName
        {
            get { return m_DeviceName; }
            set { m_DeviceName = value; }
        }
        private bool m_bInit = true;
        private bool m_InnerConnected = false;
        private string m_IpOrComPort = "";
        private int m_PortOrBaud = 0;
        private System.IO.Ports.SerialPort m_Srial = null;
        private System.Net.Sockets.Socket m_TCP = null;
        private ZebraUSB m_USB = null;
        public PrtConnectMethodEnum m_PrtConnectMethod = PrtConnectMethodEnum.Serial;
        private Encoding m_Encode = Encoding.ASCII;

        public Encoding Encode
        {
            get { return m_Encode; }
            set { m_Encode = value; }
        }

        public enum PrtConnectMethodEnum
        {
            Serial,
            TCP,
            USB
        }

        public PrtConnectMethodEnum PrtConnectMethod
        {
            get { return m_PrtConnectMethod; }
            set { m_PrtConnectMethod = value; }
        }
        public BasePrt()
        {
            InitializeComponent();
        }

        public BasePrt(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        private bool OpenSerial(int port, int baudRate, out string errMsg)
        {
            errMsg = "";
            if (m_PrtConnectMethod != PrtConnectMethodEnum.Serial)
            {
                throw new Exception("Connection method of printer is not Serial Port");
            }
            if (port == 0)
            {
                return true;
            }

            try
            {
                if (m_Srial == null)
                {
                    m_Srial = new System.IO.Ports.SerialPort();
                }
                if (m_Srial.IsOpen == true)
                {
                    m_Srial.Close();
                }

                m_Srial.ReadBufferSize = 4096 * 2;
                m_Srial.WriteBufferSize = 4096 * 2;

                m_Srial.Encoding = m_Encode;

                m_Srial.PortName = "COM" + port.ToString();
                m_Srial.BaudRate = baudRate;
                m_Srial.Parity = System.IO.Ports.Parity.None;
                m_Srial.DataBits = 8;
                m_Srial.StopBits = System.IO.Ports.StopBits.One;

                m_Srial.Open();
                return true;
            }
            catch (Exception ex)
            {
                errMsg = "[" + m_Srial.PortName + "][" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + ex.Message;
                return false;
            }
        }
        private bool IsIPAddress(string val)
        {
            string[] spData = val.Split('.');

            if(spData.Length >=4)
            { 
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /// <summary>
        /// Printer Open
        /// </summary>
        /// <param name="param">Keys:IP_OR_COMPORT, PORT_OR_BAUDRATE</param>
        /// <returns></returns>
        public bool OpenDevice(Dictionary<string, object> param)
        {
            string error = "";
            string val = "";
            if (param.Keys.Contains("IP_OR_COMPORT"))
            {
                val = param["IP_OR_COMPORT"].ToString();
                if(IsIPAddress(val))
                {
                    int port = 9100;
                    if (param.Keys.Contains("PORT_OR_BAUDRATE"))
                    {
                        port = Convert.ToInt32(param["PORT_OR_BAUDRATE"]);
                    }
                    m_PrtConnectMethod = PrtConnectMethodEnum.Serial;
                    return OpenDevice(val, port, out error);
                }
                else
                {
                    int baudrate = 9600;
                    if (param.Keys.Contains("PORT_OR_BAUDRATE"))
                    {
                        baudrate = Convert.ToInt32(param["PORT_OR_BAUDRATE"]);
                    }

                    m_PrtConnectMethod = PrtConnectMethodEnum.TCP;
                    return OpenDevice(Convert.ToInt32(val), baudrate, out error);
                }
                
            }
            else
            {
                throw new Exception("OpenDevice - Parameter Error");
            }
        }
        public bool OpenDevice(int port, ref string errMsg)
        {
            return OpenSerial(port, 9600, out errMsg);
        }
        private void thAutoReply(object arg)
        {

            try
            {
                do
                {
                    string errMsg = "";
                    try
                    {


                        if (m_TCP != null && m_TCP.Connected)
                        {
                            Write("TEST");
                        }
                        else if (m_TCP == null || (m_TCP != null && m_TCP.Connected == false))
                        {
                            System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]Barcode Printer is Disconnected(" + m_IpOrComPort + ":" + m_PortOrBaud + ")");
                            m_InnerConnected = false;
                        }
                    }
                    catch (Exception innerEX)
                    {
                        System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/INNER]" + innerEX.Message.ToString());
                        m_InnerConnected = false;
                    }

                    if (m_InnerConnected == false)
                    {
                        OpenDevice(m_IpOrComPort, m_PortOrBaud, out errMsg);
                    }
                    System.Threading.Thread.Sleep(10000);
                } while (true);
            }
            catch (Exception eLog)
            {

                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message.ToString());
            }
            finally
            {

            }
        }
        public bool OpenDevice(int port, int baudRate, out string errMsg)
        {
            return OpenSerial(port, baudRate, out errMsg);
        }
        public void Write(string data)
        {
            
            try
            {
                if (IsConnected() == false)
                {
                    throw new Exception("Printer Connection Error");
                }
                if (m_PrtConnectMethod == PrtConnectMethodEnum.Serial)
                {
                    m_Srial.Write(data);
                }
                else if (m_PrtConnectMethod == PrtConnectMethodEnum.TCP)
                {
                    try
                    {
                        m_TCP.Send(m_Encode.GetBytes(data));
                    }
                    catch (Exception innerSoeck)
                    {
                        CloseDevice();
                        string error = innerSoeck.Message;
                        OpenDevice(m_IpOrComPort, m_PortOrBaud, out error);
                    }
                }
                else if (m_PrtConnectMethod == PrtConnectMethodEnum.USB)
                {
                    m_USB.SendBytesToPrinter(data);
                }

            }
            catch (Exception eLog)
            {
                throw new Exception("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message.ToString());
            }
        }
        public bool OpenUSB(string usbDriverName)
        {
            m_IpOrComPort = usbDriverName;
            m_USB = new ZebraUSB();

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("PRINT_NAME", usbDriverName);
            m_USB.OpenDevice(param);
            return true;
        }

        public bool OpenDevice(string ip, int port, out string errMsg)
        {
            m_IpOrComPort = ip;
            m_PortOrBaud = port;
            m_PrtConnectMethod = PrtConnectMethodEnum.TCP;

            errMsg = "";
            try
            {



                m_TCP = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);
                m_TCP.SetSocketOption(System.Net.Sockets.SocketOptionLevel.Socket, System.Net.Sockets.SocketOptionName.DontLinger, false);

                var result = m_TCP.BeginConnect(ip, port, null, null);

                var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));


                m_InnerConnected = success;
                return success;
            }
            catch (Exception ex)
            {
                errMsg = "[" + ip + "][" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + ex.Message;
                return false;
            }
            finally
            {
                if (m_bInit)
                {
                    System.Threading.ThreadPool.QueueUserWorkItem(thAutoReply);
                    m_bInit = false;
                }
            }
        }



        public bool IsConnected()
        {
            if (m_PrtConnectMethod == PrtConnectMethodEnum.Serial)
            {
                return m_Srial.IsOpen;
            }
            else if (m_PrtConnectMethod == PrtConnectMethodEnum.TCP)
            {
                return m_InnerConnected;
            }
            else if (m_PrtConnectMethod == PrtConnectMethodEnum.USB)
            {
                return true;
            }
            return false;
        }

        public bool CloseDevice()
        {
            bool ret = false;
            if (m_PrtConnectMethod == PrtConnectMethodEnum.Serial)
            {
                m_Srial.Close();
                ret = true;
            }
            else if (m_PrtConnectMethod == PrtConnectMethodEnum.TCP)
            {
                m_TCP.Close();
                ret = true;
            }
            else if (m_PrtConnectMethod == PrtConnectMethodEnum.USB)
            {
                ret = m_USB.CloseDevice();
            }
            return ret;
        }

    }
}