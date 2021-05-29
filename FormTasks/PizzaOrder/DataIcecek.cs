using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder
{
    class DataIcecek
    {
        public static readonly List<Icecek> dataIcecek;
        static DataIcecek()
        {
            dataIcecek = new List<Icecek>() {
            new Icecek { Ad = "CocaCola", Qiymet = 0.9 },
            new Icecek { Ad = "Fanta", Qiymet = 0.9 },
            new Icecek { Ad = "Ayran", Qiymet = 0.4 },
            new Icecek { Ad = "Jale", Qiymet = 2 },
            };
        }
    }
}
