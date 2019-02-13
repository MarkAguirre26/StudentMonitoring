using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Reverse.SMS
{
   public class Modem
{
    // Methods
    public DataTable FillCombobox()
    {
        DataTable table = new DataTable();
        table.Columns.Add("ModemName");
        string[] strArray = this.GetModemList().Split(new char[] { '*' });
        for (int i = 0; i <= (strArray.Length - 2); i++)
        {
            table.Rows.Add(new object[] { strArray[i] });
        }
        return table;
    }

    private string GetModemList()
    {
        string str = "";
        try
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\CIMV2", "SELECT * FROM Win32_POTSModem");
            foreach (ManagementObject obj2 in searcher.Get())
            {
                if (((string) obj2["Status"]) == "OK")
                {
                    object obj3 = str;
                    str = string.Concat(new object[] { obj3, obj2["AttachedTo"], " - ", obj2["Description"], "*" });
                }
            }
        }
        catch (Exception)
        {
            str = "";
        }
        return str;
    }

    public List<string> ModemList()
    {
        List<string> list = new List<string>();
        string[] strArray = this.GetModemList().Split(new char[] { '*' });
        for (int i = 0; i <= (strArray.Length - 2); i++)
        {
            list.Add(strArray[i]);
        }
        return list;
    }
}

 

 

}
