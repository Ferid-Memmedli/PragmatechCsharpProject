using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.Task
{
    public static class Manager
    {
        #region DataBase

        static ArrayList _database;
        static Manager()
        {
            _database = new ArrayList();
        }

        #endregion DataBase

        #region CRUD

        public static void Add(Product product)
        {
            if (CheckBarcode(product.Barcode))
                Console.WriteLine($"Bu {product.Barcode} nomreli Barcode DataBAsede Movcuddur");
            else
                _database.Add(product);
        }
        public static void GetAll()
        {
            foreach (var item in _database)
            {
                Product product = (Product)item;
                if (product.IsDeleted == false)
                {
                    try
                    {
                        Laptop laptop = (Laptop)item;
                        Console.WriteLine($"Id :{laptop.Id}, Barcode :{laptop.Barcode}, Brand :{laptop.Brand}, Price :{laptop.SalePrice}");
                    }
                    catch (Exception)
                    {
                        Tv tv = (Tv)item;
                        Console.WriteLine($"Id :{tv.Id}, Barcode :{tv.Barcode}, Brand :{tv.Brand}, Price :{tv.SalePrice}");
                    }
                }
            }
        }
        public static void Update(int id)
        {
            foreach (var item in _database)
            {
                Product product = (Product)item;
                if (id == product.Id)
                {
                    product.Barcode = Input("Yeni Barcode Daxil Edin : ");
                    product.Brand = Input("Yeni Brand Daxil Edin : ");
                    product.Model = Input("Yeni Model Daxil Edin : ");
                    product.DiscountPrice = int.Parse(Input("Yeni DiscountPrice Daxil Edin : "));
                    product.SalePrice = int.Parse(Input("Yeni SalePrice Daxil Edin : "));
                    product.PurchasePrice = int.Parse(Input("Yeni PurchasePrice Daxil Edin : "));
                }
            }
        }
        public static void Remove(int id)
        {
            foreach (var item in _database)
            {
                Product removeProduct = (Product)item;
                if (id == removeProduct.Id)
                {
                    removeProduct.IsDeleted = true;
                }
            }
        }

        #endregion CRUD

        #region Methods

        private static bool CheckBarcode(string barcode)
        {
            bool control = false;

            foreach (var item in _database)
            {
                Product tempProduct = (Product)item;

                if (tempProduct != null && tempProduct.Barcode == barcode)
                {
                    control = true;
                    break;
                }
            }
            return control;
        }
        private static string Input(object value)
        {
            Console.Write(value);
            return Console.ReadLine();
        }
        #endregion Methods

    }
}
