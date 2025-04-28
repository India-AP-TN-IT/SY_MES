namespace SY_MES.Logics.MES.Sub
{
    partial class FTHistBC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ETGrid = new SY_MES.FX.Controls.YDataGridView();
            this.LSEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEA_VAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RSLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yLabel1 = new SY_MES.FX.Controls.YLabel();
            this.yLabel2 = new SY_MES.FX.Controls.YLabel();
            this.yLabel3 = new SY_MES.FX.Controls.YLabel();
            this.yLabel4 = new SY_MES.FX.Controls.YLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ETGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ETGrid
            // 
            this.ETGrid.AllowUserToAddRows = false;
            this.ETGrid.AllowUserToResizeColumns = false;
            this.ETGrid.AllowUserToResizeRows = false;
            this.ETGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ETGrid.AutoBindName = true;
            this.ETGrid.BindMove = false;
            this.ETGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ETGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ETGrid.ColumnHeadersHeight = 50;
            this.ETGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ETGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LSEQ,
            this.ISEQ,
            this.ITEM_DESC,
            this.MEA_VAL,
            this.RSLT});
            this.ETGrid.Desc = "";
            this.ETGrid.FixedSort = true;
            this.ETGrid.HeaderAlignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ETGrid.HeaderHeight = 50;
            this.ETGrid.JustifiedWidthColNM = "ITEM_DESC";
            this.ETGrid.Key = "";
            this.ETGrid.Location = new System.Drawing.Point(3, 42);
            this.ETGrid.MovePKColName = "";
            this.ETGrid.MultiSelect = false;
            this.ETGrid.Name = "ETGrid";
            this.ETGrid.ReadOnly = true;
            this.ETGrid.RowHeadersVisible = false;
            this.ETGrid.RowHeadersWidth = 82;
            this.ETGrid.RowHeight = 45;
            this.ETGrid.RowTemplate.Height = 45;
            this.ETGrid.ScrollLock = false;
            this.ETGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ETGrid.Size = new System.Drawing.Size(888, 656);
            this.ETGrid.TabIndex = 3;
            this.ETGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ETGrid_DataBindingComplete);
            // 
            // LSEQ
            // 
            this.LSEQ.DataPropertyName = "LSEQ";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LSEQ.DefaultCellStyle = dataGridViewCellStyle2;
            this.LSEQ.HeaderText = "L/SEQ";
            this.LSEQ.Name = "LSEQ";
            this.LSEQ.ReadOnly = true;
            this.LSEQ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LSEQ.Width = 65;
            // 
            // ISEQ
            // 
            this.ISEQ.DataPropertyName = "ISEQ";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ISEQ.DefaultCellStyle = dataGridViewCellStyle3;
            this.ISEQ.HeaderText = "SEQ";
            this.ISEQ.MinimumWidth = 10;
            this.ISEQ.Name = "ISEQ";
            this.ISEQ.ReadOnly = true;
            this.ISEQ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ISEQ.Width = 50;
            // 
            // ITEM_DESC
            // 
            this.ITEM_DESC.DataPropertyName = "ITEM_DESC";
            this.ITEM_DESC.HeaderText = "INSPECTION ITEM";
            this.ITEM_DESC.MinimumWidth = 10;
            this.ITEM_DESC.Name = "ITEM_DESC";
            this.ITEM_DESC.ReadOnly = true;
            this.ITEM_DESC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ITEM_DESC.Width = 474;
            // 
            // MEA_VAL
            // 
            this.MEA_VAL.DataPropertyName = "MEA_VAL";
            this.MEA_VAL.HeaderText = "VALUE";
            this.MEA_VAL.MinimumWidth = 10;
            this.MEA_VAL.Name = "MEA_VAL";
            this.MEA_VAL.ReadOnly = true;
            this.MEA_VAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MEA_VAL.Width = 200;
            // 
            // RSLT
            // 
            this.RSLT.DataPropertyName = "RSLT";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RSLT.DefaultCellStyle = dataGridViewCellStyle4;
            this.RSLT.HeaderText = "RSLT";
            this.RSLT.MinimumWidth = 10;
            this.RSLT.Name = "RSLT";
            this.RSLT.ReadOnly = true;
            this.RSLT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RSLT.Width = 50;
            // 
            // yLabel1
            // 
            this.yLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel1.Desc = "LOT";
            this.yLabel1.EditStyle = false;
            this.yLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel1.Key = "";
            this.yLabel1.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel1.Location = new System.Drawing.Point(3, 3);
            this.yLabel1.Name = "yLabel1";
            this.yLabel1.Size = new System.Drawing.Size(93, 36);
            this.yLabel1.TabIndex = 4;
            this.yLabel1.Text = "LOT";
            this.yLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel2
            // 
            this.yLabel2.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel2.Desc = "LOT";
            this.yLabel2.EditStyle = false;
            this.yLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel2.Key = "";
            this.yLabel2.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel2.Location = new System.Drawing.Point(102, 3);
            this.yLabel2.Name = "yLabel2";
            this.yLabel2.Size = new System.Drawing.Size(241, 36);
            this.yLabel2.TabIndex = 5;
            this.yLabel2.Text = "LOT";
            this.yLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel3
            // 
            this.yLabel3.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel3.Desc = "LOT";
            this.yLabel3.EditStyle = false;
            this.yLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel3.Key = "";
            this.yLabel3.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel3.Location = new System.Drawing.Point(457, 3);
            this.yLabel3.Name = "yLabel3";
            this.yLabel3.Size = new System.Drawing.Size(312, 36);
            this.yLabel3.TabIndex = 7;
            this.yLabel3.Text = "LOT";
            this.yLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel4
            // 
            this.yLabel4.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel4.Desc = "Part NO.";
            this.yLabel4.EditStyle = false;
            this.yLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel4.Key = "";
            this.yLabel4.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel4.Location = new System.Drawing.Point(358, 3);
            this.yLabel4.Name = "yLabel4";
            this.yLabel4.Size = new System.Drawing.Size(93, 36);
            this.yLabel4.TabIndex = 6;
            this.yLabel4.Text = "Part NO.";
            this.yLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FTHistBC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.yLabel3);
            this.Controls.Add(this.yLabel4);
            this.Controls.Add(this.yLabel2);
            this.Controls.Add(this.yLabel1);
            this.Controls.Add(this.ETGrid);
            this.Name = "FTHistBC";
            this.Size = new System.Drawing.Size(894, 701);
            ((System.ComponentModel.ISupportInitialize)(this.ETGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FX.Controls.YDataGridView ETGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LSEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEA_VAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RSLT;
        private FX.Controls.YLabel yLabel1;
        private FX.Controls.YLabel yLabel2;
        private FX.Controls.YLabel yLabel3;
        private FX.Controls.YLabel yLabel4;
    }
}
