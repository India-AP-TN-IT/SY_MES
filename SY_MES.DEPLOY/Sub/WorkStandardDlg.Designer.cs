namespace SY_MES.DEPLOY.Sub
{
    partial class WorkStandardDlg
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
            this.yPdfView1 = new SY_MES.FX.Controls.YPdfView();
            this.lblWarn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yPdfView1
            // 
            this.yPdfView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yPdfView1.Location = new System.Drawing.Point(0, 0);
            this.yPdfView1.Name = "yPdfView1";
            this.yPdfView1.PageCount = 0;
            this.yPdfView1.Size = new System.Drawing.Size(980, 774);
            this.yPdfView1.TabIndex = 0;
            // 
            // lblWarn
            // 
            this.lblWarn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarn.BackColor = System.Drawing.Color.Yellow;
            this.lblWarn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWarn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarn.ForeColor = System.Drawing.Color.Blue;
            this.lblWarn.Location = new System.Drawing.Point(371, 296);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(202, 101);
            this.lblWarn.TabIndex = 1;
            this.lblWarn.Text = "Empty Data";
            this.lblWarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkStandardDlg
            // 
            this.AutoLoadData = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblWarn);
            this.Controls.Add(this.yPdfView1);
            this.Name = "WorkStandardDlg";
            this.Size = new System.Drawing.Size(980, 774);
            this.ResumeLayout(false);

        }

        #endregion

        private FX.Controls.YPdfView yPdfView1;
        private System.Windows.Forms.Label lblWarn;
    }
}
