using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.Task
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public DateTime CreateDate { get; } = DateTime.Now;
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime DeletedDate { get; } = DateTime.Now;
        public DateTime UpdatedDate { get; } = DateTime.Now;
        private int purchasePrice;
        public int PurchasePrice
        {
            get => purchasePrice;
            set
            {
                if (value <= 0)
                    Console.WriteLine("mehsulun alis qiymeti 0-dan kicik ve ya beraber ola bilmez.");
                else
                    purchasePrice = value;
            }
        }
        private int salePrice;
        public int SalePrice
        {
            get => salePrice;
            set
            {
                if (value < purchasePrice)
                    Console.WriteLine("mehsulun satis qiymeti alis qiymetinden kicik ola bilmez.");
                else
                    salePrice = value;
            }
        }
        private int discountPrice;
        public int DiscountPrice
        {
            get => discountPrice;
            set
            {
                if (value <= 0)
                    Console.WriteLine("mehsulun endirimli qiymeti 0-dan kicik ve ya beraber ola bilmez.");
                else
                    discountPrice = value;
            }
        }

    }
}
