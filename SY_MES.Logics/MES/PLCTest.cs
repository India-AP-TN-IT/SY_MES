using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.Logics.MES
{
    public partial class PLCTest : Base.LocalizedContainer
    {
        private bool m_PLCAlive = false;
        private FX.PLC.PLCHelper m_PLCHelper;
        private int m_nPLCAliveSEQ = 3;
        private const int CN_TIME_TICK_SEC = 3;
        private DateTime m_timerDT;
        public PLCTest()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            
            base.OnLoad(e);
            if(DesignMode == false)
            {
                this.PBaseFrm.MsgTitle_CTL.Text = "Testing Tool";
                this.PBaseFrm.Line_CTL.Text = "PLC Test";

                SetINISectionForDebug(BaseINF.CORCD, BaseINF.BIZCD, "MCPLC_INFOR"); //Force INI Section Setting for PLC
                label1.Text = GetINI("MCPLC_INFOR/PLCIP");
                string plcType = GetINI("MCPLC_INFOR/PLCTYPE");
                if(plcType == "XGT")
                {
                    radioButton1.Checked = true;
                }
                else if (plcType == "MELSEC")
                {
                    radioButton2.Checked = true;
                }
                else if (plcType == "FINS")
                {
                    radioButton3.Checked = true;
                }
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;

                yBitLabel1.SetValue(true);
                Start_PLC();
                m_timerDT = DateTime.Now;
                TMR_PLC_ALIVE.Start();


                
            }

        }

        private SY_MES.FX.PLC.PLCHelper.PlcTypeEnum GetPLCType()
        {
            SY_MES.FX.PLC.PLCHelper.PlcTypeEnum ret = SY_MES.FX.PLC.PLCHelper.PlcTypeEnum.LS_FENET;
            if(radioButton1.Checked)
            {
                ret = FX.PLC.PLCHelper.PlcTypeEnum.LS_FENET;
            }
            else if(radioButton2.Checked)
            {
                ret = FX.PLC.PLCHelper.PlcTypeEnum.MITSUBISHI_MELSEC_ETHERNET;
            }
            else if(radioButton3.Checked)
            {
                ret = FX.PLC.PLCHelper.PlcTypeEnum.OMRON_FINS_ETHERNET;
            }
            return ret;
        }
        private void Start_PLC()
        {   //How to Set PLC
            
            Dictionary<string, string> plcParam = GetPlcInforFromINI();
            SY_MES.FX.PLC.PLCHelper.PlcTypeEnum plcType = GetPLCType();
            m_PLCHelper = new FX.PLC.PLCHelper(this, plcParam, plcType);
            m_PLCHelper.Start();
            m_PLCHelper.OnPlcSeqSignal += PLC_Signal;


            simplePlcUI1.Start(plcParam);
        }

        void PLC_Signal(object sender, int pos, bool bVal, FX.PLC.Base.Common.PLC_DeviceArray[] currentBuffer)
        {
            
            if(pos == -1)
            {
                yBitLabel1.SetValue(bVal);
            }
            else if (pos == m_nPLCAliveSEQ)
            {
                m_PLCAlive = bVal;
            }
            if(pos >=0 && pos<=17)
            {
                Control[] ctls = FindYCtls(pos.ToString());
                foreach(Control ctl in ctls)
                {
                    if(ctl is SY_MES.FX.Controls.YBitLabel)
                    {
                        ((SY_MES.FX.Controls.YBitLabel)ctl).SetValue(bVal);
                    }
                }

            }
            
        }

        private void TMR_PLC_ALIVE_Tick(object sender, EventArgs e)
        {
            try
            {
                TMR_PLC_ALIVE.Stop();
                if ((DateTime.Now - m_timerDT).TotalSeconds > CN_TIME_TICK_SEC)
                {
                    m_PLCHelper.WriteBit(m_nPLCAliveSEQ, !m_PLCAlive);
                    m_timerDT = DateTime.Now;
                }
                

            }
            catch(Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
            }
            finally
            {
                TMR_PLC_ALIVE.Start();
            }
        }

    }
}
