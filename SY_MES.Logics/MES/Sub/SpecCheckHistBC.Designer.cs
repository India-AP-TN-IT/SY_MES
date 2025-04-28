namespace SY_MES.Logics.MES.Sub
{
    partial class SpecCheckHistBC
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
            this.yLabel1 = new SY_MES.FX.Controls.YLabel();
            this.yLabel2 = new SY_MES.FX.Controls.YLabel();
            this.yLabel3 = new SY_MES.FX.Controls.YLabel();
            this.yLabel4 = new SY_MES.FX.Controls.YLabel();
            this.yDataGridView1 = new SY_MES.FX.Controls.YDataGridView();
            this.PROCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROCNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_PARTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.yDataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yLabel1
            // 
            this.yLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel1.Desc = "LOT NO.";
            this.yLabel1.EditStyle = false;
            this.yLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel1.Key = "";
            this.yLabel1.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel1.Location = new System.Drawing.Point(2, 7);
            this.yLabel1.Name = "yLabel1";
            this.yLabel1.Size = new System.Drawing.Size(85, 31);
            this.yLabel1.TabIndex = 0;
            this.yLabel1.Text = "LOT NO.";
            this.yLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel2
            // 
            this.yLabel2.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel2.Desc = "yLabel2";
            this.yLabel2.EditStyle = true;
            this.yLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel2.Key = "";
            this.yLabel2.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.TextLabel;
            this.yLabel2.Location = new System.Drawing.Point(93, 7);
            this.yLabel2.Name = "yLabel2";
            this.yLabel2.Size = new System.Drawing.Size(257, 31);
            this.yLabel2.TabIndex = 1;
            this.yLabel2.Text = "yLabel2";
            this.yLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel3
            // 
            this.yLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yLabel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.yLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel3.Desc = "yLabel3";
            this.yLabel3.EditStyle = true;
            this.yLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel3.Key = "";
            this.yLabel3.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.TextLabel;
            this.yLabel3.Location = new System.Drawing.Point(96, 4);
            this.yLabel3.Name = "yLabel3";
            this.yLabel3.Size = new System.Drawing.Size(458, 31);
            this.yLabel3.TabIndex = 3;
            this.yLabel3.Text = "yLabel3";
            this.yLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel4
            // 
            this.yLabel4.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel4.Desc = "P/NO";
            this.yLabel4.EditStyle = false;
            this.yLabel4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel4.Key = "";
            this.yLabel4.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel4.Location = new System.Drawing.Point(5, 4);
            this.yLabel4.Name = "yLabel4";
            this.yLabel4.Size = new System.Drawing.Size(85, 31);
            this.yLabel4.TabIndex = 2;
            this.yLabel4.Text = "P/NO";
            this.yLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.PROCCD,
            this.PROCNM,
            this.PARTNO,
            this.MAT_PARTNO});
            this.yDataGridView1.Desc = "";
            this.yDataGridView1.FixedSort = true;
            this.yDataGridView1.HeaderAlignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.yDataGridView1.HeaderHeight = 40;
            this.yDataGridView1.JustifiedWidthColNM = "";
            this.yDataGridView1.Key = "";
            this.yDataGridView1.Location = new System.Drawing.Point(3, 49);
            this.yDataGridView1.MovePKColName = "";
            this.yDataGridView1.MultiSelect = false;
            this.yDataGridView1.Name = "yDataGridView1";
            this.yDataGridView1.ReadOnly = true;
            this.yDataGridView1.RowHeadersVisible = false;
            this.yDataGridView1.RowHeight = 40;
            this.yDataGridView1.RowTemplate.Height = 40;
            this.yDataGridView1.ScrollLock = false;
            this.yDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.yDataGridView1.Size = new System.Drawing.Size(907, 554);
            this.yDataGridView1.TabIndex = 4;
            // 
            // PROCCD
            // 
            this.PROCCD.DataPropertyName = "PROCCD";
            this.PROCCD.HeaderText = "STATION";
            this.PROCCD.Name = "PROCCD";
            this.PROCCD.ReadOnly = true;
            this.PROCCD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PROCCD.Visible = false;
            this.PROCCD.Width = 250;
            // 
            // PROCNM
            // 
            this.PROCNM.DataPropertyName = "PROCNM";
            this.PROCNM.HeaderText = "Station Name";
            this.PROCNM.Name = "PROCNM";
            this.PROCNM.ReadOnly = true;
            this.PROCNM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PROCNM.Width = 230;
            // 
            // PARTNO
            // 
            this.PARTNO.DataPropertyName = "PARTNO";
            this.PARTNO.HeaderText = "Part NO.";
            this.PARTNO.Name = "PARTNO";
            this.PARTNO.ReadOnly = true;
            this.PARTNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PARTNO.Width = 320;
            // 
            // MAT_PARTNO
            // 
            this.MAT_PARTNO.DataPropertyName = "MAT_PARTNO";
            this.MAT_PARTNO.HeaderText = "SPEC CHK";
            this.MAT_PARTNO.Name = "MAT_PARTNO";
            this.MAT_PARTNO.ReadOnly = true;
            this.MAT_PARTNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MAT_PARTNO.Width = 320;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.yLabel3);
            this.panel1.Controls.Add(this.yLabel4);
            this.panel1.Location = new System.Drawing.Point(356, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 40);
            this.panel1.TabIndex = 5;
            // 
            // SpecCheckHistBC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.yDataGridView1);
            this.Controls.Add(this.yLabel2);
            this.Controls.Add(this.yLabel1);
            this.Name = "SpecCheckHistBC";
            this.Size = new System.Drawing.Size(917, 606);
            ((System.ComponentModel.ISupportInitialize)(this.yDataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FX.Controls.YLabel yLabel1;
        private FX.Controls.YLabel yLabel2;
        private FX.Controls.YLabel yLabel3;
        private FX.Controls.YLabel yLabel4;
        private FX.Controls.YDataGridView yDataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROCNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_PARTNO;
    }
}
