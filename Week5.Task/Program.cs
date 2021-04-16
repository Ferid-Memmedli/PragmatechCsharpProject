using System;
using System.Collections;
using static Week5.Task.Bankamat;
using static Week5.Task.Student;

namespace Week5.Task
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region 1. Havada bulut dimplom isini unuty

            /*
             * Telebinin adini soyadini 3 imtahan neticesini
             * (((her hansisa imtahan neticesi daxil edilmezse default deyer 51 verilecek,
             * daxil edilen imtahan neticeleri0-dan kicik 100-den boyuk ola bilmez,
             * eded yerine simvol ve sair daxil edilen zaman xeta mesaji cixmalidir, yeniden emeliyyati duzgun yerine yetirerek davam etmelidir))) daxil edib,
             * ortalamasini hesablayaraq console-da  adi,soyadi, imtahan neticeleri,
             * ortalamasi, Diplom isine dusub dusmediyi yazilacaq(((bunun ucun ortalama 81den boyuk ve ya beraber olmalidir))).
             *
             * Taski mumkun derece kicik methodlara bolerek her methoda verilen adi ehtiva eden isler gorulsun.
             * Student classi yaradaraq method-lari orada yazib Program classi icerisinde Main methodunda istifade edeceksiz.
             */
            //*********************************************** HELLI ******************************************************************
            /*
            string ad = Input("Adinizi daxil edin: ");
            string soyad = Input("Soyadinizi daxil edin: ");
            decimal[] Neticeler = new decimal[3];
        evvel:
            for (int i = 0; i < Neticeler.Length; i++)
            {
                string netice = Input($"{i + 1}-ci imtahan neticesini daxil edin: ");
                if (String.IsNullOrWhiteSpace(netice))
                    Neticeler[i] = 51;
                else
                {
                    if (decimal.TryParse(netice, out decimal eded))
                    {
                        if (SifirYuzAraligiYoxlama(eded))
                            Neticeler[i] = eded;
                        else
                        {
                            Console.Clear();
                            Print("Eded 100 den boyuk 0 dan kicik ola bilmez\nYeniden Melumatlari Doldurun.");
                            goto evvel;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Print($"{netice} - Duzgun melumat deyil.\nYeniden Melumatlari Doldurun.");
                        goto evvel;
                    }
                }
            }
            ImtahandanKecis(ad, soyad, Neticeler[0], Neticeler[1], Neticeler[2]);
            */

            #endregion 1. Havada bulut dimplom isini unuty

            #region 2. para pul el cerki 2 yakinda sinemalarda
            /* Evvelceden teyin edilen pin vasitesile ATM-ye yaxinlasan vetendas pini daxil edir.
             * Qarsinina cixan menu-dan balansina baxa, negd pul cixarda, ve ya umumi hesabdan cixaris
             * isteye biler.Secilen her hansi bir emeliyyatdan sonra istifadeci yeniden menuya- geri done bilmelidir.
             *
             * login
             *
             * pin:
             * pin sadece reqemlerden ibaret olmalidir // 1234
             * pin sadece 4 reqemden ibaret olmalidir.
             *
             * Menu
             *
             * 1.Balans:
             * (evvelceden standart olaraq balans 1000 azn olaraq nezerde tutulur.)
             *
             * 2.Negd pulun verilmesi:
             *  Istifadeci ATM-den min 1 manat max 1000 manat ceke biler.Balans yoxlamasi olacaq,
             *  daxil edilen mebleg hansi esginasdan nece eded olacaq o sekilde netice olaraq gosterilir.
             *
             * 3.Balansdan cixaris:
             *   Eger balansdan mexaric olubsa mexaric olunan meblegi ve hemin tarixi cap edin,
             *   Yox eger hele balansdan mexaric olunmayibsa bu haqqda mesaj gosterin.
             *
             * Qeyd: consoledan daxil edilenler yalniz eded ola biler bular yoxlayanacaq ,
             * mumkun derece methodlarla isleyin
             */

            string ad;
            string pinKod;

            while (true)
            {
                ad = Input("VISA kart qeydiyyati ucun adinizi daxil edin : ");
                pinKod = Input("Yeni 4 reqemli Pinkod daxil edin : ");
                if (PinKodYoxlama(pinKod))
                {
                    Console.Clear();
                    Print("Qeydiyyat ugurla heyata kecirildi");
                    break;
                }
                else
                {
                    Console.Clear();
                    Print("Tekrar Duzgun melumat daxil edin");
                }
            }
        daxiletme:
            int balans = 1000;
            Hashtable mexaric = new Hashtable();
            string kartDaxil = Input("ATM -e Xosh Geldiniz\nKarti Daxil Edmek Ucun 1-i Daxil Edin : ");
            if (kartDaxil == "1")
            {
                if (ATMGiris(ad, pinKod))
                {
                anamenyu:
                    switch (AnaMenyu())
                    {
                        case "1":
                            Console.Clear();
                            BalansMenyu(balans, ad);
                            goto anamenyu;
                        case "2":
                            Console.Clear();
                            int pul = NegdPulMenyu(balans, ad);
                            mexaric.Add(DateTime.Now, pul);
                            PulCixarisi(pul);
                            balans = balans - pul;
                            Print($"Balansinizda {balans}azn qaldi");
                            goto anamenyu;
                        case "3":
                            Console.Clear();
                            BalansCixaris(balans, ad,mexaric);
                            goto anamenyu;
                    }
                }
            }
            else
            {
                Console.Clear();
                Print("Daxil edmeq ugurla yerine yetirilmedi\nTekrar yoxluyun");
                goto daxiletme;
            }

            #endregion
        }
    }
}