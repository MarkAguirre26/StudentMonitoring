using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSystem
{
   public class EndProcess
    {
       public static void EndProcessNotficationSender()
       {
           Process[] workers = Process.GetProcessesByName("NotificationSender");
           foreach (Process worker in workers)
           {
               worker.Kill();
               worker.WaitForExit();
               worker.Dispose();
           }
       }


    }
}
