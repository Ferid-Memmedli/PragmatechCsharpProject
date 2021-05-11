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

        private static readonly ArrayList _database;
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
        public static void Update(int id, Product data)
        {
            if (_database != null && _database.Count > 0)
            {
                if (data != null && !string.IsNullOrEmpty(data.Barcode))
                {
                    foreach (var item in _database)
                    {
                        Product product = (Product)item;
                        if (CheckBarcode(data.Barcode, id))
                        {
                            Console.WriteLine("Eyni mehsul var.");
                            break;
                        }
                        else if (id == product.Id)
                        {
                            product.Barcode = data.Barcode;
                            product.Brand = data.Brand;
                            product.PurchasePrice = data.PurchasePrice;
                            product.SalePrice = data.SalePrice;
                            product.DiscountPrice = data.DiscountPrice;
                        }
                    }
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

        private static bool CheckBarcode(string barcode, int id)
        {
            bool control = false;

            foreach (var item in _database)
            {
                Product tempProduct = (Product)item;

                if (tempProduct != null && tempProduct.Barcode == barcode && tempProduct.Id != id)
                {
                    control = true;
                    break;
                }
            }
            return control;
        }

        #endregion Methods
    }
}
