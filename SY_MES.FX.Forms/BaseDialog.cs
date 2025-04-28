using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.FX.MainForm
{
    public partial class BaseDialog : Form
    {
        private object m_Result = null;
        public delegate void DlgClose(object sender, object rlst);
        public event DlgClose OnDlgClose;
        private Point m_MouseMovePoint = new Point();
        private bool m_bMoveMouse = false;
        private string m_Title = "Dialog";
        private BaseContainer m_BC;
        private BaseMainForm m_PBaseFrm = null;
        [Browsable(false)]
        public object Result
        {
            get { return m_Result; }
            set { m_Result = value; }
        }
        [Browsable(false)]
        public BaseContainer BC
        {
            get { return m_BC; }
        }
        [Category(Base.Common.CN_CATEGORY_APP)]
        public string Title
        {
            get { return m_Title; }
            set 
            { 
                m_Title = value;
                lbl_ReInput.Text = m_Title;
            }
        }
        [Browsable(false)]
        public FX.MainForm.BaseMainForm PBaseFrm
        {
            get
            {
                return m_PBaseFrm;

            }
        }
        public BaseDialog(string title, BaseContainer bc, BaseMainForm parentForm, FormWindowState frmState = FormWindowState.Normal)
        {
            InitializeComponent();
            m_Title = title;
            
            m_PBaseFrm = parentForm;
            m_BC = bc;
            m_BC.Parent = parentForm;
            this.WindowState = frmState;
        }


        private void lbl_ReInput_MouseDown(object sender, MouseEventArgs e)
        {
            m_MouseMovePoint = new Point(e.X, e.Y);
            m_bMoveMouse = true;
        }

        private void lbl_ReInput_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_bMoveMouse)
            {
                Point pt = new Point(this.Left + e.X - m_MouseMovePoint.X, this.Top + e.Y - m_MouseMovePoint.Y);
                this.Location = pt;
            }
        }

        private void lbl_ReInput_MouseUp(object sender, MouseEventArgs e)
        {
            m_bMoveMouse = false;

        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if(OnDlgClose!=null)
            {
                OnDlgClose(this, m_Result);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lbl_ReInput.Text = this.m_Title;
            this.Size = new System.Drawing.Size(m_BC.Width + 10, m_BC.Height + lbl_ReInput.Height+5);
            this.Icon = m_PBaseFrm.Icon;
            ContainsBC(m_BC);

            this.Location = m_PBaseFrm.Location;
        }
        private void ContainsBC(BaseContainer bc)
        {
            if (bc != null)
            {
                bc.Dock = DockStyle.Fill;
                this.Pan_Body.Controls.Clear();
                if (this.Pan_Body.Controls.Contains(bc) == false)
                {
                    this.Pan_Body.Controls.Add(bc);

                }
            }

        }
    }
}
