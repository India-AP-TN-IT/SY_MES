using SY_MES.FX.Controls;
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
    [ToolboxItem(false)]
    public partial class SpecSheetCtl : UserControl
    {
        public SpecSheetCtl()
        {
            InitializeComponent();
        }
        [Category(Base.Common.CN_CATEGORY_APP)]
        public YLabel TitleCtl
        {
            get { return lbl_SPEC1_TIT; }
            set { lbl_SPEC1_TIT = value; }
        }
        [Category(Base.Common.CN_CATEGORY_APP)]
        public YLabel DescCtl
        {
            get { return lbl_SPEC1_VAL; }
            set { lbl_SPEC1_VAL = value; }
        }
    }
}
