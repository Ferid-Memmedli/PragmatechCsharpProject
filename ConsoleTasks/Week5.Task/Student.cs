using System;

namespace Week5.Task
{
    public class Student
    {
        public static void ImtahandanKecis(string ad, string soyad, decimal eded, decimal eded1, decimal eded2)
        {
            decimal ortalama = (eded + eded1 + eded2) / 3;
            if (ortalama >= 81)
            {
                Console.WriteLine($"{ad} {soyad}\nNeticeleriniz : 1-ci netice {eded}, 2-ci netice {eded1}, 3-cu {eded2}\nOrtalamaniz : {ortalama}");
                Console.WriteLine("Imtahani Ugurla kecdiz");
            }
            else
            {
                Console.WriteLine($"{ad } {soyad} Imtahandan kesildiniz .Ortalama baliniz : {ortalama}");
            }
        }

        public static bool SifirYuzAraligiYoxlama(decimal eded)
        {
            return eded < 0 || eded > 100 ? false : true;
        }

    }
}