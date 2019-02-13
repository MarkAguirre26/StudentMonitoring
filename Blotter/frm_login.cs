using DPFP.Capture;
using Ini;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP.Verification;
using AppSystem.Class;
using System.Diagnostics;
namespace AppSystem
{

    public partial class frm_login : Form, DPFP.Capture.EventHandler
    {
        Main fmain;
        public bool isLogin;
        public string UserLevel;
        public string UserCn;
        IniFile ini;

        Capture capture = new Capture();
        Verification verify = new Verification();
        List<sp_biometric_loginResult> biometrics = new List<sp_biometric_loginResult>();
        public frm_login(Main maiin)
        {
            InitializeComponent();
            fmain = maiin;
            capture.StartCapture();
            capture.EventHandler = this;
        }


        private void frm_login_Load(object sender, EventArgs e)
        {
            ini = new IniFile(Tool.confg);
            try
            {
                biometrics = new DataClasses1DataContext(Tool.ConnectionString).sp_biometric_login().ToList();

            }
            catch (Exception)
            {
                new frm_server().ShowDialog();
            }
            label3.Text = Tool.Systemname;
        }

        private async void cmd_login_Click(object sender, EventArgs e)
        {

            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext(Tool.ConnectionString);
                this.Text = "Connecting to database";
                await db.Connection.OpenAsync();
                var list = db.sp_login(txt_username.Text, EncodeString.Encrypt(txt_password.Text)).ToList();

                if (list.Count >= 1)
                {
                    foreach (var i in list)
                    {
                        fmain.fullname = i.fullname;
                        fmain.lbl_current_username.Text = i.fullname;
                        fmain.UserLevel = i.Level_cn.ToString();
                        fmain.UserCn = i.cn.ToString();
                    }

                    if (fmain.UserLevel != "3")
                    {
                        fmain.isLogin = true;
                        db.sp_insertLog__("Login", fmain.fullname, "Login");
                        this.Close();
                        fmain.Text = Tool.Systemname;
                        fmain.buttonSelectection(fmain.pb1);
                        fmain.DailyTimeRecordSELECT();
                        fmain.Show();
                    }


                }
                else
                {
                    txt_username.Clear(); txt_password.Clear();
                    MessageBox.Show("User does not exist", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                new frm_server().ShowDialog();
            }
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            foreach (var i in biometrics)
            {
                if (FingerPrintScanner.VerificationResult(Sample, verify, i.biometrics.ToArray()).Verified)
                {
                    capture.StopCapture();
                    capture.StartCapture();
                    Invoke(new Action(() =>
                    {
                        fmain.fullname = i.fullname;
                        fmain.lbl_current_username.Text = i.fullname;
                        fmain.UserLevel = i.level_cn.ToString();


                        fmain.UserCn = i.cn.ToString();
                        if (fmain.UserLevel != "3")
                        {
                            this.Close();
                            fmain.Text = Tool.Systemname;
                            fmain.buttonSelectection(fmain.pb1);
                            fmain.DailyTimeRecordSELECT();
                            fmain.Show();
                        }

                    }));
                    DataClasses1DataContext db = new DataClasses1DataContext(Tool.ConnectionString);
                    db.sp_insertLog__("Login", fmain.fullname, "Login");
                }
            }
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {

        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            capture.StopCapture();
        }

        private void frm_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                new frm_server().ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Messaging().sendSms("09364612324", "sample message");
        }

    }
}
