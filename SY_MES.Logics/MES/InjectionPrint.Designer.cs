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
            this.injectionPrintBC1 = new SY_MES.Logics.MES.Sub.InjectionPrintBC();
            this.yTableLayout1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yTableLayout1
            // 
            this.yTableLayout1.ColumnCount = 2;
            this.yTableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.yTableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(708, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 725);
            this.panel2.TabIndex = 1;
            // 
            // injectionPrintBC1
            // 
            this.injectionPrintBC1.AutoLoadData = false;
            this.injectionPrintBC1.AutoWorkerSetting = false;
            this.injectionPrintBC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.injectionPrintBC1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injectionPrintBC1.Location = new System.Drawing.Point(4, 6);
            this.injectionPrintBC1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.injectionPrintBC1.Name = "injectionPrintBC1";
            this.injectionPrintBC1.PrvStationRslt = false;
            this.injectionPrintBC1.Size = new System.Drawing.Size(700, 713);
            this.injectionPrintBC1.TabIndex = 2;
            this.injectionPrintBC1.WorkerLabel = null;
            // 
            // InjectionPrint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.yTableLayout1);
            this.Name = "InjectionPrint";
            this.Size = new System.Drawing.Size(1012, 725);
            this.yTableLayout1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FX.Controls.YTableLayout yTableLayout1;
        private System.Windows.Forms.Panel panel2;
        private Sub.InjectionPrintBC injectionPrintBC1;
    }
}
