
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SY_MES.FX.Controls
{
    public partial class TouchKeyboard : Form
    {

        private bool m_UpperString = false;
        public bool UpperString
        {
            get { return m_UpperString; }
            set { m_UpperString = value; }
        }
        public enum KeyModeEnum
        {
            Number
            , AlphaNumber
        }
        private KeyModeEnum m_KeyMode = KeyModeEnum.Number;
        public KeyModeEnum KeyMode
        {
            get { return m_KeyMode; }
            set
            {
                m_KeyMode = value;
                switch (m_KeyMode)
                {
                    case KeyModeEnum.Number:
                        panel1.Visible = false;
                        this.Width = 312;
                        pnMsg.Location = new Point(3, 5);
                        break;
                    case KeyModeEnum.AlphaNumber:
                        panel1.Visible = true;
                        pnMsg.Location = new Point(444, 5);
                        this.Width = 753;
                        break;
                }
            }
        }

        //=========================================================================================================================
        // 멤버 변수 리스트
        //=========================================================================================================================
        //입력할 Text Box 컨트롤
        private TextBox m_oText;

        //출력좌표
        private int m_iX;
        private int m_iY;

        //최대 저장 크기
        private int m_iMaxSize;

        //Shift 처리 구분 (0-소문자, 1-대문자, 1-대문자 Lock)
        private int m_iShift = 0;
        public int iShift
        {
            get { return m_iShift; }
            set
            {
                m_iShift = value;
                switch (m_iShift)
                {
                    case 0:
                        btnShift.BackColor = SystemColors.ButtonFace;
                        break;
                    case 1:
                        btnShift.BackColor = Color.Lime;
                        break;
                }
            }
        }
        //=========================================================================================================================
        // 함수 리스트
        //=========================================================================================================================
        //------------------------------------------------------------------------------------------------------
        // 함수설명 : 생성자
        // Argument : iX        - x좌표
        //            iY        - y좌표
        //            oText     - 호출한 TextBox
        //            iMaxSize  - 최대 크기
        //   Return : None
        //------------------------------------------------------------------------------------------------------
        public TouchKeyboard(int iX, int iY, TextBox oText, int iMaxSize, KeyModeEnum keyMode = KeyModeEnum.Number)
        {
            InitializeComponent();

            //출력 좌표
            m_iX = iX;
            m_iY = iY;

            if (oText.Text == "0")
            {
                oText.Text = "";
            }
            m_iMaxSize = iMaxSize;
            //Text Box 설정
            m_oText = oText;

            KeyMode = keyMode;

            btn_AllClear.Text = "All Clear";
            btn_Close.Text = "Close";
            btn_Paste.Text = "Paste";
            iShift = 0;
        }
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.TopMost = true;
        }
        //-------------------------------------------------------------------------------
        // 함수설명 : 알파베틱 문자 변경
        // Argument : bUpper            - 대문자 표시여부(True - 대문자, False - 소문자)
        //   Return : None
        //-------------------------------------------------------------------------------
        private void MakeUpper(bool bUpper)
        {
            try
            {
                string strName = "";

                for (int iLoop = 0; iLoop < 26; iLoop++)
                {
                    //컨트롤 명
                    strName = "btnAlpha_" + Convert.ToChar(65 + iLoop).ToString();

                    //컨트롤 가져오기
                    Button oButton = (Button)pnMsg.Controls[strName];

                    //대문자 처리
                    if (bUpper == true)
                    {
                        oButton.Text = Convert.ToChar(65 + iLoop).ToString();
                    }
                    else
                    {
                        oButton.Text = Convert.ToChar(97 + iLoop).ToString();
                    }
                }
            }
            catch
            {

            }
        }
        public bool IsExistsForm()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == this.GetType().Name)
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;

        }
        //-------------------------------------------------------------------------------
        // 함수설명 : 알파베틱 버턴 클릭 시
        // Argument : None
        //   Return : None
        //-------------------------------------------------------------------------------
        private void btnAlpha_Click(object sender, EventArgs e)
        {
            try
            {
                Button oButton = (Button)sender;

                if (m_oText.TextLength < m_iMaxSize)
                {
                    //캡션 가져오기
                    string strValue = oButton.Text;

                    //스페이스인 경우 " "로 변경
                    if (strValue == "Space")
                    {
                        strValue = " ";
                    }

                    if (m_UpperString)
                    {
                        m_oText.Text += strValue.ToUpper();
                    }
                    else
                    {
                        //Shift인경우 복귀
                        if (iShift == 1)
                        {
                            //소문자 출력
                            m_oText.Text += strValue.ToUpper();

                            //소문자 복귀
                            iShift = 0;
                        }
                        else if (iShift == 0)
                        {
                            //문자열 더하기
                            m_oText.Text += strValue.ToLower();
                        }
                    }
                    //최대 크기가 되면 자동으로 폼 클로즈
                    if (m_oText.TextLength == m_iMaxSize)
                    {
                        this.Close();
                    }
                }
            }
            catch
            {

            }
        }
        //------------------------------------------------------------------------------------------------------
        // 함수설명 : 숫자 버튼 클릭 시
        // Argument : None
        //   Return : None
        //------------------------------------------------------------------------------------------------------
        private void btnNum_Click(object sender, EventArgs e)
        {
            try
            {
                Button oButton = (Button)sender;

                if (m_oText.TextLength < m_iMaxSize)
                {
                    //숫자 가져오기
                    int iNum = Convert.ToInt32(oButton.Name.Substring(oButton.Name.Length - 1));

                    //숫자 더하기
                    m_oText.Text += iNum.ToString();

                    //최대 크기가 되면 자동으로 폼 클로즈
                    if (m_oText.TextLength == m_iMaxSize)
                    {
                        this.Close();
                    }
                }
            }
            catch
            {

            }
        }
        //-------------------------------------------------------------------------------
        // 함수설명 : 시프트 버턴 클릭 시
        // Argument : None
        //   Return : None
        //-------------------------------------------------------------------------------
        private void btnShift_Click(object sender, EventArgs e)
        {
            try
            {
                switch (iShift)
                {
                    //소문자 - 대문자 변경
                    case 0:
                        //대문자 출력
                        iShift = 1;
                        break;

                    //대문자
                    case 1:
                        //대문자 Lock
                        iShift = 0;
                        break;
                }
            }
            catch
            {

            }
        }
        //------------------------------------------------------------------------------------------------------
        // 함수설명 : Backspace 버튼 클릭 시
        // Argument : None
        //   Return : None
        //------------------------------------------------------------------------------------------------------
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_oText.Text.Length > 0)
                {
                    m_oText.Text = m_oText.Text.Substring(0, m_oText.Text.Length - 1);
                }
            }
            catch
            {

            }
        }
        protected override void OnShown(EventArgs e)
        {

            base.OnShown(e);


        }

        //------------------------------------------------------------------------------------------------------
        // 함수설명 : 폼 로드 시 처리
        // Argument : None
        //   Return : None
        //------------------------------------------------------------------------------------------------------
        private void TouchKeyboard_Load(object sender, EventArgs e)
        {
            try
            {

                //화면 Control들에 대한 다국어 처리
                //MES_DB.SetControlName(this, this.Name);

                if (Screen.AllScreens[0].WorkingArea.Width > (m_iX + this.Width + 5))
                {
                    this.Left = m_iX;
                }
                else
                {
                    this.Left = Screen.AllScreens[0].WorkingArea.Width - this.Width - 5;
                }
                this.Top = m_iY;

            }
            catch
            {

            }
        }

        //------------------------------------------------------------------------------------------------------
        // 함수설명 : 닫기 버튼 클릭 시
        // Argument : None
        //   Return : None
        //------------------------------------------------------------------------------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
            catch
            {

            }
        }

        //------------------------------------------------------------------------------------------------------
        // 함수설명 : 소수점
        // Argument : None
        //   Return : None
        //------------------------------------------------------------------------------------------------------
        private void btnPoint_Click(object sender, EventArgs e)
        {
            try
            {
                Button oButton = (Button)sender;

                if (m_oText.TextLength < m_iMaxSize)
                {

                    m_oText.Text += ".";

                    //최대 크기가 되면 자동으로 폼 클로즈
                    if (m_oText.TextLength == m_iMaxSize)
                    {
                        this.Close();
                    }
                }
            }
            catch
            {

            }
        }

        //------------------------------------------------------------------------------------------------------
        // 함수설명 : 붙여넣기 버튼 클릭
        // Argument : None
        //   Return : None
        //------------------------------------------------------------------------------------------------------
        private void btnPaste_Click(object sender, EventArgs e)
        {
            try
            {
                m_oText.Text = (string)Clipboard.GetData(DataFormats.Text);
            }
            catch
            {

            }
        }

        //------------------------------------------------------------------------------------------------------
        // 함수설명 : 전체 삭제
        // Argument : None
        //   Return : None
        //------------------------------------------------------------------------------------------------------
        private void btnAllClear_Click(object sender, EventArgs e)
        {
            try
            {
                m_oText.Text = "";
            }
            catch
            {

            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    } //Class
} //Name Space
