﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Task
{
    class Mehsul
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public double Miqdar { get; set; }
        public string MiqdarNovu { get; set; }
        public double Qiymet { get; set; }
        public int Edv { get; set; }
        public double EdvQaytarici()
        {
            return Qiymet * Edv / 100;
        }
    }
}
