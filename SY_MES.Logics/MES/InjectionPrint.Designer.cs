namespace SY_MES.Logics.MES
{
    partial class InjectionPrint
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
            this.yTableLayout1 = new SY_MES.FX.Controls.YTableLayout();
            this.panel2 = new System.Windows.Forms.Panel();
            this.yTableLayout2 = new SY_MES.FX.Controls.YTableLayout();
            this.inspectionBC1 = new SY_MES.Logics.MES.Sub.InspectionBC();
            this.injectionPrintBC1 = new SY_MES.Logics.MES.Sub.SFGPrintBC();
            this.yTableLayout1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.yTableLayout2.SuspendLayout();
            this.SuspendLayout();
            // 
            // yTableLayout1
            // 
            this.yTableLayout1.ColumnCount = 2;
            this.yTableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.yTableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.yTableLayout1.Controls.Add(this.panel2, 1, 0);
            this.yTableLayout1.Controls.Add(this.injectionPrintBC1, 0, 0);
            this.yTableLayout1.Desc = "";
            this.yTableLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yTableLayout1.Key = "";
            this.yTableLayout1.Location = new System.Drawing.Point(0, 0);
            this.yTableLayout1.Name = "yTableLayout1";
            this.yTableLayout1.RowCount = 1;
            this.yTableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.yTableLayout1.Size = new System.Drawing.Size(1012, 725);
            this.yTableLayout1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.yTableLayout2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(607, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 725);
            this.panel2.TabIndex = 1;
            // 
            // yTableLayout2
            // 
            this.yTableLayout2.ColumnCount = 1;
            this.yTableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.yTableLayout2.Controls.Add(this.inspectionBC1, 0, 1);
            this.yTableLayout2.Desc = "";
            this.yTableLayout2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yTableLayout2.Key = "";
            this.yTableLayout2.Location = new System.Drawing.Point(0, 0);
            this.yTableLayout2.Margin = new System.Windows.Forms.Padding(0);
            this.yTableLayout2.Name = "yTableLayout2";
            this.yTableLayout2.RowCount = 2;
            this.yTableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.44828F));
            this.yTableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.55172F));
            this.yTableLayout2.Size = new System.Drawing.Size(405, 725);
            this.yTableLayout2.TabIndex = 0;
            // 
            // inspectionBC1
            // 
            this.inspectionBC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inspectionBC1.AutoLoadData = false;
            this.inspectionBC1.AutoWorkerSetting = false;
            this.inspectionBC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inspectionBC1.FactorsVisible = false;
            this.inspectionBC1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspectionBC1.Location = new System.Drawing.Point(4, 408);
            this.inspectionBC1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.inspectionBC1.Name = "inspectionBC1";
            this.inspectionBC1.PrvStationRslt = false;
            this.inspectionBC1.RsltBtnVisible = true;
            this.inspectionBC1.Size = new System.Drawing.Size(397, 311);
            this.inspectionBC1.TabIndex = 0;
            this.inspectionBC1.WorkerLabel = null;
            // 
            // injectionPrintBC1
            // 
            this.injectionPrintBC1.AutoLoadData = false;
            this.injectionPrintBC1.AutoWorkerSetting = true;
            this.injectionPrintBC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.injectionPrintBC1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injectionPrintBC1.Location = new System.Drawing.Point(4, 6);
            this.injectionPrintBC1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.injectionPrintBC1.MoldPairSelection = true;
            this.injectionPrintBC1.Name = "injectionPrintBC1";
            this.injectionPrintBC1.PrvStationRslt = false;
            this.injectionPrintBC1.SFGMode = SY_MES.Logics.MES.Sub.SFGPrintBC.SFGModeEnum.Injecion;
            this.injectionPrintBC1.Size = new System.Drawing.Size(599, 713);
            this.injectionPrintBC1.TabIndex = 2;
            // 
            // InjectionPrint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.yTableLayout1);
            this.Name = "InjectionPrint";
            this.Size = new System.Drawing.Size(1012, 725);
            this.yTableLayout1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.yTableLayout2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FX.Controls.YTableLayout yTableLayout1;
        private System.Windows.Forms.Panel panel2;
        private Sub.SFGPrintBC injectionPrintBC1;
        private FX.Controls.YTableLayout yTableLayout2;
        private Sub.InspectionBC inspectionBC1;
    }
}
