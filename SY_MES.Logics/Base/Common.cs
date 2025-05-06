using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY_MES.Logics.Base
{
    public class Common
    {
        public const string CN_CATEGORY_APP = "_SY_MES.Appearance";
        public const string CN_BARCODE_NG_CHECK = "INSPECNG";
        public const string CN_BARCODE_PASS_CHECK = "INSPECOK";

        public struct BarcodePT
        {
            public string LotNo;
            public string PartNo;
        };
        public const int CN_BARCODE_LEN_HE_LOT = 9;
        public const string CN_2D_BARCODE_START_CODE = "[)>";
        private LocalizedContainer m_Parent;

        private static DataRow m_ProductInfor;
        public static DataRow ProductInfor
        {
            get { return m_ProductInfor; }
        }
        public static void SetProductInfor(DataRow prodInfor)
        {
            m_ProductInfor = prodInfor;
        }
        public static string GetProductInfor(string colNM)
        {
            if (string.IsNullOrEmpty(colNM) == false)
            {
                if (m_ProductInfor != null)
                {
                    return m_ProductInfor[colNM].ToString();
                }
            }
            return "";
        }

        public Common(LocalizedContainer bc)
        {
            m_Parent = bc;
        }
        /// <summary>
        /// Getting the Process BOM Information(BM0354)
        /// </summary>
        /// <param name="corcd">Corporation Code</param>
        /// <param name="bizcd">Business Code</param>
        /// <param name="linecd">Line Code</param>
        /// <param name="proccd">Process Code</param>
        /// <param name="partno">Part Number</param>
        /// <returns>DataTable of Process BOM result</returns>
        public DataTable GetStationBOM(string corcd, string bizcd, string linecd, string proccd, string partno)
        {

            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", corcd);
            param.Add("IN_BIZCD", bizcd);
            param.Add("IN_LINECD", linecd);
            param.Add("IN_PROCCD", proccd);
            param.Add("IN_PARTNO", partno);
            return m_Parent.ExecuteQuery("PKG_ME_PARTS_CHECK.GET_PROC_BOM", param);
        }

        /// <summary>
        /// Getting the Product Information(CD0021 and Others)
        /// </summary>
        /// <param name="corcd">Corporation Code</param>
        /// <param name="bizcd">Business Code</param>
        /// <param name="lotno">LOT</param>
        /// <returns>DataRow of Product Information result</returns>
        public DataRow GetProductInfo(string corcd, string bizcd, string lotno)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("IN_CORCD", corcd);
            param.Add("IN_BIZCD", bizcd);
            param.Add("IN_LOTNO", lotno);
            DataTable dt = m_Parent.ExecuteQuery("PKG_COM.GET_PRODUCT_INFO", param);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }

        }
        public bool AvailableLine(string barcode, string compLine)
        {
            string lotno = GetExtractLotNo(barcode);
            DataRow dr = GetProductInfo(m_Parent.BaseINF.CORCD, m_Parent.BaseINF.BIZCD, lotno);
            if (string.IsNullOrEmpty(compLine))
            {
                return true;
            }
            else if(dr!=null)
            {
                if (string.IsNullOrEmpty(dr["LINECD"].ToString()) == false)
                {
                    if (compLine.Contains(dr["LINECD"].ToString().Substring(0, 4)))
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }            
            return false;
        }
        public System.Windows.Forms.Control[] GetAllControls(System.Windows.Forms.Control containerControl)
        {
            List<System.Windows.Forms.Control> allControls = new List<System.Windows.Forms.Control>();

            Queue<System.Windows.Forms.Control.ControlCollection> queue = new Queue<System.Windows.Forms.Control.ControlCollection>();
            queue.Enqueue(containerControl.Controls);

            while (queue.Count > 0)
            {
                System.Windows.Forms.Control.ControlCollection controls
                            = (System.Windows.Forms.Control.ControlCollection)queue.Dequeue();
                if (controls == null || controls.Count == 0) continue;

                foreach (System.Windows.Forms.Control control in controls)
                {
                    allControls.Add(control);
                    queue.Enqueue(control.Controls);
                }
            }
            return allControls.ToArray();
        }
        public bool IsOurBarcode(string barcode, bool lineChk =true)
        {
            if (barcode.Contains(CN_2D_BARCODE_START_CODE))
            {   //2차원                
                if (barcode.ToUpper().Contains("V" + m_Parent.BaseINF.HKMC_VENDCD))
                {
                    return true;
                }
            }
            else if (barcode.Length == CN_BARCODE_LEN_HE_LOT)
            {   //1차원
                return true;
            }
            return false;
        }
        public bool IsTrolleyBarcode(string barcode)
        {
            if(barcode.StartsWith("+ASN+@"))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Extraction of barcode data into Lotno and Partno
        /// </summary>
        /// <param name="barcode">barcode</param>
        /// <returns>Lotno and Partno</returns>
        public BarcodePT GetExtractPair(string barcode)
        {
            BarcodePT retPT = new BarcodePT();
            if(IsOurBarcode(barcode))
            {
                retPT.LotNo = GetExtractLotNo(barcode);
                DataRow dr = GetProductInfo(m_Parent.BaseINF.CORCD, m_Parent.BaseINF.BIZCD, retPT.LotNo);
                retPT.PartNo = dr["PARTNO"].ToString();
            }
            else if(barcode.Contains(CN_2D_BARCODE_START_CODE))
            {   //Data Matrix
                retPT.PartNo = GetDataFromDMatrix(barcode, "P");
                retPT.LotNo = GetDataFromDMatrix(barcode, "T");
            }
            else 
            {
                retPT.LotNo = barcode;
                retPT.PartNo = barcode;
            }
            return retPT;
        }
        public bool GetBoolStr(string strbool)
        {
            strbool = strbool.Replace(" ", "").Trim().ToUpper();

            switch (strbool)
            {
                case "Y":
                case "TRUE":
                case "T":
                case "1":
                case "YES":
                case "01":
                    return true;

            }
            return false;

        }
        public string GetExtractLotNo(string barcode)
        {
            try
            {
                if (barcode.Length == CN_BARCODE_LEN_HE_LOT)
                {
                    return barcode;
                }
                else if (barcode.Contains(CN_2D_BARCODE_START_CODE))
                {
                    string[] spBarcode = barcode.Split(Convert.ToChar(FX.Common.ConstVars.GS));
                    foreach (string code in spBarcode)
                    {
                        if (code.Length > 2 && code.Contains('@'))
                        {
                            if (code.Substring(0, 1) == "T")
                            {
                                string[] lotno = code.Split('@');
                                if (lotno.Length > 1)
                                {
                                    return lotno[1];
                                }
                            }
                        }
                        else if (code.Substring(0, 1) == "T")   
                        {
                            return code.Substring(1).Substring(11);
                        }
                    }
                }

            }
            catch (Exception eLog)
            {
                throw eLog;
            }
            return "";
        }
        /// <summary>
        /// Parsing the Data From 2D(Datamatrix code)
        /// </summary>
        /// <param name="barcode">2D Code</param>
        /// <param name="tag">Tag of Matrix</param>
        /// <param name="bIncludeTag">if you want to show the Tag</param>
        /// <returns>Data Value</returns>
        public string GetDataFromDMatrix(string barcode, string tag, bool bIncludeTag = false)
        {
            if (barcode.Contains(CN_2D_BARCODE_START_CODE))
            {   //HMC2차원 바코드
                string[] spHMC = barcode.Split(Convert.ToChar(FX.Common.ConstVars.GS));
                if (spHMC.Length <= 2)
                {
                    spHMC = barcode.Split(' ');
                }
                for (int idx = 0; idx < spHMC.Length; idx++)
                {
                    if (spHMC[idx].Length > 0 && spHMC[idx].Substring(0, 1).ToUpper() == tag)
                    {
                        string data = spHMC[idx];
                        if (bIncludeTag)
                        {
                            return data;
                        }
                        else
                        {
                            return data.Length >= 2 ? data.Substring(1) : "";
                        }
                    }
                }
            }
            return String.Empty;
        }
    }
}
