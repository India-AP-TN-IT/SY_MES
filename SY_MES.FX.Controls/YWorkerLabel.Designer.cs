namespace SY_MES.FX.Controls
{
    partial class YWorkerLabel
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
            this.lbl_DESC = new System.Windows.Forms.Label();
            this.Txt_EMP = new SY_MES.FX.Controls.YTextBox();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.yTableLayout1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yTableLayout1
            // 
            this.yTableLayout1.ColumnCount = 3;
            this.yTableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.yTableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.yTableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.yTableLayout1.Controls.Add(this.lbl_DESC, 0, 0);
            this.yTableLayout1.Controls.Add(this.Txt_EMP, 0, 0);
            this.yTableLayout1.Controls.Add(this.Lbl_Title, 0, 0);
            this.yTableLayout1.Desc = "";
            this.yTableLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yTableLayout1.Key = "";
            this.yTableLayout1.Location = new System.Drawing.Point(0, 0);
            this.yTableLayout1.Name = "yTableLayout1";
            this.yTableLayout1.RowCount = 1;
            this.yTableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.yTableLayout1.Size = new System.Drawing.Size(614, 31);
            this.yTableLayout1.TabIndex = 24;
            // 
            // lbl_DESC
            // 
            this.lbl_DESC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_DESC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_DESC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_DESC.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_DESC.Location = new System.Drawing.Point(371, 0);
            this.lbl_DESC.Name = "lbl_DESC";
            this.lbl_DESC.Size = new System.Drawing.Size(240, 31);
            this.lbl_DESC.TabIndex = 26;
            this.lbl_DESC.Text = "DESC";
            this.lbl_DESC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_EMP
            // 
            this.Txt_EMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_EMP.Desc = "";
            this.Txt_EMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_EMP.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_EMP.Key = "";
            this.Txt_EMP.KeyMode = SY_MES.FX.Controls.TouchKeyboard.KeyModeEnum.Number;
            this.Txt_EMP.KeyPadModal = true;
            this.Txt_EMP.Location = new System.Drawing.Point(187, 3);
            this.Txt_EMP.MaxLength = 6;
            this.Txt_EMP.Name = "Txt_EMP";
            this.Txt_EMP.Size = new System.Drawing.Size(178, 44);
            this.Txt_EMP.TabIndex = 25;
            this.Txt_EMP.TouchKeyBoardMethod = SY_MES.FX.Controls.YTextBox.ClickEnum.DoubleClick;
            this.Txt_EMP.TouchKeyPos = SY_MES.FX.Controls.YTextBox.TouchKeyPosEnum.Down;
            this.Txt_EMP.UpperString = false;
            this.Txt_EMP.UseTouchKeyBoard = true;
            this.Txt_EMP.OnCloseKeyboard += new SY_MES.FX.Controls.YTextBox.CloseKeyboard(this.Txt_EMP_OnCloseKeyboard);
            this.Txt_EMP.TextChanged += new System.EventHandler(this.Txt_EMP_TextChanged);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Lbl_Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Title.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lbl_Title.Location = new System.Drawing.Point(3, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(178, 31);
            this.Lbl_Title.TabIndex = 24;
            this.Lbl_Title.Text = "Worker";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YWorkerLabel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.yTableLayout1);
            this.Name = "YWorkerLabel";
            this.Size = new System.Drawing.Size(614, 31);
            this.yTableLayout1.ResumeLayout(false);
            this.yTableLayout1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private YTableLayout yTableLayout1;
        private System.Windows.Forms.Label lbl_DESC;
        private YTextBox Txt_EMP;
        private System.Windows.Forms.Label Lbl_Title;
    }
}
