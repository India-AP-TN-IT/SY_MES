namespace SY_MES.Logics.MES.Sub
{
    partial class FT_BC
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
            this.ETGrid = new SY_MES.FX.Controls.YDataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLoad = new SY_MES.FX.Controls.YBitLabel();
            this.lblStatus = new SY_MES.FX.Controls.YBitLabel();
            this.simplePlcUI1 = new SY_MES.FX.PLC.SimplePlcUI();
            this.lblETCD = new SY_MES.FX.Controls.YLabel();
            this.yLabel2 = new SY_MES.FX.Controls.YLabel();
            this.yLabel1 = new SY_MES.FX.Controls.YLabel();
            this.ISEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEA_VAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RSLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RSTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ETGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.ISEQ,
            this.ITEM_DESC,
            this.MEA_VAL,
            this.RSLT,
            this.RSTATUS});
            this.ETGrid.Desc = "";
            this.ETGrid.FixedSort = true;
            this.ETGrid.HeaderAlignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ETGrid.HeaderHeight = 50;
            this.ETGrid.JustifiedWidthColNM = "ITEM_DESC";
            this.ETGrid.Key = "";
            this.ETGrid.Location = new System.Drawing.Point(3, 113);
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
            this.ETGrid.Size = new System.Drawing.Size(634, 778);
            this.ETGrid.TabIndex = 1;
            this.ETGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ETGrid_DataBindingComplete);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblLoad);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.simplePlcUI1);
            this.groupBox1.Controls.Add(this.lblETCD);
            this.groupBox1.Controls.Add(this.yLabel2);
            this.groupBox1.Controls.Add(this.yLabel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functional Test Information";
            // 
            // lblLoad
            // 
            this.lblLoad.BackColor = System.Drawing.Color.Black;
            this.lblLoad.Desc = "";
            this.lblLoad.ForeColor = System.Drawing.Color.White;
            this.lblLoad.Key = "";
            this.lblLoad.Location = new System.Drawing.Point(298, 74);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.OffBGColor = System.Drawing.Color.Black;
            this.lblLoad.OffForeColor = System.Drawing.Color.White;
            this.lblLoad.OnBGColor = System.Drawing.Color.Lime;
            this.lblLoad.OnForeColor = System.Drawing.Color.Black;
            this.lblLoad.Size = new System.Drawing.Size(17, 16);
            this.lblLoad.TabIndex = 5;
            this.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Black;
            this.lblStatus.Desc = "WAIT";
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Key = "";
            this.lblStatus.Location = new System.Drawing.Point(124, 68);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.OffBGColor = System.Drawing.Color.Black;
            this.lblStatus.OffForeColor = System.Drawing.Color.White;
            this.lblStatus.OnBGColor = System.Drawing.Color.Lime;
            this.lblStatus.OnForeColor = System.Drawing.Color.Black;
            this.lblStatus.Size = new System.Drawing.Size(162, 29);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "WAIT";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // simplePlcUI1
            // 
            this.simplePlcUI1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simplePlcUI1.Location = new System.Drawing.Point(507, 30);
            this.simplePlcUI1.Name = "simplePlcUI1";
            this.simplePlcUI1.Size = new System.Drawing.Size(121, 57);
            this.simplePlcUI1.TabIndex = 4;
            this.simplePlcUI1.Title = "ET PLC";
            // 
            // lblETCD
            // 
            this.lblETCD.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblETCD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblETCD.Desc = "yLabel3";
            this.lblETCD.EditStyle = true;
            this.lblETCD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblETCD.Key = "";
            this.lblETCD.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lblETCD.Location = new System.Drawing.Point(124, 36);
            this.lblETCD.Name = "lblETCD";
            this.lblETCD.Size = new System.Drawing.Size(191, 29);
            this.lblETCD.TabIndex = 2;
            this.lblETCD.Text = "yLabel3";
            this.lblETCD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel2
            // 
            this.yLabel2.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel2.Desc = "Test Status";
            this.yLabel2.EditStyle = false;
            this.yLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel2.Key = "";
            this.yLabel2.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel2.Location = new System.Drawing.Point(6, 68);
            this.yLabel2.Name = "yLabel2";
            this.yLabel2.Size = new System.Drawing.Size(112, 29);
            this.yLabel2.TabIndex = 1;
            this.yLabel2.Text = "Test Status";
            this.yLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel1
            // 
            this.yLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel1.Desc = "ET Code";
            this.yLabel1.EditStyle = false;
            this.yLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel1.Key = "";
            this.yLabel1.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel1.Location = new System.Drawing.Point(6, 36);
            this.yLabel1.Name = "yLabel1";
            this.yLabel1.Size = new System.Drawing.Size(112, 29);
            this.yLabel1.TabIndex = 0;
            this.yLabel1.Text = "ET Code";
            this.yLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ISEQ
            // 
            this.ISEQ.DataPropertyName = "ISEQ";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ISEQ.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.ITEM_DESC.Width = 280;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RSLT.DefaultCellStyle = dataGridViewCellStyle3;
            this.RSLT.HeaderText = "RSLT";
            this.RSLT.MinimumWidth = 10;
            this.RSLT.Name = "RSLT";
            this.RSLT.ReadOnly = true;
            this.RSLT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RSLT.Width = 75;
            // 
            // RSTATUS
            // 
            this.RSTATUS.DataPropertyName = "RSTATUS";
            this.RSTATUS.HeaderText = "STATUS";
            this.RSTATUS.Name = "RSTATUS";
            this.RSTATUS.ReadOnly = true;
            this.RSTATUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RSTATUS.Visible = false;
            // 
            // FT_BC
            // 
            this.AutoLoadData = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.ETGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "FT_BC";
            this.Size = new System.Drawing.Size(640, 894);
            ((System.ComponentModel.ISupportInitialize)(this.ETGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FX.PLC.SimplePlcUI simplePlcUI1;
        private FX.Controls.YLabel lblETCD;
        private FX.Controls.YLabel yLabel2;
        private FX.Controls.YLabel yLabel1;
        private FX.Controls.YDataGridView ETGrid;
        private FX.Controls.YBitLabel lblStatus;
        private FX.Controls.YBitLabel lblLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEA_VAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RSLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn RSTATUS;
    }
}
