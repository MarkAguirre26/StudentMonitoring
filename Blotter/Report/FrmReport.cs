using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSystem.Report
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            getReport();
        }


        void RemoveTab(CrystalReportViewer rpt)
        {

            foreach (Control control in rpt.Controls)
            {
                if (control is PageView)
                {
                    TabControl tab = (TabControl)((PageView)control).Controls[0];
                    tab.ItemSize = new Size(0, 1);
                    tab.SizeMode = TabSizeMode.Fixed;
                    tab.Appearance = TabAppearance.Buttons;
                }
            }

        }


        void getReport()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Tool.ConnectionString);
            DataTable dt = new DataSet1.DailyTimeRecordSelectAllDataTable();
            DailyTimeRecord crDTR = new DailyTimeRecord();
            var list = db.DailyTimeRecordSelectAll().ToList();
            foreach (var i in list)
            {
                dt.Rows.Add(i.RecID, i.AccountName, i.TimeIN, i.TimeOUT, i.DateCreated, i.Total, i.RowRemark);
            }
            crDTR.SetDataSource(dt);
            viewer1.ReportSource = crDTR;
            RemoveTab(viewer1);
            Cursor.Current = Cursors.Default;
        }
    }
}
