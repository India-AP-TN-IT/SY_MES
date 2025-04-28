namespace SY_MES.Logics.MES.Sub
{
    partial class SpecSheetCtl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_SPEC1_VAL = new SY_MES.FX.Controls.YLabel();
            this.lbl_SPEC1_TIT = new SY_MES.FX.Controls.YLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_SPEC1_VAL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_SPEC1_TIT, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_SPEC1_VAL
            // 
            this.lbl_SPEC1_VAL.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_SPEC1_VAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_SPEC1_VAL.Desc = "DESC";
            this.lbl_SPEC1_VAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SPEC1_VAL.EditStyle = false;
            this.lbl_SPEC1_VAL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_SPEC1_VAL.ForeColor = System.Drawing.Color.Blue;
            this.lbl_SPEC1_VAL.Key = "";
            this.lbl_SPEC1_VAL.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lbl_SPEC1_VAL.Location = new System.Drawing.Point(159, 0);
            this.lbl_SPEC1_VAL.Name = "lbl_SPEC1_VAL";
            this.lbl_SPEC1_VAL.Size = new System.Drawing.Size(286, 48);
            this.lbl_SPEC1_VAL.TabIndex = 17;
            this.lbl_SPEC1_VAL.Text = "DESC";
            this.lbl_SPEC1_VAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_SPEC1_TIT
            // 
            this.lbl_SPEC1_TIT.BackColor = System.Drawing.Color.Blue;
            this.lbl_SPEC1_TIT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_SPEC1_TIT.Desc = "Title";
            this.lbl_SPEC1_TIT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SPEC1_TIT.EditStyle = true;
            this.lbl_SPEC1_TIT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_SPEC1_TIT.ForeColor = System.Drawing.Color.White;
            this.lbl_SPEC1_TIT.Key = "";
            this.lbl_SPEC1_TIT.LabelDisStyle = SY_MES.FX.Controls.YLabel.LableStyleEnum.NomalLabel;
            this.lbl_SPEC1_TIT.Location = new System.Drawing.Point(3, 0);
            this.lbl_SPEC1_TIT.Name = "lbl_SPEC1_TIT";
            this.lbl_SPEC1_TIT.Size = new System.Drawing.Size(150, 48);
            this.lbl_SPEC1_TIT.TabIndex = 16;
            this.lbl_SPEC1_TIT.Text = "Title";
            this.lbl_SPEC1_TIT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpecSheetCtl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SpecSheetCtl";
            this.Size = new System.Drawing.Size(448, 48);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FX.Controls.YLabel lbl_SPEC1_VAL;
        private FX.Controls.YLabel lbl_SPEC1_TIT;
    }
}
