namespace SY_MES.DEPLOY.Sub
{
    partial class SystemConfigDlg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnScan = new System.Windows.Forms.Button();
            this.txtScan = new SY_MES.FX.Controls.YTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_LUPDATE_LOC = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_STARTDATE = new System.Windows.Forms.Label();
            this.lbl_LUPDATE = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_DBU = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_SID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_DBType = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_STATIONCD = new System.Windows.Forms.Label();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.lbl_CLASS = new System.Windows.Forms.Label();
            this.lbl_POS = new System.Windows.Forms.Label();
            this.lbl_LINE = new System.Windows.Forms.Label();
            this.lbl_BIZCD = new System.Windows.Forms.Label();
            this.lbl_CORCD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.yDataGridView1 = new SY_MES.FX.Controls.YDataGridView();
            this.SCREEN_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SECTION_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INI_KEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INI_KEYVALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INI_KEY_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.GrdLog = new SY_MES.FX.Controls.YDataGridView();
            this.LOG_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOG_TY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOG_MSG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOG_METHOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yDataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdLog)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnScan);
            this.groupBox1.Controls.Add(this.txtScan);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Virtual Scanner";
            // 
            // BtnScan
            // 
            this.BtnScan.Location = new System.Drawing.Point(483, 17);
            this.BtnScan.Name = "BtnScan";
            this.BtnScan.Size = new System.Drawing.Size(75, 28);
            this.BtnScan.TabIndex = 2;
            this.BtnScan.Text = "Scan";
            this.BtnScan.UseVisualStyleBackColor = true;
            this.BtnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // txtScan
            // 
            this.txtScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScan.Desc = "";
            this.txtScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtScan.Key = "";
            this.txtScan.KeyMode = SY_MES.FX.Controls.TouchKeyboard.KeyModeEnum.AlphaNumber;
            this.txtScan.KeyPadModal = true;
            this.txtScan.Location = new System.Drawing.Point(77, 19);
            this.txtScan.MaxLength = 200;
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(400, 26);
            this.txtScan.TabIndex = 1;
            this.txtScan.TouchKeyBoardMethod = SY_MES.FX.Controls.YTextBox.ClickEnum.DoubleClick;
            this.txtScan.TouchKeyPos = SY_MES.FX.Controls.YTextBox.TouchKeyPosEnum.Down;
            this.txtScan.UpperString = false;
            this.txtScan.UseTouchKeyBoard = true;
            this.txtScan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.yTextBox1_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Scan Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(9, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Version Information";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_LUPDATE_LOC);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(454, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 68);
            this.panel2.TabIndex = 1;
            // 
            // lbl_LUPDATE_LOC
            // 
            this.lbl_LUPDATE_LOC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_LUPDATE_LOC.Location = new System.Drawing.Point(57, 27);
            this.lbl_LUPDATE_LOC.Name = "lbl_LUPDATE_LOC";
            this.lbl_LUPDATE_LOC.Size = new System.Drawing.Size(194, 24);
            this.lbl_LUPDATE_LOC.TabIndex = 5;
            this.lbl_LUPDATE_LOC.Text = "label18";
            this.lbl_LUPDATE_LOC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(107, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Last Update";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(2, 1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 63);
            this.label16.TabIndex = 0;
            this.label16.Text = "Logic";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_STARTDATE);
            this.panel1.Controls.Add(this.lbl_LUPDATE);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(13, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 68);
            this.panel1.TabIndex = 0;
            // 
            // lbl_STARTDATE
            // 
            this.lbl_STARTDATE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_STARTDATE.Location = new System.Drawing.Point(246, 27);
            this.lbl_STARTDATE.Name = "lbl_STARTDATE";
            this.lbl_STARTDATE.Size = new System.Drawing.Size(176, 24);
            this.lbl_STARTDATE.TabIndex = 4;
            this.lbl_STARTDATE.Text = "label17";
            this.lbl_STARTDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LUPDATE
            // 
            this.lbl_LUPDATE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_LUPDATE.Location = new System.Drawing.Point(57, 27);
            this.lbl_LUPDATE.Name = "lbl_LUPDATE";
            this.lbl_LUPDATE.Size = new System.Drawing.Size(174, 24);
            this.lbl_LUPDATE.TabIndex = 3;
            this.lbl_LUPDATE.Text = "label14";
            this.lbl_LUPDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(269, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Program Start Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(85, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Last Update";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(2, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 63);
            this.label8.TabIndex = 0;
            this.label8.Text = "Deploy";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 212);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 267);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_DBU);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.lbl_SID);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.lbl_DBType);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lbl_STATIONCD);
            this.tabPage1.Controls.Add(this.lbl_IP);
            this.tabPage1.Controls.Add(this.lbl_CLASS);
            this.tabPage1.Controls.Add(this.lbl_POS);
            this.tabPage1.Controls.Add(this.lbl_LINE);
            this.tabPage1.Controls.Add(this.lbl_BIZCD);
            this.tabPage1.Controls.Add(this.lbl_CORCD);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(708, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_DBU
            // 
            this.lbl_DBU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_DBU.Location = new System.Drawing.Point(104, 168);
            this.lbl_DBU.Name = "lbl_DBU";
            this.lbl_DBU.Size = new System.Drawing.Size(92, 35);
            this.lbl_DBU.TabIndex = 19;
            this.lbl_DBU.Text = "lbl_DBU";
            this.lbl_DBU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "User";
            // 
            // lbl_SID
            // 
            this.lbl_SID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_SID.Location = new System.Drawing.Point(327, 107);
            this.lbl_SID.Name = "lbl_SID";
            this.lbl_SID.Size = new System.Drawing.Size(309, 35);
            this.lbl_SID.TabIndex = 17;
            this.lbl_SID.Text = "label10";
            this.lbl_SID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(209, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "DB Name/SID";
            // 
            // lbl_DBType
            // 
            this.lbl_DBType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_DBType.Location = new System.Drawing.Point(104, 107);
            this.lbl_DBType.Name = "lbl_DBType";
            this.lbl_DBType.Size = new System.Drawing.Size(92, 35);
            this.lbl_DBType.TabIndex = 15;
            this.lbl_DBType.Text = "label10";
            this.lbl_DBType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "DB Type";
            // 
            // lbl_STATIONCD
            // 
            this.lbl_STATIONCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_STATIONCD.Location = new System.Drawing.Point(511, 9);
            this.lbl_STATIONCD.Name = "lbl_STATIONCD";
            this.lbl_STATIONCD.Size = new System.Drawing.Size(90, 35);
            this.lbl_STATIONCD.TabIndex = 13;
            this.lbl_STATIONCD.Text = "label14";
            this.lbl_STATIONCD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_IP
            // 
            this.lbl_IP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_IP.Location = new System.Drawing.Point(248, 56);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(183, 35);
            this.lbl_IP.TabIndex = 12;
            this.lbl_IP.Text = "label13";
            this.lbl_IP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CLASS
            // 
            this.lbl_CLASS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_CLASS.Location = new System.Drawing.Point(369, 161);
            this.lbl_CLASS.Name = "lbl_CLASS";
            this.lbl_CLASS.Size = new System.Drawing.Size(232, 35);
            this.lbl_CLASS.TabIndex = 11;
            this.lbl_CLASS.Text = "label12";
            this.lbl_CLASS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_POS
            // 
            this.lbl_POS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_POS.Location = new System.Drawing.Point(509, 56);
            this.lbl_POS.Name = "lbl_POS";
            this.lbl_POS.Size = new System.Drawing.Size(92, 35);
            this.lbl_POS.TabIndex = 10;
            this.lbl_POS.Text = "label11";
            this.lbl_POS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LINE
            // 
            this.lbl_LINE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_LINE.Location = new System.Drawing.Point(104, 56);
            this.lbl_LINE.Name = "lbl_LINE";
            this.lbl_LINE.Size = new System.Drawing.Size(92, 35);
            this.lbl_LINE.TabIndex = 9;
            this.lbl_LINE.Text = "label10";
            this.lbl_LINE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_BIZCD
            // 
            this.lbl_BIZCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_BIZCD.Location = new System.Drawing.Point(283, 9);
            this.lbl_BIZCD.Name = "lbl_BIZCD";
            this.lbl_BIZCD.Size = new System.Drawing.Size(90, 35);
            this.lbl_BIZCD.TabIndex = 8;
            this.lbl_BIZCD.Text = "label9";
            this.lbl_BIZCD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CORCD
            // 
            this.lbl_CORCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_CORCD.Location = new System.Drawing.Point(104, 9);
            this.lbl_CORCD.Name = "lbl_CORCD";
            this.lbl_CORCD.Size = new System.Drawing.Size(92, 35);
            this.lbl_CORCD.TabIndex = 7;
            this.lbl_CORCD.Text = "label8";
            this.lbl_CORCD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Logic Class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "POS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "STATIONCD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LINECD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BIZCD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CORCD";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.yDataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(708, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "INI Setting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "INI SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 216);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "INI Modify";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // yDataGridView1
            // 
            this.yDataGridView1.AllowUserToAddRows = false;
            this.yDataGridView1.AllowUserToResizeColumns = false;
            this.yDataGridView1.AllowUserToResizeRows = false;
            this.yDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yDataGridView1.AutoBindName = true;
            this.yDataGridView1.AutoGenerateColumns = false;
            this.yDataGridView1.BindMove = false;
            this.yDataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.yDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.yDataGridView1.ColumnHeadersHeight = 30;
            this.yDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SCREEN_ID,
            this.SECTION_ID,
            this.INI_KEY,
            this.INI_KEYVALUE,
            this.INI_KEY_DESC});
            this.yDataGridView1.Desc = "";
            this.yDataGridView1.FixedSort = true;
            this.yDataGridView1.GridMode = SY_MES.FX.Controls.YDataGridView.GridModeEnum.UserSetting;
            this.yDataGridView1.HeaderAlignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.yDataGridView1.HeaderHeight = 30;
            this.yDataGridView1.Key = "";
            this.yDataGridView1.Location = new System.Drawing.Point(6, 6);
            this.yDataGridView1.MovePKColName = "";
            this.yDataGridView1.MultiSelect = false;
            this.yDataGridView1.Name = "yDataGridView1";
            this.yDataGridView1.ReadOnly = true;
            this.yDataGridView1.RowHeadersVisible = false;
            this.yDataGridView1.RowHeadersWidth = 82;
            this.yDataGridView1.RowHeight = 40;
            this.yDataGridView1.RowTemplate.Height = 40;
            this.yDataGridView1.ScrollLock = false;
            this.yDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.yDataGridView1.Size = new System.Drawing.Size(694, 204);
            this.yDataGridView1.TabIndex = 0;
            this.yDataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.yDataGridView1_CellBeginEdit);
            // 
            // SCREEN_ID
            // 
            this.SCREEN_ID.DataPropertyName = "SCREEN_ID";
            this.SCREEN_ID.HeaderText = "Program";
            this.SCREEN_ID.MinimumWidth = 10;
            this.SCREEN_ID.Name = "SCREEN_ID";
            this.SCREEN_ID.ReadOnly = true;
            this.SCREEN_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SCREEN_ID.Visible = false;
            this.SCREEN_ID.Width = 200;
            // 
            // SECTION_ID
            // 
            this.SECTION_ID.DataPropertyName = "SECTION_ID";
            this.SECTION_ID.HeaderText = "SECTION_ID";
            this.SECTION_ID.MinimumWidth = 10;
            this.SECTION_ID.Name = "SECTION_ID";
            this.SECTION_ID.ReadOnly = true;
            this.SECTION_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SECTION_ID.Width = 150;
            // 
            // INI_KEY
            // 
            this.INI_KEY.DataPropertyName = "INI_KEY";
            this.INI_KEY.HeaderText = "INI KEY";
            this.INI_KEY.MinimumWidth = 10;
            this.INI_KEY.Name = "INI_KEY";
            this.INI_KEY.ReadOnly = true;
            this.INI_KEY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.INI_KEY.Width = 185;
            // 
            // INI_KEYVALUE
            // 
            this.INI_KEYVALUE.DataPropertyName = "INI_KEYVALUE";
            this.INI_KEYVALUE.HeaderText = "INI VALUE";
            this.INI_KEYVALUE.MinimumWidth = 10;
            this.INI_KEYVALUE.Name = "INI_KEYVALUE";
            this.INI_KEYVALUE.ReadOnly = true;
            this.INI_KEYVALUE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.INI_KEYVALUE.Width = 95;
            // 
            // INI_KEY_DESC
            // 
            this.INI_KEY_DESC.DataPropertyName = "INI_KEY_DESC";
            this.INI_KEY_DESC.HeaderText = "DESCRIPTION";
            this.INI_KEY_DESC.MinimumWidth = 10;
            this.INI_KEY_DESC.Name = "INI_KEY_DESC";
            this.INI_KEY_DESC.ReadOnly = true;
            this.INI_KEY_DESC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.INI_KEY_DESC.Width = 235;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.GrdLog);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(708, 241);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Status Log List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // GrdLog
            // 
            this.GrdLog.AllowUserToAddRows = false;
            this.GrdLog.AllowUserToResizeColumns = false;
            this.GrdLog.AllowUserToResizeRows = false;
            this.GrdLog.AutoBindName = true;
            this.GrdLog.AutoGenerateColumns = false;
            this.GrdLog.BindMove = false;
            this.GrdLog.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GrdLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LOG_DATE,
            this.LOG_TY,
            this.LOG_MSG,
            this.LOG_METHOD});
            this.GrdLog.Desc = "";
            this.GrdLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdLog.FixedSort = true;
            this.GrdLog.HeaderAlignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GrdLog.HeaderHeight = 23;
            this.GrdLog.Key = "";
            this.GrdLog.Location = new System.Drawing.Point(3, 3);
            this.GrdLog.MovePKColName = "";
            this.GrdLog.MultiSelect = false;
            this.GrdLog.Name = "GrdLog";
            this.GrdLog.ReadOnly = true;
            this.GrdLog.RowHeadersVisible = false;
            this.GrdLog.RowHeight = 23;
            this.GrdLog.RowTemplate.Height = 23;
            this.GrdLog.ScrollLock = false;
            this.GrdLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdLog.Size = new System.Drawing.Size(702, 235);
            this.GrdLog.TabIndex = 0;
            // 
            // LOG_DATE
            // 
            this.LOG_DATE.DataPropertyName = "LOG_DATE";
            this.LOG_DATE.HeaderText = "Date";
            this.LOG_DATE.Name = "LOG_DATE";
            this.LOG_DATE.ReadOnly = true;
            this.LOG_DATE.Width = 110;
            // 
            // LOG_TY
            // 
            this.LOG_TY.DataPropertyName = "LOG_TY";
            this.LOG_TY.HeaderText = "Type";
            this.LOG_TY.Name = "LOG_TY";
            this.LOG_TY.ReadOnly = true;
            this.LOG_TY.Width = 65;
            // 
            // LOG_MSG
            // 
            this.LOG_MSG.DataPropertyName = "LOG_MSG";
            this.LOG_MSG.HeaderText = "Message";
            this.LOG_MSG.Name = "LOG_MSG";
            this.LOG_MSG.ReadOnly = true;
            this.LOG_MSG.Width = 360;
            // 
            // LOG_METHOD
            // 
            this.LOG_METHOD.DataPropertyName = "LOG_METHOD";
            this.LOG_METHOD.HeaderText = "Method";
            this.LOG_METHOD.Name = "LOG_METHOD";
            this.LOG_METHOD.ReadOnly = true;
            this.LOG_METHOD.Width = 120;
            // 
            // SystemConfigDlg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SystemConfigDlg";
            this.Size = new System.Drawing.Size(739, 492);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yDataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_STATIONCD;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Label lbl_CLASS;
        private System.Windows.Forms.Label lbl_POS;
        private System.Windows.Forms.Label lbl_LINE;
        private System.Windows.Forms.Label lbl_BIZCD;
        private System.Windows.Forms.Label lbl_CORCD;
        private System.Windows.Forms.Label lbl_SID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_DBType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_DBU;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private FX.Controls.YDataGridView yDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCREEN_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SECTION_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn INI_KEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn INI_KEYVALUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn INI_KEY_DESC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_LUPDATE_LOC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_STARTDATE;
        private System.Windows.Forms.Label lbl_LUPDATE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private FX.Controls.YTextBox txtScan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnScan;
        private System.Windows.Forms.TabPage tabPage3;
        private FX.Controls.YDataGridView GrdLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOG_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOG_TY;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOG_MSG;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOG_METHOD;
    }
}
