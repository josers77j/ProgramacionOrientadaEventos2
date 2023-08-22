using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsLibrary
{
    public class Verduras
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public override string ToString()
        {
            return $"{Nombre} / ${Precio}";
        }
    }
}
