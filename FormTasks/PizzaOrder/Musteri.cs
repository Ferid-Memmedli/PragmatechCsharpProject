using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder
{
    public class Musteri : IdGenerator
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public Pizza Pizza { get; set; }
        public override string ToString()
        {
            string terkibleri = "";
            if (Pizza.Terkib.Count > 0)
            {
                foreach (string item in Pizza.Terkib)
                    terkibleri += $"{item}-";
                terkibleri = terkibleri.Remove(terkibleri.Length - 1, 1);
            }
            else
                terkibleri += "Sade";
            return $"{Id}) {Ad} {Soyad}, Telefon : {Telefon}, Adres : {Adres}, Icecek : {Pizza.Icecekler.Say}eded " +
                $"{Pizza.Icecekler.Ad}, {Pizza.PizzaOlcusu.Say}eded {Pizza.PizzaOlcusu.Olcu} Pizza, Terkibinde : " +
                $"{terkibleri},Umumi Qiymet : {Pizza.TotalQiymet}azn";
        }
    }
}
