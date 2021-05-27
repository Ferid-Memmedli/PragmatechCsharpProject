using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder
{
    public class Icecek
    {
        public string Ad { get; set; }
        public double Qiymet { get; set; }
        public double Say { get; set; } = 1;
        public override string ToString()
        {
            return $"{Ad} : {Qiymet}azn";
        }
    }
}
