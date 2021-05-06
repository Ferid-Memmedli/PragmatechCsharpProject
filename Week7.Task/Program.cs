using System;

namespace Week7.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Product laptop = new Laptop() { Id = 1, Barcode = "5465", Brand = "Toshiba", Ram = "4", PurchasePrice = 500, SalePrice = 750, DiscountPrice = 50 };
            Product tv = new Tv() { Id = 2, Barcode = "53465", Brand = "Samsung", SmartTv = true, PurchasePrice = 1500, SalePrice = 1550, DiscountPrice = 58 };
            Product tv1 = new Tv() { Id = 3, Barcode = "234", Brand = "Samsung2", SmartTv = false, PurchasePrice = 2500, SalePrice = 2750, DiscountPrice = 54 };


            Manager.Add(laptop);
            Manager.Add(tv);
            Manager.Add(tv1);
            Console.WriteLine("Data Base-de Olan Mehsullar");
            Manager.GetAll();
            Manager.Remove(laptop.Id);
            Manager.Remove(tv1.Id);
            Console.WriteLine("Data Base-de Mehsullar Silindi");
            Manager.GetAll();
            Console.WriteLine("Data Base-de Mehsullar Update Olunmasi");
            Manager.Update(tv.Id);
            Manager.GetAll();
        }
    }
}
