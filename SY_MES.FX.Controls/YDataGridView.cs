using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;
using SY_MES.FX.Controls.Base;
using System.Runtime.CompilerServices;

namespace SY_MES.FX.Controls
{
    [ToolboxBitmap(typeof(DataGridView))]
    public partial class YDataGridView: DataGridView, Base.IYGrid
    {
        private string m_JustifiedWidthColNM = "";
        private bool m_IsSelected = false;
        private DataGridViewContentAlignment m_HeaderAlignment = DataGridViewContentAlignment.MiddleCenter;
        private bool m_bScrollMove = false;
        public delegate void MovePKNotFound(object sender);
        public event MovePKNotFound OnMovePKNotFound = null;

        public delegate void MovePKFound(object sender, int selectRow);
        public event MovePKFound OnMovePKFound = null;
        private string m_MovePKColName = "";
        private bool m_BindMove = false;
        private string m_LastSelectedKey = "";
        private List<string> m_lstPKColName = new List<string>();
        private bool m_AutoBindName = true;
        private GridModeEnum m_GridMode = GridModeEnum.QueryNomal;
        private bool m_CanSelectGrid = true;

        private bool m_BindAfterClearGrid = true;
        private bool m_FixedSort = true;
        private bool m_ScrollLock = false;
        private int m_LastScollRow = 0;


        private bool m_bLoadForSize = false;
        private bool m_bInitForSize = false;
        private int m_prvGridWidthForSize = 0;

