using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder
{
    class DataPizzaOlcu
    {
        public static readonly List<PizzaOlcu> data;
        static DataPizzaOlcu()
        {
            data = new List<PizzaOlcu>() {
            new PizzaOlcu { Olcu = "Balaca", Qiymet = 10 },
            new PizzaOlcu { Olcu = "Orta", Qiymet = 15 },
            new PizzaOlcu { Olcu = "Boyuk", Qiymet = 20 }
            };
        }

    }
}
