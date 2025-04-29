namespace SY_MES.Logics.MES
{
    partial class SpecCheck
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
            this.specCheckBC1 = new SY_MES.Logics.MES.Sub.SpecCheckBC();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcVisionCtl1 = new SY_MES.Logics.Base.PCVisionCtl();
            this.yWorkerLabel1 = new SY_MES.FX.Controls.YWorkerLabel();
            this.specDetUC1 = new SY_MES.Logics.MES.Sub.LegendUC();
            this.productInforBC1 = new SY_MES.Logics.MES.Sub.ProductInforBC();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.specCheckBC1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 821);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // specCheckBC1
            // 
            this.specCheckBC1.AutoLoadData = true;
            this.specCheckBC1.AutoWorkerSetting = true;
            this.specCheckBC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.specCheckBC1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specCheckBC1.Location = new System.Drawing.Point(484, 6);
            this.specCheckBC1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.specCheckBC1.Name = "specCheckBC1";
            this.specCheckBC1.PrvStationRslt = false;
            this.specCheckBC1.Size = new System.Drawing.Size(712, 809);
            this.specCheckBC1.TabIndex = 0;
            this.specCheckBC1.WorkerLabel = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pcVisionCtl1);
            this.panel1.Controls.Add(this.yWorkerLabel1);
            this.panel1.Controls.Add(this.specDetUC1);
            this.panel1.Controls.Add(this.productInforBC1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 821);
            this.panel1.TabIndex = 1;
            // 
            // pcVisionCtl1
            // 
            this.pcVisionCtl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pcVisionCtl1.Location = new System.Drawing.Point(4, 688);
            this.pcVisionCtl1.Name = "pcVisionCtl1";
            this.pcVisionCtl1.Size = new System.Drawing.Size(298, 127);
            this.pcVisionCtl1.TabIndex = 5;
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
            this.yWorkerLabel1.Size = new System.Drawing.Size(472, 31);
            this.yWorkerLabel1.TabIndex = 4;
            this.yWorkerLabel1.Title = "Worker";
            this.yWorkerLabel1.TitleSizePercent = 30F;
            this.yWorkerLabel1.TouchKeyPos = SY_MES.FX.Controls.YTextBox.TouchKeyPosEnum.Down;
            // 
            // specDetUC1
            // 
            this.specDetUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.specDetUC1.CountOfIdx = 5;
            this.specDetUC1.Location = new System.Drawing.Point(3, 238);
            this.specDetUC1.Name = "specDetUC1";
            this.specDetUC1.Size = new System.Drawing.Size(473, 444);
            this.specDetUC1.TabIndex = 1;
            // 
            // productInforBC1
            // 
            this.productInforBC1.AlcCD = "";
            this.productInforBC1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productInforBC1.AutoLoadData = false;
            this.productInforBC1.AutoWorkerSetting = false;
            this.productInforBC1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInforBC1.Location = new System.Drawing.Point(4, 38);
            this.productInforBC1.LotNo = "";
            this.productInforBC1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.productInforBC1.Name = "productInforBC1";
            this.productInforBC1.PartNo = "";
            this.productInforBC1.PrvStationRslt = false;
            this.productInforBC1.Size = new System.Drawing.Size(473, 191);
            this.productInforBC1.SPEC1_DESC_COLNM = "";
            this.productInforBC1.SPEC1_TITLE = "SPEC1";
            this.productInforBC1.SPEC2_DESC_COLNM = "";
            this.productInforBC1.SPEC2_TITLE = "SPEC2";
            this.productInforBC1.SPEC3_DESC_COLNM = "";
            this.productInforBC1.SPEC3_TITLE = "SPEC3";
            this.productInforBC1.TabIndex = 0;
            this.productInforBC1.WorkerLabel = null;
            // 
            // SpecCheck
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SpecCheck";
            this.Size = new System.Drawing.Size(1200, 821);
            this.WorkerLabel = this.yWorkerLabel1;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Sub.SpecCheckBC specCheckBC1;
        private System.Windows.Forms.Panel panel1;
        private Sub.ProductInforBC productInforBC1;
        private Sub.LegendUC specDetUC1;
        private FX.Controls.YWorkerLabel yWorkerLabel1;
        private Base.PCVisionCtl pcVisionCtl1;
    }
}
