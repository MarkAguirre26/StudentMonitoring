namespace AppSystem
{
    partial class frm_user
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
            this.cmd_cancel = new System.Windows.Forms.Button();
            this.cmd_save = new System.Windows.Forms.Button();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.wizard1 = new AppSystem.wizard();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.openCameraUser = new System.Windows.Forms.Button();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Lname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_invalid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.cb_show_pwd = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_repeatPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_level = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt_TimeOUT = new System.Windows.Forms.DateTimePicker();
            this.dt_TimeIN = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmdFingerPrint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openCameraStudent = new System.Windows.Forms.Button();
            this.pbStudent = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.FirstNameStudent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MiddleNameStudent = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.LastNameStudent = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSy = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.LRNStudent = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.labelStrand = new System.Windows.Forms.Label();
            this.txtStrand = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboSection = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtGuardiansName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.PhoneNumberStudent = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRfidId = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtAdviser = new System.Windows.Forms.TextBox();
            this.wizard1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_cancel.Location = new System.Drawing.Point(254, 505);
            this.cmd_cancel.Name = "cmd_cancel";
            this.cmd_cancel.Size = new System.Drawing.Size(189, 30);
            this.cmd_cancel.TabIndex = 27;
            this.cmd_cancel.Text = "Cancel";
            this.cmd_cancel.UseVisualStyleBackColor = true;
            this.cmd_cancel.Click += new System.EventHandler(this.cmd_cancel_Click);
            // 
            // cmd_save
            // 
            this.cmd_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_save.Location = new System.Drawing.Point(59, 505);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(189, 30);
            this.cmd_save.TabIndex = 28;
            this.cmd_save.Text = "&Save";
            this.cmd_save.UseVisualStyleBackColor = true;
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbUser.Location = new System.Drawing.Point(132, 4);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(95, 17);
            this.rbUser.TabIndex = 30;
            this.rbUser.Text = "System User";
            this.rbUser.UseVisualStyleBackColor = true;
            this.rbUser.CheckedChanged += new System.EventHandler(this.rbUser_CheckedChanged);
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbStudent.Location = new System.Drawing.Point(291, 4);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(69, 17);
            this.rbStudent.TabIndex = 31;
            this.rbStudent.Text = "Student";
            this.rbStudent.UseVisualStyleBackColor = true;
            this.rbStudent.CheckedChanged += new System.EventHandler(this.rbStudent_CheckedChanged);
            // 
            // wizard1
            // 
            this.wizard1.Controls.Add(this.tabPage3);
            this.wizard1.Controls.Add(this.tabPage4);
            this.wizard1.Location = new System.Drawing.Point(23, 23);
            this.wizard1.Name = "wizard1";
            this.wizard1.SelectedIndex = 0;
            this.wizard1.Size = new System.Drawing.Size(498, 476);
            this.wizard1.TabIndex = 29;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.openCameraUser);
            this.tabPage3.Controls.Add(this.pbUser);
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(490, 424);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(461, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 30);
            this.button4.TabIndex = 72;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openCameraUser
            // 
            this.openCameraUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openCameraUser.Location = new System.Drawing.Point(300, 193);
            this.openCameraUser.Name = "openCameraUser";
            this.openCameraUser.Size = new System.Drawing.Size(158, 30);
            this.openCameraUser.TabIndex = 29;
            this.openCameraUser.Text = "...";
            this.openCameraUser.UseVisualStyleBackColor = true;
            this.openCameraUser.Click += new System.EventHandler(this.openCameraUser_Click);
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.Color.LightGray;
            this.pbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUser.Image = global::AppSystem.Properties.Resources.AnonymousPic;
            this.pbUser.Location = new System.Drawing.Point(300, 20);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(189, 169);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 28;
            this.pbUser.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabel1.Location = new System.Drawing.Point(174, 349);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 20);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Scan finger print";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_fname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_MName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Lname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.lbl_invalid);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_repeatPassword);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbo_level);
            this.panel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 297);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(3, 16);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(288, 20);
            this.txt_fname.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle Name:";
            // 
            // txt_MName
            // 
            this.txt_MName.Location = new System.Drawing.Point(3, 55);
            this.txt_MName.Name = "txt_MName";
            this.txt_MName.Size = new System.Drawing.Size(288, 20);
            this.txt_MName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // txt_Lname
            // 
            this.txt_Lname.Location = new System.Drawing.Point(3, 94);
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.Size = new System.Drawing.Size(288, 20);
            this.txt_Lname.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email/Username";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(3, 133);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(207, 20);
            this.txt_username.TabIndex = 13;
            this.txt_username.Validating += new System.ComponentModel.CancelEventHandler(this.txt_username_Validating);
            // 
            // lbl_invalid
            // 
            this.lbl_invalid.AutoSize = true;
            this.lbl_invalid.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_invalid.Location = new System.Drawing.Point(3, 156);
            this.lbl_invalid.Name = "lbl_invalid";
            this.lbl_invalid.Size = new System.Drawing.Size(65, 13);
            this.lbl_invalid.TabIndex = 27;
            this.lbl_invalid.Text = "Invalid email";
            this.lbl_invalid.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txt_password);
            this.flowLayoutPanel1.Controls.Add(this.cb_show_pwd);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 185);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(293, 28);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(3, 3);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(204, 20);
            this.txt_password.TabIndex = 14;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.Validating += new System.ComponentModel.CancelEventHandler(this.txt_password_Validating);
            // 
            // cb_show_pwd
            // 
            this.cb_show_pwd.Location = new System.Drawing.Point(213, 3);
            this.cb_show_pwd.Name = "cb_show_pwd";
            this.cb_show_pwd.Size = new System.Drawing.Size(56, 24);
            this.cb_show_pwd.TabIndex = 15;
            this.cb_show_pwd.Text = "Show";
            this.cb_show_pwd.UseVisualStyleBackColor = true;
            this.cb_show_pwd.Visible = false;
            this.cb_show_pwd.CheckedChanged += new System.EventHandler(this.cb_show_pwd_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(3, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Minimum password lenght of 6";
            this.label7.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Repeat Password";
            // 
            // txt_repeatPassword
            // 
            this.txt_repeatPassword.Location = new System.Drawing.Point(3, 245);
            this.txt_repeatPassword.Name = "txt_repeatPassword";
            this.txt_repeatPassword.Size = new System.Drawing.Size(207, 20);
            this.txt_repeatPassword.TabIndex = 15;
            this.txt_repeatPassword.UseSystemPasswordChar = true;
            this.txt_repeatPassword.TextChanged += new System.EventHandler(this.txt_repeatPassword_TextChanged);
            this.txt_repeatPassword.Enter += new System.EventHandler(this.txt_repeatPassword_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(3, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Password not match";
            this.label8.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "User Level";
            // 
            // cbo_level
            // 
            this.cbo_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_level.FormattingEnabled = true;
            this.cbo_level.Location = new System.Drawing.Point(302, 3);
            this.cbo_level.Name = "cbo_level";
            this.cbo_level.Size = new System.Drawing.Size(239, 21);
            this.cbo_level.TabIndex = 16;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.cmdFingerPrint);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.openCameraStudent);
            this.tabPage4.Controls.Add(this.pbStudent);
            this.tabPage4.Controls.Add(this.flowLayoutPanel2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(490, 450);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_TimeOUT);
            this.groupBox1.Controls.Add(this.dt_TimeIN);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(299, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 69);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule";
            // 
            // dt_TimeOUT
            // 
            this.dt_TimeOUT.CustomFormat = "hh:mm tt";
            this.dt_TimeOUT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_TimeOUT.Location = new System.Drawing.Point(109, 38);
            this.dt_TimeOUT.Name = "dt_TimeOUT";
            this.dt_TimeOUT.Size = new System.Drawing.Size(75, 20);
            this.dt_TimeOUT.TabIndex = 77;
            // 
            // dt_TimeIN
            // 
            this.dt_TimeIN.CustomFormat = "hh:mm tt";
            this.dt_TimeIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_TimeIN.Location = new System.Drawing.Point(11, 38);
            this.dt_TimeIN.Name = "dt_TimeIN";
            this.dt_TimeIN.Size = new System.Drawing.Size(75, 20);
            this.dt_TimeIN.TabIndex = 76;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(107, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "Time-OUT";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(9, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Time-IN";
            // 
            // cmdFingerPrint
            // 
            this.cmdFingerPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdFingerPrint.ForeColor = System.Drawing.Color.Blue;
            this.cmdFingerPrint.Location = new System.Drawing.Point(303, 341);
            this.cmdFingerPrint.Name = "cmdFingerPrint";
            this.cmdFingerPrint.Size = new System.Drawing.Size(180, 67);
            this.cmdFingerPrint.TabIndex = 74;
            this.cmdFingerPrint.Text = "Finger Print";
            this.cmdFingerPrint.UseVisualStyleBackColor = true;
            this.cmdFingerPrint.Click += new System.EventHandler(this.cmdFingerPrint_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 30);
            this.button1.TabIndex = 73;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openCameraStudent
            // 
            this.openCameraStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openCameraStudent.Location = new System.Drawing.Point(299, 194);
            this.openCameraStudent.Name = "openCameraStudent";
            this.openCameraStudent.Size = new System.Drawing.Size(159, 29);
            this.openCameraStudent.TabIndex = 31;
            this.openCameraStudent.Text = "...";
            this.openCameraStudent.UseVisualStyleBackColor = true;
            this.openCameraStudent.Click += new System.EventHandler(this.openCameraStudent_Click);
            // 
            // pbStudent
            // 
            this.pbStudent.BackColor = System.Drawing.Color.LightGray;
            this.pbStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStudent.Image = global::AppSystem.Properties.Resources.AnonymousPic;
            this.pbStudent.Location = new System.Drawing.Point(299, 22);
            this.pbStudent.Name = "pbStudent";
            this.pbStudent.Size = new System.Drawing.Size(189, 169);
            this.pbStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStudent.TabIndex = 30;
            this.pbStudent.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label9);
            this.flowLayoutPanel2.Controls.Add(this.FirstNameStudent);
            this.flowLayoutPanel2.Controls.Add(this.label11);
            this.flowLayoutPanel2.Controls.Add(this.MiddleNameStudent);
            this.flowLayoutPanel2.Controls.Add(this.label12);
            this.flowLayoutPanel2.Controls.Add(this.LastNameStudent);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Controls.Add(this.LRNStudent);
            this.flowLayoutPanel2.Controls.Add(this.label15);
            this.flowLayoutPanel2.Controls.Add(this.cboGrade);
            this.flowLayoutPanel2.Controls.Add(this.labelStrand);
            this.flowLayoutPanel2.Controls.Add(this.txtStrand);
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Controls.Add(this.cboSection);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.label17);
            this.flowLayoutPanel2.Controls.Add(this.txtRfidId);
            this.flowLayoutPanel2.Controls.Add(this.label23);
            this.flowLayoutPanel2.Controls.Add(this.txtAdviser);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(296, 445);
            this.flowLayoutPanel2.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "First Name";
            // 
            // FirstNameStudent
            // 
            this.FirstNameStudent.Location = new System.Drawing.Point(3, 16);
            this.FirstNameStudent.Name = "FirstNameStudent";
            this.FirstNameStudent.Size = new System.Drawing.Size(291, 20);
            this.FirstNameStudent.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Middle Name:";
            // 
            // MiddleNameStudent
            // 
            this.MiddleNameStudent.Location = new System.Drawing.Point(3, 55);
            this.MiddleNameStudent.Name = "MiddleNameStudent";
            this.MiddleNameStudent.Size = new System.Drawing.Size(291, 20);
            this.MiddleNameStudent.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Last Name";
            // 
            // LastNameStudent
            // 
            this.LastNameStudent.Location = new System.Drawing.Point(3, 94);
            this.LastNameStudent.Name = "LastNameStudent";
            this.LastNameStudent.Size = new System.Drawing.Size(291, 20);
            this.LastNameStudent.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSy);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.dtBirthDate);
            this.panel2.Location = new System.Drawing.Point(3, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 40);
            this.panel2.TabIndex = 27;
            // 
            // txtSy
            // 
            this.txtSy.Location = new System.Drawing.Point(173, 17);
            this.txtSy.Name = "txtSy";
            this.txtSy.Size = new System.Drawing.Size(116, 20);
            this.txtSy.TabIndex = 26;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(170, 1);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "School Year";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Birth Date";
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.CustomFormat = "MM/dd/yyyy";
            this.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirthDate.Location = new System.Drawing.Point(4, 17);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(121, 20);
            this.dtBirthDate.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "LRN";
            // 
            // LRNStudent
            // 
            this.LRNStudent.Location = new System.Drawing.Point(3, 179);
            this.LRNStudent.Name = "LRNStudent";
            this.LRNStudent.Size = new System.Drawing.Size(291, 20);
            this.LRNStudent.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 202);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Grade";
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(3, 218);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(291, 21);
            this.cboGrade.TabIndex = 16;
            this.cboGrade.SelectedIndexChanged += new System.EventHandler(this.cboGrade_SelectedIndexChanged);
            // 
            // labelStrand
            // 
            this.labelStrand.AutoSize = true;
            this.labelStrand.Location = new System.Drawing.Point(3, 242);
            this.labelStrand.Name = "labelStrand";
            this.labelStrand.Size = new System.Drawing.Size(38, 13);
            this.labelStrand.TabIndex = 25;
            this.labelStrand.Text = "Strand";
            this.labelStrand.Visible = false;
            // 
            // txtStrand
            // 
            this.txtStrand.Location = new System.Drawing.Point(3, 258);
            this.txtStrand.Name = "txtStrand";
            this.txtStrand.Size = new System.Drawing.Size(293, 20);
            this.txtStrand.TabIndex = 26;
            this.txtStrand.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 281);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Section";
            // 
            // cboSection
            // 
            this.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSection.FormattingEnabled = true;
            this.cboSection.Location = new System.Drawing.Point(3, 297);
            this.cboSection.Name = "cboSection";
            this.cboSection.Size = new System.Drawing.Size(291, 21);
            this.cboSection.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtGuardiansName);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.PhoneNumberStudent);
            this.panel3.Location = new System.Drawing.Point(3, 324);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 40);
            this.panel3.TabIndex = 74;
            // 
            // txtGuardiansName
            // 
            this.txtGuardiansName.Location = new System.Drawing.Point(4, 17);
            this.txtGuardiansName.Name = "txtGuardiansName";
            this.txtGuardiansName.Size = new System.Drawing.Size(198, 20);
            this.txtGuardiansName.TabIndex = 74;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(205, 1);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Phone No.";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 1);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "Guardian\'s Name";
            // 
            // PhoneNumberStudent
            // 
            this.PhoneNumberStudent.Location = new System.Drawing.Point(208, 17);
            this.PhoneNumberStudent.Mask = "####-###-####";
            this.PhoneNumberStudent.Name = "PhoneNumberStudent";
            this.PhoneNumberStudent.Size = new System.Drawing.Size(83, 20);
            this.PhoneNumberStudent.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 367);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "RFID UID";
            // 
            // txtRfidId
            // 
            this.txtRfidId.Location = new System.Drawing.Point(3, 383);
            this.txtRfidId.Name = "txtRfidId";
            this.txtRfidId.Size = new System.Drawing.Size(291, 20);
            this.txtRfidId.TabIndex = 22;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 406);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 13);
            this.label23.TabIndex = 75;
            this.label23.Text = "Adviser";
            // 
            // txtAdviser
            // 
            this.txtAdviser.Location = new System.Drawing.Point(3, 422);
            this.txtAdviser.Name = "txtAdviser";
            this.txtAdviser.Size = new System.Drawing.Size(291, 20);
            this.txtAdviser.TabIndex = 76;
            // 
            // frm_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 547);
            this.Controls.Add(this.rbStudent);
            this.Controls.Add(this.rbUser);
            this.Controls.Add(this.wizard1);
            this.Controls.Add(this.cmd_cancel);
            this.Controls.Add(this.cmd_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_user";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCOUNT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_user_FormClosed);
            this.Load += new System.EventHandler(this.frm_user_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_user_KeyDown);
            this.wizard1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.TextBox txt_password;
        public System.Windows.Forms.CheckBox cb_show_pwd;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_fname;
        public System.Windows.Forms.TextBox txt_MName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_Lname;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txt_repeatPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbo_level;
        private System.Windows.Forms.Button cmd_cancel;
        public System.Windows.Forms.Button cmd_save;
        private System.Windows.Forms.Label lbl_invalid;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox FirstNameStudent;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox MiddleNameStudent;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox LastNameStudent;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox LRNStudent;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox cboSection;
        private System.Windows.Forms.MaskedTextBox PhoneNumberStudent;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtRfidId;
        public System.Windows.Forms.Button openCameraUser;
        public System.Windows.Forms.Button openCameraStudent;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.RadioButton rbUser;
        public System.Windows.Forms.RadioButton rbStudent;
        public System.Windows.Forms.PictureBox pbUser;
        public System.Windows.Forms.PictureBox pbStudent;
        public wizard wizard1;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.Label labelStrand;
        private System.Windows.Forms.TextBox txtStrand;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSy;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtGuardiansName;
        private System.Windows.Forms.Button cmdFingerPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dt_TimeOUT;
        private System.Windows.Forms.DateTimePicker dt_TimeIN;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.TextBox txtAdviser;
    }
}