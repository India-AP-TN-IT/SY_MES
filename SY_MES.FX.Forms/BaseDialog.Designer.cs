namespace SY_MES.FX.MainForm
{
    partial class BaseDialog
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
            this.Btn_Close = new System.Windows.Forms.Button();
            this.lbl_ReInput = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Pan_Body = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Red;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Close.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Location = new System.Drawing.Point(7, 7);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(7);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(61, 46);
            this.Btn_Close.TabIndex = 4;
            this.Btn_Close.Text = "×";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // lbl_ReInput
            // 
            this.lbl_ReInput.BackColor = System.Drawing.Color.DarkBlue;
            this.lbl_ReInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ReInput.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_ReInput.ForeColor = System.Drawing.Color.White;
            this.lbl_ReInput.Location = new System.Drawing.Point(90, 0);
            this.lbl_ReInput.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ReInput.Name = "lbl_ReInput";
            this.lbl_ReInput.Size = new System.Drawing.Size(874, 60);
            this.lbl_ReInput.TabIndex = 3;
            this.lbl_ReInput.Text = "Dialog Title";
            this.lbl_ReInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ReInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_ReInput_MouseDown);
            this.lbl_ReInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_ReInput_MouseMove);
            this.lbl_ReInput.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_ReInput_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Pan_Body, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(966, 695);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DarkBlue;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.439834F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.56017F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_ReInput, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Close, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(964, 60);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // Pan_Body
            // 
            this.Pan_Body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pan_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pan_Body.Location = new System.Drawing.Point(1, 62);
            this.Pan_Body.Margin = new System.Windows.Forms.Padding(0);
            this.Pan_Body.Name = "Pan_Body";
            this.Pan_Body.Size = new System.Drawing.Size(964, 632);
            this.Pan_Body.TabIndex = 7;
            // 
            // BaseDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(966, 695);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BaseDialog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label lbl_ReInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel Pan_Body;
    }
}