        [Browsable(false)]
        public bool IsSelected
        {
            get { return m_IsSelected; }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public string JustifiedWidthColNM
        {
            get { return m_JustifiedWidthColNM; }
            set { m_JustifiedWidthColNM = value; }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public bool ScrollLock
        {
            get { return m_ScrollLock; }
            set { m_ScrollLock = value; }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public int RowHeight
        {
            get { return this.RowTemplate.Height; }
            set { this.RowTemplate.Height = value; }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public int HeaderHeight
        {
            get { return this.ColumnHeadersHeight; }
            set { this.ColumnHeadersHeight = value; }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public bool FixedSort
        {
            get { return m_FixedSort; }
            set
            {
                m_FixedSort = value;

                foreach (DataGridViewColumn col in this.Columns)
                {
                    if (m_FixedSort)
                    {
                        col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    else
                    {
                        col.SortMode = DataGridViewColumnSortMode.Automatic;
                    }
                }
            }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public DataGridViewContentAlignment HeaderAlignment
        {
            get { return m_HeaderAlignment; }
            set
            {
                m_HeaderAlignment = value;
                AlignHeader();
            }
        }
        private string m_Key = string.Empty;
        [Category(Common.CN_CATEGORY_APP)]
        public string Key
        {
            get { return m_Key; }
            set { m_Key = value; }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public string Desc
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        [Category(Common.CN_CATEGORY_APP)]
        [DefaultValue(true)]        
        public bool BindAfterClearGrid
        {
            get { return m_BindAfterClearGrid; }
            set { m_BindAfterClearGrid = value; }
        }

        [Category(Common.CN_CATEGORY_APP)]
        [DefaultValue(true)]
        public bool CanSelectGrid
        {
            get { return m_CanSelectGrid; }
            set { m_CanSelectGrid = value; }
        }
        [Category(Common.CN_CATEGORY_APP)]
        [DefaultValue(GridModeEnum.QueryNomal)]
        public GridModeEnum GridMode
        {
            get { return m_GridMode; }
            set { m_GridMode = value; }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public bool AutoBindName
        {
            get { return m_AutoBindName; }
            set { m_AutoBindName = value; }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public string MovePKColName
        {
            get { return m_MovePKColName; }
            set { m_MovePKColName = value; }
        }
        [Category(Common.CN_CATEGORY_APP)]
        public bool BindMove
        {
            get { return m_BindMove; }
            set
            {
                m_BindMove = value;
            }
        }
        protected override Control.ControlCollection CreateControlsInstance()
        {
            m_bLoadForSize = true;
            return base.CreateControlsInstance();
        }

        public enum GridModeEnum
        {
            QueryNomal
            , UserSetting
        }
        public YDataGridView()
        {
            InitializeComponent();

        }
        private void AlignHeader()
        {
            foreach (DataGridViewColumn col in this.Columns)
            {
                col.HeaderCell.Style.Alignment = HeaderAlignment;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.AutoGenerateColumns = false;
            foreach (DataGridViewColumn col in this.Columns)
            {
                if (m_FixedSort)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                else
                {
                    col.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
            if (GridMode == GridModeEnum.QueryNomal)
            {

                this.MultiSelect = false;
                this.RowHeadersVisible = false;
                this.ReadOnly = true;
                this.MultiSelect = false;
                this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                this.AllowUserToAddRows = false;
                this.AllowUserToOrderColumns = false;
                this.AllowUserToResizeColumns = false;
                this.AllowUserToResizeRows = false;
                this.AllowUserToOrderColumns = false;
               // this.RowTemplate.Height = 40;
                this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
               // this.ColumnHeadersHeight = 30;
                this.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
                this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }


            if (m_bLoadForSize)
            {
                if (m_bInitForSize)
                {
                    if (this.Columns.Contains(JustifiedWidthColNM) && this.Columns[JustifiedWidthColNM].Visible)
                    {
                        int diffSize = (Width - m_prvGridWidthForSize);
                        this.Columns[JustifiedWidthColNM].Width = this.Columns[JustifiedWidthColNM].Width + diffSize;
                    }
                }
                if (m_bInitForSize == false)
                {
                    m_bInitForSize = true;

                }
            }
            m_prvGridWidthForSize = Width;

        }
        private string GetSelectedKeyVal(int selectedRow)
        {
            string keyVal = string.Empty;
            List<string> keyCols = GetPKColNames();
            foreach(string colNM in keyCols)
            {
                keyVal += this.GetValue(selectedRow, colNM);
            }
            return keyVal;
        }
        protected override void OnCellClick(DataGridViewCellEventArgs e)
        {
            base.OnCellClick(e);
            if (e.RowIndex == -1 && FixedSort)
            {
                MoveGridRow(m_LastSelectedKey);
            }
            if (!CanSelectGrid)
            {
                ClearSelection();
            }
        }
        protected override void OnCellDoubleClick(DataGridViewCellEventArgs e)
        {
            base.OnCellDoubleClick(e);
            if (!CanSelectGrid)
            {
                ClearSelection();
            }
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if(SelectedRowIdx >=0)
            {
                m_LastSelectedKey = GetSelectedKeyVal(SelectedRowIdx);
                m_IsSelected = true;
            }
            if (!CanSelectGrid)
            {
                ClearSelection();
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (!DesignMode)
            {
                if (m_BindMove)
                {
                    m_lstPKColName = GetPKColNames();
                }
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            }

        }
        
        public DataGridViewCell GetCell(int row, string bindName)
        {
            try
            {
                string colName = GetColName(bindName);
                return this.Rows[row].Cells[colName];
            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
            }
            return null;
        }
        public DataGridViewCell GetCell(int row, int col)
        {

            try
            {
                return this.Rows[row].Cells[col];
            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
            }
            return null;

        }
        public int FindRow(string bindName, string data)
        {
            int col = GetColNum(bindName);
            int cnt = 0;
            if (col >= 0)
            {
                foreach (DataGridViewRow dr in Rows)
                {
                    if (dr.Cells[col].Value.ToString().ToUpper() == data)
                    {
                        return cnt;
                    }
                    cnt++;
                }
            }
            return -1;
        }
        public bool SetValue(int row, int col, object val)
        {
            try
            {
                if (row >= 0 && row < this.Rows.Count)
                {
                    if (col >= 0 && col < this.Columns.Count)
                    {
                        this.Rows[row].Cells[col].Value = val;
                    }
                }
            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
                return false;
            }
            return true;
        }
        public DataGridViewCellStyle GetCellStyle(int row, string bindName)
        {
            int col = GetColNum(bindName);
            return this.Rows[row].Cells[col].Style;
        }
        public bool SetValue(int row, string bindName, object val)
        {
            try
            {
                if (row >= 0 && row < this.Rows.Count)
                {
                    string colName = GetColName(bindName);
                    this.Rows[row].Cells[colName].Value = val;
                }
                       
                
                if (!CanSelectGrid)
                {
                    ClearSelection();
                }
            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
                return false;
            }
            return true;
        }
        
        public DataGridViewRow GetRow(int row)
        {
            if(row>=0 && row<this.Rows.Count)
            {
                return this.Rows[row];
            }
            return null;
        }
        public string GetColName(string name)
        {
            for (int i = 0; i < Columns.Count; i++)
            {
                if (Columns[i].DataPropertyName == name)
                {
                    return Columns[i].Name;
                }
            }
            return "";
        }
        public string GetValue(string bindName)
        {
            if (SelectedRowIdx >= 0)
            {
                return GetValue(SelectedRowIdx, bindName);
            }
            return "";
        }
        public string GetValue(int row, string bindName)
        {
            try
            {
                string colName = GetColName(bindName);
                if (!this.Columns.Contains(colName))
                {
                    return "";
                }
                if (row >= 0 && row<Rows.Count)
                {
                    if (this.Rows[row].Cells[colName].Value != null)
                    {
                        return this.Rows[row].Cells[colName].Value.ToString();
                    }
                }
                return "";
            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
                return "";
            }
        }
        protected override void OnDataBindingComplete(DataGridViewBindingCompleteEventArgs e)
        {
            base.OnDataBindingComplete(e);
            if (!CanSelectGrid)
            {
                ClearSelection();
            }
            AlignHeader();
        }
        public DataRow GetDataRow(int row)
        {

            try
            {
                if (row >= 0 && row < Rows.Count)
                {

                    return ((DataRowView)this.Rows[row].DataBoundItem).Row;
                }
                return null;
            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
                return null;
            }
        }

        public string GetValue(int row, int col)
        {
            try
            {
                if (row >= 0 && row < Rows.Count)
                {
                    if (this.Rows[row].Cells[col].Value != null)
                    {
                        return this.Rows[row].Cells[col].Value.ToString();
                    }
                }
                else
                {
                    return "";
                }
            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);

            }
            return "";
        }
        public int GetColNum(string bindNM)
        {
            for (int i = 0; i < this.Columns.Count; i++)
            {
                if (this.Columns[i].DataPropertyName != null)
                {
                    if (this.Columns[i].DataPropertyName.ToUpper() == bindNM.ToUpper())
                    {
                        return i;
                    }
                }
            }
            return -1;
        }


        private List<string> GetPKColNames()
        {
            List<string> ret = new List<string>();
            if (!string.IsNullOrEmpty(m_MovePKColName))
            {
                string[] pkCols = m_MovePKColName.Split(',');

                for (int i = 0; i < pkCols.Length; i++)
                {
                    pkCols[i] = pkCols[i].Trim().ToUpper();

                    if (!string.IsNullOrEmpty(pkCols[i]))
                    {
                        for (int col = 0; col < Columns.Count; col++)
                        {
                            if (Columns[col].DataPropertyName == pkCols[i])
                            {
                                ret.Add(Columns[col].DataPropertyName);
                            }
                        }
                    }
                }
            }
            return ret;
        }
        
        private void MoveGridRow(string keyVal)
        {
            try
            {
                if (BindMove)
                {
                    string afterColName = "";
                    if (!string.IsNullOrEmpty(keyVal))
                    {
                        if (m_lstPKColName.Count <= 0)
                        {

                            m_lstPKColName = GetPKColNames();
                        }
                        for (int row = 0; row < Rows.Count; row++)
                        {
                            string compVal = "";

                            foreach (string colName in m_lstPKColName)
                            {
                                afterColName = GetColName(colName);
                                if (Rows[row].Cells[afterColName].Value != null)
                                {
                                    compVal += Rows[row].Cells[afterColName].Value.ToString();
                                }
                                else
                                {
                                    compVal += "";
                                }
                            }
                            if (compVal == keyVal)
                            {
                                Rows[row].Selected = true;

                                FirstDisplayedCell = Rows[row].Cells[GetFirstVisibleColIdx()];
                                if(OnMovePKFound!=null)
                                {
                                    OnMovePKFound(this, row);
                                }
                                m_IsSelected = true;
                                return;
                            }
                        }
                    }
                    if (OnMovePKNotFound != null)
                    {
                        OnMovePKNotFound(this);
                    }
                }
                if (m_BindAfterClearGrid)
                {
                    ClearSelection();
                }
            }
            catch (Exception eLog)
            {
                throw new Exception(eLog.Message);
            }
        }
        public void ShowLastRow()
        {
            try
            {
                int row = this.Rows.Count - 1;
                if (row >= 0)
                {
                    FirstDisplayedCell = Rows[row].Cells[GetFirstVisibleColIdx()];
                }
            }
            catch(Exception eLog)
            {
                throw new Exception(eLog.Message);
            }
        }

        public int GetFirstVisibleColIdx()
        {
            try
            {
                int idx = 0;
                foreach (DataGridViewColumn col in Columns)
                {

                    if (col.Visible)
                    {
                        return idx;
                    }
                    idx++;
                }
                return idx;
            }
            catch (Exception eLog)
            {
                throw new Exception(eLog.Message);
            }
        }
        [Browsable(false)]
        public int SelectedRowIdx
        {
            get
            {
                if (this.SelectedRows.Count > 0)
                {
                    return SelectedRows[0].Index;
                }
                return -1;
            }
        }
        protected override void OnCellEndEdit(DataGridViewCellEventArgs e)
        {
            base.OnCellEndEdit(e);
            Rows[e.RowIndex].HeaderCell.Value = "U";
            Rows[e.RowIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }
        protected override void OnColumnAdded(DataGridViewColumnEventArgs e)
        {
            base.OnColumnAdded(e);
            if (AutoBindName)
            {
                e.Column.DataPropertyName = e.Column.Name;
            }

        }
        protected override void OnSelectionChanged(EventArgs e)
        {
            base.OnSelectionChanged(e);
        }
        protected override void OnDataSourceChanged(EventArgs e)
        {
            
            
            base.OnDataSourceChanged(e);
            m_IsSelected = false;
            if (DataSource !=null && m_ScrollLock && Rows.Count> m_LastScollRow)
            {
                FirstDisplayedScrollingRowIndex = m_LastScollRow;               
            }
            if (m_ScrollLock == true && m_bScrollMove)
            { }
            else
            {
                MoveGridRow(m_LastSelectedKey);
            }

            m_bScrollMove = false;
            
        }
        protected override void OnSorted(EventArgs e)
        {
            base.OnSorted(e);
            if (!string.IsNullOrEmpty(m_LastSelectedKey))
            {
                MoveGridRow(m_LastSelectedKey);
            }
        }
        protected override void OnScroll(ScrollEventArgs e)
        {
            base.OnScroll(e);

            m_LastScollRow = e.NewValue;
            m_bScrollMove = true;
        }
        public void MoveToRow(string[] cols)
        {
            try
            {
                if (Rows.Count > 0 && Columns.Count > 0)
                {
                    string compKey = "";
                    int moveRow = 0;
                    for (int row = 0; row < Rows.Count; row++)
                    {
                        compKey = "";
                        for (int i = 0; i < cols.Length; i++)
                        {
                            compKey += GetValue(row, cols[i]);
                        }
                        if (m_LastSelectedKey == compKey)
                        {
                            moveRow = row;
                            break;
                        }
                    }
                    Rows[moveRow].Selected = true;
                    FirstDisplayedCell = Rows[moveRow].Cells[0];
                }
            }
            catch (Exception eLog)
            {
                throw new Exception(eLog.Message);
            }
        }


        #region Interface Define

        public void ClearValue()
        {
            this.DataSource = null;
        }

        public object GetCellValue(int row, string colBindNM)
        {
            try
            {
                string colName = GetColNM(colBindNM);
                if (!this.Columns.Contains(colName))
                {
                    return null;
                }
                if (row >= 0 && row < Rows.Count)
                {
                    if (this.Rows[row].Cells[colName].Value != null)
                    {
                        return this.Rows[row].Cells[colName].Value;
                    }
                }
                return null;
            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
                return null;
            }
        }

        public object GetCellValue(int row, int col)
        {
            try
            {
                if (row >= 0 && row < Rows.Count)
                {
                    if (this.Rows[row].Cells[col].Value != null)
                    {
                        return this.Rows[row].Cells[col].Value;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);

            }
            return null;
        }

        public string GetColNM(string colBindNM)
        {
            for (int i = 0; i < Columns.Count; i++)
            {
                if (Columns[i].DataPropertyName == colBindNM)
                {
                    return Columns[i].Name;
                }
            }
            return "";
        }

        public string GetColNM(int col)
        {
            return Columns[col].Name;
        }
        public string GetColBindNM(int col)
        {
            return Columns[col].DataPropertyName;
        }
        public object GetValue()
        {
            return this.DataSource;
        }

        public void SetValue(object val)
        {
            SetValue(val, "Value");
        }
        public void SetValue(object val, string colName = "Value")
        {
            
            if (Columns.Count <= 0)
            {
                AutoGenerateColumns = true;
            }
            if (val is DataTable)
            {
                this.DataSource = val;
            }
            else if (val is DataSet)
            {
                this.DataSource = ((DataSet)val).Tables[0];
            }
            else if (val is IDictionary)
            {
                DataTable dt = new DataTable();
                List<object> vals = new List<object>();
                foreach (var item in ((IDictionary)val).Keys)
                {
                    var key = item;
                    DataColumn col = new DataColumn();
                    col.ColumnName = key.ToString();
                    dt.Columns.Add(col);
                    vals.Add(((IDictionary)val)[key]);
                }
                dt.Rows.Add(vals.ToArray());
                this.DataSource = dt;
                foreach (DataGridViewColumn dvcol in this.Columns)
                {
                    dvcol.HeaderText = dvcol.Name;
                }
            }
            else
            {
                DataColumn dc = new DataColumn(colName);
                DataTable dt = new DataTable();
                dt.Columns.Add(dc);
                DataRow dr = dt.NewRow();
                dr[0] = val;
                dt.Rows.Add(dr);
                this.DataSource = dt;
            }
        }
        public void RefreshCtl()
        {
            foreach (DataGridViewColumn col in this.Columns)
            {
                if (m_FixedSort)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                else
                {
                    col.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }

            if (GridMode == GridModeEnum.QueryNomal)
            {

                this.MultiSelect = false;
                this.RowHeadersVisible = false;
                this.ReadOnly = true;
                this.MultiSelect = false;
                this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                this.AllowUserToAddRows = false;
                this.AllowUserToOrderColumns = false;
                this.AllowUserToResizeColumns = false;
                this.AllowUserToResizeRows = false;
                this.AllowUserToOrderColumns = false;
                //this.RowTemplate.Height = 40;
                this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
              //  this.ColumnHeadersHeight = 30;
                this.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
                this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
        }
        #endregion

    }
}
