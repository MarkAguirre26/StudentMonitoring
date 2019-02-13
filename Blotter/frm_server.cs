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
    public partial class frm_server : Form
    {

        public frm_server()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IniFile ini = new IniFile(Tool.confg);
                ini.IniWriteValue("SERVER", "Server", txt_Server.Text);
                ini.IniWriteValue("SERVER", "Database", txt_database.Text);
                ini.IniWriteValue("SERVER", "UID", txt_userID.Text);
                ini.IniWriteValue("SERVER", "Pwd", EncodeString.Encrypt(txt_Password.Text));
                Tool.ConnectionString = "Data Source=" + ini.IniReadValue("SERVER", "Server") + ";Initial Catalog=" + ini.IniReadValue("SERVER", "Database") + ";Persist Security Info=True;User ID=" + ini.IniReadValue("SERVER", "UID") + ";Password=" + ini.IniReadValue("SERVER", "Pwd") + ";";
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void frm_server_Load(object sender, EventArgs e)
        {
            IniFile ini = new IniFile(Tool.confg);
            txt_Server.Text = ini.IniReadValue("SERVER", "SERVER");
            txt_database.Text = ini.IniReadValue("SERVER", "Database");
            txt_userID.Text = ini.IniReadValue("SERVER", "UID");
            txt_Password.Text = EncodeString.Decrypt(ini.IniReadValue("SERVER", "Pwd"));

        }
    }
}
