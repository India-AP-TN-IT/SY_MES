namespace SY_MES.DEPLOY.Sub
{
    partial class StationRsltDlg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_RSLT = new SY_MES.FX.Controls.YLabel();
            this.yLabel6 = new SY_MES.FX.Controls.YLabel();
            this.lbl_TOT = new SY_MES.FX.Controls.YLabel();
            this.yLabel3 = new SY_MES.FX.Controls.YLabel();
            this.GrdRSLT = new SY_MES.FX.Controls.YDataGridView();
            this.SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOT_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RSLT_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEND_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDateTime1 = new SY_MES.FX.Controls.YDateTime();
            this.lbl_POS = new SY_MES.FX.Controls.YLabel();
            this.yLabel4 = new SY_MES.FX.Controls.YLabel();
            this.lbl_STATIONCD = new SY_MES.FX.Controls.YLabel();
            this.yLabel2 = new SY_MES.FX.Controls.YLabel();
            this.lbl_LINECD = new SY_MES.FX.Controls.YLabel();
            this.lbl_SPEC1_TIT = new SY_MES.FX.Controls.YLabel();
            this.lbl_PENDING = new SY_MES.FX.Controls.YLabel();
            this.yLabel8 = new SY_MES.FX.Controls.YLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRSLT)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_RSLT
            // 
            this.lbl_RSLT.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_RSLT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_RSLT.Desc = "SPEC1 DESC";
            this.lbl_RSLT.EditStyle = true;
            this.lbl_RSLT.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_RSLT.Key = "";
            this.lbl_RSLT.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lbl_RSLT.Location = new System.Drawing.Point(278, 95);
            this.lbl_RSLT.Name = "lbl_RSLT";
            this.lbl_RSLT.Size = new System.Drawing.Size(73, 27);
            this.lbl_RSLT.TabIndex = 25;
            this.lbl_RSLT.Text = "SPEC1 DESC";
            this.lbl_RSLT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel6
            // 
            this.yLabel6.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel6.Desc = "Result";
            this.yLabel6.EditStyle = true;
            this.yLabel6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel6.Key = "";
            this.yLabel6.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel6.Location = new System.Drawing.Point(201, 95);
            this.yLabel6.Name = "yLabel6";
            this.yLabel6.Size = new System.Drawing.Size(71, 27);
            this.yLabel6.TabIndex = 24;
            this.yLabel6.Text = "Result";
            this.yLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TOT
            // 
            this.lbl_TOT.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_TOT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TOT.Desc = "SPEC1 DESC";
            this.lbl_TOT.EditStyle = true;
            this.lbl_TOT.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_TOT.Key = "";
            this.lbl_TOT.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lbl_TOT.Location = new System.Drawing.Point(86, 95);
            this.lbl_TOT.Name = "lbl_TOT";
            this.lbl_TOT.Size = new System.Drawing.Size(96, 27);
            this.lbl_TOT.TabIndex = 23;
            this.lbl_TOT.Text = "SPEC1 DESC";
            this.lbl_TOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel3
            // 
            this.yLabel3.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel3.Desc = "T/QTY";
            this.yLabel3.EditStyle = true;
            this.yLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel3.Key = "";
            this.yLabel3.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel3.Location = new System.Drawing.Point(6, 96);
            this.yLabel3.Name = "yLabel3";
            this.yLabel3.Size = new System.Drawing.Size(74, 27);
            this.yLabel3.TabIndex = 22;
            this.yLabel3.Text = "T/QTY";
            this.yLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrdRSLT
            // 
            this.GrdRSLT.AllowUserToAddRows = false;
            this.GrdRSLT.AllowUserToResizeColumns = false;
            this.GrdRSLT.AllowUserToResizeRows = false;
            this.GrdRSLT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdRSLT.AutoBindName = true;
            this.GrdRSLT.BindMove = false;
            this.GrdRSLT.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdRSLT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdRSLT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SEQ,
            this.PARTNO,
            this.ALCCD,
            this.TOT_QTY,
            this.RSLT_QTY,
            this.PEND_QTY});
            this.GrdRSLT.Desc = "";
            this.GrdRSLT.FixedSort = true;
            this.GrdRSLT.HeaderAlignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GrdRSLT.HeaderHeight = 23;
            this.GrdRSLT.Key = "";
            this.GrdRSLT.Location = new System.Drawing.Point(6, 132);
            this.GrdRSLT.MovePKColName = "";
            this.GrdRSLT.MultiSelect = false;
            this.GrdRSLT.Name = "GrdRSLT";
            this.GrdRSLT.ReadOnly = true;
            this.GrdRSLT.RowHeadersVisible = false;
            this.GrdRSLT.RowHeight = 23;
            this.GrdRSLT.RowTemplate.Height = 23;
            this.GrdRSLT.ScrollLock = false;
            this.GrdRSLT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdRSLT.Size = new System.Drawing.Size(661, 415);
            this.GrdRSLT.TabIndex = 21;
            // 
            // SEQ
            // 
            this.SEQ.DataPropertyName = "SEQ";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SEQ.DefaultCellStyle = dataGridViewCellStyle2;
            this.SEQ.HeaderText = "SEQ.";
            this.SEQ.Name = "SEQ";
            this.SEQ.ReadOnly = true;
            this.SEQ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SEQ.Width = 50;
            // 
            // PARTNO
            // 
            this.PARTNO.DataPropertyName = "PARTNO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.PARTNO.DefaultCellStyle = dataGridViewCellStyle3;
            this.PARTNO.HeaderText = "Part No.";
            this.PARTNO.Name = "PARTNO";
            this.PARTNO.ReadOnly = true;
            this.PARTNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PARTNO.Width = 160;
            // 
            // ALCCD
            // 
            this.ALCCD.DataPropertyName = "ALCCD";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ALCCD.DefaultCellStyle = dataGridViewCellStyle4;
            this.ALCCD.HeaderText = "ALC";
            this.ALCCD.Name = "ALCCD";
            this.ALCCD.ReadOnly = true;
            this.ALCCD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ALCCD.Width = 80;
            // 
            // TOT_QTY
            // 
            this.TOT_QTY.DataPropertyName = "TOT_QTY";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TOT_QTY.DefaultCellStyle = dataGridViewCellStyle5;
            this.TOT_QTY.HeaderText = "T/QTY";
            this.TOT_QTY.Name = "TOT_QTY";
            this.TOT_QTY.ReadOnly = true;
            this.TOT_QTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TOT_QTY.Width = 65;
            // 
            // RSLT_QTY
            // 
            this.RSLT_QTY.DataPropertyName = "RSLT_QTY";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.RSLT_QTY.DefaultCellStyle = dataGridViewCellStyle6;
            this.RSLT_QTY.HeaderText = "Result";
            this.RSLT_QTY.Name = "RSLT_QTY";
            this.RSLT_QTY.ReadOnly = true;
            this.RSLT_QTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RSLT_QTY.Width = 65;
            // 
            // PEND_QTY
            // 
            this.PEND_QTY.DataPropertyName = "PEND_QTY";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PEND_QTY.DefaultCellStyle = dataGridViewCellStyle7;
            this.PEND_QTY.HeaderText = "PENDING";
            this.PEND_QTY.Name = "PEND_QTY";
            this.PEND_QTY.ReadOnly = true;
            this.PEND_QTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PEND_QTY.Width = 65;
            // 
            // yDateTime1
            // 
            this.yDateTime1.DateFormat = "yyyy-MM-dd";
            this.yDateTime1.Desc = "2014-09-06";
            this.yDateTime1.Key = "";
            this.yDateTime1.Location = new System.Drawing.Point(2, 63);
            this.yDateTime1.Name = "yDateTime1";
            this.yDateTime1.Size = new System.Drawing.Size(501, 30);
            this.yDateTime1.TabIndex = 20;
            this.yDateTime1.Title = "Production Date";
            this.yDateTime1.OnDateChg += new SY_MES.FX.Controls.YDateTime.DateChg(this.yDateTime1_OnDateChg);
            // 
            // lbl_POS
            // 
            this.lbl_POS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_POS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_POS.Desc = "SPEC1 DESC";
            this.lbl_POS.EditStyle = true;
            this.lbl_POS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_POS.Key = "";
            this.lbl_POS.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lbl_POS.Location = new System.Drawing.Point(528, 33);
            this.lbl_POS.Name = "lbl_POS";
            this.lbl_POS.Size = new System.Drawing.Size(139, 27);
            this.lbl_POS.TabIndex = 19;
            this.lbl_POS.Text = "SPEC1 DESC";
            this.lbl_POS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel4
            // 
            this.yLabel4.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel4.Desc = "Position";
            this.yLabel4.EditStyle = false;
            this.yLabel4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel4.Key = "";
            this.yLabel4.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel4.Location = new System.Drawing.Point(399, 33);
            this.yLabel4.Name = "yLabel4";
            this.yLabel4.Size = new System.Drawing.Size(123, 27);
            this.yLabel4.TabIndex = 18;
            this.yLabel4.Text = "Position";
            this.yLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_STATIONCD
            // 
            this.lbl_STATIONCD.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_STATIONCD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_STATIONCD.Desc = "SPEC1 DESC";
            this.lbl_STATIONCD.EditStyle = true;
            this.lbl_STATIONCD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_STATIONCD.Key = "";
            this.lbl_STATIONCD.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lbl_STATIONCD.Location = new System.Drawing.Point(135, 33);
            this.lbl_STATIONCD.Name = "lbl_STATIONCD";
            this.lbl_STATIONCD.Size = new System.Drawing.Size(253, 27);
            this.lbl_STATIONCD.TabIndex = 17;
            this.lbl_STATIONCD.Text = "SPEC1 DESC";
            this.lbl_STATIONCD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel2
            // 
            this.yLabel2.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel2.Desc = "Station";
            this.yLabel2.EditStyle = false;
            this.yLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel2.Key = "";
            this.yLabel2.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel2.Location = new System.Drawing.Point(6, 33);
            this.yLabel2.Name = "yLabel2";
            this.yLabel2.Size = new System.Drawing.Size(123, 27);
            this.yLabel2.TabIndex = 16;
            this.yLabel2.Text = "Station";
            this.yLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LINECD
            // 
            this.lbl_LINECD.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_LINECD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_LINECD.Desc = "SPEC1 DESC";
            this.lbl_LINECD.EditStyle = true;
            this.lbl_LINECD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_LINECD.Key = "";
            this.lbl_LINECD.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lbl_LINECD.Location = new System.Drawing.Point(135, 6);
            this.lbl_LINECD.Name = "lbl_LINECD";
            this.lbl_LINECD.Size = new System.Drawing.Size(253, 27);
            this.lbl_LINECD.TabIndex = 15;
            this.lbl_LINECD.Text = "SPEC1 DESC";
            this.lbl_LINECD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_SPEC1_TIT
            // 
            this.lbl_SPEC1_TIT.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_SPEC1_TIT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_SPEC1_TIT.Desc = "W/Center";
            this.lbl_SPEC1_TIT.EditStyle = false;
            this.lbl_SPEC1_TIT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_SPEC1_TIT.Key = "";
            this.lbl_SPEC1_TIT.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lbl_SPEC1_TIT.Location = new System.Drawing.Point(6, 6);
            this.lbl_SPEC1_TIT.Name = "lbl_SPEC1_TIT";
            this.lbl_SPEC1_TIT.Size = new System.Drawing.Size(123, 27);
            this.lbl_SPEC1_TIT.TabIndex = 14;
            this.lbl_SPEC1_TIT.Text = "W/Center";
            this.lbl_SPEC1_TIT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PENDING
            // 
            this.lbl_PENDING.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_PENDING.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_PENDING.Desc = "SPEC1 DESC";
            this.lbl_PENDING.EditStyle = true;
            this.lbl_PENDING.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_PENDING.Key = "";
            this.lbl_PENDING.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lbl_PENDING.Location = new System.Drawing.Point(460, 94);
            this.lbl_PENDING.Name = "lbl_PENDING";
            this.lbl_PENDING.Size = new System.Drawing.Size(73, 27);
            this.lbl_PENDING.TabIndex = 27;
            this.lbl_PENDING.Text = "SPEC1 DESC";
            this.lbl_PENDING.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel8
            // 
            this.yLabel8.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel8.Desc = "PENDING";
            this.yLabel8.EditStyle = true;
            this.yLabel8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel8.Key = "";
            this.yLabel8.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel8.Location = new System.Drawing.Point(372, 94);
            this.yLabel8.Name = "yLabel8";
            this.yLabel8.Size = new System.Drawing.Size(82, 27);
            this.yLabel8.TabIndex = 26;
            this.yLabel8.Text = "PENDING";
            this.yLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StationRsltDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_PENDING);
            this.Controls.Add(this.yLabel8);
            this.Controls.Add(this.lbl_RSLT);
            this.Controls.Add(this.yLabel6);
            this.Controls.Add(this.lbl_TOT);
            this.Controls.Add(this.yLabel3);
            this.Controls.Add(this.GrdRSLT);
            this.Controls.Add(this.yDateTime1);
            this.Controls.Add(this.lbl_POS);
            this.Controls.Add(this.yLabel4);
            this.Controls.Add(this.lbl_STATIONCD);
            this.Controls.Add(this.yLabel2);
            this.Controls.Add(this.lbl_LINECD);
            this.Controls.Add(this.lbl_SPEC1_TIT);
            this.Name = "StationRsltDlg";
            this.Size = new System.Drawing.Size(670, 550);
            ((System.ComponentModel.ISupportInitialize)(this.GrdRSLT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FX.Controls.YLabel lbl_LINECD;
        private FX.Controls.YLabel lbl_SPEC1_TIT;
        private FX.Controls.YLabel lbl_STATIONCD;
        private FX.Controls.YLabel yLabel2;
        private FX.Controls.YLabel lbl_POS;
        private FX.Controls.YLabel yLabel4;
        private FX.Controls.YDateTime yDateTime1;
        private FX.Controls.YDataGridView GrdRSLT;
        private FX.Controls.YLabel lbl_TOT;
        private FX.Controls.YLabel yLabel3;
        private FX.Controls.YLabel lbl_RSLT;
        private FX.Controls.YLabel yLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOT_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn RSLT_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEND_QTY;
        private FX.Controls.YLabel lbl_PENDING;
        private FX.Controls.YLabel yLabel8;
    }
}
