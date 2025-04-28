using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.Logics.MES.Sub
{
    [ToolboxItem(true)]
    public partial class ProductInforBC : Base.LocalizedContainer
    {
        public ProductInforBC()
        {
            InitializeComponent();
        }
        [Category(Base.Common.CN_CATEGORY_APP)]
        public string SPEC1_DESC_COLNM
        {
            get { return lbl_SPEC1_VAL.Key; }
            set { lbl_SPEC1_VAL.Key = value; }
        }
        [Category(Base.Common.CN_CATEGORY_APP)]
        public string SPEC2_DESC_COLNM
        {
            get { return lbl_SPEC2_VAL.Key; }
            set { lbl_SPEC2_VAL.Key = value; }
        }
        [Category(Base.Common.CN_CATEGORY_APP)]
        public string SPEC3_DESC_COLNM
        {
            get { return lbl_SPEC3_VAL.Key; }
            set { lbl_SPEC3_VAL.Key = value; }
        }
        [Category(Base.Common.CN_CATEGORY_APP)]
        public string SPEC1_TITLE
        {
            get { return lbl_SPEC1_TIT.Text; }
            set { lbl_SPEC1_TIT.Text = value; }
        }
        [Category(Base.Common.CN_CATEGORY_APP)]
        public string SPEC2_TITLE
        {
            get { return lbl_SPEC2_TIT.Text; }
            set { lbl_SPEC2_TIT.Text = value; }
        }
        [Category(Base.Common.CN_CATEGORY_APP)]
        public string SPEC3_TITLE
        {
            get { return lbl_SPEC3_TIT.Text; }
            set { lbl_SPEC3_TIT.Text = value; }
        }
        [Category(Base.Common.CN_CATEGORY_APP)]
        public string LotNo
        {
            get { return lbl_LOTNO.Text; }
            set { lbl_LOTNO.Text = value; }
        }
        [Category(Base.Common.CN_CATEGORY_APP)]
        public string PartNo
        {
            get { return lbl_PARTNO.Text; }
            set { lbl_PARTNO.Text = value; }
        }
        [Category(Base.Common.CN_CATEGORY_APP)]
        public string AlcCD
        {
            get { return lbl_ALCCD.Text; }
            set { lbl_ALCCD.Text = value; }
        }
        public void Clear()
        {
            lbl_ALCCD.Text = "";
            lbl_LOTNO.Text = "";
            lbl_PARTNO.Text = "";

            lbl_SPEC1_VAL.Text = "";
            lbl_SPEC2_VAL.Text = "";
            lbl_SPEC3_VAL.Text = "";
            if (string.IsNullOrEmpty(lbl_SPEC1_VAL.Key))
            {
                lbl_SPEC1_VAL.Visible = false;
                lbl_SPEC1_TIT.Visible = false;
            }
            if (string.IsNullOrEmpty(lbl_SPEC2_VAL.Key))
            {
                lbl_SPEC2_VAL.Visible = false;
                lbl_SPEC2_TIT.Visible = false;
            }
            if (string.IsNullOrEmpty(lbl_SPEC3_VAL.Key))
            {
                lbl_SPEC3_VAL.Visible = false;
                lbl_SPEC3_TIT.Visible = false;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode == false)
            {
                DispProdFromINI();
                LoadData();
            }
        }
        public override void LoadData()
        {
            base.LoadData();
            Clear();
            lbl_ALCCD.Text = Base.Common.GetProductInfor("ALCCD");
            lbl_LOTNO.Text = Base.Common.GetProductInfor("LOTNO");
            lbl_PARTNO.Text = Base.Common.GetProductInfor("PARTNO");

            lbl_SPEC1_VAL.Text = Base.Common.GetProductInfor(lbl_SPEC1_VAL.Key);
            lbl_SPEC2_VAL.Text = Base.Common.GetProductInfor(lbl_SPEC2_VAL.Key);
            lbl_SPEC3_VAL.Text = Base.Common.GetProductInfor(lbl_SPEC3_VAL.Key);
        }
        public void ReLoadData()
        {
            LoadData();
        }
        private void DispProdFromINI()
        {
            string ini = GetINI("PROD_INFOR/SPEC_LIST").Replace(" ","");
            string[] iniLst = ini.Split(',');
            int idx = 0;
            foreach(string str in iniLst)
            {
                if(str.Contains("@"))
                {
                    if(idx ==0)
                    {
                        lbl_SPEC1_TIT.Text = str.Split('@')[0];
                        lbl_SPEC1_VAL.Key = str.Split('@')[1];
                    }
                    else if (idx == 1)
                    {
                        lbl_SPEC2_TIT.Text = str.Split('@')[0];
                        lbl_SPEC2_VAL.Key = str.Split('@')[1];
                    }
                    else if (idx == 2)
                    {
                        lbl_SPEC3_TIT.Text = str.Split('@')[0];
                        lbl_SPEC3_VAL.Key = str.Split('@')[1];
                    }
                }
                idx++;
            }

        }
    }
}
