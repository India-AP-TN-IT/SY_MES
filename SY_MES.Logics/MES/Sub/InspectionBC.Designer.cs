namespace SY_MES.Logics.MES.Sub
{
    partial class InspectionBC
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.yLabel1 = new SY_MES.FX.Controls.YLabel();
            this.Pan_InspectionFact = new System.Windows.Forms.FlowLayoutPanel();
            this.yTableLayout1 = new SY_MES.FX.Controls.YTableLayout();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yButton1 = new SY_MES.FX.Controls.YButton();
            this.yButton2 = new SY_MES.FX.Controls.YButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.yLabel2 = new SY_MES.FX.Controls.YLabel();
            this.Lbl_RSLT = new SY_MES.FX.Controls.YBitLabel();
            this.panel2.SuspendLayout();
            this.yTableLayout1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.yLabel1);
            this.panel2.Controls.Add(this.Pan_InspectionFact);
            this.panel2.Location = new System.Drawing.Point(5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 226);
            this.panel2.TabIndex = 13;
            // 
            // yLabel1
            // 
            this.yLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel1.Desc = "Inspection Factors";
            this.yLabel1.EditStyle = false;
            this.yLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel1.Key = "";
            this.yLabel1.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel1.Location = new System.Drawing.Point(2, 4);
            this.yLabel1.Name = "yLabel1";
            this.yLabel1.Size = new System.Drawing.Size(191, 35);
            this.yLabel1.TabIndex = 0;
            this.yLabel1.Text = "Inspection Factors";
            this.yLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pan_InspectionFact
            // 
            this.Pan_InspectionFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pan_InspectionFact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pan_InspectionFact.Location = new System.Drawing.Point(2, 42);
            this.Pan_InspectionFact.Name = "Pan_InspectionFact";
            this.Pan_InspectionFact.Size = new System.Drawing.Size(436, 181);
            this.Pan_InspectionFact.TabIndex = 1;
            // 
            // yTableLayout1
            // 
            this.yTableLayout1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yTableLayout1.ColumnCount = 1;
            this.yTableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.yTableLayout1.Controls.Add(this.panel1, 0, 1);
            this.yTableLayout1.Controls.Add(this.panel3, 0, 0);
            this.yTableLayout1.Desc = "";
            this.yTableLayout1.Key = "";
            this.yTableLayout1.Location = new System.Drawing.Point(5, 235);
            this.yTableLayout1.Name = "yTableLayout1";
            this.yTableLayout1.RowCount = 2;
            this.yTableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.yTableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.yTableLayout1.Size = new System.Drawing.Size(442, 235);
            this.yTableLayout1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.yButton1);
            this.panel1.Controls.Add(this.yButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 100);
            this.panel1.TabIndex = 9;
            // 
            // yButton1
            // 
            this.yButton1.BackColor = System.Drawing.Color.Lime;
            this.yButton1.ButtonStyle = SY_MES.FX.Controls.YButton.ButtonStyleEnum.Lime;
            this.yButton1.Desc = "OK";
            this.yButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yButton1.ForeColor = System.Drawing.Color.Black;
            this.yButton1.Key = "OK";
            this.yButton1.Location = new System.Drawing.Point(3, 11);
            this.yButton1.Name = "yButton1";
            this.yButton1.Size = new System.Drawing.Size(186, 71);
            this.yButton1.TabIndex = 3;
            this.yButton1.Text = "OK";
            this.yButton1.UseVisualStyleBackColor = false;
            // 
            // yButton2
            // 
            this.yButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yButton2.BackColor = System.Drawing.Color.Red;
            this.yButton2.ButtonStyle = SY_MES.FX.Controls.YButton.ButtonStyleEnum.Red;
            this.yButton2.Desc = "NG";
            this.yButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yButton2.ForeColor = System.Drawing.Color.White;
            this.yButton2.Key = "NG";
            this.yButton2.Location = new System.Drawing.Point(337, 45);
            this.yButton2.Name = "yButton2";
            this.yButton2.Size = new System.Drawing.Size(92, 48);
            this.yButton2.TabIndex = 4;
            this.yButton2.Text = "NG";
            this.yButton2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.yLabel2);
            this.panel3.Controls.Add(this.Lbl_RSLT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 123);
            this.panel3.TabIndex = 11;
            // 
            // yLabel2
            // 
            this.yLabel2.BackColor = System.Drawing.Color.Gainsboro;
            this.yLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yLabel2.Desc = "Inspection Result";
            this.yLabel2.EditStyle = false;
            this.yLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.yLabel2.Key = "";
            this.yLabel2.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.yLabel2.Location = new System.Drawing.Point(3, 4);
            this.yLabel2.Name = "yLabel2";
            this.yLabel2.Size = new System.Drawing.Size(191, 35);
            this.yLabel2.TabIndex = 2;
            this.yLabel2.Text = "Inspection Result";
            this.yLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_RSLT
            // 
            this.Lbl_RSLT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_RSLT.BackColor = System.Drawing.Color.Red;
            this.Lbl_RSLT.Desc = "Lbl_RSLT";
            this.Lbl_RSLT.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RSLT.ForeColor = System.Drawing.Color.White;
            this.Lbl_RSLT.Key = "";
            this.Lbl_RSLT.Location = new System.Drawing.Point(3, 40);
            this.Lbl_RSLT.Name = "Lbl_RSLT";
            this.Lbl_RSLT.OffBGColor = System.Drawing.Color.Red;
            this.Lbl_RSLT.OffForeColor = System.Drawing.Color.White;
            this.Lbl_RSLT.OnBGColor = System.Drawing.Color.Lime;
            this.Lbl_RSLT.OnForeColor = System.Drawing.Color.Black;
            this.Lbl_RSLT.Size = new System.Drawing.Size(430, 80);
            this.Lbl_RSLT.TabIndex = 6;
            this.Lbl_RSLT.Text = "Lbl_RSLT";
            this.Lbl_RSLT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InspectionBC
            // 
            this.AutoLoadData = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.yTableLayout1);
            this.Name = "InspectionBC";
            this.Size = new System.Drawing.Size(453, 472);
            this.panel2.ResumeLayout(false);
            this.yTableLayout1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FX.Controls.YLabel yLabel1;
        private System.Windows.Forms.FlowLayoutPanel Pan_InspectionFact;
        private FX.Controls.YTableLayout yTableLayout1;
        private System.Windows.Forms.Panel panel1;
        private FX.Controls.YButton yButton1;
        private FX.Controls.YButton yButton2;
        private System.Windows.Forms.Panel panel3;
        private FX.Controls.YLabel yLabel2;
        private FX.Controls.YBitLabel Lbl_RSLT;


    }
}
