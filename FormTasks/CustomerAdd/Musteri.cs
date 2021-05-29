using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAdd
{
    public class Musteri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Nomre { get; set; }
        public string FullName1 => Ad + " " + Soyad;
        public override string ToString()
        {
            return Ad + " " + Soyad;
        }

        public string FullName()
        {
            return Ad + " " + Soyad;
        }
    }
}
