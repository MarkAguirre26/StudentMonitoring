using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSystem
{
    public partial class FrmRequest : Form
    {
        DataClasses1DataContext db;
        private string status;
        public FrmRequest()
        {
            InitializeComponent();
            db = new DataClasses1DataContext(Tool.ConnectionString);
        }

        private void FrmRequest_Load(object sender, EventArgs e)
        {

            //TableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Absolute;
            //TableLayoutPanel1.ColumnStyles[1].Width = 0;

            hideTablePanelRow(true);

            getRequest();
        }

        void hideTablePanelRow(bool isTrue)
        {
            if (isTrue)
            {
                tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Percent;
                tableLayoutPanel1.RowStyles[0].Height = 100;
                tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Percent;
                tableLayoutPanel1.RowStyles[1].Height = 0;
                tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Percent;
                tableLayoutPanel1.RowStyles[2].Height = 0;
            }
            else
            {
                tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Percent;
                tableLayoutPanel1.RowStyles[0].Height = 55;
                tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Percent;
                tableLayoutPanel1.RowStyles[1].Height = 28;
                tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Percent;
                tableLayoutPanel1.RowStyles[2].Height = 18;
            }
        }

        void getRequest()
        {
            var list = db.getRequest().ToList();
            dg_DTR.Refresh();
            dg_DTR.DataSource = list;
        }

        public void pendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            status = "Pending";
            hideTablePanelRow(false);
        }

        public void update(string action,string note = "")
        {
            string RecID = dg_DTR.SelectedRows[0].Cells[0].Value.ToString();
            db.ExecuteCommand("UPDATE Request SET Approve={0},Note={1} WHERE (RecID={2})", action,note, RecID);
        }

        public void approveToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

            status = "Approved";
            hideTablePanelRow(false);
        }

        public void deniedToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

            status = "Denied";
            hideTablePanelRow(false);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
          
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            update(status, txtNote.Text);
            getRequest();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNote.Text = "";
            hideTablePanelRow(true);
        }
    }
}
