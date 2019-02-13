using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using Reverse.SMS;
namespace AppSystem.Class.Messages
{
    public class SendMessage
    {
        public static async void SendSms(string number, string Message, String port)
        {
            SMSSend sms = new SMSSend(number, Message, port);

            await sms.SendAsync();

        }
        public static List<String> PortList()
        {
            var list = new List<string>();
            foreach (var i in SerialPort.GetPortNames())
            {
                list.Add(i);
            }
            return list;
        }
    }
}
