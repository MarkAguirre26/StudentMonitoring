namespace AppSystem
{
    partial class frm_fingerPrint
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
            this.pic_left = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_save = new System.Windows.Forms.Button();
            this.cmd_cancel = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_left)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_left
            // 
            this.pic_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_left.Image = global::AppSystem.Properties.Resources.w;
            this.pic_left.Location = new System.Drawing.Point(14, 13);
            this.pic_left.Name = "pic_left";
            this.pic_left.Size = new System.Drawing.Size(135, 135);
            this.pic_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_left.TabIndex = 2;
            this.pic_left.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(11, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "_________________________________________________________________________________" +
    "__";
            // 
            // cmd_save
            // 
            this.cmd_save.Location = new System.Drawing.Point(70, 195);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(75, 30);
            this.cmd_save.TabIndex = 5;
            this.cmd_save.Text = "&Save";
            this.cmd_save.UseVisualStyleBackColor = true;
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_cancel.Location = new System.Drawing.Point(151, 195);
            this.cmd_cancel.Name = "cmd_cancel";
            this.cmd_cancel.Size = new System.Drawing.Size(75, 30);
            this.cmd_cancel.TabIndex = 6;
            this.cmd_cancel.Text = "&Cancel";
            this.cmd_cancel.UseVisualStyleBackColor = true;
            this.cmd_cancel.Click += new System.EventHandler(this.cmd_cancel_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(155, 12);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(352, 136);
            this.txtStatus.TabIndex = 7;
            // 
            // frm_fingerPrint
            // 
            this.AcceptButton = this.cmd_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmd_cancel;
            this.ClientSize = new System.Drawing.Size(519, 233);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.cmd_cancel);
            this.Controls.Add(this.cmd_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_fingerPrint";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finger print";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_fingerPrint_FormClosed);
            this.Load += new System.EventHandler(this.frm_fingerPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_left)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_save;
        private System.Windows.Forms.Button cmd_cancel;
        private System.Windows.Forms.TextBox txtStatus;
    }
}