using SY_MES.FX.Controls.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SY_MES.FX.Controls
{
    public partial class YButton : Button, Base.IYControls
    {
        public enum ButtonStyleEnum
        {
            None,
            Blue,
            Red,
            Yellow,
            Lime,
            Combo
        }
        private ButtonStyleEnum m_ButtonStyle = ButtonStyleEnum.None;
        public YButton()
        {
            InitializeComponent();
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.AutoSize = false;
        }
        private void SetStyle(ButtonStyleEnum st)
        {
            switch (st)
            {
                case ButtonStyleEnum.None:
                    this.FlatStyle = FlatStyle.Standard;
                    this.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.ForeColor = Color.Black;
                    break;
                case ButtonStyleEnum.Blue:
                    this.FlatStyle = FlatStyle.Popup;
                    this.BackColor = Color.Blue;
                    this.ForeColor = Color.White;
                    break;
                case ButtonStyleEnum.Red:
                    this.FlatStyle = FlatStyle.Popup;
                    this.BackColor = Color.Red;
                    this.ForeColor = Color.White;
                    break;
                case ButtonStyleEnum.Yellow:
                    this.FlatStyle = FlatStyle.Popup;
                    this.BackColor = Color.Yellow;
                    this.ForeColor = Color.Black;
                    break;
                case ButtonStyleEnum.Lime:
                    this.FlatStyle = FlatStyle.Popup;
                    this.BackColor = Color.Lime;
                    this.ForeColor = Color.Black;
                    break;
                case ButtonStyleEnum.Combo:
                    this.FlatStyle = FlatStyle.Popup;
                    this.BackColor = Color.FromArgb(128, 128, 255);
                    this.ForeColor = Color.Black;
                    break;
            }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public ButtonStyleEnum ButtonStyle
        {
            get
            {
                return m_ButtonStyle;
            }
            set
            {
                m_ButtonStyle = value;
                SetStyle(m_ButtonStyle);
            }
        }

        private string m_Key = "";
        [Category(Common.CN_CATEGORY_APP)]
        public string Key
        { get
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
        public void ClearValue()
        {
            
        }

        public object GetValue()
        {
            return this.Text;
        }

        public void RefreshCtl()
        {
            
        }

        public void SetValue(object val)
        {
            this.Text = val.ToString();
        }
    }
}
