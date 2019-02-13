using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSystem
{
   public class ComboBoxItem
    {
        protected string items { get; set; }
        public string Value { get; set; }

        public ComboBoxItem(string item, string cn)
        {
            items = item;
            Value = cn;

        }
        public override string ToString()
        {
            return items;
        }


    }
}
