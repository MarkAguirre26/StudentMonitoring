using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Reverse.SMS
{
    public class SMSSend
    {
        // Fields
        string ContactNumber;
        string Message;
        string PortName;
        private SerialPort port;

        // Methods
        public SMSSend()
        {
            this.ContactNumber = "";
            this.Message = "";
            this.PortName = "";
            this.port = new SerialPort();
        }
        public SMSSend(string ContactNumber, string Message, String PortName)
        {
            this.ContactNumber = ContactNumber;
            this.Message = Message;
            this.PortName = PortName;
            this.port = new SerialPort();
        }
        public SMSSend(MessageDetail Message)
        {
            this.ContactNumber = "";
            this.Message = "";
            this.PortName = "";
            this.port = new SerialPort();
            this.ContactNumber = Message.ContactNumber;
            this.Message = Message.Message;
            this.PortName = Message.PortName;
        }

        private void OpenPort()
        {
        Label_0001: ;
            try
            {
                this.port.Open();
                Thread.Sleep(0x3e8);
            }
            catch (Exception)
            {
                Thread.Sleep(0x1388);
                this.port.Close();
                goto Label_0001;
            }
        }

        public async Task<bool> SendAsync()
        {
            this.port.BaudRate = 0x2580;
            this.port.DataBits = 8;
            this.port.ReadBufferSize = 0x1000;
            this.port.ReadTimeout = 0x3e8;
            this.port.ReceivedBytesThreshold = 1;
            this.port.RtsEnable = true;
            this.port.StopBits = StopBits.One;
            this.port.WriteBufferSize = 0x800;
            this.port.WriteTimeout = -1;
            this.port.DtrEnable = false;
            this.port.Handshake = Handshake.None;
            this.port.Parity = Parity.None;
            await Task.Run(delegate
            {
                this.port.PortName = this.PortName;
                this.port.NewLine = Environment.NewLine;
                this.OpenPort();
                this.port.Write("AT+CMGF=1" + Environment.NewLine);
                Thread.Sleep(0x3e8);
                this.port.Write(string.Concat(new object[] { "AT+CMGS=", '"', this.ContactNumber, '"', Environment.NewLine }));
                Thread.Sleep(0x3e8);
                this.port.Write(this.Message + '\x001a');
                Thread.Sleep(0x3e8);
                this.port.Close();
            });
            return false;
        }
    }

}


