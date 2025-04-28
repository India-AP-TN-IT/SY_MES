namespace SY_MES.Logics.MES.Sub
{
    partial class WOPrintBC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WOPrintBC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PrtHelper = new SY_MES.FX.Devices.Printer.PrtHelper();
            this.Chk_All = new SY_MES.FX.Controls.YCheckBox();
            this.yButton4 = new SY_MES.FX.Controls.YButton();
            this.yWorkerLabel1 = new SY_MES.FX.Controls.YWorkerLabel();
            this.lblShift = new SY_MES.FX.Controls.YLabel();
            this.yLabel6 = new SY_MES.FX.Controls.YLabel();
            this.yButton3 = new SY_MES.FX.Controls.YButton();
            this.lblPOS = new SY_MES.FX.Controls.YLabel();
            this.yLabel3 = new SY_MES.FX.Controls.YLabel();
            this.yButton1 = new SY_MES.FX.Controls.YButton();
            this.yButton2 = new SY_MES.FX.Controls.YButton();
            this.lbl_LINECD = new SY_MES.FX.Controls.YLabel();
            this.yLabel1 = new SY_MES.FX.Controls.YLabel();
            this.yDataGridView1 = new SY_MES.FX.Controls.YDataGridView();
            this.SHIFT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHIFT_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIMECD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JOB_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSTALL_POS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLAN_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESULT_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMAIN_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REWORK_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRINT_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLAN_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LINECD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORK_ORDNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnPrint = new SY_MES.FX.Controls.YButton();
            this.txtPlan = new SY_MES.FX.Controls.YTextBox();
            this.yLabel4 = new SY_MES.FX.Controls.YLabel();
            this.lblPrintedBarcode = new SY_MES.FX.Controls.YLabel();
            this.yLabel2 = new SY_MES.FX.Controls.YLabel();
            this.yDateTime1 = new SY_MES.FX.Controls.YDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.yDataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrtHelper
            // 
            this.PrtHelper.DeviceName = "";
            this.PrtHelper.Encode = ((System.Text.Encoding)(resources.GetObject("PrtHelper.Encode")));
            this.PrtHelper.PrtConnectMethod = SY_MES.FX.Devices.Printer.BasePrt.PrtConnectMethodEnum.Serial;
            this.PrtHelper.PrtLanguage = SY_MES.FX.Devices.Printer.PrtHelper.PrtLanguageEnum.IPL;
            // 
            // Chk_All
            // 
            this.Chk_All.Appearance = System.Windows.Forms.Appearance.Button;
            this.Chk_All.BackColor = System.Drawing.Color.Silver;
            this.Chk_All.Desc = "All";
            this.Chk_All.Key = "";
            this.Chk_All.Location = new System.Drawing.Point(315, 94);
            this.Chk_All.Name = "Chk_All";
            this.Chk_All.Size = new System.Drawing.Size(91, 29);
            this.Chk_All.TabIndex = 15;
            this.Chk_All.Text = "All";
            this.Chk_All.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Chk_All.UseVisualStyleBackColor = false;
            this.Chk_All.CheckedChanged += new System.EventHandler(this.Chk_All_CheckedChanged);
            // 
            // yButton4
            // 
            this.yButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.yButton4.ButtonStyle = SY_MES.FX.Controls.YButton.ButtonStyleEnum.Combo;
            this.yButton4.Desc = "▼";
            this.yButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yButton4.ForeColor = System.Drawing.Color.Black;
            this.yButton4.Key = "SHIFT";
            this.yButton4.Location = new System.Drawing.Point(246, 95);
            this.yButton4.Name = "yButton4";
            this.yButton4.Size = new System.Drawing.Size(53, 26);
            this.yButton4.TabIndex = 14;
            this.yButton4.Text = "▼";
            this.yButton4.UseVisualStyleBackColor = false;
            this.yButton4.Click += new System.EventHandler(this.Combo_Click);
            // 
            // yWorkerLabel1
            // 
            this.yWorkerLabel1.Desc = "";
            this.yWorkerLabel1.EmpnmSizePercent = 60F;
            this.yWorkerLabel1.EmpnoSizePercent = 20F;
            this.yWorkerLabel1.Key = "";
            this.yWorkerLabel1.KeyMode = SY_MES.FX.Controls.TouchKeyboard.KeyModeEnum.Number;
            this.yWorkerLabel1.Location = new System.Drawing.Point(7, 126);
            this.yWorkerLabel1.MaxEmpLength = 6;
            this.yWorkerLabel1.Name = "yWorkerLabel1";
            this.yWorkerLabel1.Size = new System.Drawing.Size(614, 31);
            this.yWorkerLabel1.TabIndex = 10;
            this.yWorkerLabel1.Title = "Inspector";
            this.yWorkerLabel1.TitleSizePercent = 20F;
            this.yWorkerLabel1.TouchKeyPos = SY_MES.FX.Controls.YTextBox.TouchKeyPosEnum.Down;
            this.yWorkerLabel1.OnEmpnoChanged += new SY_MES.FX.Controls.YWorkerLabel.EmpnoChanged(this.yWorkerLabel1_OnEmpnoChanged);
            // 
            // lblShift
            // 
            this.lblShift.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblShift.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShift.Desc = "W/Center";
            this.lblShift.EditStyle = true;
            this.lblShift.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblShift.Key = "";
            this.lblShift.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lblShift.Location = new System.Drawing.Point(102, 94);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(138, 27);
            this.lblShift.TabIndex = 13;
            this.lblShift.Text = "W/Center";
            this.lblShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel6
            // 
            this.yLabel6.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel6.Desc = "SHIFT";
            this.yLabel6.EditStyle = false;
            this.yLabel6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel6.Key = "";
            this.yLabel6.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel6.Location = new System.Drawing.Point(9, 94);
            this.yLabel6.Name = "yLabel6";
            this.yLabel6.Size = new System.Drawing.Size(87, 27);
            this.yLabel6.TabIndex = 12;
            this.yLabel6.Text = "SHIFT";
            this.yLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yButton3
            // 
            this.yButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.yButton3.ButtonStyle = SY_MES.FX.Controls.YButton.ButtonStyleEnum.Combo;
            this.yButton3.Desc = "▼";
            this.yButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yButton3.ForeColor = System.Drawing.Color.Black;
            this.yButton3.Key = "INSTALL_POS";
            this.yButton3.Location = new System.Drawing.Point(245, 63);
            this.yButton3.Name = "yButton3";
            this.yButton3.Size = new System.Drawing.Size(53, 26);
            this.yButton3.TabIndex = 9;
            this.yButton3.Text = "▼";
            this.yButton3.UseVisualStyleBackColor = false;
            this.yButton3.Click += new System.EventHandler(this.Combo_Click);
            // 
            // lblPOS
            // 
            this.lblPOS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPOS.Desc = "W/Center";
            this.lblPOS.EditStyle = true;
            this.lblPOS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblPOS.Key = "";
            this.lblPOS.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lblPOS.Location = new System.Drawing.Point(101, 62);
            this.lblPOS.Name = "lblPOS";
            this.lblPOS.Size = new System.Drawing.Size(138, 27);
            this.lblPOS.TabIndex = 8;
            this.lblPOS.Text = "W/Center";
            this.lblPOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel3
            // 
            this.yLabel3.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel3.Desc = "POS";
            this.yLabel3.EditStyle = false;
            this.yLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel3.Key = "";
            this.yLabel3.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel3.Location = new System.Drawing.Point(8, 62);
            this.yLabel3.Name = "yLabel3";
            this.yLabel3.Size = new System.Drawing.Size(87, 27);
            this.yLabel3.TabIndex = 7;
            this.yLabel3.Text = "POS";
            this.yLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yButton1
            // 
            this.yButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yButton1.BackColor = System.Drawing.Color.Blue;
            this.yButton1.ButtonStyle = SY_MES.FX.Controls.YButton.ButtonStyleEnum.Blue;
            this.yButton1.Desc = "Refresh Data";
            this.yButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yButton1.ForeColor = System.Drawing.Color.White;
            this.yButton1.Key = "";
            this.yButton1.Location = new System.Drawing.Point(524, 62);
            this.yButton1.Name = "yButton1";
            this.yButton1.Size = new System.Drawing.Size(119, 27);
            this.yButton1.TabIndex = 3;
            this.yButton1.Text = "Refresh Data";
            this.yButton1.UseVisualStyleBackColor = false;
            this.yButton1.Click += new System.EventHandler(this.yButton1_Click);
            // 
            // yButton2
            // 
            this.yButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.yButton2.ButtonStyle = SY_MES.FX.Controls.YButton.ButtonStyleEnum.Combo;
            this.yButton2.Desc = "▼";
            this.yButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yButton2.ForeColor = System.Drawing.Color.Black;
            this.yButton2.Key = "ASSY_LINE";
            this.yButton2.Location = new System.Drawing.Point(444, 34);
            this.yButton2.Name = "yButton2";
            this.yButton2.Size = new System.Drawing.Size(53, 26);
            this.yButton2.TabIndex = 6;
            this.yButton2.Text = "▼";
            this.yButton2.UseVisualStyleBackColor = false;
            this.yButton2.Click += new System.EventHandler(this.Combo_Click);
            // 
            // lbl_LINECD
            // 
            this.lbl_LINECD.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_LINECD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_LINECD.Desc = "W/Center";
            this.lbl_LINECD.EditStyle = true;
            this.lbl_LINECD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_LINECD.Key = "";
            this.lbl_LINECD.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lbl_LINECD.Location = new System.Drawing.Point(101, 33);
            this.lbl_LINECD.Name = "lbl_LINECD";
            this.lbl_LINECD.Size = new System.Drawing.Size(337, 27);
            this.lbl_LINECD.TabIndex = 5;
            this.lbl_LINECD.Text = "W/Center";
            this.lbl_LINECD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel1
            // 
            this.yLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel1.Desc = "W/Center";
            this.yLabel1.EditStyle = false;
            this.yLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel1.Key = "";
            this.yLabel1.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel1.Location = new System.Drawing.Point(8, 33);
            this.yLabel1.Name = "yLabel1";
            this.yLabel1.Size = new System.Drawing.Size(87, 27);
            this.yLabel1.TabIndex = 4;
            this.yLabel1.Text = "W/Center";
            this.yLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.yDataGridView1.BindMove = true;
            this.yDataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.yDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.yDataGridView1.ColumnHeadersHeight = 40;
            this.yDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SHIFT,
            this.SHIFT_DESC,
            this.TIMECD,
            this.JOB_TYPE,
            this.INSTALL_POS,
            this.ALCCD,
            this.PARTNO,
            this.PLAN_QTY,
            this.RESULT_QTY,
            this.REMAIN_QTY,
            this.REWORK_QTY,
            this.PRINT_QTY,
            this.PLAN_DATE,
            this.LINECD,
            this.WORK_ORDNO,
            this.Column1});
            this.yDataGridView1.Desc = "";
            this.yDataGridView1.FixedSort = true;
            this.yDataGridView1.HeaderAlignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.yDataGridView1.HeaderHeight = 40;
            this.yDataGridView1.Key = "";
            this.yDataGridView1.Location = new System.Drawing.Point(3, 160);
            this.yDataGridView1.MovePKColName = "PLAN_DATE,SHIFT,TIMECD,PARTNO";
            this.yDataGridView1.MultiSelect = false;
            this.yDataGridView1.Name = "yDataGridView1";
            this.yDataGridView1.ReadOnly = true;
            this.yDataGridView1.RowHeadersVisible = false;
            this.yDataGridView1.RowHeadersWidth = 82;
            this.yDataGridView1.RowHeight = 50;
            this.yDataGridView1.RowTemplate.Height = 50;
            this.yDataGridView1.ScrollLock = false;
            this.yDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.yDataGridView1.Size = new System.Drawing.Size(644, 454);
            this.yDataGridView1.TabIndex = 1;
            this.yDataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.yDataGridView1_MouseClick);
            // 
            // SHIFT
            // 
            this.SHIFT.DataPropertyName = "SHIFT";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SHIFT.DefaultCellStyle = dataGridViewCellStyle11;
            this.SHIFT.HeaderText = "S";
            this.SHIFT.MinimumWidth = 10;
            this.SHIFT.Name = "SHIFT";
            this.SHIFT.ReadOnly = true;
            this.SHIFT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SHIFT.Visible = false;
            this.SHIFT.Width = 32;
            // 
            // SHIFT_DESC
            // 
            this.SHIFT_DESC.DataPropertyName = "SHIFT_DESC";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SHIFT_DESC.DefaultCellStyle = dataGridViewCellStyle12;
            this.SHIFT_DESC.HeaderText = "S";
            this.SHIFT_DESC.MinimumWidth = 10;
            this.SHIFT_DESC.Name = "SHIFT_DESC";
            this.SHIFT_DESC.ReadOnly = true;
            this.SHIFT_DESC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SHIFT_DESC.Width = 32;
            // 
            // TIMECD
            // 
            this.TIMECD.DataPropertyName = "TIMECD";
            this.TIMECD.HeaderText = "T";
            this.TIMECD.MinimumWidth = 10;
            this.TIMECD.Name = "TIMECD";
            this.TIMECD.ReadOnly = true;
            this.TIMECD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TIMECD.Visible = false;
            this.TIMECD.Width = 32;
            // 
            // JOB_TYPE
            // 
            this.JOB_TYPE.DataPropertyName = "JOB_TYPE";
            this.JOB_TYPE.HeaderText = "J";
            this.JOB_TYPE.MinimumWidth = 10;
            this.JOB_TYPE.Name = "JOB_TYPE";
            this.JOB_TYPE.ReadOnly = true;
            this.JOB_TYPE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.JOB_TYPE.Visible = false;
            this.JOB_TYPE.Width = 32;
            // 
            // INSTALL_POS
            // 
            this.INSTALL_POS.DataPropertyName = "INSTALL_POS";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSTALL_POS.DefaultCellStyle = dataGridViewCellStyle13;
            this.INSTALL_POS.HeaderText = "POS";
            this.INSTALL_POS.MinimumWidth = 10;
            this.INSTALL_POS.Name = "INSTALL_POS";
            this.INSTALL_POS.ReadOnly = true;
            this.INSTALL_POS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.INSTALL_POS.Width = 38;
            // 
            // ALCCD
            // 
            this.ALCCD.DataPropertyName = "ALCCD";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALCCD.DefaultCellStyle = dataGridViewCellStyle14;
            this.ALCCD.HeaderText = "ALC";
            this.ALCCD.MinimumWidth = 10;
            this.ALCCD.Name = "ALCCD";
            this.ALCCD.ReadOnly = true;
            this.ALCCD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ALCCD.Width = 90;
            // 
            // PARTNO
            // 
            this.PARTNO.DataPropertyName = "PARTNO";
            this.PARTNO.HeaderText = "PART NO.";
            this.PARTNO.MinimumWidth = 10;
            this.PARTNO.Name = "PARTNO";
            this.PARTNO.ReadOnly = true;
            this.PARTNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PARTNO.Width = 190;
            // 
            // PLAN_QTY
            // 
            this.PLAN_QTY.DataPropertyName = "PLAN_QTY";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAN_QTY.DefaultCellStyle = dataGridViewCellStyle15;
            this.PLAN_QTY.HeaderText = "PLAN";
            this.PLAN_QTY.MinimumWidth = 10;
            this.PLAN_QTY.Name = "PLAN_QTY";
            this.PLAN_QTY.ReadOnly = true;
            this.PLAN_QTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PLAN_QTY.Width = 65;
            // 
            // RESULT_QTY
            // 
            this.RESULT_QTY.DataPropertyName = "RESULT_QTY";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Blue;
            this.RESULT_QTY.DefaultCellStyle = dataGridViewCellStyle16;
            this.RESULT_QTY.HeaderText = "OK";
            this.RESULT_QTY.MinimumWidth = 10;
            this.RESULT_QTY.Name = "RESULT_QTY";
            this.RESULT_QTY.ReadOnly = true;
            this.RESULT_QTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RESULT_QTY.Width = 65;
            // 
            // REMAIN_QTY
            // 
            this.REMAIN_QTY.DataPropertyName = "REMAIN_QTY";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Red;
            this.REMAIN_QTY.DefaultCellStyle = dataGridViewCellStyle17;
            this.REMAIN_QTY.HeaderText = "DIFF";
            this.REMAIN_QTY.MinimumWidth = 10;
            this.REMAIN_QTY.Name = "REMAIN_QTY";
            this.REMAIN_QTY.ReadOnly = true;
            this.REMAIN_QTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.REMAIN_QTY.Width = 65;
            // 
            // REWORK_QTY
            // 
            this.REWORK_QTY.DataPropertyName = "REWORK_QTY";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Red;
            this.REWORK_QTY.DefaultCellStyle = dataGridViewCellStyle18;
            this.REWORK_QTY.HeaderText = "NG";
            this.REWORK_QTY.MinimumWidth = 10;
            this.REWORK_QTY.Name = "REWORK_QTY";
            this.REWORK_QTY.ReadOnly = true;
            this.REWORK_QTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.REWORK_QTY.Width = 65;
            // 
            // PRINT_QTY
            // 
            this.PRINT_QTY.DataPropertyName = "PRINT_QTY";
            this.PRINT_QTY.HeaderText = "Printed";
            this.PRINT_QTY.MinimumWidth = 10;
            this.PRINT_QTY.Name = "PRINT_QTY";
            this.PRINT_QTY.ReadOnly = true;
            this.PRINT_QTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PRINT_QTY.Visible = false;
            this.PRINT_QTY.Width = 200;
            // 
            // PLAN_DATE
            // 
            this.PLAN_DATE.DataPropertyName = "PLAN_DATE";
            this.PLAN_DATE.HeaderText = "PLAN_DATE";
            this.PLAN_DATE.MinimumWidth = 10;
            this.PLAN_DATE.Name = "PLAN_DATE";
            this.PLAN_DATE.ReadOnly = true;
            this.PLAN_DATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PLAN_DATE.Visible = false;
            this.PLAN_DATE.Width = 200;
            // 
            // LINECD
            // 
            this.LINECD.DataPropertyName = "LINECD";
            this.LINECD.HeaderText = "LINECD";
            this.LINECD.MinimumWidth = 10;
            this.LINECD.Name = "LINECD";
            this.LINECD.ReadOnly = true;
            this.LINECD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LINECD.Visible = false;
            this.LINECD.Width = 200;
            // 
            // WORK_ORDNO
            // 
            this.WORK_ORDNO.DataPropertyName = "WORK_ORDNO";
            this.WORK_ORDNO.HeaderText = "WORK_ORDNO";
            this.WORK_ORDNO.MinimumWidth = 10;
            this.WORK_ORDNO.Name = "WORK_ORDNO";
            this.WORK_ORDNO.ReadOnly = true;
            this.WORK_ORDNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WORK_ORDNO.Visible = false;
            this.WORK_ORDNO.Width = 200;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Column1";
            this.Column1.HeaderText = "STR_LOC";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Visible = false;
            this.Column1.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnPrint);
            this.panel1.Controls.Add(this.txtPlan);
            this.panel1.Controls.Add(this.yLabel4);
            this.panel1.Controls.Add(this.lblPrintedBarcode);
            this.panel1.Controls.Add(this.yLabel2);
            this.panel1.Location = new System.Drawing.Point(3, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 124);
            this.panel1.TabIndex = 2;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrint.BackColor = System.Drawing.Color.Yellow;
            this.BtnPrint.ButtonStyle = SY_MES.FX.Controls.YButton.ButtonStyleEnum.Yellow;
            this.BtnPrint.Desc = "Print";
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrint.ForeColor = System.Drawing.Color.Black;
            this.BtnPrint.Key = "";
            this.BtnPrint.Location = new System.Drawing.Point(531, 3);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(108, 46);
            this.BtnPrint.TabIndex = 10;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // txtPlan
            // 
            this.txtPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlan.Desc = "";
            this.txtPlan.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlan.Key = "";
            this.txtPlan.KeyMode = SY_MES.FX.Controls.TouchKeyboard.KeyModeEnum.Number;
            this.txtPlan.KeyPadModal = true;
            this.txtPlan.Location = new System.Drawing.Point(165, 48);
            this.txtPlan.MaxLength = 6;
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(78, 33);
            this.txtPlan.TabIndex = 11;
            this.txtPlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlan.TouchKeyBoardMethod = SY_MES.FX.Controls.YTextBox.ClickEnum.DoubleClick;
            this.txtPlan.TouchKeyPos = SY_MES.FX.Controls.YTextBox.TouchKeyPosEnum.Up;
            this.txtPlan.UpperString = false;
            this.txtPlan.UseTouchKeyBoard = true;
            // 
            // yLabel4
            // 
            this.yLabel4.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel4.Desc = "Available Barcode";
            this.yLabel4.EditStyle = false;
            this.yLabel4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel4.Key = "";
            this.yLabel4.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel4.Location = new System.Drawing.Point(3, 42);
            this.yLabel4.Name = "yLabel4";
            this.yLabel4.Size = new System.Drawing.Size(156, 39);
            this.yLabel4.TabIndex = 10;
            this.yLabel4.Text = "Available Barcode";
            this.yLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrintedBarcode
            // 
            this.lblPrintedBarcode.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPrintedBarcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrintedBarcode.Desc = "W/Center";
            this.lblPrintedBarcode.EditStyle = true;
            this.lblPrintedBarcode.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintedBarcode.Key = "";
            this.lblPrintedBarcode.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lblPrintedBarcode.Location = new System.Drawing.Point(165, 3);
            this.lblPrintedBarcode.Name = "lblPrintedBarcode";
            this.lblPrintedBarcode.Size = new System.Drawing.Size(78, 39);
            this.lblPrintedBarcode.TabIndex = 9;
            this.lblPrintedBarcode.Text = "W/Center";
            this.lblPrintedBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel2
            // 
            this.yLabel2.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel2.Desc = "Printed Barcode";
            this.yLabel2.EditStyle = false;
            this.yLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel2.Key = "";
            this.yLabel2.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel2.Location = new System.Drawing.Point(3, 3);
            this.yLabel2.Name = "yLabel2";
            this.yLabel2.Size = new System.Drawing.Size(156, 39);
            this.yLabel2.TabIndex = 8;
            this.yLabel2.Text = "Printed Barcode";
            this.yLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yDateTime1
            // 
            this.yDateTime1.DateFormat = "dd-MM-yyyy";
            this.yDateTime1.Desc = "23-04-2025";
            this.yDateTime1.Key = "";
            this.yDateTime1.Location = new System.Drawing.Point(3, 3);
            this.yDateTime1.Name = "yDateTime1";
            this.yDateTime1.Size = new System.Drawing.Size(494, 30);
            this.yDateTime1.TabIndex = 0;
            this.yDateTime1.Title = "Production Date";
            this.yDateTime1.OnDateChg += new SY_MES.FX.Controls.YDateTime.DateChg(this.yDateTime1_OnDateChg);
            // 
            // WOPrintBC
            // 
            this.AutoLoadData = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Chk_All);
            this.Controls.Add(this.yButton4);
            this.Controls.Add(this.yWorkerLabel1);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.yLabel6);
            this.Controls.Add(this.yButton3);
            this.Controls.Add(this.lblPOS);
            this.Controls.Add(this.yLabel3);
            this.Controls.Add(this.yButton1);
            this.Controls.Add(this.yButton2);
            this.Controls.Add(this.lbl_LINECD);
            this.Controls.Add(this.yLabel1);
            this.Controls.Add(this.yDataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.yDateTime1);
            this.Name = "WOPrintBC";
            this.Size = new System.Drawing.Size(650, 743);
            ((System.ComponentModel.ISupportInitialize)(this.yDataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FX.Controls.YDateTime yDateTime1;
        private FX.Controls.YDataGridView yDataGridView1;
        private System.Windows.Forms.Panel panel1;
        private FX.Controls.YButton yButton1;
        private FX.Controls.YLabel yLabel1;
        private FX.Controls.YLabel lbl_LINECD;
        private FX.Controls.YButton yButton2;
        private FX.Controls.YLabel lblPOS;
        private FX.Controls.YLabel yLabel3;
        private FX.Controls.YButton yButton3;
        private FX.Controls.YButton BtnPrint;
        private FX.Devices.Printer.PrtHelper PrtHelper;
        private FX.Controls.YLabel lblPrintedBarcode;
        private FX.Controls.YLabel yLabel2;
        private FX.Controls.YTextBox txtPlan;
        private FX.Controls.YLabel yLabel4;
        private FX.Controls.YWorkerLabel yWorkerLabel1;
        private FX.Controls.YButton yButton4;
        private FX.Controls.YLabel lblShift;
        private FX.Controls.YLabel yLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHIFT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHIFT_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIMECD;
        private System.Windows.Forms.DataGridViewTextBoxColumn JOB_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSTALL_POS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLAN_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESULT_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn REMAIN_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn REWORK_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRINT_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLAN_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LINECD;
        private System.Windows.Forms.DataGridViewTextBoxColumn WORK_ORDNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private FX.Controls.YCheckBox Chk_All;
    }
}
