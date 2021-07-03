using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IProductManager
    {
        List<Product> Getall(Expression<Func<Product,bool>>filter = null);
    }
}
