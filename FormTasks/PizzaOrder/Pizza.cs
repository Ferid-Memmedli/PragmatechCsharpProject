using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder
{
    public class Pizza
    {
        public Pizza()
        {
            Terkib = new List<string>();
        }
        public PizzaOlcu PizzaOlcusu { get; set; }
        public Icecek Icecekler { get; set; }
        public List<string> Terkib { get; set; }
        public double TotalQiymet => (PizzaOlcusu.Qiymet * PizzaOlcusu.Say) + (Icecekler.Qiymet * Icecekler.Say);
    }
}
