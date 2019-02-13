using AppSystem.Class;
using DPFP.Capture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSystem
{
    public partial class frm_user : Form
    {
        public bool isEdit;
        DataClasses1DataContext db;
        Main fmain;
        //Capture capture = new Capture();
        public frm_user(Main maiin)
        {
            InitializeComponent();
            db = new DataClasses1DataContext(Tool.ConnectionString);
            fmain = maiin;

        }


        void getGradeLevel()
        {
            db = new DataClasses1DataContext(Tool.ConnectionString);
            var Grades = db.GradeSELECT().ToList();
            foreach (var i in Grades)
            {
                cboGrade.Items.Add(new ComboBoxItem(i.Grade, i.RecID.ToString()+"/"+i.Remark));
            }
        }


        private void frm_user_Load(object sender, EventArgs e)
        {
            rbUser.Checked = true;

            getGradeLevel();
        

            var Sections = db.SectionSELECT().ToList();
            foreach (var i in Sections)
            {
                cboSection.Items.Add(new ComboBoxItem(i.Section, i.RecID.ToString()));
            }

            var a = db.sp_selectLevel().ToList();
            foreach (var i in a)
            {
                cbo_level.Items.Add(new ComboBoxItem(i.Rank, i.cn.ToString()));
            }



            if (isEdit)
            {
                txt_fname.Enabled = false;
                txt_MName.Enabled = false;
                txt_Lname.Enabled = false;
                txt_username.Enabled = false;
                linkLabel1.Enabled = false;
                cbo_level.Enabled = false;

            }



            if (this.Tag == null)
            {

                cmd_save.Text = "&Save";

                rbUser.Checked = true;
            }
            else
            {
                //rbStudent.Checked = true;
                cmd_save.Text = "Save";
                getDetails(this.Tag.ToString());


                cbo_level.SelectedIndex = Convert.ToInt32(fmain.UserLevel) - 1;
     
            }

            Process.Start(Tool.RFID_Reader_Path);

        }
  
        private void cmd_save_Click(object sender, EventArgs e)
        {
            if (wizard1.SelectedTab == tabPage3)
            {
                if (Tool.CheckEmpty(panel1) || txt_password.Text != txt_repeatPassword.Text || txt_password.Text.Length < 6 || txt_repeatPassword.Text.Length < 6 || FingerPrintScanner.FingerprintTemplate == null || FingerPrintScanner.FingerprintTemplate.Length < 0)//|| FingerPrintScanner.FingerprintTemplate==null
                {
                    MessageBox.Show("Please  fill all required information", "Empty String", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {

                    UserSave();



                }
            }
            else
            {
                if (FirstNameStudent.Text == "" || MiddleNameStudent.Text == "" || LastNameStudent.Text == "" || LRNStudent.Text == "" || cboGrade.Text == "" || cboSection.Text == "" || FingerPrintScanner.FingerprintTemplate == null || FingerPrintScanner.FingerprintTemplate.Length < 0)//|| FingerPrintScanner.FingerprintTemplate==null
                {
                    MessageBox.Show("Please  fill all required information", "Empty String", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {


                    StudentSave();



                }
            }



        }
        void StudentSave()
        {
            string Grade = ((cboGrade.SelectedItem as ComboBoxItem).Value.ToString());
            string Section = ((cboSection.SelectedItem as ComboBoxItem).Value.ToString());

            string[] g = Grade.Split('/');
            Grade = g[0];

            if (cmd_save.Text == "&Save")
            {

                db.sp_InsertUser(FirstNameStudent.Text, MiddleNameStudent.Text, LastNameStudent.Text, "", "3", "", "", new System.Data.Linq.Binary(FingerPrintScanner.FingerprintTemplate), txtRfidId.Text, Tool.ImageToByte(pbStudent.Image), LRNStudent.Text, Grade, Section, "", "", PhoneNumberStudent.Text, dtBirthDate.Text, txtStrand.Text, txtSy.Text, txtGuardiansName.Text, dt_TimeIN.Text + "/" + dt_TimeOUT.Text, txtAdviser.Text);

                MessageBox.Show("Changes Successfully saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fmain.getAccounts("%");
                FingerPrintScanner.FingerprintTemplate = null;
                this.Close();

            }
            else
            {


                string level = ((this.cbo_level.SelectedItem as ComboBoxItem).Value.ToString());
                db.sp_UpdateUser(FirstNameStudent.Text, MiddleNameStudent.Text, LastNameStudent.Text, "", "3", "", "", new System.Data.Linq.Binary(FingerPrintScanner.FingerprintTemplate), txtRfidId.Text, Tool.ImageToByte(pbStudent.Image), LRNStudent.Text, Grade, Section, "", "", PhoneNumberStudent.Text, this.Tag.ToString(), dt_TimeIN.Text + "/" + dt_TimeOUT.Text, txtGuardiansName.Text, txtAdviser.Text);
                MessageBox.Show("Changes Successfully saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fmain.getAccounts("%");
                this.Close();


            }

        }
        void UserSave()
        {

            if (cmd_save.Text == "&Save")
            {
                int i = db.sp_checkUsername(txt_username.Text).Count();
                if (i >= 1)
                {
                    MessageBox.Show("Username already exist!", Tool.Systemname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    //if (rbUser.Checked == true)
                    //{
                    string level = ((this.cbo_level.SelectedItem as ComboBoxItem).Value.ToString());
                    db.sp_InsertUser(txt_fname.Text, txt_MName.Text, txt_Lname.Text, txt_username.Text, level, txt_username.Text, Tool.Encrypt(txt_password.Text), new System.Data.Linq.Binary(FingerPrintScanner.FingerprintTemplate), "", Tool.ImageToByte(pbUser.Image), "", "0", "0", "", "", PhoneNumberStudent.Text, "", "", "", "", "","");

                    //}
                    //else
                    //{
                    //string Grade = ((cboGrade.SelectedItem as ComboBoxItem).Value.ToString());
                    //string Section = ((cboSection.SelectedItem as ComboBoxItem).Value.ToString());
                    //db.sp_InsertUser(FirstNameStudent.Text, MiddleNameStudent.Text, LastNameStudent.Text, "", "3", "", "", new System.Data.Linq.Binary(FingerPrintScanner.FingerprintTemplate), txtRfidId.Text, Tool.ImageToByte(pbStudent.Image), LRNStudent.Text, Grade, Section, "", "");
                    //}



                    MessageBox.Show("Changes Successfully saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fmain.getAccounts("%");
                    FingerPrintScanner.FingerprintTemplate = null;
                    this.Close();
                }

            }
            else
            {


                string level = ((this.cbo_level.SelectedItem as ComboBoxItem).Value.ToString());
                db.sp_UpdateUser(txt_fname.Text, txt_MName.Text, txt_Lname.Text, txt_username.Text, level, txt_username.Text, Tool.Encrypt(txt_password.Text), new System.Data.Linq.Binary(FingerPrintScanner.FingerprintTemplate), "", Tool.ImageToByte(pbUser.Image), "", "0", "0", "", "", PhoneNumberStudent.Text, this.Tag.ToString(), "", txtGuardiansName.Text,"");
                MessageBox.Show("Changes Successfully saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fmain.getAccounts("%");
                this.Close();


            }
        }
        public void getDetails(string cn)
        {
            rbStudent.Visible = false;
            rbUser.Visible = false;


            DataClasses1DataContext db = new DataClasses1DataContext(Tool.ConnectionString);
            var i = db.AccountSelectByID(this.Tag.ToString()).FirstOrDefault();

            if (!i.Level_cn.Equals(3))
            {
                wizard1.SelectedTab = tabPage3;

                txt_fname.Text = i.Firstname;
                txt_MName.Text = i.Middlename;
                txt_Lname.Text = i.Lastname;
                txt_username.Text = i.Email;
                cbo_level.Tag = i.Level_cn;
                txt_username.Text = i.Email;

             

                try
                {
                    DateTime Bd = i.BirrthDate.Value;
                    dtBirthDate.Text = Bd.ToShortDateString();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
               
                txtSy.Text = i.SchoolYear;
                txtStrand.Text = i.Strand;

                txtGuardiansName.Text = i.GuardianName;



                txt_password.Text = EncodeString.Decrypt(i.Password);
                try
                {
                    pbUser.Image = Tool.bytetoimage(i.AVATAR.ToArray());
                }
                catch (Exception)
                {

                    pbUser.Image = Properties.Resources.AnonymousPic;
                }

                try
                {
                    FingerPrintScanner.FingerprintTemplate = i.biometrics.ToArray();
                }
                catch (Exception)
                {


                }
            }
            else
            {
                wizard1.SelectedTab = tabPage4;
                FirstNameStudent.Text = i.Firstname;
                MiddleNameStudent.Text = i.Middlename;
                LastNameStudent.Text = i.Lastname;
                LRNStudent.Text = i.LRN;
                txtRfidId.Text = i.RFID;
                cboGrade.Text = i.GradeName;
                PhoneNumberStudent.Text = i.PhoneNo;
                cboSection.Text = i.Section_;
                txtGuardiansName.Text = i.GuardianName;
                string schedule = i.Schedule;
                string[] scheduleSplited = schedule.Split('/');
                dt_TimeIN.Text = scheduleSplited[0];
                dt_TimeOUT.Text = scheduleSplited[1];
                txtAdviser.Text = i.Adviser;
                try
                {
                    pbStudent.Image = Tool.bytetoimage(i.AVATAR.ToArray());
                }
                catch (Exception)
                {

                    pbStudent.Image = Properties.Resources.AnonymousPic;
                }

                try
                {
                    FingerPrintScanner.FingerprintTemplate = i.biometrics.ToArray();
                }
                catch (Exception)
                {


                }



            }






        }





        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string e_password;
        private void cb_show_pwd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (cb_show_pwd.Checked)
                {
                    //  e_password = txt_password.Text;
                    txt_password.UseSystemPasswordChar = false;
                    //txt_password.Text = EncodeString.Decrypt(txt_password.Text);
                }
                else
                {

                    txt_password.UseSystemPasswordChar = true;
                    //      txt_password.Text = EncodeString.Encrypt(txt_password.Text);
                }
            }
            catch
            {
                txt_password.Text = EncodeString.Decrypt(e_password);
            }
        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            if (txt_password.Text.Length < 6)
            { label7.Visible = true; }
            else
            { label7.Visible = false; }
        }

        private void txt_repeatPassword_TextChanged(object sender, EventArgs e)
        {

            if (txt_password.Text != txt_repeatPassword.Text)
            { label8.Visible = true; }
            else
            { label8.Visible = false; }
            //if (cb_show_pwd.Checked)
            //{
            //    if (txt_password.Text != txt_repeatPassword.Text)
            //    { label8.Visible = true; }
            //    else
            //    { label8.Visible = false; }
            //}
            //else
            //{
            //    if (e_password != txt_repeatPassword.Text)
            //    { label8.Visible = true; }
            //    else
            //    { label8.Visible = false; }
            //}
        }

        private void txt_username_Validating(object sender, CancelEventArgs e)
        {
            if (!Tool.IsValidEmail(txt_username.Text))
            {
                lbl_invalid.Visible = true;
            }
            else
            {
                lbl_invalid.Visible = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void txt_repeatPassword_Enter(object sender, EventArgs e)
        {
            cb_show_pwd.Checked = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void rbUser_CheckedChanged(object sender, EventArgs e)
        {
            wizard1.SelectedTab = tabPage3;
        }

        private void rbStudent_CheckedChanged(object sender, EventArgs e)
        {
            wizard1.SelectedTab = tabPage4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pbStudent.Image = Properties.Resources.AnonymousPic;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pbUser.Image = Properties.Resources.AnonymousPic;
        }

        private void openCameraUser_Click(object sender, EventArgs e)
        {
            new frm_camera().ShowDialog();
        }

        private void openCameraStudent_Click(object sender, EventArgs e)
        {
            new frm_camera().ShowDialog();
        }

        private void frm_user_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frm_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Grade = ((cboGrade.SelectedItem as ComboBoxItem).Value.ToString());

            if (Grade.Contains("22"))
            {
                labelStrand.Visible = true;
                txtStrand.Visible = true;
            }
            else
            {
                labelStrand.Visible = false;
                txtStrand.Visible = false;
            }
        }

        private void cmdFingerPrint_Click(object sender, EventArgs e)
        {
            new frm_fingerPrint().ShowDialog();
        }

    }
}
