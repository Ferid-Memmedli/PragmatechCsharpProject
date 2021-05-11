using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Task
{
    class Rectangle
    {
        private int en;
        private int uzunluk;

        public int En
        {
            get => en;
            set => en = value > 0 ? value : 0;
        }

        public int Uzunluk
        {
            get => uzunluk;
            set => uzunluk = value > 0 ? value : 0;
        }

        public int Sahe()
        {
            return en * uzunluk;
        }
    }
}
