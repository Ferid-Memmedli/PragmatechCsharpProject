﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryDb inMemoryDb = new InMemoryDb();
            var db = inMemoryDb.Getall(p => p.Id == 1);
            foreach (var item in db)
            {
                Console.WriteLine(item.Status);
            }
            Console.ReadKey();
            ///*
            //*  ele bir class dizayn etmelisiz ki , daxilindeki method 3 parametr qebul edecek
            //*
            //* ilk ikisi int tipinde ededler olacaq , classin ucuncu parametri ise qarsilashtirma emeliyyatini yerine yetirecek
            //*  classlarin instance-i olacaq yeni bir defe == dirmini yoxlayan classin instance-i daxil edile bilmeli bir defe
            //* boyuk ve ya kicik olmasini yoxlayan classin instance-i
            //*
            //*  bool CompareTo(int a, int b, new Instance1()) ==
            //*  bool CompareTo(int a, int b, new Instance2()) > or <
            //*/

            //bool a = Compare.CompareTo(7, 2, new Beraberlik());
            //bool c = Compare.CompareTo(2, 2, new Beraberlik());
            //Console.WriteLine(a);
            //Console.WriteLine(c);
            //bool b = Compare.CompareTo(7, 8, new Boyukluk());
            //Console.WriteLine(b);


            //Console.ReadKey();
        }
    }
}
