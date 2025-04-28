namespace SY_MES.Logics.MES.Sub
{
    partial class ReworkBomUC
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
            this.tableLayoutPanel1 = new SY_MES.FX.Controls.YTableLayout();
            this.ChkPartNO = new SY_MES.FX.Controls.YCheckBox();
            this.Btn_Who = new SY_MES.FX.Controls.YButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yButton3 = new SY_MES.FX.Controls.YButton();
            this.lblDefType = new SY_MES.FX.Controls.YLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.yButton1 = new SY_MES.FX.Controls.YButton();
            this.lblRewMe = new SY_MES.FX.Controls.YLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtQTY = new SY_MES.FX.Controls.YTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.ChkPartNO, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Who, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Desc = "";
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Key = "";
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 67);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ChkPartNO
            // 
            this.ChkPartNO.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkPartNO.BackColor = System.Drawing.Color.Silver;
            this.ChkPartNO.Desc = "ChkPartNO";
            this.ChkPartNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkPartNO.Key = "";
            this.ChkPartNO.Location = new System.Drawing.Point(0, 0);
            this.ChkPartNO.Margin = new System.Windows.Forms.Padding(0);
            this.ChkPartNO.Name = "ChkPartNO";
            this.tableLayoutPanel1.SetRowSpan(this.ChkPartNO, 2);
            this.ChkPartNO.Size = new System.Drawing.Size(174, 67);
            this.ChkPartNO.TabIndex = 0;
            this.ChkPartNO.Text = "ChkPartNO";
            this.ChkPartNO.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ChkPartNO.UseVisualStyleBackColor = false;
            this.ChkPartNO.CheckedChanged += new System.EventHandler(this.ChkPartNO_CheckedChanged);
            // 
            // Btn_Who
            // 
            this.Btn_Who.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Who.ButtonStyle = SY_MES.FX.Controls.YButton.ButtonStyleEnum.None;
            this.Btn_Who.Desc = "Btn_Who";
            this.Btn_Who.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Who.ForeColor = System.Drawing.Color.Black;
            this.Btn_Who.Key = "WREL";
            this.Btn_Who.Location = new System.Drawing.Point(174, 33);
            this.Btn_Who.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Who.Name = "Btn_Who";
            this.Btn_Who.Size = new System.Drawing.Size(43, 34);
            this.Btn_Who.TabIndex = 2;
            this.Btn_Who.Text = "Btn_Who";
            this.Btn_Who.UseVisualStyleBackColor = true;
            this.Btn_Who.Click += new System.EventHandler(this.Combo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(217, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "What";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(217, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "How";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yButton3);
            this.panel1.Controls.Add(this.lblDefType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(260, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 33);
            this.panel1.TabIndex = 5;
            // 
            // yButton3
            // 
            this.yButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.yButton3.ButtonStyle = SY_MES.FX.Controls.YButton.ButtonStyleEnum.Combo;
            this.yButton3.Desc = "▼";
            this.yButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yButton3.ForeColor = System.Drawing.Color.Black;
            this.yButton3.Key = "DEF_TYPE";
            this.yButton3.Location = new System.Drawing.Point(134, 3);
            this.yButton3.Name = "yButton3";
            this.yButton3.Size = new System.Drawing.Size(38, 26);
            this.yButton3.TabIndex = 25;
            this.yButton3.Text = "▼";
            this.yButton3.UseVisualStyleBackColor = false;
            this.yButton3.Click += new System.EventHandler(this.Combo_Click);
            // 
            // lblDefType
            // 
            this.lblDefType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDefType.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDefType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDefType.Desc = "Defect Type";
            this.lblDefType.EditStyle = false;
            this.lblDefType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDefType.Key = "";
            this.lblDefType.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lblDefType.Location = new System.Drawing.Point(3, 3);
            this.lblDefType.Name = "lblDefType";
            this.lblDefType.Size = new System.Drawing.Size(128, 26);
            this.lblDefType.TabIndex = 24;
            this.lblDefType.Text = "Defect Type";
            this.lblDefType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.yButton1);
            this.panel2.Controls.Add(this.lblRewMe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(260, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 34);
            this.panel2.TabIndex = 6;
            // 
            // yButton1
            // 
            this.yButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.yButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.yButton1.ButtonStyle = SY_MES.FX.Controls.YButton.ButtonStyleEnum.Combo;
            this.yButton1.Desc = "▼";
            this.yButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yButton1.ForeColor = System.Drawing.Color.Black;
            this.yButton1.Key = "METHOD";
            this.yButton1.Location = new System.Drawing.Point(3, 4);
            this.yButton1.Name = "yButton1";
            this.yButton1.Size = new System.Drawing.Size(38, 26);
            this.yButton1.TabIndex = 26;
            this.yButton1.Text = "▼";
            this.yButton1.UseVisualStyleBackColor = false;
            this.yButton1.Click += new System.EventHandler(this.Combo_Click);
            // 
            // lblRewMe
            // 
            this.lblRewMe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRewMe.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRewMe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRewMe.Desc = "How to Rework";
            this.lblRewMe.EditStyle = false;
            this.lblRewMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblRewMe.Key = "";
            this.lblRewMe.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lblRewMe.Location = new System.Drawing.Point(44, 4);
            this.lblRewMe.Name = "lblRewMe";
            this.lblRewMe.Size = new System.Drawing.Size(128, 26);
            this.lblRewMe.TabIndex = 26;
            this.lblRewMe.Text = "How to Rework";
            this.lblRewMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtQTY);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(174, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 33);
            this.panel3.TabIndex = 7;
            // 
            // txtQTY
            // 
            this.txtQTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQTY.Desc = "";
            this.txtQTY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtQTY.Key = "";
            this.txtQTY.KeyMode = SY_MES.FX.Controls.TouchKeyboard.KeyModeEnum.Number;
            this.txtQTY.KeyPadModal = true;
            this.txtQTY.Location = new System.Drawing.Point(0, 0);
            this.txtQTY.MaxLength = 6;
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(43, 26);
            this.txtQTY.TabIndex = 0;
            this.txtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQTY.TouchKeyBoardMethod = SY_MES.FX.Controls.YTextBox.ClickEnum.DoubleClick;
            this.txtQTY.TouchKeyPos = SY_MES.FX.Controls.YTextBox.TouchKeyPosEnum.Down;
            this.txtQTY.UpperString = false;
            this.txtQTY.UseTouchKeyBoard = true;
            this.txtQTY.TextChanged += new System.EventHandler(this.txtQTY_TextChanged);
            // 
            // ReworkBomUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ReworkBomUC";
            this.Size = new System.Drawing.Size(435, 67);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SY_MES.FX.Controls.YTableLayout tableLayoutPanel1;
        private FX.Controls.YCheckBox ChkPartNO;
        private FX.Controls.YButton Btn_Who;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private FX.Controls.YButton yButton3;
        private FX.Controls.YLabel lblDefType;
        private System.Windows.Forms.Panel panel2;
        private FX.Controls.YButton yButton1;
        private FX.Controls.YLabel lblRewMe;
        private System.Windows.Forms.Panel panel3;
        private FX.Controls.YTextBox txtQTY;
    }
}
