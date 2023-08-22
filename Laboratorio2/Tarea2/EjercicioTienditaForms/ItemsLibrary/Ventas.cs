using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsLibrary
{
    public class Ventas
    {

        public string cliente { get; set; }
        public int cantidad { get; set;}
        public decimal total { get; set; }
        public string verdura { get; set; }

        public override string ToString()
        {
            return $"{verdura} / {cliente} / {cantidad} / ${total} ";
        }

    }
}
