namespace SY_MES.FX.PLC
{
    partial class PLC_MonitorFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPLCIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBaseAddr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPLC_TYPE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPLC_PORT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPLC_BSIZE = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPLC_TAG = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 17;
            this.dataGridView1.Size = new System.Drawing.Size(378, 464);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "C1";
            this.Column1.HeaderText = "0";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "C2";
            this.Column2.HeaderText = "1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 30;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "C3";
            this.Column3.HeaderText = "2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 30;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "C4";
            this.Column4.HeaderText = "3";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 30;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "C5";
            this.Column5.HeaderText = "4";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 30;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "C6";
            this.Column6.HeaderText = "5";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 30;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "C7";
            this.Column7.HeaderText = "6";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 30;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "C8";
            this.Column8.HeaderText = "7";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 30;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "C9";
            this.Column9.HeaderText = "8";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 30;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "C10";
            this.Column10.HeaderText = "9";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 30;
            // 
            // lblPLCIP
            // 
            this.lblPLCIP.AutoSize = true;
            this.lblPLCIP.Location = new System.Drawing.Point(70, 9);
            this.lblPLCIP.Name = "lblPLCIP";
            this.lblPLCIP.Size = new System.Drawing.Size(53, 12);
            this.lblPLCIP.TabIndex = 4;
            this.lblPLCIP.Text = "lblPLCIP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "PLC IP :";
            // 
            // lblBaseAddr
            // 
            this.lblBaseAddr.AutoSize = true;
            this.lblBaseAddr.Location = new System.Drawing.Point(111, 28);
            this.lblBaseAddr.Name = "lblBaseAddr";
            this.lblBaseAddr.Size = new System.Drawing.Size(73, 12);
            this.lblBaseAddr.TabIndex = 6;
            this.lblBaseAddr.Text = "lblBaseAddr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base Address :";
            // 
            // lblPLC_TYPE
            // 
            this.lblPLC_TYPE.AutoSize = true;
            this.lblPLC_TYPE.Location = new System.Drawing.Point(292, 9);
            this.lblPLC_TYPE.Name = "lblPLC_TYPE";
            this.lblPLC_TYPE.Size = new System.Drawing.Size(80, 12);
            this.lblPLC_TYPE.TabIndex = 8;
            this.lblPLC_TYPE.Text = "lblPLC_TYPE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "PLC TYPE :";
            // 
            // lblPLC_PORT
            // 
            this.lblPLC_PORT.AutoSize = true;
            this.lblPLC_PORT.Location = new System.Drawing.Point(292, 28);
            this.lblPLC_PORT.Name = "lblPLC_PORT";
            this.lblPLC_PORT.Size = new System.Drawing.Size(81, 12);
            this.lblPLC_PORT.TabIndex = 10;
            this.lblPLC_PORT.Text = "lblPLC_PORT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "PORT :";
            // 
            // lblPLC_BSIZE
            // 
            this.lblPLC_BSIZE.AutoSize = true;
            this.lblPLC_BSIZE.Location = new System.Drawing.Point(97, 50);
            this.lblPLC_BSIZE.Name = "lblPLC_BSIZE";
            this.lblPLC_BSIZE.Size = new System.Drawing.Size(83, 12);
            this.lblPLC_BSIZE.TabIndex = 12;
            this.lblPLC_BSIZE.Text = "lblPLC_BSIZE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "Block Size :";
            // 
            // lblPLC_TAG
            // 
            this.lblPLC_TAG.AutoSize = true;
            this.lblPLC_TAG.Location = new System.Drawing.Point(292, 50);
            this.lblPLC_TAG.Name = "lblPLC_TAG";
            this.lblPLC_TAG.Size = new System.Drawing.Size(73, 12);
            this.lblPLC_TAG.TabIndex = 14;
            this.lblPLC_TAG.Text = "lblPLC_TAG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tag :";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 549);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 16);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Write";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // PLC_MonitorFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(402, 572);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblPLC_TAG);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPLC_BSIZE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPLC_PORT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPLC_TYPE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBaseAddr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPLCIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PLC_MonitorFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PLC Communication Monitoring";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label lblPLCIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBaseAddr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPLC_TYPE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPLC_PORT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPLC_BSIZE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPLC_TAG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}