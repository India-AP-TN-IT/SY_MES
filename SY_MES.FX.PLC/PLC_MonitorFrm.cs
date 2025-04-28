using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.FX.PLC
{
    public partial class PLC_MonitorFrm : Form
    {

        private Dictionary<string, string> m_DicParam = null;
        private int m_MaxRow = 26;
        private PLCHelper m_PLC;
        public int MaxRow
        {
            get { return m_MaxRow; }
            set { m_MaxRow = value; }
        }
        public PLC_MonitorFrm()
        {
            InitializeComponent();
        }
        public void SetPLCParam(Dictionary<string, string> param, ref PLCHelper plc)
        {
            m_DicParam = param;
            m_PLC = plc;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lblPLCIP.Text = m_DicParam["@PLCIP"];
            lblBaseAddr.Text = m_DicParam["@BLOCK_TYPE"] + m_DicParam["@PLCBASEADDR"];
            lblPLC_TYPE.Text = m_DicParam["@PLCTYPE"];
            lblPLC_BSIZE.Text = m_DicParam["@BLOCK_SIZE"];
            lblPLC_TAG.Text = m_DicParam["@MEMORY_TAG"];
            lblPLC_PORT.Text = m_DicParam["@PLC_PORT"];
            if (dataGridView1.Rows.Count <= 0)
            {
                dataGridView1.Rows.Add(m_MaxRow);
            }
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                dataGridView1.Rows[row].HeaderCell.Value = row.ToString();
                dataGridView1.RowHeadersWidth = 50;

            }
        }
        private int GetO2I(object obj)
        {
            if (obj == null)
            {
                return 0;
            }
            else
            {
                try
                {
                    if (obj is string)
                    {
                        obj = obj.ToString().Replace(",", "");
                    }
                    if (string.IsNullOrEmpty(obj.ToString()))
                    {
                        return 0;
                    }
                    return Convert.ToInt32(obj);
                }
                catch
                {
                    return 0;
                }
            }
        }
        public void MonitorPLC(int pos, bool bVal)
        {
            
                this.Invoke(new System.Windows.Forms.MethodInvoker(
                delegate()
                {
                    if (dataGridView1 == null)
                    {
                        return;
                    }
                    if (dataGridView1.Rows.Count <= 0)
                    {
                        return;
                    }

                    int row = 0;
                    int col = 0;
                    if (pos >= 0)
                    {
                        row = pos / 10;
                        col = GetO2I(pos.ToString().Substring(pos.ToString().Length - 1));
                        if (row < m_MaxRow)
                        {
                            if (bVal)
                            {
                                dataGridView1.Rows[row].Cells[col].Value = "1";
                                dataGridView1.Rows[row].Cells[col].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Rows[row].Cells[col].Style.BackColor = Color.Lime;
                            }
                            else
                            {
                                dataGridView1.Rows[row].Cells[col].Style.BackColor = Color.White;
                                dataGridView1.Rows[row].Cells[col].Value = "";
                            }
                        }
                    }
                }));
           

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            
            if(row>=0 && col>=0)
            {
                bool bVal = dataGridView1.Rows[row].Cells[col].Value.ToString() == "1" ? true : false;
                WritePLC(row, col, !bVal);
            }
            
        }

        private void WritePLC(int row, int col, bool bVal)
        {
            if (dataGridView1.Rows.Count > 0 && checkBox1.Checked && row >= 0 && col >= 0 && m_PLC!=null)
            {
                int pos = (row * 10) + col;

                m_PLC.WriteBit(pos, bVal);
            }
        }
    }
}
