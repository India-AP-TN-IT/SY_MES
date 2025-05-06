namespace SY_MES.Logics.MES.Sub
{
    partial class TrolleyStockListBC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.yBitLabel1 = new SY_MES.FX.Controls.YBitLabel();
            this.yLabel6 = new SY_MES.FX.Controls.YLabel();
            this.yDataGridView1 = new SY_MES.FX.Controls.YDataGridView();
            this.yBitLabel2 = new SY_MES.FX.Controls.YBitLabel();
            this.yLabel1 = new SY_MES.FX.Controls.YLabel();
            this.SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCAN_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.yDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // yBitLabel1
            // 
            this.yBitLabel1.BackColor = System.Drawing.Color.Black;
            this.yBitLabel1.Desc = "yBitLabel1";
            this.yBitLabel1.ForeColor = System.Drawing.Color.White;
            this.yBitLabel1.Key = "";
            this.yBitLabel1.Location = new System.Drawing.Point(121, 4);
            this.yBitLabel1.Name = "yBitLabel1";
            this.yBitLabel1.OffBGColor = System.Drawing.Color.Black;
            this.yBitLabel1.OffForeColor = System.Drawing.Color.White;
            this.yBitLabel1.OnBGColor = System.Drawing.Color.Lime;
            this.yBitLabel1.OnForeColor = System.Drawing.Color.Black;
            this.yBitLabel1.Size = new System.Drawing.Size(386, 39);
            this.yBitLabel1.TabIndex = 16;
            this.yBitLabel1.Text = "yBitLabel1";
            this.yBitLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel6
            // 
            this.yLabel6.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel6.Desc = "TROLLEY NO";
            this.yLabel6.EditStyle = false;
            this.yLabel6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel6.Key = "";
            this.yLabel6.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel6.Location = new System.Drawing.Point(3, 4);
            this.yLabel6.Name = "yLabel6";
            this.yLabel6.Size = new System.Drawing.Size(112, 39);
            this.yLabel6.TabIndex = 15;
            this.yLabel6.Text = "TROLLEY NO";
            this.yLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yDataGridView1
            // 
            this.yDataGridView1.AllowUserToAddRows = false;
            this.yDataGridView1.AllowUserToResizeColumns = false;
            this.yDataGridView1.AllowUserToResizeRows = false;
            this.yDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yDataGridView1.AutoBindName = true;
            this.yDataGridView1.AutoGenerateColumns = false;
            this.yDataGridView1.AutoMultiSelection = false;
            this.yDataGridView1.BindMove = false;
            this.yDataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.yDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.yDataGridView1.ColumnHeadersHeight = 40;
            this.yDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.yDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SEQ,
            this.LOTNO,
            this.PARTNO,
            this.SCAN_DATE});
            this.yDataGridView1.Desc = "";
            this.yDataGridView1.FixedSort = true;
            this.yDataGridView1.HeaderAlignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.yDataGridView1.HeaderHeight = 40;
            this.yDataGridView1.JustifiedWidthColNM = "";
            this.yDataGridView1.Key = "";
            this.yDataGridView1.Location = new System.Drawing.Point(3, 46);
            this.yDataGridView1.MovePKColName = "";
            this.yDataGridView1.MultiSelect = false;
            this.yDataGridView1.MultiSelectionColor = System.Drawing.Color.Yellow;
            this.yDataGridView1.Name = "yDataGridView1";
            this.yDataGridView1.ReadOnly = true;
            this.yDataGridView1.RowHeadersVisible = false;
            this.yDataGridView1.RowHeight = 35;
            this.yDataGridView1.RowTemplate.Height = 35;
            this.yDataGridView1.ScrollLock = false;
            this.yDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.yDataGridView1.Size = new System.Drawing.Size(660, 540);
            this.yDataGridView1.TabIndex = 17;
            // 
            // yBitLabel2
            // 
            this.yBitLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yBitLabel2.BackColor = System.Drawing.Color.Black;
            this.yBitLabel2.Desc = "yBitLabel2";
            this.yBitLabel2.ForeColor = System.Drawing.Color.White;
            this.yBitLabel2.Key = "";
            this.yBitLabel2.Location = new System.Drawing.Point(586, 5);
            this.yBitLabel2.Name = "yBitLabel2";
            this.yBitLabel2.OffBGColor = System.Drawing.Color.Black;
            this.yBitLabel2.OffForeColor = System.Drawing.Color.White;
            this.yBitLabel2.OnBGColor = System.Drawing.Color.Lime;
            this.yBitLabel2.OnForeColor = System.Drawing.Color.Black;
            this.yBitLabel2.Size = new System.Drawing.Size(77, 39);
            this.yBitLabel2.TabIndex = 18;
            this.yBitLabel2.Text = "yBitLabel2";
            this.yBitLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel1
            // 
            this.yLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel1.Desc = "QTY";
            this.yLabel1.EditStyle = false;
            this.yLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel1.Key = "";
            this.yLabel1.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel1.Location = new System.Drawing.Point(513, 5);
            this.yLabel1.Name = "yLabel1";
            this.yLabel1.Size = new System.Drawing.Size(67, 39);
            this.yLabel1.TabIndex = 19;
            this.yLabel1.Text = "QTY";
            this.yLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SEQ
            // 
            this.SEQ.DataPropertyName = "SEQ";
            this.SEQ.HeaderText = "SEQ";
            this.SEQ.Name = "SEQ";
            this.SEQ.ReadOnly = true;
            this.SEQ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SEQ.Width = 50;
            // 
            // LOTNO
            // 
            this.LOTNO.DataPropertyName = "LOTNO";
            this.LOTNO.HeaderText = "LOT NO.";
            this.LOTNO.Name = "LOTNO";
            this.LOTNO.ReadOnly = true;
            this.LOTNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LOTNO.Width = 160;
            // 
            // PARTNO
            // 
            this.PARTNO.DataPropertyName = "PARTNO";
            this.PARTNO.HeaderText = "Part NO.";
            this.PARTNO.Name = "PARTNO";
            this.PARTNO.ReadOnly = true;
            this.PARTNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PARTNO.Width = 210;
            // 
            // SCAN_DATE
            // 
            this.SCAN_DATE.DataPropertyName = "SCAN_DATE";
            this.SCAN_DATE.HeaderText = "Date";
            this.SCAN_DATE.Name = "SCAN_DATE";
            this.SCAN_DATE.ReadOnly = true;
            this.SCAN_DATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SCAN_DATE.Width = 210;
            // 
            // TrolleyStockListBC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.yLabel1);
            this.Controls.Add(this.yBitLabel2);
            this.Controls.Add(this.yDataGridView1);
            this.Controls.Add(this.yBitLabel1);
            this.Controls.Add(this.yLabel6);
            this.Name = "TrolleyStockListBC";
            this.Size = new System.Drawing.Size(666, 589);
            ((System.ComponentModel.ISupportInitialize)(this.yDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FX.Controls.YBitLabel yBitLabel1;
        private FX.Controls.YLabel yLabel6;
        private FX.Controls.YDataGridView yDataGridView1;
        private FX.Controls.YBitLabel yBitLabel2;
        private FX.Controls.YLabel yLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCAN_DATE;
    }
}
