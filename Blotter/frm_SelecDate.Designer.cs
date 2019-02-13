namespace AppSystem
{
    partial class frm_SelecDate
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
            this.cmd_ok = new System.Windows.Forms.Button();
            this.cmd_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmd_ok
            // 
            this.cmd_ok.Location = new System.Drawing.Point(30, 69);
            this.cmd_ok.Name = "cmd_ok";
            this.cmd_ok.Size = new System.Drawing.Size(75, 23);
            this.cmd_ok.TabIndex = 1;
            this.cmd_ok.Text = "Ok";
            this.cmd_ok.UseVisualStyleBackColor = true;
            this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_cancel.Location = new System.Drawing.Point(109, 69);
            this.cmd_cancel.Name = "cmd_cancel";
            this.cmd_cancel.Size = new System.Drawing.Size(75, 23);
            this.cmd_cancel.TabIndex = 2;
            this.cmd_cancel.Text = "Cance";
            this.cmd_cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // frm_SelecDate
            // 
            this.AcceptButton = this.cmd_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmd_cancel;
            this.ClientSize = new System.Drawing.Size(220, 107);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_cancel);
            this.Controls.Add(this.cmd_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_SelecDate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_ok;
        private System.Windows.Forms.Button cmd_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}