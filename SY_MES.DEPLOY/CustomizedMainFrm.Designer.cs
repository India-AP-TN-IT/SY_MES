namespace SY_MES.DEPLOY
{
    partial class CustomizedMainFrm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomizedMainFrm));
            this.SuspendLayout();
            // 
            // MainCtl
            // 
            this.MainCtl.AppIcon = ((System.Drawing.Icon)(resources.GetObject("MainCtl.AppIcon")));
            this.MainCtl.LogoImg = ((System.Drawing.Image)(resources.GetObject("MainCtl.LogoImg")));
            this.MainCtl.TIT_DateFormat = SY_MES.FX.MainForm.Base.Common.DateFormatEnum.DDMMYYYY;
            this.MainCtl.TIT_Line = "D/TRIM";
            this.MainCtl.TIT_Plant = "PN";
            this.MainCtl.TIT_Station = "Station #1";
            this.MainCtl.XMLConfigPrivateFile = "Config_Private.xml";
            // 
            // CustomizedMainFrm
            // 
            this.AppIcon = ((System.Drawing.Icon)(resources.GetObject("$this.AppIcon")));
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 644);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomizedMainFrm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
    }
}