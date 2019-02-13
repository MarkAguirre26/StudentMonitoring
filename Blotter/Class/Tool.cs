using Ini;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppSystem
{
    public static class Tool
    {
        static IniFile ini = new IniFile(Tool.confg);
        public static string confg = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "StudentMonitoring.ini");
        public static string ConnectionString;
        //public static string confgLocal = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TrafficMonitoringLocal.ini");
        public static string Systemname;
        public static string RFID_Reader_Path = Application.StartupPath.ToString().Replace("Debug", "") + @"\system_rfid_mjr\nfcUID.exe";
        public static string ExtractNumber(string s)
        {
            var getNumbers = (from t in s
                              where char.IsDigit(t)
                              select t).ToArray();
            return new string(getNumbers);
        }

    public static    bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }



        public static bool IsNullOrEmpty(this PictureBox pb)
        {
            return pb == null || pb.Image == null;
        }

        public static DateTime AddWorkingDays(DateTime specificDate, int workingDaysToAdd)
        {
            int completeWeeks = workingDaysToAdd / 5;
            DateTime date = specificDate.AddDays(completeWeeks * 7);
            workingDaysToAdd = workingDaysToAdd % 5;
            for (int i = 0; i < workingDaysToAdd; i++)
            {
                date = date.AddDays(1);
                while (!IsWeekDay(date))
                {
                    date = date.AddDays(1);
                }
            }
            return date;
        }

        private static bool IsWeekDay(DateTime date)
        {
            DayOfWeek day = date.DayOfWeek;
            return day != DayOfWeek.Saturday && day != DayOfWeek.Sunday;
        }

        public static double GetBusinessDays(DateTime startD, DateTime endD)
        {
            double calcBusinessDays =
                1 + ((endD - startD).TotalDays * 5 -
                (startD.DayOfWeek - endD.DayOfWeek) * 2) / 7;

            if (endD.DayOfWeek == DayOfWeek.Saturday) calcBusinessDays--;
            if (startD.DayOfWeek == DayOfWeek.Sunday) calcBusinessDays--;

            return calcBusinessDays;
        }
        public static string ReplaceString(string str)
        {
            return str.Replace("'", "`").Replace(@"\", "");
        }
        public static void MessageBoxSave()
        {
            MessageBox.Show("New record successfully saved", Systemname, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void MessageBoxUpdate()
        {
            MessageBox.Show("Record successfully updated", Systemname, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void MessageBoxDelete()
        {
            MessageBox.Show("Record has been deleted", Systemname, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void MessageBoxDeniede()
        {
            MessageBox.Show("Please fill required information", Systemname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;

        }

        public static string Encrypt(string inputText)
        {

            byte[] bytesToEncode = Encoding.Unicode.GetBytes(inputText);
            return Convert.ToBase64String(bytesToEncode);
        }
        public static string Decrypt(string EncryptedText)
        {

            byte[] decodedBytes = Convert.FromBase64String(EncryptedText);
            return Encoding.Unicode.GetString(decodedBytes);

        }
        public static Image bytetoimage(byte[] bytearray)
        {

            Image img = null;
            try
            {
                using (MemoryStream ms = new MemoryStream(bytearray))
                {

                    img = Image.FromStream(ms, true);

                }
            }
            catch (Exception)
            {
                img = null;

            }

            return img;
        }
   
        public static byte[] ImageToByte(Image img)
        {
            using (Bitmap bmp = new Bitmap(img))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
        }

        public static byte[] ImagePathToByte(string imgPath)
        {
            Image img = Image.FromFile(imgPath);
            using (Bitmap bmp = new Bitmap(img))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
        }
        public static void ClearControl(Control ctrl)
        {

            foreach (Control control in ctrl.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;
                    txtbox.Text = string.Empty;
                }
                else if (control is CheckBox)
                {
                    CheckBox chkbox = (CheckBox)control;
                    chkbox.Checked = false;
                }
                else if (control is RadioButton)
                {
                    RadioButton rdbtn = (RadioButton)control;
                    rdbtn.Checked = false;
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)control;
                    dtp.Value = DateTime.Now;
                }
            }
        }


        public static void EnablerControl(Control control, bool bl)
        {

            foreach (Control child in control.Controls)
            {
                if (child is TextBox)
                {
                    TextBox txtbox = (TextBox)child;
                    txtbox.Enabled = bl;
                }
                else if (child is CheckBox)
                {
                    CheckBox chkbox = (CheckBox)child;
                    chkbox.Enabled = bl;
                }
                else if (child is RadioButton)
                {
                    RadioButton rdbtn = (RadioButton)child;
                    rdbtn.Enabled = bl;
                }
                else if (child is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)child;
                    dtp.Enabled = bl;
                }
                else if (child is DataGridView)
                {
                    DataGridView dg = (DataGridView)child;
                    dg.Enabled = bl;
                }
                else if (child is ComboBox)
                {
                    ComboBox dg = (ComboBox)child;
                    dg.Enabled = bl;
                }

            }
        }

        private static bool bl;
        public static bool CheckEmpty(Control control)
        {

            var emptyTextboxes = from tb in control.Controls.OfType<TextBox>()
                                 where string.IsNullOrEmpty(tb.Text)
                                 select tb;

            var emptyComboBox = from cb in control.Controls.OfType<ComboBox>()
                                where string.IsNullOrEmpty(cb.Text)
                                select cb;
            //ErrorProvider errorProvider1 = new ErrorProvider();
            //var boxes = control.Controls.OfType<TextBox>();
            //foreach (var box in boxes)
            //{
            //    if (string.IsNullOrWhiteSpace(box.Text))
            //    {
            //        errorProvider1.SetError(box, "required");
            //        bl = true;
            //    }
            //    else { bl = false; }
            //}



            if (emptyTextboxes.Any() || emptyComboBox.Any())
            { bl = true; }
            else
            { bl = false; }

            return bl;

        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {

                return false;
            }
        }

        public static bool checksystemTime()
        {
            IniFile ini = new IniFile(Tool.confg);
            bool istrue;
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(ini.IniReadValue("TimeZone", "URL"));
                DateTime RemoteTime = Convert.ToDateTime(json.Trim(new char[] { ' ', '"', '.' }).Replace("-", "/"));
                if (DateTime.Now.Date != RemoteTime)
                { istrue = false; }
                else
                { istrue = true; }


            }

            return istrue;
        }

    }
}
