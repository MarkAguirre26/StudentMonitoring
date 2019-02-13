using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSystem.Class
{
    public class Messaging
    {
        public async void sendSms(string PhoneNo,string message)
        {
            //if (txtNumber.Text.Length > 0)
            //{
            var modems = new Reverse.SMS.Modem().ModemList();

            if (modems.Count() <= 0)
            {
                MessageBox.Show("No SMS Gateway or Modem Connected", "Modem Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var port = modems.LastOrDefault().Split('-');

                await new Reverse.SMS.SMSSend(new Reverse.SMS.MessageDetail()
                {
                    ContactNumber = PhoneNo,
                    Message = message,
                    PortName = port[0]
                }).SendAsync();
            }
        }
    }
}
