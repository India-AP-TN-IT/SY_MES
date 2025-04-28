using SY_MES.FX.Controls;
using SY_MES.FX.Controls.Base;
using SY_MES.FX.Devices.Printer;
using SY_MES.Logics.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.Logics.MES.Sub
{
    public partial class ReworkBomUC : LocalUC
    {
        private YLabel lblWhoRel;
        public struct ReworkDataST
        {
            public string partno;
            public string partnm;
            public string qty;
            public bool chk;
            public string defectType;
            public string reworkType;
            public string whoRel;
        }
        private ReworkDataST m_ReworkData;
        public ReworkDataST ReworkData
        {
            get { return m_ReworkData; }
            set
            {
                m_ReworkData = value;
                
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DispData();
        }
        private void DispData()
        {
            if (DesignMode == false)
            {
                ChkPartNO.Text = "["+m_ReworkData.partno+"] "+m_ReworkData.partnm;
                txtQTY.Text = m_ReworkData.qty;
                ChkCondition();
            }
        } 
        public ReworkBomUC()
        {
            InitializeComponent();
        }
        protected override void InitControls()
        {
            base.InitControls();
            lblDefType.Text = "";
            lblRewMe.Text = "";
            lblWhoRel = new YLabel();
            Btn_Who.Text = "";
        }

        private void Combo_Click(object sender, EventArgs e)
        {
            if (sender is FX.Controls.YButton)
            {
                switch (((FX.Controls.YButton)sender).Key)
                {
                    case "DEF_TYPE":
                        ParentBC.ShowCodeSelectDlg(Base.CodeSelectBC.CodeListEnum.REWORK_DEF_TYPE, (IYControls)lblDefType);
                        m_ReworkData.defectType = lblDefType.Key;
                        break;
                    case "METHOD":
                        ParentBC.ShowCodeSelectDlg(Base.CodeSelectBC.CodeListEnum.REWORK_METHOD, (IYControls)lblRewMe);
                        m_ReworkData.reworkType = lblRewMe.Key;
                        break;
                    case "WREL":
                        ParentBC.ShowCodeSelectDlg(Base.CodeSelectBC.CodeListEnum.WHO_RESPONSIBILITY, (IYControls)lblWhoRel);
                        m_ReworkData.whoRel = lblWhoRel.Key;
                        
                        if (sender is IYControls)
                        {
                            if (string.IsNullOrEmpty(lblWhoRel.Text) == false)
                            {
                                ((IYControls)sender).Desc = lblWhoRel.Text.Substring(0, 1);
                            }
                            else
                            {
                                ((IYControls)sender).Desc = "";
                            }
                        }
                        break;
                }
            }
        }
        private void ChkCondition()
        {
            if (ChkPartNO.Checked)
            {
                ChkPartNO.BackColor = Color.Lime;
                ChkPartNO.ForeColor = Color.Black;

                CtlEnable(true);
                m_ReworkData.chk = true;
            }
            else
            {
                ChkPartNO.BackColor = Color.Silver;
                ChkPartNO.ForeColor = Color.Black;

                CtlEnable(false);
                m_ReworkData.chk = false;
            }
        }
        private void CtlEnable(bool enable)
        {
            panel1.Enabled = enable;
            panel2.Enabled = enable;
            panel3.Enabled = enable;
            Btn_Who.Enabled = enable;
        }
        private void ChkPartNO_CheckedChanged(object sender, EventArgs e)
        {
            ChkCondition();
        }

        private void txtQTY_TextChanged(object sender, EventArgs e)
        {
            m_ReworkData.qty = txtQTY.Text;
        }
    }
}
