namespace AppSystem
{
    partial class frm_BrgyClearance
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
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmd_cancel = new System.Windows.Forms.Button();
            this.cmd_save = new System.Windows.Forms.Button();
            this.cmd_print = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_purpose = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_certNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_or = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rdleft = new System.Windows.Forms.RadioButton();
            this.rdright = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pic_left = new System.Windows.Forms.PictureBox();
            this.pic_Right = new System.Windows.Forms.PictureBox();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(6, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 21);
            this.label14.TabIndex = 46;
            this.label14.Text = "Brgy Clearance Details";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(-66, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(511, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_cancel.Location = new System.Drawing.Point(249, 381);
            this.cmd_cancel.Name = "cmd_cancel";
            this.cmd_cancel.Size = new System.Drawing.Size(75, 30);
            this.cmd_cancel.TabIndex = 50;
            this.cmd_cancel.Text = "&Close";
            this.cmd_cancel.UseVisualStyleBackColor = true;
            this.cmd_cancel.Click += new System.EventHandler(this.cmd_cancel_Click);
            // 
            // cmd_save
            // 
            this.cmd_save.Location = new System.Drawing.Point(168, 381);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(75, 30);
            this.cmd_save.TabIndex = 48;
            this.cmd_save.Text = "&Save";
            this.cmd_save.UseVisualStyleBackColor = true;
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // cmd_print
            // 
            this.cmd_print.Enabled = false;
            this.cmd_print.Location = new System.Drawing.Point(87, 381);
            this.cmd_print.Name = "cmd_print";
            this.cmd_print.Size = new System.Drawing.Size(75, 30);
            this.cmd_print.TabIndex = 47;
            this.cmd_print.Text = "Print";
            this.cmd_print.UseVisualStyleBackColor = true;
            this.cmd_print.Click += new System.EventHandler(this.cmd_print_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(91, 38);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(315, 20);
            this.txt_name.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Name:";
            // 
            // txt_purpose
            // 
            this.txt_purpose.Location = new System.Drawing.Point(91, 64);
            this.txt_purpose.Name = "txt_purpose";
            this.txt_purpose.Size = new System.Drawing.Size(315, 20);
            this.txt_purpose.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Purpose:";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(91, 90);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(315, 52);
            this.txt_address.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Address:";
            // 
            // txt_certNo
            // 
            this.txt_certNo.Location = new System.Drawing.Point(91, 148);
            this.txt_certNo.Multiline = true;
            this.txt_certNo.Name = "txt_certNo";
            this.txt_certNo.Size = new System.Drawing.Size(112, 21);
            this.txt_certNo.TabIndex = 58;
            this.txt_certNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_certNo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Cert. No.";
            // 
            // txt_or
            // 
            this.txt_or.Location = new System.Drawing.Point(91, 175);
            this.txt_or.Multiline = true;
            this.txt_or.Name = "txt_or";
            this.txt_or.Size = new System.Drawing.Size(112, 21);
            this.txt_or.TabIndex = 60;
            this.txt_or.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_or_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "OR. No.:";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(294, 148);
            this.txt_amount.Multiline = true;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(112, 21);
            this.txt_amount.TabIndex = 62;
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Amount:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "Capture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdleft
            // 
            this.rdleft.AutoSize = true;
            this.rdleft.Checked = true;
            this.rdleft.Location = new System.Drawing.Point(216, 332);
            this.rdleft.Name = "rdleft";
            this.rdleft.Size = new System.Drawing.Size(43, 17);
            this.rdleft.TabIndex = 69;
            this.rdleft.TabStop = true;
            this.rdleft.Text = "Left";
            this.rdleft.UseVisualStyleBackColor = true;
            // 
            // rdright
            // 
            this.rdright.AutoSize = true;
            this.rdright.Location = new System.Drawing.Point(326, 331);
            this.rdright.Name = "rdright";
            this.rdright.Size = new System.Drawing.Size(50, 17);
            this.rdright.TabIndex = 70;
            this.rdright.TabStop = true;
            this.rdright.Text = "Right";
            this.rdright.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 443);
            this.tabControl1.TabIndex = 72;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.rdright);
            this.tabPage1.Controls.Add(this.cmd_print);
            this.tabPage1.Controls.Add(this.rdleft);
            this.tabPage1.Controls.Add(this.cmd_save);
            this.tabPage1.Controls.Add(this.cmd_cancel);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pic_left);
            this.tabPage1.Controls.Add(this.txt_name);
            this.tabPage1.Controls.Add(this.pic_Right);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.picPhoto);
            this.tabPage1.Controls.Add(this.txt_purpose);
            this.tabPage1.Controls.Add(this.txt_amount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_address);
            this.tabPage1.Controls.Add(this.txt_or);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_certNo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(427, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pic_left
            // 
            this.pic_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_left.Location = new System.Drawing.Point(176, 210);
            this.pic_left.Name = "pic_left";
            this.pic_left.Size = new System.Drawing.Size(112, 112);
            this.pic_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_left.TabIndex = 65;
            this.pic_left.TabStop = false;
            // 
            // pic_Right
            // 
            this.pic_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Right.Location = new System.Drawing.Point(294, 210);
            this.pic_Right.Name = "pic_Right";
            this.pic_Right.Size = new System.Drawing.Size(112, 112);
            this.pic_Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Right.TabIndex = 64;
            this.pic_Right.TabStop = false;
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(25, 215);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(112, 112);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 63;
            this.picPhoto.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 71;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frm_BrgyClearance
            // 
            this.AcceptButton = this.cmd_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmd_cancel;
            this.ClientSize = new System.Drawing.Size(435, 443);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(451, 482);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(451, 482);
            this.Name = "frm_BrgyClearance";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brgy. Clearance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_BrgyClearance_FormClosed);
            this.Load += new System.EventHandler(this.frm_BrgyClearance_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmd_cancel;
        public System.Windows.Forms.Button cmd_save;
        public System.Windows.Forms.Button cmd_print;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_purpose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_certNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_or;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pic_Right;
        private System.Windows.Forms.PictureBox pic_left;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdleft;
        private System.Windows.Forms.RadioButton rdright;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.PictureBox picPhoto;
        public System.Windows.Forms.Button button4;
    }
}