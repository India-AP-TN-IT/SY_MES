using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY_MES.FX.Devices
{
    public partial class UDio : Component, System.Windows.Forms.IMessageFilter, FX.Devices.Base.IDevice
    {
        private string m_DeivceName = "UDIO";
        public delegate void PushButton(System.Windows.Forms.Message m);
        [Category(SY_MES.FX.Devices.Base.Common.CN_CATEGORY_APP)]
        public event PushButton OnPushButton = null;
        private System.Windows.Forms.Form m_BaseFrm = null;
        private int m_DelaySecond = 2;
        [Category(SY_MES.FX.Devices.Base.Common.CN_CATEGORY_APP)]
        public int PID
        {
            get { return m_PID; }
            set { m_PID = value; }
        }
        public struct USB_INPUT     // UIO 입력 패킷으로부터 데이타를 얻기 위한 구조체 
        {
            public int ProductID;   // 장치 ID 
            public Byte Status;     // 패킷 수신 상태값  0=입력 변화에 의한 수신, 1=데이타 재전송 요구에 의한 수신 
            public Byte Button;     // 입력 버턴값
            public Byte Output;     // USB 장치의 입출력 상태값
            public Byte Mask;       // 포트의 입출력 설정값. bit값이 '0'이면 출력, '1'이면 입력
        };
        public const int WM_CREATE = 1;
        public const int WM_INPUT = 255;
        public const int WM_WM_DEVICECHANGE = 537;
        private DateTime m_LastInTime = DateTime.Now;
        [Category(SY_MES.FX.Devices.Base.Common.CN_CATEGORY_APP)]
        public int DelaySecond
        {
            get { return m_DelaySecond; }
            set { m_DelaySecond = value; }
        }
        public struct OutArgsST
        {
            public int outPort;
            public int delaySec;
        };
        [Category(SY_MES.FX.Devices.Base.Common.CN_CATEGORY_APP)]
        public System.Windows.Forms.Form BaseFrm
        {
            set { m_BaseFrm = value; }
            get { return m_BaseFrm; }
        }
        private int m_PID = 281;
        private int m_BtnUID = 15;
        [Category(SY_MES.FX.Devices.Base.Common.CN_CATEGORY_APP)]
        public int BtnUID
        {
            get { return m_BtnUID; }
            set { m_BtnUID = value; }
        }
        public UDio()
        {
            InitializeComponent();
        }

        public UDio(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("CLIB/uio64.dll")]
        public static extern void get_usb_input(int lParam, ref USB_INPUT uInput);
        [System.Runtime.InteropServices.DllImport("CLIB/uio64.dll")]
        public static extern void set_usb_events(int hWnd);
        [System.Runtime.InteropServices.DllImport("CLIB/uio64.dll")]
        public static extern bool usb_io_output(int pID, int cmd, int io1, int io2, int io3, int io4);
        [System.Runtime.InteropServices.DllImport("CLIB/uio64.dll")]
        public static extern int usb_io_init(int pID);
        [System.Runtime.InteropServices.DllImport("CLIB/uio64.dll")]
        private static extern bool usb_io_reset(int pID);

        public bool PreFilterMessage(ref System.Windows.Forms.Message m)
        {
            switch (m.Msg)
            {


                case WM_INPUT:              // USB로부터 입력 패킷이 수신 되었을 때 발생하는 이벤트 
                    if (OnPushButton != null)
                    {
                        USB_INPUT uInput = new USB_INPUT();
                        get_usb_input((int)m.LParam, ref uInput);
                        TimeSpan span = DateTime.Now - m_LastInTime;
                        if (span.TotalSeconds > DelaySecond)
                        {
                            if (uInput.ProductID == Convert.ToInt32(PID.ToString(), 16) && uInput.Button == BtnUID && uInput.Status == 0 && uInput.Output == 0)
                            {
                                OnPushButton(m);
                                m_LastInTime = DateTime.Now;
                            }
                        }
                    }
                    break;


            }
            return false;
        }
        System.Threading.Thread m_thOut = null;
        bool m_bThOut = false;

        public bool DioOut(int outPort = 4, int delaySec = 3)
        {
            return DioOut(outPort, delaySec, 0, 0);
        }
        public bool DioOut(int outPort = 4, int delaySec = 3, int blink_on = 0, int blink_off = 0)
        {
            bool bRet = false;
            int blink = 0;
            try
            {
                blink = blink_on * 16;
                blink += blink_off;
                bRet = usb_io_output(Convert.ToInt32(PID.ToString(), 16), blink, outPort, 0, 0, 0);
                if (!m_bThOut)
                {
                    OutArgsST arg = new OutArgsST();
                    arg.delaySec = delaySec;
                    arg.outPort = outPort;
                    m_bThOut = true;
                    m_thOut = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(OffOutput));
                    m_thOut.Start(arg);
                }
                return bRet;
            }
            catch
            {
                return false;
            }
        }
        private void OffOutput(object args)
        {
            if (args is OutArgsST)
            {
                System.Threading.Thread.Sleep(((OutArgsST)args).delaySec * 1000);
                //usb_io_output(Convert.ToInt32(PID.ToString(), 16), 0, ((OutArgsST)args).outPort * -1, 0, 0, 0);
                usb_io_reset(Convert.ToInt32(PID.ToString(), 16));  //출력 전체 Reset으로 출력되는 신호 ALL OFF
                m_bThOut = false;
            }
        }
        [Category(SY_MES.FX.Devices.Base.Common.CN_CATEGORY_APP)]
        public string DeviceName
        {
            get
            {
                return m_DeivceName;
            }
            set
            {
                m_DeivceName = value;
            }
        }

        public bool OpenDevice(Dictionary<string, object> param)
        {

            if(param.ContainsKey("PBASE"))
            {
                this.BaseFrm = (System.Windows.Forms.Form)param["PBASE"];
                System.Windows.Forms.Application.AddMessageFilter(this);
                FX.Devices.UDio.set_usb_events(BaseFrm.Handle.ToInt32());
            }
            else
            {
                throw new Exception("PBase is not defined!");
            }
            if(param.ContainsKey("PID"))
            {
                this.PID = Convert.ToInt32(param["PID"].ToString());
            }
            if (param.ContainsKey("BID"))
            {
                this.m_BtnUID = Convert.ToInt32(param["BID"].ToString());
            }
            return true;
        }

        public bool IsConnected()
        {
            return true;
        }

        public bool CloseDevice()
        {
            return true;
        }
    }
}
