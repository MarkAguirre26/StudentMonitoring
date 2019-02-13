using AppSystem.Class;
using AppSystem.Properties;
//using AppSystem.Report;
using DPFP.Capture;
using DPFP.Processing;
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

namespace AppSystem
{
    public partial class frm_BrgyClearance : Form, DPFP.Capture.EventHandler
    {
        Main fmain;
        DataClasses1DataContext db;
        IniFile ini;
        Capture capture = new Capture();

        public frm_BrgyClearance(Main Mainn)
        {
            InitializeComponent();
            fmain = Mainn;
            ini = new IniFile(Tool.confg);
            capture.StartCapture();
            capture.EventHandler = this;
            
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txt_name.Text == "" || this.txt_purpose.Text == "" || this.txt_address.Text == "" || this.txt_certNo.Text == "" || this.txt_or.Text == "" || this.txt_amount.Text == "" || picPhoto.Image == null || pic_left.Image == null || pic_Right.Image == null)
                {
                    MessageBox.Show("Please fill all required information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    if (cmd_save.Text == "&Save")
                    {


                     //   db.sp_InsertBrgyClearance(txt_name.Text, txt_address.Text, txt_certNo.Text, txt_purpose.Text, txt_or.Text, txt_amount.Text, ini.IniReadValue("LOCATION", "Address"), Tool.ImageToByte(picPhoto.Image), Tool.ImageToByte(pic_Right.Image), Tool.ImageToByte(pic_left.Image));
                        MessageBox.Show("Successfully saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmd_print.Enabled = true;
                     //   fmain.getBrgyClearance("%");

                    }
                    else
                    {


                        if (Tool.IsNullOrEmpty(picPhoto) == true)
                        {
                            picPhoto.Image = Properties.Resources.w;
                        }
                        if (Tool.IsNullOrEmpty(pic_Right) == true)
                        {
                            pic_Right.Image = Properties.Resources.w;
                        }
                        if (Tool.IsNullOrEmpty(pic_left) == true)
                        {
                            this.pic_left.Image = Properties.Resources.w;
                        }
                     //   db.sp_UpdateBrgyClearance(txt_name.Text, txt_address.Text, txt_certNo.Text, txt_purpose.Text, txt_or.Text, txt_amount.Text, ini.IniReadValue("LOCATION", "Address"), Tool.ImageToByte(picPhoto.Image), Tool.ImageToByte(pic_Right.Image), Tool.ImageToByte(pic_left.Image), this.Tag.ToString());
                        MessageBox.Show("Changes Successfully saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       // fmain.getBrgyClearance("%");
                        this.Close();
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }


        //public void getDetails(string cn)
        //{
        //    db = new DataClasses1DataContext(Tool.ConnectionString);
        //    var i = db.sp_selectBrgyClearance_details(cn).FirstOrDefault();
        //    txt_name.Text = i.Name;
        //    txt_purpose.Text = i.Purpose;
        //    txt_address.Text = i.Address;
        //    txt_certNo.Text = i.CertificateNo;
        //    txt_or.Text = i.OrNo;
        //    txt_amount.Text = i.Amount;
        //    picPhoto.Image = Tool.bytetoimage(i.Photo.ToArray());
        //    pic_Right.Image = Tool.bytetoimage(i.RF.ToArray());
        //    pic_left.Image = Tool.bytetoimage(i.LF.ToArray());

        //}

        private void cmd_print_Click(object sender, EventArgs e)
        {
            //using (frm_report f = new frm_report(fmain))
            //{
            //    if (this.Tag != null)
            //    {
            //        f.Tag = this.Tag.ToString();
            //    }
            //    else
            //    {
            //        var i = db.sp_getMaxcn_Brgy().FirstOrDefault();
            //        f.Tag = i.cn;
            //    }
            //    f.selection = 3;

            //    f.ShowDialog();
            //}

        }

        private void frm_BrgyClearance_Load(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext(Tool.ConnectionString);
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        
        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            if (rdleft.Checked )
            {
                FingerPrintScanner.DrawPicture(pic_left, FingerPrintScanner.ConvertSampleToBitmap(Sample));
            }
            else
            {
                FingerPrintScanner.DrawPicture(pic_Right , FingerPrintScanner.ConvertSampleToBitmap(Sample));
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

        private void frm_BrgyClearance_FormClosed(object sender, FormClosedEventArgs e)
        {
            capture.StopCapture();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frm_camera().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            picPhoto.Image = Properties.Resources.w;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pic_left.Image = Properties.Resources.w;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pic_Right.Image = Properties.Resources.w;
        }

        private void txt_certNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_or_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
