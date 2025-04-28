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
    public partial class YLabel :Label, FX.Controls.Base.IYControls
    {
        private string m_Key = "";
        public const float CN_LABEL_DEFAULT_FONT_SIZE = 12;
        public const float CN_LABEL_EMPHASIS_FONT_SIZE = 15;
        public YLabel()
        {
            InitializeComponent();
        }
        private bool m_EditStyle = false;
        [Category(Common.CN_CATEGORY_APP)]
        public bool EditStyle
        {
            get { return m_EditStyle; }
            set { m_EditStyle = value; }
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            
            this.TextAlign = ContentAlignment.MiddleCenter;
            
            LabelDisStyle = LableStyleEnum.NomalLabel;

            this.AutoSize = false;
        }
        public enum LableStyleEnum
        {
            NomalLabel,
            TextLabel,
            ContentsEmphasis
        }

        private LableStyleEnum m_LabelDisStyle = LableStyleEnum.NomalLabel;

        [Category(Common.CN_CATEGORY_APP)]
        public LableStyleEnum LabelDisStyle
        {
            get { return m_LabelDisStyle; }
            set 
            { 
                m_LabelDisStyle = value;
                SetStyle(value);
            }
        }
        private void SetStyle(LableStyleEnum st)
        {
            if(EditStyle ==true)
            {
                return;
            }
            switch (st)
            {
                case LableStyleEnum.NomalLabel:
                    if (!EditStyle)
                    {
                        BackColor = Color.Gainsboro;
                    }
                    this.Font = new Font(Font.FontFamily, CN_LABEL_DEFAULT_FONT_SIZE, FontStyle.Bold);
                    this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    break;
                case LableStyleEnum.TextLabel:
                    if (!EditStyle)
                    {
                        BackColor = Color.LightSteelBlue;
                    }
                    this.Font = new Font(Font.FontFamily, CN_LABEL_DEFAULT_FONT_SIZE, FontStyle.Bold);
                    this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    break;
                case LableStyleEnum.ContentsEmphasis:
                    if (!EditStyle)
                    {
                        BackColor = Color.PeachPuff;
                    }
                    this.Font = new Font(Font.FontFamily, CN_LABEL_EMPHASIS_FONT_SIZE, FontStyle.Bold);
                    this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    break;
            }
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
            get { return this.Text; }
            set { this.Text = value; }
        }
        public void SetValue(object val)
        {
            this.Text = Convert.ToString(val);
        }

        public object GetValue()
        {
            return Text;
        }

        public void ClearValue()
        {
            this.Text = "";
        }

        public void RefreshCtl()
        {

        }
    }
}
