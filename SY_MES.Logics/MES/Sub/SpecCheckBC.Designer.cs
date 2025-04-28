namespace SY_MES.Logics.MES.Sub
{
    partial class SpecCheckBC
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
            this.GrdPart = new SY_MES.FX.Controls.YDataGridView();
            this.CHK_SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHK_PARTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHK_PARTNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHK_REV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHK_RESULT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAD_TAB_POS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPart)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdPart
            // 
            this.GrdPart.AllowUserToAddRows = false;
            this.GrdPart.AllowUserToResizeColumns = false;
            this.GrdPart.AllowUserToResizeRows = false;
            this.GrdPart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdPart.AutoBindName = true;
            this.GrdPart.BindMove = false;
            this.GrdPart.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdPart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdPart.ColumnHeadersHeight = 40;
            this.GrdPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHK_SEQ,
            this.CHK_PARTNO,
            this.CHK_PARTNM,
            this.CHK_REV,
            this.CHK_RESULT,
            this.LOAD_TAB_POS});
            this.GrdPart.Desc = "";
            this.GrdPart.FixedSort = true;
            this.GrdPart.HeaderAlignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GrdPart.HeaderHeight = 40;
            this.GrdPart.JustifiedWidthColNM = "CHK_PARTNM";
            this.GrdPart.Key = "";
            this.GrdPart.Location = new System.Drawing.Point(3, 3);
            this.GrdPart.MovePKColName = "";
            this.GrdPart.MultiSelect = false;
            this.GrdPart.Name = "GrdPart";
            this.GrdPart.ReadOnly = true;
            this.GrdPart.RowHeadersVisible = false;
            this.GrdPart.RowHeight = 40;
            this.GrdPart.RowTemplate.Height = 40;
            this.GrdPart.ScrollLock = false;
            this.GrdPart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdPart.Size = new System.Drawing.Size(795, 722);
            this.GrdPart.TabIndex = 0;
            // 
            // CHK_SEQ
            // 
            this.CHK_SEQ.DataPropertyName = "CHK_SEQ";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CHK_SEQ.DefaultCellStyle = dataGridViewCellStyle2;
            this.CHK_SEQ.HeaderText = "No";
            this.CHK_SEQ.Name = "CHK_SEQ";
            this.CHK_SEQ.ReadOnly = true;
            this.CHK_SEQ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CHK_SEQ.Width = 35;
            // 
            // CHK_PARTNO
            // 
            this.CHK_PARTNO.DataPropertyName = "CHK_PARTNO";
            this.CHK_PARTNO.HeaderText = "Material Part No.";
            this.CHK_PARTNO.Name = "CHK_PARTNO";
            this.CHK_PARTNO.ReadOnly = true;
            this.CHK_PARTNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CHK_PARTNO.Width = 250;
            // 
            // CHK_PARTNM
            // 
            this.CHK_PARTNM.DataPropertyName = "CHK_PARTNM";
            this.CHK_PARTNM.HeaderText = "Part Name";
            this.CHK_PARTNM.Name = "CHK_PARTNM";
            this.CHK_PARTNM.ReadOnly = true;
            this.CHK_PARTNM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CHK_PARTNM.Width = 380;
            // 
            // CHK_REV
            // 
            this.CHK_REV.DataPropertyName = "CHK_REV";
            this.CHK_REV.HeaderText = "Column1";
            this.CHK_REV.Name = "CHK_REV";
            this.CHK_REV.ReadOnly = true;
            this.CHK_REV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CHK_REV.Visible = false;
            // 
            // CHK_RESULT
            // 
            this.CHK_RESULT.DataPropertyName = "CHK_RESULT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CHK_RESULT.DefaultCellStyle = dataGridViewCellStyle3;
            this.CHK_RESULT.HeaderText = "Result";
            this.CHK_RESULT.Name = "CHK_RESULT";
            this.CHK_RESULT.ReadOnly = true;
            this.CHK_RESULT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LOAD_TAB_POS
            // 
            this.LOAD_TAB_POS.DataPropertyName = "LOAD_TAB_POS";
            this.LOAD_TAB_POS.HeaderText = "LOAD_POS";
            this.LOAD_TAB_POS.Name = "LOAD_TAB_POS";
            this.LOAD_TAB_POS.ReadOnly = true;
            this.LOAD_TAB_POS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LOAD_TAB_POS.Visible = false;
            // 
            // SpecCheckBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrdPart);
            this.Name = "SpecCheckBC";
            this.Size = new System.Drawing.Size(801, 728);
            ((System.ComponentModel.ISupportInitialize)(this.GrdPart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FX.Controls.YDataGridView GrdPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHK_SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHK_PARTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHK_PARTNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHK_REV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHK_RESULT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAD_TAB_POS;
    }
}
