namespace AppSystem
{
    partial class frm_camera
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
            this.cmd_save = new System.Windows.Forms.Button();
            this.cmd_reset = new System.Windows.Forms.Button();
            this.cmd_capture = new System.Windows.Forms.Button();
            this.imgCapture = new System.Windows.Forms.PictureBox();
            this.imgVideo = new Camera_NET.CameraControl();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_save
            // 
            this.cmd_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_save.Enabled = false;
            this.cmd_save.Location = new System.Drawing.Point(147, 184);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(66, 23);
            this.cmd_save.TabIndex = 9;
            this.cmd_save.Text = "&OK";
            this.cmd_save.UseVisualStyleBackColor = true;
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // cmd_reset
            // 
            this.cmd_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_reset.Enabled = false;
            this.cmd_reset.Location = new System.Drawing.Point(81, 184);
            this.cmd_reset.Name = "cmd_reset";
            this.cmd_reset.Size = new System.Drawing.Size(66, 23);
            this.cmd_reset.TabIndex = 8;
            this.cmd_reset.Text = "Reset";
            this.cmd_reset.UseVisualStyleBackColor = true;
            this.cmd_reset.Click += new System.EventHandler(this.cmd_reset_Click);
            // 
            // cmd_capture
            // 
            this.cmd_capture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_capture.Location = new System.Drawing.Point(15, 184);
            this.cmd_capture.Name = "cmd_capture";
            this.cmd_capture.Size = new System.Drawing.Size(66, 23);
            this.cmd_capture.TabIndex = 7;
            this.cmd_capture.Text = "Capture";
            this.cmd_capture.UseVisualStyleBackColor = true;
            this.cmd_capture.Click += new System.EventHandler(this.cmd_capture_Click);
            // 
            // imgCapture
            // 
            this.imgCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCapture.Location = new System.Drawing.Point(8, 9);
            this.imgCapture.Name = "imgCapture";
            this.imgCapture.Size = new System.Drawing.Size(224, 169);
            this.imgCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture.TabIndex = 11;
            this.imgCapture.TabStop = false;
            // 
            // imgVideo
            // 
            this.imgVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgVideo.DirectShowLogFilepath = "";
            this.imgVideo.Location = new System.Drawing.Point(8, 9);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(224, 169);
            this.imgVideo.TabIndex = 10;
            // 
            // frm_camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 218);
            this.Controls.Add(this.cmd_save);
            this.Controls.Add(this.cmd_reset);
            this.Controls.Add(this.cmd_capture);
            this.Controls.Add(this.imgVideo);
            this.Controls.Add(this.imgCapture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_camera";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_camera_FormClosing);
            this.Load += new System.EventHandler(this.frm_camera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_save;
        private System.Windows.Forms.Button cmd_reset;
        private System.Windows.Forms.Button cmd_capture;
        private System.Windows.Forms.PictureBox imgCapture;
        private Camera_NET.CameraControl imgVideo;
    }
}