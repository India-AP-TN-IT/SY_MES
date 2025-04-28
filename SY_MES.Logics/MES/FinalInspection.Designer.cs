namespace SY_MES.Logics.MES
{
    partial class FinalInspection
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
            this.planRsltBC1 = new SY_MES.Logics.MES.Sub.PlanRsltBC();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.productInforBC1 = new SY_MES.Logics.MES.Sub.ProductInforBC();
            this.inspectionBC1 = new SY_MES.Logics.MES.Sub.InspectionBC();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // planRsltBC1
            // 
            this.planRsltBC1.AutoLoadData = false;
            this.planRsltBC1.AutoWorkerSetting = false;
            this.planRsltBC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planRsltBC1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planRsltBC1.Location = new System.Drawing.Point(4, 6);
            this.planRsltBC1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.planRsltBC1.Name = "planRsltBC1";
            this.planRsltBC1.PrvStationRslt = false;
            this.planRsltBC1.Size = new System.Drawing.Size(815, 828);
            this.planRsltBC1.TabIndex = 0;
            this.planRsltBC1.WorkerLabel = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.planRsltBC1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1373, 840);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.productInforBC1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.inspectionBC1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(826, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(544, 834);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // productInforBC1
            // 
            this.productInforBC1.AlcCD = "W/Center";
            this.productInforBC1.AutoLoadData = false;
            this.productInforBC1.AutoWorkerSetting = false;
            this.productInforBC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productInforBC1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInforBC1.Location = new System.Drawing.Point(4, 6);
            this.productInforBC1.LotNo = "W/Center";
            this.productInforBC1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.productInforBC1.Name = "productInforBC1";
            this.productInforBC1.PartNo = "W/Center";
            this.productInforBC1.PrvStationRslt = false;
            this.productInforBC1.Size = new System.Drawing.Size(536, 196);
            this.productInforBC1.SPEC1_DESC_COLNM = "";
            this.productInforBC1.SPEC1_TITLE = "SPEC1";
            this.productInforBC1.SPEC2_DESC_COLNM = "";
            this.productInforBC1.SPEC2_TITLE = "SPEC2";
            this.productInforBC1.SPEC3_DESC_COLNM = "";
            this.productInforBC1.SPEC3_TITLE = "SPEC3";
            this.productInforBC1.TabIndex = 0;
            this.productInforBC1.WorkerLabel = null;
            // 
            // inspectionBC1
            // 
            this.inspectionBC1.AutoLoadData = false;
            this.inspectionBC1.AutoWorkerSetting = false;
            this.inspectionBC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inspectionBC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inspectionBC1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspectionBC1.Location = new System.Drawing.Point(4, 214);
            this.inspectionBC1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.inspectionBC1.Name = "inspectionBC1";
            this.inspectionBC1.PrvStationRslt = false;
            this.inspectionBC1.RsltBtnVisible = true;
            this.inspectionBC1.Size = new System.Drawing.Size(536, 614);
            this.inspectionBC1.TabIndex = 1;
            this.inspectionBC1.WorkerLabel = null;
            // 
            // FinalInspection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FinalInspection";
            this.Size = new System.Drawing.Size(1373, 840);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sub.PlanRsltBC planRsltBC1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Sub.ProductInforBC productInforBC1;
        private Sub.InspectionBC inspectionBC1;
    }
}
