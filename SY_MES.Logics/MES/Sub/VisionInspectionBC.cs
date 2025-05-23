﻿using SY_MES.FX.Devices.Printer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.Logics.MES.Sub
{
    public partial class VisionInspectionBC : Base.LocalizedContainer
    {
        private const string CN_ASYNC_LOAD_QUERY = "PKG_ME_MC_API.GET_LOT_INSP_IMG";
        public VisionInspectionBC()
        {
            InitializeComponent();
        }
        protected override void InitControls()
        {
            base.InitControls();
            yLabel5.Text = "";
            yLabel4.Text = "";
        }

        public override void LoadData()
        {
            base.LoadData();
            string lotno = Base.Common.GetProductInfor("LOTNO");
            string partno = Base.Common.GetProductInfor("PARTNO");
            yLabel5.SetValue(lotno);
            yLabel4.SetValue(partno);
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", BaseINF.CORCD);
            param.Add("IN_BIZCD", BaseINF.BIZCD);
            param.Add("IN_LOTNO", lotno);
            AsyncExecueteQuery(this, CN_ASYNC_LOAD_QUERY, param);


            
            
        }
        public override void ReadAsyncDBData(object sender, string query, Dictionary<string, string> param, DataTable dt)
        {
            if (PBaseFrm != null)
            {
                PBaseFrm.Invoke(new MethodInvoker(
                delegate()
                {
                    if (query.Contains(CN_ASYNC_LOAD_QUERY))
                    {
                        if (dt.Rows.Count > 0)
                        {
                            pictureBox1.BackgroundImage = GetImg((byte[])dt.Rows[0]["IMG"]);
                            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                            yBitLabel1.Text = dt.Rows[0]["RSLT"].ToString();
                            if (yBitLabel1.Text.Contains("OK"))
                            {
                                yBitLabel1.BackColor = Color.Lime;
                                yBitLabel1.ForeColor = Color.Black;
                            }
                            else
                            {
                                yBitLabel1.BackColor = Color.Red;
                                yBitLabel1.ForeColor = Color.White;
                            }
                        }
                        else
                        {
                            pictureBox1.BackgroundImage = null;
                            yBitLabel1.BackColor = Color.Black;
                            yBitLabel1.ForeColor = Color.White;
                            yBitLabel1.Text = "No Data";
                        }
                    }
                    
                }));
            }
        }
        private Image GetImg(byte[] byteArray)
        {
            MemoryStream stream = new MemoryStream(byteArray);
            return Image.FromStream(stream);
        }
    }
}
