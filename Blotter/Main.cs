using AppSystem.model;
using AppSystem.Report;
using CrystalDecisions.Windows.Forms;
using Ini;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSystem
{
    public partial class Main : Form
    {
        //private bool p1, p2, p3, p4, p5, p6;
        public bool isLogin;
        public string UserLevel;
        public string UserCn;
        public string fullname;
        public Main()
        {
            InitializeComponent();
        }
        public void buttonSelectection(PictureBox picturebox)
        {
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = false;
            picturebox.Visible = true;

        }
        //
        private void cmd_media_Click(object sender, EventArgs e)
        {
            wizard1.SelectedTab = tabPage1;
            buttonSelectection(pb1);
            //p1 = true; p2 = false; p3 = false; p4 = false; p5 = false;

        }

        private void cmd_violation_menu_Click(object sender, EventArgs e)
        {
            buttonSelectection(pb2); wizard1.SelectedTab = tabPage4;
            //p1 = false; p2 = false; p3 = false; p4 = true; p5 = false; p6 = false;

            if (!backgroundWorker5.IsBusy)
            {
                backgroundWorker5.RunWorkerAsync();
            }
            //
        }


        private void Main_Load(object sender, EventArgs e)
        {
            try
            {



                IniFile ini = new IniFile(Tool.confg);
                Tool.ConnectionString = "Data Source=" + ini.IniReadValue("SERVER", "Server") + ";Initial Catalog=" + ini.IniReadValue("SERVER", "Database") + ";Persist Security Info=True;User ID=" + ini.IniReadValue("SERVER", "UID") + ";Password=" + EncodeString.Decrypt(ini.IniReadValue("SERVER", "Pwd")) + ";";
                if (!File.Exists(Tool.confg))
                {
                    ini.IniWriteValue("SYSTEM", "Name", "Change System name in config.ini");
                    ini.IniWriteValue("LOCATION", "Address", "");

                }


                Tool.Systemname = ini.IniReadValue("SYSTEM", "Name");
                lbl_system_name.Text = Tool.Systemname;
                this.Hide();
                new frm_login(this).ShowDialog();
            }
            catch (Exception)
            {
                new frm_server().ShowDialog();
                throw;
            }
        }
        private void cmd_account_icon_MouseDown(object sender, MouseEventArgs e)
        {
            this.contextMenuStrip1.Show(Cursor.Position.X - 100, Cursor.Position.Y + 10);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            new FrmDTR().Show();
            this.Hide();


        }



        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            using (frm_user f = new frm_user(this))
            {
                f.Tag = UserCn;
                f.getDetails(UserCn);
                f.isEdit = true;
                f.ShowDialog();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
            new frm_login(this).ShowDialog();

        }



        public void getAccounts(string cn)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Tool.ConnectionString);
            var list = db.sp_AccountSELECT(cn).ToList();
            dg_user.Rows.Clear();
            foreach (var i in list)
            {
                dg_user.Rows.Add(i.cn, i.fullname,i.Adviser,i.Grade,i.Section, i.Username, i.Rank, i.Level_cn,i.Schedule);
            }
            items.Text = "Items: " + dg_user.Rows.Count.ToString();

        }
        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            DailyTimeRecordSELECT();
        }

        private void txt_search_blotter_Click(object sender, EventArgs e)
        {


        }

        private void txt_search_blotter_TextChanged(object sender, EventArgs e)
        {
            DailyTimeRecordSELECT(txt_search_blotter.Text);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            txt_search_blotter.Clear();
        }




        private void dg_blotter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 || e.ColumnIndex != -1)
            {
                //# Do couble click function 
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(Tool.confg);

        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (isLogin)
            {
                DataClasses1DataContext db = new DataClasses1DataContext(Tool.ConnectionString);
                db.sp_insertLog__("Logout", fullname, "Logout");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmd_searchLog_Click(object sender, EventArgs e)
        {



            DataClasses1DataContext db = new DataClasses1DataContext(Tool.ConnectionString);
            dg_logs.Rows.Clear();
            if (dateTimePicker1.Value.ToShortDateString() == dateTimePicker2.Value.ToShortDateString())
            {
                //MessageBox.Show("True");
                var list = db.sp_selectLogs(dateTimePicker1.Value.AddDays(-1), dateTimePicker2.Value);
                // dg_logs.Rows.Clear();
                foreach (var i in list)
                {
                    dg_logs.Rows.Add(i.cn, i.ActionName, i.ByName, i.Modules, i.Date.Value);
                }
            }
            else
            {
                //    MessageBox.Show("False");
                var list = db.sp_selectLogs(dateTimePicker1.Value, dateTimePicker2.Value);
                //  dg_logs.Rows.Clear();
                foreach (var i in list)
                {
                    dg_logs.Rows.Add(i.cn, i.ActionName, i.ByName, i.Modules, i.Date.Value);
                }
            }


            lbl_logs_count.Text = "Items: " + dg_logs.Rows.Count.ToString();


        }

        private void txt_userSearch_TextChanged(object sender, EventArgs e)
        {
            if (txt_userSearch.Text.Length <= 0)
            {
                getAccounts("%");
            }
            else
            {
                getAccounts(txt_userSearch.Text);
            }
        }

        private void cmd_clear_Click(object sender, EventArgs e)
        {
            txt_userSearch.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new frm_user(this).ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (dg_user.SelectedRows.Count >= 1)
            {
                using (frm_user f = new frm_user(this))
                {
                    f.cmd_save.Text = "Save";
                    f.Tag = dg_user.SelectedRows[0].Cells[0].Value.ToString();
                    f.cb_show_pwd.Visible = true;

                    f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Action Denied! No active/selected record", Tool.Systemname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frm_server().ShowDialog();
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            using (FrmReport f = new FrmReport())
            {
                f.ShowDialog();
            }
        }

        private void cmd_searchHome_Click(object sender, EventArgs e)
        {
            //if (txt_search_blotter.Visible == true)
            //{
            //    txt_search_blotter.Visible = false;
            //    cmd_ClearHome.Visible = false;
            //}
            //else
            //{
            //    txt_search_blotter.Visible = true;
            //    cmd_ClearHome.Visible = true;
            //}
        }


        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (dg_user.SelectedRows.Count >= 1)
            {
                if (MessageBox.Show("Comfirm Delete!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataClasses1DataContext db = new DataClasses1DataContext(Tool.ConnectionString);
                    db.sp_deleteUser(dg_user.SelectedRows[0].Cells[0].Value.ToString());
                    getAccounts("%");
                }

            }
            else
            {
                MessageBox.Show("Action Denied! No active/selected record", Tool.Systemname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        //
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            //this.Invoke(new MethodInvoker(delegate { DailyTimeRecordSELECT(); }));
        }
      
        public void DailyTimeRecordSELECT(string keyword = "")
        {
            List<dtr> dtrList = new List<dtr>();
            DataClasses1DataContext db = new DataClasses1DataContext(Tool.ConnectionString);
            var list = db.DailyTimeRecordSelectAll().ToList();

            if (keyword != "")
            {
                list = (from m in list where m.AccountName.ToLower().Contains(keyword.ToLower()) select m).ToList();
            }

            
            foreach (var i in list)
            {
               // dg_DTR.Rows.Add(i.RecID, i.AccountName, i.TimeIN, i.TimeOUT, (i.Total / 60), Convert.ToDateTime(i.DateCreated).ToShortDateString());
                if (!dtrList.Any(t => t.AccountName == i.AccountName))
                {
                    dtrList.Add(new dtr
                    {
                        RecID = i.RecID,
                        AccountName = i.AccountName,
                        TimeIN = i.TimeIN,
                        TimeOUT = i.TimeOUT,
                        Total = i.Total.ToString(),
                        RowRemark = i.RowRemark,
                        DateCreated = i.DateCreated
                    });
                }
            }
            dg_DTR.Refresh();
            dg_DTR.DataSource = dtrList;
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            //
            // this.Invoke(new MethodInvoker(delegate { getIndigence("%"); }));
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {


        }

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {

            this.Invoke(new MethodInvoker(delegate { getAccounts("%"); }));
        }

        private void txt_search_blotter_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            using (frm_SelecDate f = new frm_SelecDate(this))
            {
                f.ShowDialog();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            buttonSelectection(pb3); wizard1.SelectedTab = tabPage2;
            DataClasses1DataContext db = new DataClasses1DataContext(Tool.ConnectionString);
            var Sections = db.SectionSELECT().ToList();
            cboSection.Items.Clear();
            foreach (var i in Sections)
            {
                cboSection.Items.Add(new ComboBoxItem(i.Section, i.RecID.ToString()));

            }

            var Grades = db.GradeSELECT().ToList();
            cboGrade.Items.Clear();
            foreach (var i in Grades)
            {
                cboGrade.Items.Add(new ComboBoxItem(i.Grade, i.RecID.ToString()));
            }


            var Adviser = db.getAdviser().ToList();
            cboAdviser.Items.Clear();
            foreach (var i in Adviser)
            {
                cboAdviser.Items.Add(i.Adviser);
            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            string grade = ((cboGrade.SelectedItem as ComboBoxItem).Value.ToString());
            string section = ((cboSection.SelectedItem as ComboBoxItem).Value.ToString());
            string adviser = cboAdviser.Text;
            string rDate = txtDate.Text;

      

            DataClasses1DataContext db = new DataClasses1DataContext(Tool.ConnectionString);
            DataTable dt = new DataSet1.getReportDataTable();
            reportByKeyWord crDTR = new reportByKeyWord();
            var list = db.getReport(rDate, grade, section, adviser).ToList();
            foreach (var i in list)
            {
                dt.Rows.Add(i.RecID, i.AccountName, i.TimeIN, i.TimeOUT, i.Total, i.RowRemark, i.DateCreated);
            }
            crDTR.SetDataSource(dt);
            //crDTR.Refresh();
            //
            crDTR.SetParameterValue("Date", "Date Generated: " + rDate);
            crDTR.SetParameterValue("Grade", "Grade: " + grade);
            crDTR.SetParameterValue("Section", "Section: " + section);
            crDTR.SetParameterValue("SystemName", Tool.Systemname);
            crDTR.SetParameterValue("Adviser", "Adviser: " + adviser);


            Viewer1.ReportSource = crDTR;
            RemoveTab(Viewer1);
            Cursor.Current = Cursors.Default;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Viewer1.PrintReport();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            using (FrmRequest f = new FrmRequest())
            {
                f.ShowDialog();

            }
        }
    }
}
