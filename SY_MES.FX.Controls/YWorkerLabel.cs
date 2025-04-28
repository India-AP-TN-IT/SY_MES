using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SY_MES.FX.Controls.Base;

namespace SY_MES.FX.Controls
{
    public partial class YWorkerLabel : UserControl, Base.IYControls
    {
        public delegate void EmpnoChanged(object sender, string code, string desc);
        [Category(Common.CN_CATEGORY_APP)]
        public event SY_MES.FX.Controls.YTextBox.CloseKeyboard OnCloseKeyboard = null;
        private float m_TitleSize = 30F;
        private float m_EmpnoSize = 30F;
        private float m_EmpnmSize = 40F;
        
        [Category(Common.CN_CATEGORY_APP)]
        public event EmpnoChanged OnEmpnoChanged = null;
        private SY_MES.FX.Controls.YTextBox.TouchKeyPosEnum m_TouchKeyPos = SY_MES.FX.Controls.YTextBox.TouchKeyPosEnum.Down;
        private SY_MES.FX.Controls.TouchKeyboard.KeyModeEnum m_KeyMode = SY_MES.FX.Controls.TouchKeyboard.KeyModeEnum.Number;
        [Category(Common.CN_CATEGORY_APP)]
        public SY_MES.FX.Controls.TouchKeyboard.KeyModeEnum KeyMode
        {
            get { return m_KeyMode; }
            set 
            { 
                m_KeyMode = value;
                this.Txt_EMP.KeyMode = value;
            }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public string Title
        {
            get { return Lbl_Title.Text; }
            set
            {
                Lbl_Title.Text = value;
            }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public int MaxEmpLength
        {
            get
            {
                return Txt_EMP.MaxLength;
            }
            set
            {
                Txt_EMP.MaxLength = value;
            }

        }
        [Category(Common.CN_CATEGORY_APP)]
        public SY_MES.FX.Controls.YTextBox.TouchKeyPosEnum TouchKeyPos
        {
            get { return m_TouchKeyPos; }
            set 
            { 
                m_TouchKeyPos = value;
                this.Txt_EMP.TouchKeyPos = value;
            }

        }
        [Category(Common.CN_CATEGORY_APP)]
        public float TitleSizePercent
        {
            get
            {
                return m_TitleSize; 
                
            }
            set
            {
                m_TitleSize = value;
                if (yTableLayout1.ColumnCount >= 1)
                {
                    yTableLayout1.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, m_TitleSize);
                }
            }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public float EmpnoSizePercent
        {
            get
            {
                return m_EmpnoSize;

            }
            set
            {
                m_EmpnoSize = value;
                if (yTableLayout1.ColumnCount >= 2)
                {
                    yTableLayout1.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, m_EmpnoSize);
                }
            }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public float EmpnmSizePercent
        {
            get
            {
                return m_EmpnmSize;

            }
            set
            {
                m_EmpnmSize = value;
                if (yTableLayout1.ColumnCount >= 3)
                {
                    yTableLayout1.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, m_EmpnmSize);
                }
            }
        }
        private string m_Key = "";
        public YWorkerLabel()
        {
            InitializeComponent();
        }
        [Category(Common.CN_CATEGORY_APP)]
        public string Key
        {
            get
            {
                return m_Key;
            }
            set
            {
                m_Key = value;
            }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public string Desc
        {
            get
            {
                return this.lbl_DESC.Text;
            }
            set
            {
                this.lbl_DESC.Text = value;
            }
        }
        public void SetValue(object val)
        {
            this.Txt_EMP.Text = val.ToString();
        }
        public object GetValue()
        {
            return this.Txt_EMP.Text;
        }
        public void ClearValue()
        {
            this.lbl_DESC.Text = "";
            this.Txt_EMP.Text = "";
        }
        
        public void RefreshCtl()
        {
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            ClearValue();
        }

        private void Txt_EMP_OnCloseKeyboard(object sender, object args)
        {
            if (OnCloseKeyboard != null)
            {
                OnCloseKeyboard(sender, args);
            }
        }

        private void Txt_EMP_TextChanged(object sender, EventArgs e)
        {
            if(OnEmpnoChanged!=null && Txt_EMP.Text.Length == Txt_EMP.MaxLength)
            {
                OnEmpnoChanged(this, Txt_EMP.Text, lbl_DESC.Text);
            }
        }
    }
}
