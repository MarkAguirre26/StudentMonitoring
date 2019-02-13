namespace AppSystem
{
    partial class FrmDTR
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNotification = new System.Windows.Forms.Label();
            this.lblUseFingerprint = new System.Windows.Forms.Label();
            this.lblGradeSection = new System.Windows.Forms.Label();
            this.lblLrn = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtRfidScan = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.dg_DTR = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.03432F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.96568F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 587F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1049, 587);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelNotification);
            this.panel1.Controls.Add(this.lblUseFingerprint);
            this.panel1.Controls.Add(this.lblGradeSection);
            this.panel1.Controls.Add(this.lblLrn);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.pb);
            this.panel1.Controls.Add(this.txtRfidScan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(381, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 581);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(58, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "524cb135";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Get";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNotification
            // 
            this.labelNotification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotification.ForeColor = System.Drawing.Color.Maroon;
            this.labelNotification.Location = new System.Drawing.Point(0, 509);
            this.labelNotification.Name = "labelNotification";
            this.labelNotification.Size = new System.Drawing.Size(665, 72);
            this.labelNotification.TabIndex = 13;
            this.labelNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUseFingerprint
            // 
            this.lblUseFingerprint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUseFingerprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lblUseFingerprint.ForeColor = System.Drawing.Color.Indigo;
            this.lblUseFingerprint.Location = new System.Drawing.Point(3, 420);
            this.lblUseFingerprint.Name = "lblUseFingerprint";
            this.lblUseFingerprint.Size = new System.Drawing.Size(656, 65);
            this.lblUseFingerprint.TabIndex = 12;
            this.lblUseFingerprint.Text = "use fingerprint scanner to confirm.";
            this.lblUseFingerprint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUseFingerprint.Visible = false;
            this.lblUseFingerprint.Click += new System.EventHandler(this.lblUseFingerprint_Click);
            // 
            // lblGradeSection
            // 
            this.lblGradeSection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGradeSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeSection.Location = new System.Drawing.Point(18, 379);
            this.lblGradeSection.Name = "lblGradeSection";
            this.lblGradeSection.Size = new System.Drawing.Size(641, 36);
            this.lblGradeSection.TabIndex = 7;
            this.lblGradeSection.Text = "-";
            this.lblGradeSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLrn
            // 
            this.lblLrn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLrn.Location = new System.Drawing.Point(18, 343);
            this.lblLrn.Name = "lblLrn";
            this.lblLrn.Size = new System.Drawing.Size(641, 36);
            this.lblLrn.TabIndex = 6;
            this.lblLrn.Text = "-";
            this.lblLrn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(18, 307);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(641, 36);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "-";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtRfidScan
            // 
            this.txtRfidScan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRfidScan.Location = new System.Drawing.Point(283, 101);
            this.txtRfidScan.Name = "txtRfidScan";
            this.txtRfidScan.Size = new System.Drawing.Size(42, 20);
            this.txtRfidScan.TabIndex = 11;
            this.txtRfidScan.TextChanged += new System.EventHandler(this.txtRfidScan_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.dg_DTR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 581);
            this.panel2.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTime.Location = new System.Drawing.Point(0, 509);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(372, 72);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "08:00 AM";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // dg_DTR
            // 
            this.dg_DTR.AllowUserToAddRows = false;
            this.dg_DTR.AllowUserToDeleteRows = false;
            this.dg_DTR.AllowUserToResizeColumns = false;
            this.dg_DTR.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dg_DTR.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_DTR.BackgroundColor = System.Drawing.Color.White;
            this.dg_DTR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_DTR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_DTR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_DTR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column7,
            this.Column4,
            this.Column6});
            this.dg_DTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_DTR.Location = new System.Drawing.Point(0, 0);
            this.dg_DTR.Name = "dg_DTR";
            this.dg_DTR.ReadOnly = true;
            this.dg_DTR.RowHeadersVisible = false;
            this.dg_DTR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_DTR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_DTR.Size = new System.Drawing.Size(372, 581);
            this.dg_DTR.TabIndex = 4;
            this.dg_DTR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_DTR_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RecID";
            this.Column1.HeaderText = "RecID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "AccountName";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "TimeIN";
            this.Column3.HeaderText = "TIME-IN";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 72;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.DataPropertyName = "TimeOUT";
            this.Column5.HeaderText = "TIME-OUT";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 84;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Total";
            this.Column7.HeaderText = "TOTAL";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "RowRemark";
            this.Column4.HeaderText = "REMARK";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DateCreated";
            this.Column6.HeaderText = "DATE";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pb
            // 
            this.pb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb.Image = global::AppSystem.Properties.Resources.AnonymousPic;
            this.pb.Location = new System.Drawing.Point(248, 80);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(202, 205);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb.TabIndex = 4;
            this.pb.TabStop = false;
            // 
            // FrmDTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 587);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1065, 626);
            this.Name = "FrmDTR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Time Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDTR_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDTR_FormClosed);
            this.Load += new System.EventHandler(this.FrmDTR_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_DTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        //private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGradeSection;
        private System.Windows.Forms.Label lblLrn;
        public System.Windows.Forms.DataGridView dg_DTR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtRfidScan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblUseFingerprint;
        private System.Windows.Forms.Label labelNotification;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button3;
    }
}