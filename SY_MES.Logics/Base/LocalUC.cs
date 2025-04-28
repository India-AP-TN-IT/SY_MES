using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.Logics.Base
{
    public partial class LocalUC : UserControl
    {
        protected LocalizedContainer ParentBC
        {
            get
            {
                if (this.ParentForm != null)
                {
                    SY_MES.FX.MainForm.BaseContainer pbc = null;
                    if (ParentForm is SY_MES.FX.MainForm.BaseMainForm)
                    {
                        pbc = ((FX.MainForm.BaseMainForm)ParentForm).ChildBC;
                    }
                    else if (ParentForm is SY_MES.FX.MainForm.BaseDialog)
                    {
                        pbc = (((FX.MainForm.BaseDialog)ParentForm).PBaseFrm).ChildBC;
                    }
                    if (pbc is LocalizedContainer)
                    {
                        return (LocalizedContainer)pbc;
                    }
                    return null;
                }
                return null;

            }
        }
        protected virtual void InitControls()
        {

        }
        public LocalUC()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode == false)
            {
                InitControls();
            }
        }
        public virtual void LoadData()
        {

        }
    }
}
