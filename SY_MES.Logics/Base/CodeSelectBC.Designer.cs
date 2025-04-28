namespace SY_MES.Logics.Base
{
    partial class CodeSelectBC
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
            this.FL_Pan = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnClear = new SY_MES.FX.Controls.YButton();
            this.lblDesc = new SY_MES.FX.Controls.YLabel();
            this.SuspendLayout();
            // 
            // FL_Pan
            // 
            this.FL_Pan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FL_Pan.AutoScroll = true;
            this.FL_Pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FL_Pan.Location = new System.Drawing.Point(3, 45);
            this.FL_Pan.Name = "FL_Pan";
            this.FL_Pan.Size = new System.Drawing.Size(733, 444);
            this.FL_Pan.TabIndex = 0;
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Yellow;
            this.BtnClear.ButtonStyle = SY_MES.FX.Controls.YButton.ButtonStyleEnum.Yellow;
            this.BtnClear.Desc = "Clear";
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClear.ForeColor = System.Drawing.Color.Black;
            this.BtnClear.Key = "";
            this.BtnClear.Location = new System.Drawing.Point(50, 4);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(94, 35);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesc.Desc = "yLabel1";
            this.lblDesc.EditStyle = false;
            this.lblDesc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblDesc.Key = "";
            this.lblDesc.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.TextLabel;
            this.lblDesc.Location = new System.Drawing.Point(150, 4);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(586, 35);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "yLabel1";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CodeSelectDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.FL_Pan);
            this.Name = "CodeSelectDlg";
            this.Size = new System.Drawing.Size(739, 492);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FL_Pan;
        private FX.Controls.YButton BtnClear;
        private FX.Controls.YLabel lblDesc;
    }
}
