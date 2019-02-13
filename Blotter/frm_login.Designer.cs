namespace AppSystem
{
    partial class frm_login
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
            this.lnk_forgotPassword = new System.Windows.Forms.LinkLabel();
            this.cmd_cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmd_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnk_forgotPassword
            // 
            this.lnk_forgotPassword.AutoSize = true;
            this.lnk_forgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnk_forgotPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_forgotPassword.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.lnk_forgotPassword.Location = new System.Drawing.Point(455, 165);
            this.lnk_forgotPassword.Name = "lnk_forgotPassword";
            this.lnk_forgotPassword.Size = new System.Drawing.Size(107, 17);
            this.lnk_forgotPassword.TabIndex = 30;
            this.lnk_forgotPassword.TabStop = true;
            this.lnk_forgotPassword.Text = "Forgot Password";
            this.lnk_forgotPassword.Visible = false;
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_cancel.Location = new System.Drawing.Point(289, 210);
            this.cmd_cancel.Name = "cmd_cancel";
            this.cmd_cancel.Size = new System.Drawing.Size(102, 24);
            this.cmd_cancel.TabIndex = 29;
            this.cmd_cancel.Text = "Cancel";
            this.cmd_cancel.UseVisualStyleBackColor = true;
            this.cmd_cancel.Click += new System.EventHandler(this.cmd_cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(161, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Welcome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "-";
            // 
            // cmd_login
            // 
            this.cmd_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_login.Location = new System.Drawing.Point(138, 210);
            this.cmd_login.Name = "cmd_login";
            this.cmd_login.Size = new System.Drawing.Size(145, 24);
            this.cmd_login.TabIndex = 25;
            this.cmd_login.Text = "Login";
            this.cmd_login.UseVisualStyleBackColor = true;
            this.cmd_login.Click += new System.EventHandler(this.cmd_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(219, 139);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(207, 23);
            this.txt_password.TabIndex = 24;
            this.txt_password.Text = "Sommerson26";
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(219, 108);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(207, 23);
            this.txt_username.TabIndex = 23;
            this.txt_username.Text = "markaguirre26@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(139, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(135, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppSystem.Properties.Resources.lock1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(176, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Note: You can use fingerprint scanner to login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_login
            // 
            this.AcceptButton = this.cmd_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppSystem.Properties.Resources.h1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.cmd_cancel;
            this.ClientSize = new System.Drawing.Size(437, 249);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lnk_forgotPassword);
            this.Controls.Add(this.cmd_cancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmd_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_login_FormClosed);
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnk_forgotPassword;
        private System.Windows.Forms.Button cmd_cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmd_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}