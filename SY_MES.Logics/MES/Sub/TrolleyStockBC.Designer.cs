namespace SY_MES.Logics.MES.Sub
{
    partial class TrolleyStockBC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.yBitLabel2 = new SY_MES.FX.Controls.YBitLabel();
            this.yLabel1 = new SY_MES.FX.Controls.YLabel();
            this.yBitLabel1 = new SY_MES.FX.Controls.YBitLabel();
            this.yLabel6 = new SY_MES.FX.Controls.YLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.yBitLabel2);
            this.panel1.Controls.Add(this.yLabel1);
            this.panel1.Controls.Add(this.yBitLabel1);
            this.panel1.Controls.Add(this.yLabel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 208);
            this.panel1.TabIndex = 14;
            // 
            // yBitLabel2
            // 
            this.yBitLabel2.BackColor = System.Drawing.Color.Black;
            this.yBitLabel2.Desc = "999";
            this.yBitLabel2.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yBitLabel2.ForeColor = System.Drawing.Color.White;
            this.yBitLabel2.Key = "";
            this.yBitLabel2.Location = new System.Drawing.Point(2, 101);
            this.yBitLabel2.Name = "yBitLabel2";
            this.yBitLabel2.OffBGColor = System.Drawing.Color.Black;
            this.yBitLabel2.OffForeColor = System.Drawing.Color.White;
            this.yBitLabel2.OnBGColor = System.Drawing.Color.Lime;
            this.yBitLabel2.OnForeColor = System.Drawing.Color.Black;
            this.yBitLabel2.Size = new System.Drawing.Size(164, 101);
            this.yBitLabel2.TabIndex = 16;
            this.yBitLabel2.Text = "999";
            this.yBitLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel1
            // 
            this.yLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel1.Desc = "Stuffing QTY.";
            this.yLabel1.EditStyle = false;
            this.yLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel1.Key = "";
            this.yLabel1.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel1.Location = new System.Drawing.Point(3, 74);
            this.yLabel1.Name = "yLabel1";
            this.yLabel1.Size = new System.Drawing.Size(163, 27);
            this.yLabel1.TabIndex = 15;
            this.yLabel1.Text = "Stuffing QTY.";
            this.yLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yBitLabel1
            // 
            this.yBitLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yBitLabel1.BackColor = System.Drawing.Color.Black;
            this.yBitLabel1.Desc = "yBitLabel1";
            this.yBitLabel1.ForeColor = System.Drawing.Color.White;
            this.yBitLabel1.Key = "";
            this.yBitLabel1.Location = new System.Drawing.Point(3, 33);
            this.yBitLabel1.Name = "yBitLabel1";
            this.yBitLabel1.OffBGColor = System.Drawing.Color.Black;
            this.yBitLabel1.OffForeColor = System.Drawing.Color.White;
            this.yBitLabel1.OnBGColor = System.Drawing.Color.Lime;
            this.yBitLabel1.OnForeColor = System.Drawing.Color.Black;
            this.yBitLabel1.Size = new System.Drawing.Size(427, 39);
            this.yBitLabel1.TabIndex = 14;
            this.yBitLabel1.Text = "yBitLabel1";
            this.yBitLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel6
            // 
            this.yLabel6.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel6.Desc = "TROLLEY NO";
            this.yLabel6.EditStyle = false;
            this.yLabel6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel6.Key = "";
            this.yLabel6.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel6.Location = new System.Drawing.Point(4, 4);
            this.yLabel6.Name = "yLabel6";
            this.yLabel6.Size = new System.Drawing.Size(112, 27);
            this.yLabel6.TabIndex = 13;
            this.yLabel6.Text = "TROLLEY NO";
            this.yLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrolleyStockBC
            // 
            this.AutoLoadData = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Name = "TrolleyStockBC";
            this.Size = new System.Drawing.Size(435, 208);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FX.Controls.YLabel yLabel6;
        private System.Windows.Forms.Panel panel1;
        private FX.Controls.YBitLabel yBitLabel1;
        private FX.Controls.YBitLabel yBitLabel2;
        private FX.Controls.YLabel yLabel1;
    }
}
