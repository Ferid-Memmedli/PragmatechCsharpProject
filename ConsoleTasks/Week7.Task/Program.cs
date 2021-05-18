using System;

namespace Week7.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
          * Productin database elave edilmesi, silinmesi, redakte edilmesi,butun mehsullarin gosterilmesi.
          * Taski yerine yetirerken kecdiyimiz yeni movzulari
          * ehate etmesine fikir verilmelidir. 2 mehsul tipimiz olacaq biri Tv digeri ise Laptop.
          *
          *
          * Product
          * Id : sistem terefinden genarete olunacaq , set oluna bilmez, 1-den baslayaraq artan olmalidir.
          * Barcode : DataBase-de eyni barcode-a sahip mehsulun olub olmamasi yoxlanmalidir.
          * Purchase price : mehsulun alis qiymeti 0-dan kicik ve ya beraber ola bilmez.
          * Sale price : mehsulun satis qiymeti alis qiymetinden kicik ola bilmez.
          * Discount price : mehsulun endirimli qiymeti 0-dan kicik ve ya beraber ola bilmez.
          * CreateDate : set edile bilmez.
          * Brand
          * Model
          * IsDeleted (bool)
          * DeletedDate : set edile bilmez
          * UpdatedDate : set edile bilmez
           *
           *
          * *Laptop
          * cpu
          * ram
          * videoCard
          *
          * * Tv
          * SmartTv (bool)
          * Inch
          * HDMi (bool)
          *
          * *Database 
          * Add : mehsulun elave edilmesi
          * Remove : mehsulun silinmesi(sadece isDeleted statusu redakte edilir.)
          * GetAll : IsDeleted statusu false olanlarin siyahisinin gosterilmesi 
          * Update : Mehsulun Brand,Model,Discount price,Sale price,Purchase price, Barcode xususiyyetleri redakte edilecek.
          *
          *
          */

            //Product laptop = new Laptop() { Barcode = "5465", Brand = "Toshiba", Ram = "4", PurchasePrice = 500, SalePrice = 750, DiscountPrice = 50 };
            //Product tv = new Tv() { Barcode = "5346", Brand = "Samsung", SmartTv = true, PurchasePrice = 1500, SalePrice = 1550, DiscountPrice = 58 };
            //Product tv1 = new Tv() { Barcode = "2324", Brand = "Samsung2", SmartTv = false, PurchasePrice = 2500, SalePrice = 2750, DiscountPrice = 54 };
            //Product tv2 = new Tv() { Barcode = "565", Brand = "Nokia", SmartTv = false, PurchasePrice = 200, SalePrice = 250, DiscountPrice = 10 };


            //Manager.Add(laptop);
            //Manager.Add(tv);
            //Manager.Add(tv1);
            //Console.WriteLine("Data Base-de Olan Mehsullar");
            //Manager.GetAll();
            //Console.WriteLine("Data Base-de Mehsullar Update Olunmasi");
            //Manager.Update(2, tv2);
            //Manager.GetAll();
        }

    }
}
