using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Task
{
    class Bankamat
    {
        public static bool ATMGiris(string ad, string pinKod)
        {
            while (true)
            {
                string tempPinKod = Input("Pininizi daxil edin : ");
                if (tempPinKod == pinKod)
                {
                    Console.Clear();
                    Print($"Hormetli {ad} ATM-e Ugurla Daxil Oldunuz");
                    break;
                }
                else
                {
                    Console.Clear();
                    Print($"Hormetli {ad} Pin kodunuz yalnisdir.Tekrar Giris Edin");
                }
            }
            return true;
        }
        public static string AnaMenyu()
        {
            Console.WriteLine
(@$"
        ATM MENYU
1 : Balansa Baxmaq
2 : Negd Pul Cixartmaq
3 : Balansdan Cixaris
");
            while (true)
            {
                string emeliyyat = Input("Emeliyyat edmeq isdediyiniz sirani daxil edin : ");
                if (emeliyyat == "1")
                {
                    return emeliyyat;
                }
                else if (emeliyyat == "2")
                    return emeliyyat;
                else if (emeliyyat == "3")
                    return emeliyyat;
                else
                    Print("Duzgun Melumat daxil olunmadi");
            }
        }
        public static string BalansMenyu(int balans, string ad)
        {
            Console.WriteLine
(@$"
Hormetli {ad} Balansiniz : {balans} azn
1 : ATM Menyuya geri donmeq
");
            while (true)
            {
                string emeliyyat = Input("Emeliyyat edmeq isdediyiniz sirani daxil edin : ");
                if (emeliyyat == "1")
                {
                    return emeliyyat;
                }
                else
                {
                    Print("Duzgun emeliyyat sirasi daxil olunmadi");
                }
            }
        }
        public static int NegdPulMenyu(int balans, string ad)
        {
            Print
(@$"
Hormetli {ad} Balansiniz : {balans} azn
");
            while (true)
            {
                string emeliyyat = Input("Nece azn pul cixartmaq isdediyinizi daxil edin ");
                if (EdedYoxlama(emeliyyat))
                {
                    int pul = int.Parse(emeliyyat);
                    if (pul > 0 && pul <= balans)
                    {
                        return pul;
                    }
                    else
                        Print($"Balansinizda kifayet geder mebleg yoxdur\nEn az 1 azn , en cox {balans} cixara bilersiz");
                }
                else
                    Print("Dogru melumat daxil eidin");
            }
        }
        public static void PulCixarisi(int cixarisPulu)
        {
            int[] eskinaslar = { 200, 100, 50, 20, 10, 5, 1 };
            for (int i = 0; i < eskinaslar.Length; i++)
            {
                if (cixarisPulu >= eskinaslar[i])
                {
                    int temp = cixarisPulu / eskinaslar[i];
                    cixarisPulu = cixarisPulu - eskinaslar[i] * temp;
                    Print($"{temp} eded {eskinaslar[i]}");
                }
            }
        }
        public static void BalansCixaris(int balans, string ad,Hashtable mexaric)
        {
            if (balans == 1000)
                Print("Balansdan Mexaric Olunmayib");
            else
            {
                Print($"Hormetli {ad} balansinizda {balans}azn qaldi");
                Print("Mexaric Tarixcesi");
                foreach (DictionaryEntry de in mexaric)
                    Console.WriteLine($"Cixarilan Mebleg: {de.Value}azn, Cixarildiqi Tarix: {de.Key}");
            }
        }
        public static bool EdedYoxlama(string eded)
        {
            return double.TryParse(eded, out double b) ? true : false;
        }
        public static bool TamEdedYoxlama(string eded)
        {
            return eded.IndexOf('.') == -1 ? true : false;
        }
        public static bool PinUzunluqYoxlama(string eded)
        {
            return eded.Length == 4 ? true : false;
        }
        public static bool PinKodYoxlama(string pinYoxla)
        {
            if (EdedYoxlama(pinYoxla) && TamEdedYoxlama(pinYoxla) && PinUzunluqYoxlama(pinYoxla))
                return true;
            else
                return false;
        }
        public static void Print(object value)
        {
            Console.WriteLine(value);
        }
        public static string Input(object value)
        {
            Console.Write(value);
            return Console.ReadLine();
        }
    }
}
