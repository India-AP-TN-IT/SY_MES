using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.FX.PLC
{
    public partial class SimplePlcUI : UserControl
    {
        public delegate void PlcSeqSignal(object sender, int pos, bool bVal, SY_MES.FX.PLC.Base.Common.PLC_DeviceArray[] currentBuffer);
        [Category(Base.Common.CN_CATEGORY_APP)]
        public event PlcSeqSignal OnPlcSeqSignal;
        private PLC_MonitorFrm m_MCViewer = null;
        
        private string m_Title = "PLC";
        public string Title
        {
            get { return m_Title; }
            set 
            { 
                m_Title = value;
                lblMain.Text = value;
            }
        }
        public enum StateEnum
        {
            Wait,
            Running,
            Disconnect

        }
        private PLCHelper m_PLC;
        private Dictionary<string, string> m_PlcParam;
        public SimplePlcUI()
        {
            InitializeComponent();
        }
        public void Start(Dictionary<string, string> param)
        {
            m_PlcParam = param;
            m_PLC = new PLCHelper(this, m_PlcParam);
            m_PLC.Start();
            if (m_PLC.IsConnected)
            {
                State(StateEnum.Running);
            }
            else
            {
                State(StateEnum.Disconnect);
            }
            m_PLC.OnPlcSeqSignal += OnPLCSignal;
        }

        private void OnPLCSignal(object sender, int pos, bool bVal, Base.Common.PLC_DeviceArray[] currentBuffer)
        {
            if(OnPlcSeqSignal!=null)
            {
                OnPlcSeqSignal(sender, pos, bVal, currentBuffer);
            }

            if (m_MCViewer != null && m_MCViewer.Visible)
            {
                m_MCViewer.MonitorPLC(pos, bVal);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            State(StateEnum.Wait);
        }
        private void State(StateEnum state)
        {
            switch(state)
            {
                case StateEnum.Wait:
                    lblMain.BackColor = Color.Yellow;
                    lblMain.ForeColor = Color.Blue;
                    lblState.BackColor = Color.Yellow;
                    lblState.ForeColor = Color.Blue;
                    tableLayoutPanel1.BackColor = Color.Yellow;
                    lblState.Text = "WAIT";
                    break;
                case StateEnum.Running:
                    lblMain.BackColor = Color.Lime;
                    lblMain.ForeColor = Color.Black;
                    lblState.BackColor = Color.Lime;
                    lblState.ForeColor = Color.Black;
                    tableLayoutPanel1.BackColor = Color.Lime;
                    lblState.Text = "RUN";
                    break;
                case StateEnum.Disconnect:
                    lblMain.BackColor = Color.Red;
                    lblMain.ForeColor = Color.White;
                    lblState.BackColor = Color.Red;
                    lblState.ForeColor = Color.White;
                    tableLayoutPanel1.BackColor = Color.Red;
                    lblState.Text = "STOP";
                    break;
            }
        }
        public string GetVars(string key)
        {
            if (m_PlcParam.ContainsKey(key))
            {
                return m_PlcParam[key];
            }
            return string.Empty;
        }
        private void lblMain_DoubleClick(object sender, EventArgs e)
        {
            if (ParentForm != null && m_PLC!=null && m_PLC.IsConnected)
            {
                string baseVar = GetVars("@PLCBASEADDR");
                if (m_MCViewer != null && m_MCViewer.Visible)
                {
                    return;
                }
                if (m_MCViewer == null || m_MCViewer.IsDisposed)
                {
                    m_MCViewer = new PLC_MonitorFrm();
                }
                m_MCViewer.SetPLCParam(m_PlcParam, ref m_PLC);
                m_MCViewer.Show();
                
                m_MCViewer.Icon = ParentForm.Icon;
                m_MCViewer.TopMost = true;
                m_MCViewer.BringToFront();
                int blSize = Convert.ToInt16(GetVars("@BLOCK_SIZE"));
                
                for(int row=0;row<blSize;row++)
                {
                    for(int i=0;i<16;i++)
                    {
                        m_MCViewer.MonitorPLC(16*row + i, m_PLC.CurrentBuffer[row].iBitValue[i] == 0 ? false : true);                        
                    }
                }
            }
        }
    }
}
