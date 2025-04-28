using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SY_MES.FX.Controls.Base;

namespace SY_MES.FX.Controls
{
    [ToolboxBitmap(typeof(TextBox))]
    public partial class YTextBox : TextBox, FX.Controls.Base.IYControls
    {
        private string m_Key = "";
        public delegate void CloseKeyboard(object sender, object args);
        public event CloseKeyboard OnCloseKeyboard = null;

        private bool m_UpperString = false;
        [Category(Common.CN_CATEGORY_APP)]
        public bool UpperString
        {
            get { return m_UpperString; }
            set { m_UpperString = value; }
        }

        private bool m_KeyPadModal = true;
        [Category(Common.CN_CATEGORY_APP)]
        public bool KeyPadModal
        {
            get { return m_KeyPadModal; }
            set { m_KeyPadModal = value; }
        }

        private SY_MES.FX.Controls.TouchKeyboard.KeyModeEnum m_KeyMode = SY_MES.FX.Controls.TouchKeyboard.KeyModeEnum.Number;
        [Category(Common.CN_CATEGORY_APP)]
        public SY_MES.FX.Controls.TouchKeyboard.KeyModeEnum KeyMode
        {
            get { return m_KeyMode; }
            set { m_KeyMode = value; }
        }
        public const float CN_TEXT_DEFAULT_FONT_SIZE = 12;
        public enum ClickEnum
        {
            OneClick,
            DoubleClick
        }
        private bool m_UseTouchKeyBoard = false;
        private ClickEnum m_TouchKeyBoardMethod = ClickEnum.DoubleClick;
        public enum TouchKeyPosEnum
        {
            Down
            , Up
        }
        private TouchKeyPosEnum m_TouchKeyPos = TouchKeyPosEnum.Down;
        [Category(Common.CN_CATEGORY_APP)]
        public TouchKeyPosEnum TouchKeyPos
        {
            get { return m_TouchKeyPos; }
            set { m_TouchKeyPos = value; }

        }
        [Category(Common.CN_CATEGORY_APP)]
        public ClickEnum TouchKeyBoardMethod
        {
            get { return m_TouchKeyBoardMethod; }
            set { m_TouchKeyBoardMethod = value; }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public bool UseTouchKeyBoard
        {
            get { return m_UseTouchKeyBoard; }
            set { m_UseTouchKeyBoard = value; }
        }
        public YTextBox()
        {
            InitializeComponent();
            base.MaxLength = 6;
            this.Font = new Font(Font.FontFamily, CN_TEXT_DEFAULT_FONT_SIZE, FontStyle.Bold);
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }
        public void TouchKeyBoardCall()
        {
            if (UseTouchKeyBoard && ReadOnly == false)
            {
                int iX, iY;
                iX = PointToScreen(new Point(0, 0)).X;
                iY = PointToScreen(new Point(0, 0)).Y + this.Height;


                TouchKeyboard oFormKeyboard = null;

                if (TouchKeyPos == TouchKeyPosEnum.Down)
                {
                    oFormKeyboard = new TouchKeyboard(iX, iY, this, base.MaxLength, KeyMode);

                }
                else if (TouchKeyPos == TouchKeyPosEnum.Up)
                {
                    oFormKeyboard = new TouchKeyboard(iX, iY - this.Height - 288, this, base.MaxLength, KeyMode);

                }
                if (oFormKeyboard != null)
                {
                    oFormKeyboard.FormClosed += OFormKeyboard_FormClosed;
                }
                oFormKeyboard.UpperString = UpperString;
                if (KeyPadModal)
                {
                    if (oFormKeyboard.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
                else
                {
                    if (oFormKeyboard.IsExistsForm() == false)
                    {
                        oFormKeyboard.Show();
                        oFormKeyboard.TopMost = true;

                    }
                }

            }
        }

        private void OFormKeyboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (OnCloseKeyboard != null)
            {
                OnCloseKeyboard(sender, e);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (TouchKeyBoardMethod == ClickEnum.OneClick)
            {
                TouchKeyBoardCall();
            }
        }
        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);
            if (TouchKeyBoardMethod == ClickEnum.DoubleClick)
            {
                TouchKeyBoardCall();

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
            this.Clear();
        }

        public void RefreshCtl()
        {
            
        }
    }

}
