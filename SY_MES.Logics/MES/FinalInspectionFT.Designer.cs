namespace SY_MES.Logics.MES
{
    partial class FinalInspectionFT
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fT_BC1 = new SY_MES.Logics.MES.Sub.FT_BC();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.inspectionBC1 = new SY_MES.Logics.MES.Sub.InspectionBC();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productInforBC1 = new SY_MES.Logics.MES.Sub.ProductInforBC();
            this.yWorkerLabel1 = new SY_MES.FX.Controls.YWorkerLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.fT_BC1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 631);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // fT_BC1
            // 
            this.fT_BC1.AutoLoadData = false;
            this.fT_BC1.AutoWorkerSetting = false;
            this.fT_BC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fT_BC1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fT_BC1.Location = new System.Drawing.Point(4, 6);
            this.fT_BC1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fT_BC1.Name = "fT_BC1";
            this.fT_BC1.PrvStationRslt = false;
            this.fT_BC1.Size = new System.Drawing.Size(606, 619);
            this.fT_BC1.TabIndex = 2;
            this.fT_BC1.WorkerLabel = null;
            this.fT_BC1.OnProcResult += new SY_MES.Logics.MES.Sub.FT_BC.ProcResult(this.fT_BC1_OnProcResult);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.inspectionBC1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(617, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.68F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(404, 625);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // inspectionBC1
            // 
            this.inspectionBC1.AutoLoadData = false;
            this.inspectionBC1.AutoWorkerSetting = false;
            this.inspectionBC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inspectionBC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inspectionBC1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspectionBC1.Location = new System.Drawing.Point(4, 229);
            this.inspectionBC1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.inspectionBC1.Name = "inspectionBC1";
            this.inspectionBC1.PrvStationRslt = false;
            this.inspectionBC1.RsltBtnVisible = true;
            this.inspectionBC1.Size = new System.Drawing.Size(396, 390);
            this.inspectionBC1.TabIndex = 1;
            this.inspectionBC1.WorkerLabel = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yWorkerLabel1);
            this.panel1.Controls.Add(this.productInforBC1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 223);
            this.panel1.TabIndex = 2;
            // 
            // productInforBC1
            // 
            this.productInforBC1.AlcCD = "W/Center";
            this.productInforBC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productInforBC1.AutoLoadData = false;
            this.productInforBC1.AutoWorkerSetting = false;
            this.productInforBC1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInforBC1.Location = new System.Drawing.Point(4, 35);
            this.productInforBC1.LotNo = "W/Center";
            this.productInforBC1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.productInforBC1.Name = "productInforBC1";
            this.productInforBC1.PartNo = "W/Center";
            this.productInforBC1.PrvStationRslt = false;
            this.productInforBC1.Size = new System.Drawing.Size(396, 184);
            this.productInforBC1.SPEC1_DESC_COLNM = "";
            this.productInforBC1.SPEC1_TITLE = "SPEC1";
            this.productInforBC1.SPEC2_DESC_COLNM = "";
            this.productInforBC1.SPEC2_TITLE = "SPEC2";
            this.productInforBC1.SPEC3_DESC_COLNM = "";
            this.productInforBC1.SPEC3_TITLE = "SPEC3";
            this.productInforBC1.TabIndex = 1;
            this.productInforBC1.WorkerLabel = null;
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
            this.yWorkerLabel1.Size = new System.Drawing.Size(397, 31);
            this.yWorkerLabel1.TabIndex = 2;
            this.yWorkerLabel1.Title = "Worker";
            this.yWorkerLabel1.TitleSizePercent = 30F;
            this.yWorkerLabel1.TouchKeyPos = SY_MES.FX.Controls.YTextBox.TouchKeyPosEnum.Down;
            // 
            // FinalInspectionFT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoWorkerSetting = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FinalInspectionFT";
            this.Size = new System.Drawing.Size(1024, 631);
            this.WorkerLabel = this.yWorkerLabel1;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Sub.InspectionBC inspectionBC1;
        private Sub.FT_BC fT_BC1;
        private System.Windows.Forms.Panel panel1;
        private FX.Controls.YWorkerLabel yWorkerLabel1;
        private Sub.ProductInforBC productInforBC1;
    }
}
