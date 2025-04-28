namespace SY_MES.Logics.MES
{
    partial class Rework
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.yLabel1 = new SY_MES.FX.Controls.YLabel();
            this.lblReQTY = new SY_MES.FX.Controls.YBitLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTimer = new SY_MES.FX.Controls.YLabel();
            this.inspectionBC1 = new SY_MES.Logics.MES.Sub.InspectionBC();
            this.yWorkerLabel1 = new SY_MES.FX.Controls.YWorkerLabel();
            this.productInforBC1 = new SY_MES.Logics.MES.Sub.ProductInforBC();
            this.panel2 = new System.Windows.Forms.Panel();
            this.yButton1 = new SY_MES.FX.Controls.YButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Tmr_Rework = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.30664F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.69336F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1373, 840);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.inspectionBC1);
            this.panel1.Controls.Add(this.yWorkerLabel1);
            this.panel1.Controls.Add(this.productInforBC1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 840);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel2.Controls.Add(this.yLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblReQTY, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 654);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.47253F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.52747F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(321, 182);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // yLabel1
            // 
            this.yLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel1.Desc = "Wait for Rework";
            this.yLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yLabel1.EditStyle = false;
            this.yLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel1.Key = "";
            this.yLabel1.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel1.Location = new System.Drawing.Point(3, 0);
            this.yLabel1.Name = "yLabel1";
            this.yLabel1.Size = new System.Drawing.Size(186, 50);
            this.yLabel1.TabIndex = 2;
            this.yLabel1.Text = "Wait for Rework";
            this.yLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReQTY
            // 
            this.lblReQTY.BackColor = System.Drawing.Color.Red;
            this.lblReQTY.Desc = "0";
            this.lblReQTY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReQTY.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReQTY.ForeColor = System.Drawing.Color.Yellow;
            this.lblReQTY.Key = "";
            this.lblReQTY.Location = new System.Drawing.Point(3, 50);
            this.lblReQTY.Name = "lblReQTY";
            this.lblReQTY.OffBGColor = System.Drawing.Color.Red;
            this.lblReQTY.OffForeColor = System.Drawing.Color.Yellow;
            this.lblReQTY.OnBGColor = System.Drawing.Color.Red;
            this.lblReQTY.OnForeColor = System.Drawing.Color.Yellow;
            this.lblReQTY.Size = new System.Drawing.Size(186, 132);
            this.lblReQTY.TabIndex = 3;
            this.lblReQTY.Text = "0";
            this.lblReQTY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTimer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(195, 3);
            this.panel3.Name = "panel3";
            this.tableLayoutPanel2.SetRowSpan(this.panel3, 2);
            this.panel3.Size = new System.Drawing.Size(123, 176);
            this.panel3.TabIndex = 4;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Desc = "yLabel2";
            this.lblTimer.EditStyle = false;
            this.lblTimer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblTimer.Key = "";
            this.lblTimer.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lblTimer.Location = new System.Drawing.Point(3, 47);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(97, 40);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "yLabel2";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inspectionBC1
            // 
            this.inspectionBC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inspectionBC1.AutoLoadData = false;
            this.inspectionBC1.AutoWorkerSetting = false;
            this.inspectionBC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inspectionBC1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspectionBC1.Location = new System.Drawing.Point(4, 228);
            this.inspectionBC1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.inspectionBC1.Name = "inspectionBC1";
            this.inspectionBC1.PrvStationRslt = false;
            this.inspectionBC1.RsltBtnVisible = false;
            this.inspectionBC1.Size = new System.Drawing.Size(559, 424);
            this.inspectionBC1.TabIndex = 1;
            this.inspectionBC1.WorkerLabel = null;
            // 
            // yWorkerLabel1
            // 
            this.yWorkerLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yWorkerLabel1.Desc = "";
            this.yWorkerLabel1.EmpnmSizePercent = 40F;
            this.yWorkerLabel1.EmpnoSizePercent = 30F;
            this.yWorkerLabel1.Key = "";
            this.yWorkerLabel1.KeyMode = SY_MES.FX.Controls.TouchKeyboard.KeyModeEnum.Number;
            this.yWorkerLabel1.Location = new System.Drawing.Point(4, 3);
            this.yWorkerLabel1.MaxEmpLength = 6;
            this.yWorkerLabel1.Name = "yWorkerLabel1";
            this.yWorkerLabel1.Size = new System.Drawing.Size(559, 31);
            this.yWorkerLabel1.TabIndex = 0;
            this.yWorkerLabel1.Title = "Worker";
            this.yWorkerLabel1.TitleSizePercent = 30F;
            this.yWorkerLabel1.TouchKeyPos = SY_MES.FX.Controls.YTextBox.TouchKeyPosEnum.Down;
            // 
            // productInforBC1
            // 
            this.productInforBC1.AlcCD = "W/Center";
            this.productInforBC1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productInforBC1.AutoLoadData = false;
            this.productInforBC1.AutoWorkerSetting = false;
            this.productInforBC1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInforBC1.Location = new System.Drawing.Point(4, 37);
            this.productInforBC1.LotNo = "W/Center";
            this.productInforBC1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.productInforBC1.Name = "productInforBC1";
            this.productInforBC1.PartNo = "W/Center";
            this.productInforBC1.PrvStationRslt = false;
            this.productInforBC1.Size = new System.Drawing.Size(559, 191);
            this.productInforBC1.SPEC1_DESC_COLNM = "";
            this.productInforBC1.SPEC1_TITLE = "SPEC1";
            this.productInforBC1.SPEC2_DESC_COLNM = "";
            this.productInforBC1.SPEC2_TITLE = "SPEC2";
            this.productInforBC1.SPEC3_DESC_COLNM = "";
            this.productInforBC1.SPEC3_TITLE = "SPEC3";
            this.productInforBC1.TabIndex = 0;
            this.productInforBC1.WorkerLabel = null;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.yButton1);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(567, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 840);
            this.panel2.TabIndex = 1;
            // 
            // yButton1
            // 
            this.yButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yButton1.BackColor = System.Drawing.Color.Blue;
            this.yButton1.ButtonStyle = SY_MES.FX.Controls.YButton.ButtonStyleEnum.Blue;
            this.yButton1.Desc = "Save";
            this.yButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yButton1.ForeColor = System.Drawing.Color.White;
            this.yButton1.Key = "";
            this.yButton1.Location = new System.Drawing.Point(3, 765);
            this.yButton1.Name = "yButton1";
            this.yButton1.Size = new System.Drawing.Size(132, 68);
            this.yButton1.TabIndex = 1;
            this.yButton1.Text = "Save";
            this.yButton1.UseVisualStyleBackColor = false;
            this.yButton1.Click += new System.EventHandler(this.yButton1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 756);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Tmr_Rework
            // 
            this.Tmr_Rework.Interval = 500;
            this.Tmr_Rework.Tick += new System.EventHandler(this.Tmr_Rework_Tick);
            // 
            // Rework
            // 
            this.AutoLoadData = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoWorkerSetting = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Rework";
            this.Size = new System.Drawing.Size(1373, 840);
            this.WorkerLabel = this.yWorkerLabel1;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Sub.ProductInforBC productInforBC1;
        private System.Windows.Forms.Panel panel2;
        private FX.Controls.YWorkerLabel yWorkerLabel1;
        private FX.Controls.YLabel yLabel1;
        private Sub.InspectionBC inspectionBC1;
        private FX.Controls.YBitLabel lblReQTY;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private FX.Controls.YLabel lblTimer;
        private System.Windows.Forms.Timer Tmr_Rework;
        private FX.Controls.YButton yButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
