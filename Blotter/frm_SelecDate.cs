
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
    public partial class frm_SelecDate : Form
    {
        Main fmain;
      
        public frm_SelecDate(Main maiin)
        {
            InitializeComponent();
            fmain = maiin;
        }

        private void cmd_ok_Click(object sender, EventArgs e)
        {

            fmain.txtDate.Text = dateTimePicker1.Text;
            this.Close();
            //using (frm_report f = new frm_report(fmain))
            //{

            //    if (dateTimePicker1.Value.ToShortDateString() == dateTimePicker2.Value.ToShortDateString())
            //    {
            //        f.dateFrom = dateTimePicker1.Value.AddDays(-1).ToString();
            //        f.DateTo = dateTimePicker2.Value.ToString();
            //    }
            //    else
            //    {
            //        f.dateFrom = dateTimePicker1.Value.ToString();
            //        f.DateTo = dateTimePicker2.Value.ToString();
            //    }
               
            //    f.selection = 4;
            //    f.ShowDialog();
            //    this.Close();
            //}

        }

      
    }
}
