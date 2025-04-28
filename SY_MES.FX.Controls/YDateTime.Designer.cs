namespace SY_MES.FX.Controls
{
    partial class YDateTime
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
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.Btn_Nex = new System.Windows.Forms.Button();
            this.Btn_Prv = new System.Windows.Forms.Button();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Date.BackColor = System.Drawing.Color.White;
            this.Lbl_Date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Date.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lbl_Date.Location = new System.Drawing.Point(121, 2);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(138, 24);
            this.Lbl_Date.TabIndex = 20;
            this.Lbl_Date.Text = "2014-09-06";
            this.Lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Date.TextChanged += new System.EventHandler(this.Lbl_Date_TextChanged);
            this.Lbl_Date.Click += new System.EventHandler(this.Lbl_Date_Click);
            // 
            // Btn_Nex
            // 
            this.Btn_Nex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Nex.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Nex.Location = new System.Drawing.Point(334, 3);
            this.Btn_Nex.Name = "Btn_Nex";
            this.Btn_Nex.Size = new System.Drawing.Size(55, 25);
            this.Btn_Nex.TabIndex = 19;
            this.Btn_Nex.Text = ">>";
            this.Btn_Nex.UseVisualStyleBackColor = true;
            this.Btn_Nex.Click += new System.EventHandler(this.Btn_Nex_Click);
            // 
            // Btn_Prv
            // 
            this.Btn_Prv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Prv.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Prv.Location = new System.Drawing.Point(265, 2);
            this.Btn_Prv.Name = "Btn_Prv";
            this.Btn_Prv.Size = new System.Drawing.Size(55, 27);
            this.Btn_Prv.TabIndex = 18;
            this.Btn_Prv.Text = "<<";
            this.Btn_Prv.UseVisualStyleBackColor = true;
            this.Btn_Prv.Click += new System.EventHandler(this.Btn_Prv_Click);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Lbl_Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Title.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lbl_Title.Location = new System.Drawing.Point(3, 1);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(112, 26);
            this.Lbl_Title.TabIndex = 21;
            this.Lbl_Title.Text = "Date";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YDateTime
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.Btn_Nex);
            this.Controls.Add(this.Btn_Prv);
            this.Name = "YDateTime";
            this.Size = new System.Drawing.Size(397, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.Button Btn_Nex;
        private System.Windows.Forms.Button Btn_Prv;
        private System.Windows.Forms.Label Lbl_Title;
    }
}
