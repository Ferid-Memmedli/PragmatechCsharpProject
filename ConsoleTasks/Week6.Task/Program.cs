using System;
using System.Collections;
using System.Collections.Generic;

namespace Week6.Task
{
    class Program
    {
        static void Main(string[] args)
        {

            #region rectangle
            /*
             * Console-dan daxil edilen en ve uzunluga gore duzbucaqlinin sahesinin hesablanmasi.
             * class memeber-ler ve encapsulation movuzlarina uygun isleyin.
             * Qeyd: daxil edilnlerden her hansisa birinin menfi olub olmamasini yoxlayin.
             * menfidirse deyeri 0 beraber edin.
             */

            //**************************************HELLI*********************************************

            /*
            Rectangle duzbucaqli = new Rectangle();
            Print("Duzbucaqli Sahesinin tapilmasi");
            duzbucaqli.En = int.Parse(Input("Eni daxil edin : "));
            duzbucaqli.Uzunluk = int.Parse(Input("Uzunlugu daxil edin : "));
            Print("Duzbucaqlinin Sahesi :"+ duzbucaqli.Sahe());
            */
            #endregion

            #region teacher class
            /*
             *  Muellim modeli yaradin, id, adi,soyadi,vezifesi,dogum tarixi, ise baslama tarixi, islediyi yer
             *  datalarini saxlasin.
             *  Id: sadece oxuna biler auto yaradilacaq.
             *  Vezife: daxil edilmeyibse nulldursa Teacher deye set edilsin.
             *  Ise Baslama tarixi : Muellimin eger 23 yasi varsa muellim olaraq fealiyyet gostere biler.
             */

            //**************************************HELLI*********************************************

            /*
            Muellim muellim = new Muellim
            {
                Ad = Input("Adinizi daxil edin : "),
                Soyad = Input("Soyadinizi daxil edin : "),
                Vezife = Input("Vezifenizi daxil edin : "),
                DogumTarixi = Input("Dogum tarixinizi bu sekilde daxil edin 'ay/gun/il' : "),
                IslediyiYer = Input("Islediyiniz yeri daxil edin : ")
            };
            Print(muellim.IseBaslamaTarixi());
            */
            #endregion

            #region gelende eve corey al
            /*
             *  Online alis veris :
             *  * Console ekaraninda musterini ilk once  menu qarsilamalidir,
             *  mehsullari menudan sececek( qiymetleri de olmalidir) sonra hansindan ne qeder istediyini qeyd edecek
             *  bildiklerinizi tetbiq ederek asagidaki numune cekin hazilanmasi
             *  lazimdir. Mehsul adlari onlarin qiymetleri edv olub olmamasi mehsulda endirim olub olmamasi
             *  siz terefden serbest teyin olunacaq.(burada gosterilenler hayel urunudur hic biri gercegi yansitmamaktadir).
             *
             *  | mehsul adi        |  miqdar  |  qiymet  |EDV  |toplam|
             *  | Un                | 5 kq     |  1       |0 %  |5     |
             *   Sizin qazanciniz=================== 0,495             |
             *  | quzu eti          | 3,5 kq   |  12      |18 % |42    |
             *   Sizin qazanciniz=================== 0,90              |
             *  | cay               | 2   eded |  1,50    |0 %  |3     |
             *   Sizin qazanciniz=================== 0,90              |
             *  | alma qirmizi      | 2   kq   |  2,50    |0 %  |5     |
             *   Sizin qazanciniz=================== 0,90              |
             * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
             * Endirim                                          | 2,48 |
             * vergi edv                                        | 5,02 |
             * yekun mebleg                                     | 54,50|
             * odenis novu: kartla odenib                        
             * tarix 20:04:21
             * qebz nomresi : 12
             *
             * Musterinin hesabinda umumi 450 azn pul var,
             * elave olaraq musteri bravo endirim kartina sahib oldugu ucun her alis verishinde
             * umumi meblegin 2% qeder endirim elde edir. Musteri odenisi kartla ederse 0,18 elave deyer vergisinin
             * 10 % qederini , negd pulla ederse 15 % qederini yeniden musterinin hesabina kocurulur.
             *
             * sizin qazanciniz :
             * | Un                | 5 kq     |  1       |0 %  | 5
             *  Sizin qazanciniz=================== 0,495 ( 5 % endirim olub bu mehsulda digerlerinde de bu sekilde endrim olarsa hesablanmalidir.)
             *  0,495 qaliqlarda yuvarlasdirmada edersiz 
             * EDV :
             *  asagida gosterildiyi kimi bezi mehsullarda 0% bezilerinde 18% edv olmalidir.
             *  Sonda elave deyer vergisi-de hansi mehsullarda varsa toplanib yekun meblegin
             *  uzerine gelmelidir. Musteri odenisi kart-la  edibse 10% negd yolla odenis edibse
             *  15 % umumi edv-den musterinin hesabina pul qayidacaq.
             *
             *  | mehsul adi        |  miqdar  |  qiymet  |EDV  |toplam
             *  | Un                | 5 kq     |  1       |0 %  |5
             *   Sizin qazanciniz=================== 0,25
             *  | quzu eti          | 3,5 kq   |  12      |18 % |42
             *
             *
             *  alis veris 15 azn den azdirsa catdirilma ucun 4,50 azn teleb olunacaq.
             */
            //**************************************Helli******************************************

            List<Mehsul> mehsullar = new List<Mehsul>();
            List<Mehsul> alinanMehsullar = new List<Mehsul>();
            ArrayList toplamEdvDeyer = new();
            ArrayList toplamQiymet = new();

            #region Mehsul elave olunmasi
            do
            {
                mehsullar.Add(new Mehsul
                {
                    Ad = Input("Mehsul adi : "),
                    //MiqdarNovu = Input("Mehsul miqdar novunu yazin (kq ve ya eded) : "),
                    Qiymet = double.Parse(Input("Mehsulun qiymeti : ")),
                    Edv = int.Parse(Input("Mehsulun EDV faizi : ")),
                });
            } while (Input("Yeni mehsul elave edmek ucun 'H' yazin : ").ToUpper() == "H");
            #endregion Mehsul elave olunmasi

            #region Mehsullara baxmaq "Menu"
            Print("*************************************");
            Print("Mehsullarimiz");
            Print("*************************************");
            Print("| Id | Mehsul adi        |  Qiymet  |");
            for (int i = 0; i < mehsullar.Count; i++)
            {
                mehsullar[i].Id = i + 1;
                Print(String.Format($"|{mehsullar[i].Id,-3} | {mehsullar[i].Ad,-17} | {mehsullar[i].Qiymet,-5}azn |"));
            }
            #endregion Mehsullara baxmaq "Menu"

            #region Alinacaq Mehsullar
            Print("*************************************");
            Print("Almaq isdediyiniz mehsullari daxil edin");
            do
            {
                string mehsulAd = Input("Mehsul adini yazin : ");
                double mehsulMiqdar = double.Parse(Input("Mehsul sayini ve ya cekisini yazin : "));
                Print("*************************************");
                for (int i = 0; i < mehsullar.Count; i++)
                {
                    if (mehsullar[i].Ad == mehsulAd)
                    {
                        mehsullar[i].Miqdar = mehsulMiqdar;
                        alinanMehsullar.Add(mehsullar[i]);
                    }
                }
            } while (Input("Yeniden mehsul almaq ucun 'H' yazin : ").ToUpper() == "H");
            #endregion Alinacaq Mehsullar

            #region Alinmis Mehsullar
            Print("*************************************");
            Print("| Mehsul adi        |  Miqdar  |  Qiymet  |EDV  |Toplam |");
            foreach (var item in alinanMehsullar)
            {
                Print(String.Format($"| {item.Ad,-17} | {item.Miqdar,-8} | {item.Qiymet,-8} |{item.Edv,-3}% |{item.Qiymet * item.Miqdar,-4}azn|"));
                toplamEdvDeyer.Add(item.EdvQaytarici() * item.Miqdar);
                toplamQiymet.Add(item.Qiymet * item.Miqdar);
            }
            double a = 0;
            double b = 0;
            for (int i = 0; i < alinanMehsullar.Count; i++)
            {
                a += (double)toplamQiymet[i];
                b += (double)toplamEdvDeyer[i];
            }
            Print("*************************************");
            Print($"vergi edv                                        | {Math.Round(b, 2)} |");
            Print($"yekun mebleg                                     | {a} |");
            #endregion Alinmis Mehsullar

            #endregion
        }
        #region Methods
        static void Print(object value)
        {
            Console.WriteLine(value);
        }

        static string Input(object value)
        {
            Console.Write(value);
            return Console.ReadLine();
        }
        #endregion
    }
}
