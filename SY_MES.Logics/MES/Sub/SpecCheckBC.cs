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
    public partial class SpecCheckBC : Base.LocalizedContainer
    {
        private string m_PartNo = "";
        [Browsable(false)]
        public string PartNo
        {
            get { return m_PartNo; }
        }
        public SpecCheckBC()
        {
            InitializeComponent();
        }
        public void SetValue(string partno, object val)
        {
            m_PartNo = partno;
            GrdPart.SetValue(val);
        }
        public int LoadStationBOM(string linecd, string parentPart)
        {
            DataTable dt = Comm.GetStationBOM(BaseINF.CORCD, BaseINF.BIZCD, linecd, BaseINF.STATIONCD, parentPart);

            SetValue(parentPart, dt);
            if (dt != null)
            {
                return dt.Rows.Count;
            }
            return 0;
        }

        public bool PartCheckWithGrid(string readData, string lotno, string worker, out string rsltMSG, out bool bAllOK)
        {
            bAllOK = false;
            rsltMSG = "";
            try
            {

                Base.Common.BarcodePT barcodePT = Comm.GetExtractPair(readData);
                string ptLot = barcodePT.LotNo;
                string ptno = barcodePT.PartNo;


                Dictionary<string, string> param = new Dictionary<string, string>();
                DataTable dt = new DataTable();




                for (int i = 0; i < GrdPart.Rows.Count; i++)
                {


                    string compPart = GrdPart.GetValue(i, "CHK_PARTNO").Replace("-", "").Trim();
                    if (compPart == ptno.Replace("-", "").Trim() && GrdPart.GetValue(i, "CHK_RESULT") != "OK")
                    {
                        if (string.IsNullOrEmpty(ptLot))
                        {
                            ptLot = readData;
                        }
                        if (ptLot.Length > 30)
                        {
                            ptLot = ptLot.Substring(0, 25);
                        }

                        param = new Dictionary<string, string>();
                        param.Add("IN_CORCD", BaseINF.CORCD);
                        param.Add("IN_BIZCD", BaseINF.BIZCD);
                        param.Add("IN_LINECD", BaseINF.LINECD);
                        param.Add("IN_PROCCD", BaseINF.STATIONCD);
                        param.Add("IN_LOTNO", lotno);
                        param.Add("IN_MAT_PARTNO", ptno);
                        param.Add("IN_MAT_LOTNO", string.IsNullOrEmpty(ptLot) ? readData : ptLot);
                        param.Add("IN_PROD_DATE", PBaseFrm.GetWorkDate());
                        param.Add("IN_SHIFT", PBaseFrm.GetShift());
                        param.Add("IN_CHKRESULT", "OK");
                        param.Add("IN_EMPNO", worker);
                        param.Add("IN_MOD_CHK", "");
                        param.Add("IN_MAT_2D_BARCODE", readData);
                        ExecuteNonQuery("PKG_ME_PARTS_CHECK.SET_CHK_MAT_PART", param);
                        GrdPart.SetValue(i, "CHK_RESULT", "OK");


                        GrdPart.Rows[i].Cells["CHK_RESULT"].Style.BackColor = Color.Lime;

                        if (GrdPartChk_AllOK())
                        {
                            bAllOK = true;
                            param = new Dictionary<string, string>();
                            param.Add("IN_CORCD", BaseINF.CORCD);
                            param.Add("IN_BIZCD", BaseINF.BIZCD);
                            param.Add("IN_LOTNO", lotno);
                            param.Add("IN_CHK_DIFF", "Y");
                            ExecuteNonQuery("PKG_ME_PARTS_CHECK.SET_MES2010_CHK_DIFF", param);

                            

                        }
                        rsltMSG = "[" + readData + "] OK";
                        GrdPart.FirstDisplayedCell = GrdPart.Rows[i].Cells[GrdPart.GetFirstVisibleColIdx()];
                        return true;

                    }
                    else if (GrdPart.GetValue(i, "CHK_PARTNO") == ptno && GrdPart.GetValue(i, "CHK_RESULT") == "OK")
                    {
                        rsltMSG = "[" + readData + "]Already Scanned";
                        return false;
                    }
                }
                rsltMSG = "[" + readData + "]Material Error";
                return false;
            }
            catch (Exception eLog)
            {
                rsltMSG = "[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message;
                return false;
            }
        }
        public bool GrdPartChk_AllOK()
        {
            if (GrdPart.Rows.Count <= 0)
            {
                return false;
            }
            for (int i = 0; i < GrdPart.Rows.Count; i++)
            {

                if (GrdPart.GetValue(i, "CHK_RESULT") != "OK")
                {
                    return false;
                }
            }
            return true;
        }
        [Browsable(false)]
        public int RowCnt
        {
            get { return GrdPart.Rows.Count; }
        }
    }
}
