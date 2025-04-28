namespace SY_MES.FX.PLC
{
    partial class SimplePlcUI
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
            this.lblMain = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMain.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(3, 3);
            this.lblMain.Margin = new System.Windows.Forms.Padding(0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(44, 51);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "PLC";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMain.DoubleClick += new System.EventHandler(this.lblMain_DoubleClick);
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblState.Location = new System.Drawing.Point(53, 3);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(62, 51);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "RUNNING";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblState.DoubleClick += new System.EventHandler(this.lblMain_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.lblMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblState, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(121, 57);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.DoubleClick += new System.EventHandler(this.lblMain_DoubleClick);
            // 
            // SimplePlcUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SimplePlcUI";
            this.Size = new System.Drawing.Size(121, 57);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
