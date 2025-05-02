using SY_MES.FX.Controls;
using SY_MES.Logics.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.Logics.MES.Sub
{
    [ToolboxItem(true)]
    public partial class InspectionBC :  Base.LocalizedContainer
    {
        
        private bool m_RsltBtnVisible = true;
        [Category(Base.Common.CN_CATEGORY_APP)]
        public bool RsltBtnVisible
        {
            get { return m_RsltBtnVisible; }
            set
            { 
                m_RsltBtnVisible = value;
                panel1.Visible = value;
                if (value == false)
                {
                    Lbl_RSLT.Height = 115 + panel1.Height;
                    Lbl_RSLT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                        | AnchorStyles.Left | AnchorStyles.Right;
                }
                else
                {
                    Lbl_RSLT.Height = 115 ;
                    Lbl_RSLT.Anchor = AnchorStyles.Top
                        | AnchorStyles.Left | AnchorStyles.Right;
                }
            }
        }
        private bool m_InspectFactorsVisible = true;
        [Category(Base.Common.CN_CATEGORY_APP)]
        public bool FactorsVisible
        {
            get { return m_InspectFactorsVisible; }
            set
            {
                m_InspectFactorsVisible = value;


                if (m_InspectFactorsVisible == false)
                {
                    panel2.Visible = false;
                    yTableLayout1.Location = panel2.Location;
                    
                }
                else
                {
                    panel2.Visible = true;
                    yTableLayout1.Location = new Point(yTableLayout1.Location.X, panel2.Location.Y + panel2.Size.Height+2);

                }

                
            }
        }
        private List<string> m_Factors;
        public InspectionBC()
        {
            InitializeComponent();
        }
        protected override void InitControls()
        {
            base.InitControls();
            Lbl_RSLT.Visible = false;
            Lbl_RSLT.Text = "";
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode == false)
            {
                InitInspectionFactors();
            }
        }
        private void InitInspectionFactors()
        {
            string iniForInspection = GetINI("INSPECTION/INSPECT_LIST").Replace(" ","");
            string[] facotrs = iniForInspection.Split(',');
            Pan_InspectionFact.Controls.Clear();
            m_Factors = new List<string>();
            m_Factors.Clear();
            if (facotrs.Length > 0)
            {
                for (int i = 0; i < facotrs.Length; i++)
                {
                    YBitLabel ctl = new YBitLabel();
                    ctl.Width = 120;
                    ctl.Height = 65;
                    ctl.Margin = new Padding(5, 5, 5, 5);
                    ctl.OffBGColor = Color.Red;
                    ctl.OffForeColor = Color.White;
                    ctl.OnBGColor = Color.Lime;
                    ctl.OnForeColor = Color.Black;
                    if (facotrs[i].Contains("@"))
                    {
                        string title = facotrs[i].Split('@')[0];
                        string col = facotrs[i].Split('@')[1];
                        m_Factors.Add(col);
                        if (string.IsNullOrEmpty(title) == false)
                        {
                            ctl.Desc = title;
                            ctl.Key = col;
                            ctl.DoubleClick += Ctl_DoubleClick;
                            this.Pan_InspectionFact.Controls.Add(ctl);
                        }
                    }
                }
            }
        }
        
        public override void LoadData()
        {
            base.LoadData();
            string lotno = Common.GetProductInfor("LOTNO");
            string chkFNL = Common.GetProductInfor("CHK_FNL");
            if(string.IsNullOrEmpty(lotno) == false)
            {
                Lbl_RSLT.Visible = false;
               
                switch (chkFNL)
                {
                    case "IC":
                        Lbl_RSLT.Visible = true;
                        Lbl_RSLT.SetValue("OK");
                        Lbl_RSLT.Desc = "OK";
                        break;
                    case "IF":
                        Lbl_RSLT.Visible = true;
                        Lbl_RSLT.SetValue("NG");
                        Lbl_RSLT.Desc = "NG";
                        break;

                }
               
                
                foreach (string factor in m_Factors)
                {
                    string val = Common.GetProductInfor(factor);
                    
                    GetFactor(factor).SetValue(val);


                }
                
            }
        }
        private bool ValidInsRslt(bool bOK)
        {
            bool bRslt = true;
            if(bOK)
            {
                if(GetInspectioFactorRslt() == false)
                {
                    bRslt = false;
                    StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, "This lot has inspection error!!", System.Reflection.MethodBase.GetCurrentMethod().Name, true);
                }
                
            }

            return bRslt;
        }
        public void SetData(bool bOK)
        {
            Lbl_RSLT.Visible = false;
            string lotno = Common.GetProductInfor("LOTNO");
            if(string.IsNullOrEmpty(lotno))
            {
                StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Error, "Empty Lot is not allowed!!", System.Reflection.MethodBase.GetCurrentMethod().Name, true);
                return;
            }
            if (ValidInsRslt(bOK) == true)
            {
                string rslt = "NG";
                string chkFNL = "IF";
                if (bOK)
                {
                    rslt = "OK";
                    chkFNL = "IC";
                }
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("IN_CORCD", BaseINF.CORCD);
                param.Add("IN_BIZCD", BaseINF.BIZCD);
                param.Add("IN_LOTNO", lotno);
                param.Add("IN_CHK_FNL", chkFNL);
                ExecuteNonQuery("MES.PKG_ME_INSPECTION.SET_CHK_FNL", param);
                Lbl_RSLT.SetValue(rslt);
                Lbl_RSLT.Desc = rslt;
                Lbl_RSLT.Visible = true;
                if (rslt == "OK")
                {
                    StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Alarm, "[" + lotno + "] Saved - OK");
                    WorkState(FX.MainForm.Base.Common.WorkStateEnum.OK_Complete);
                }
                else
                {
                    StatusBarMsg(FX.MainForm.Base.Common.MsgTypeEnum.Warnning, "[" + lotno + "] Saved - NG");
                    WorkState(FX.MainForm.Base.Common.WorkStateEnum.NG_Complete);

                }
            }
        }
        private bool Exists(string[] vals, string key)
        {
            if (vals.Length ==0)
            {
                if(string.IsNullOrEmpty(vals[0]))
                {
                    return false;
                }
            }
            foreach(string val in vals)
            {
                if(key == val)
                {
                    return true;
                }
            }
            return false;
        }
        public bool GetInspectioFactorRslt(string except="")
        {
            string[] excepts = except.Split(',');
            foreach (string factor in m_Factors)
            {
                string val = Common.GetProductInfor(factor);
                if (Exists(excepts, factor) == false)
                {
                    if (((bool)GetFactor(factor).GetValue()) == false)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void SetFactor(string key, bool bRslt)
        {
            GetFactor(key).SetValue(bRslt);
        }
        private YBitLabel GetFactor(string key)
        {
            foreach(Control ctl in Pan_InspectionFact.Controls)
            {
                if(ctl is YBitLabel)
                {
                    if(((YBitLabel)ctl).Key == key)
                    {
                        return (YBitLabel)ctl;
                    }
                }
            }
            return null;
        }
        private void Ctl_DoubleClick(object sender, EventArgs e)
        {
            if(sender is YBitLabel)
            {
                string lotno = Base.Common.GetProductInfor("LOTNO");
                if(string.IsNullOrEmpty(lotno))
                {
                    return;
                }
                FX.MainForm.BaseDialog dlg = null;
                switch(((YBitLabel)sender).Key)
                {
                    case "CHK_DIFF":
                        dlg = new FX.MainForm.BaseDialog("Part Check List", new Sub.SpecCheckHistBC(), this.PBaseFrm, FormWindowState.Normal);
                        break;
                    case "CHK_ELEC":
                        dlg = new FX.MainForm.BaseDialog("Functional Test List", new Sub.FTHistBC(), this.PBaseFrm, FormWindowState.Normal);
                        break;
                    case "CHK_VISION":
                        dlg = new FX.MainForm.BaseDialog("Vision Inspection Result", new Sub.VisionInspectionBC(), this.PBaseFrm, FormWindowState.Maximized);
                        break;
                }
                if(dlg != null)
                {
                   
                    dlg.Show();
                    dlg.BringToFront();
                }
                
            }
        }

        private void CmdRun(object sender, EventArgs e)
        {
            if(sender is YButton)
            {
                if(((YButton)sender).Key == "OK")
                {
                    SetData(true);
                }
                else if (((YButton)sender).Key == "NG")
                {
                    SetData(false);
                }
            }
        }
    }
}
