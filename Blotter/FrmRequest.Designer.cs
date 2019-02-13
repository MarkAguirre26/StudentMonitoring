namespace AppSystem
{
    partial class FrmRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_DTR = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deniedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DTR)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_DTR
            // 
            this.dg_DTR.AllowUserToAddRows = false;
            this.dg_DTR.AllowUserToDeleteRows = false;
            this.dg_DTR.AllowUserToResizeColumns = false;
            this.dg_DTR.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dg_DTR.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_DTR.BackgroundColor = System.Drawing.Color.White;
            this.dg_DTR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_DTR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_DTR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_DTR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column8});
            this.dg_DTR.ContextMenuStrip = this.contextMenuStrip1;
            this.dg_DTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_DTR.Location = new System.Drawing.Point(3, 3);
            this.dg_DTR.Name = "dg_DTR";
            this.dg_DTR.ReadOnly = true;
            this.dg_DTR.RowHeadersVisible = false;
            this.dg_DTR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_DTR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_DTR.Size = new System.Drawing.Size(681, 163);
            this.dg_DTR.TabIndex = 4;
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
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "For";
            this.Column3.HeaderText = "DESCRIPTION";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 105;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.DataPropertyName = "DateCreated";
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 55;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Approve";
            this.Column8.HeaderText = "STATUS";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendingToolStripMenuItem,
            this.approveToolStripMenuItem,
            this.deniedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 70);
            // 
            // pendingToolStripMenuItem
            // 
            this.pendingToolStripMenuItem.Name = "pendingToolStripMenuItem";
            this.pendingToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.pendingToolStripMenuItem.Text = "Pending";
            this.pendingToolStripMenuItem.Click += new System.EventHandler(this.pendingToolStripMenuItem_Click);
            // 
            // approveToolStripMenuItem
            // 
            this.approveToolStripMenuItem.Name = "approveToolStripMenuItem";
            this.approveToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.approveToolStripMenuItem.Text = "Approve";
            this.approveToolStripMenuItem.Click += new System.EventHandler(this.approveToolStripMenuItem_Click);
            // 
            // deniedToolStripMenuItem
            // 
            this.deniedToolStripMenuItem.Name = "deniedToolStripMenuItem";
            this.deniedToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.deniedToolStripMenuItem.Text = "Denied";
            this.deniedToolStripMenuItem.Click += new System.EventHandler(this.deniedToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dg_DTR, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNote, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.83871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.06452F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.41936F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 310);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(3, 172);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(681, 80);
            this.txtNote.TabIndex = 5;
            this.txtNote.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 49);
            this.panel1.TabIndex = 6;
            // 
            // cmdSave
            // 
            this.cmdSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdSave.Location = new System.Drawing.Point(119, 3);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(222, 43);
            this.cmdSave.TabIndex = 0;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(347, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(222, 43);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmRequest
            // 
            this.AcceptButton = this.cmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(687, 310);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRequest";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request for Approval";
            this.Load += new System.EventHandler(this.FrmRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_DTR)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dg_DTR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deniedToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button btnCancel;
    }
}