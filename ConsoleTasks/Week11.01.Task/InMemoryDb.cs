using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InMemoryDb : IProductManager
    {
        public static readonly List<Product> _database = new List<Product>() 
        {
            new Product(){Id=1 ,Name = "Et",Status =true,IsDeleted = false,Price=23},
            new Product(){Id=2 ,Name = "Corek",Status =true,IsDeleted = false,Price=(decimal)0.5},
            new Product(){Id=3 ,Name = "Dondurma",Status =false,IsDeleted = false,Price=1},
            new Product(){Id=4 ,Name = "Un",Status =true,IsDeleted = false,Price=1},
            new Product(){Id=5 ,Name = "Yag",Status =false,IsDeleted = false,Price=8},
            new Product(){Id=6 ,Name = "Pendir",Status =true,IsDeleted = false,Price=4}
        };


        public List<Product> Getall(Expression<Func<Product, bool>> filter = null)
        {
            return filter != null?
                _database.AsQueryable().Where(filter).ToList()
                :_database;
        }
    }
}
