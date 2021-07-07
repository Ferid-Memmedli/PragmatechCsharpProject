using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryDb inMemoryDb = new InMemoryDb();
            var db = inMemoryDb.Getall(p => p.Status);
            foreach (var item in db)
            {
                Console.WriteLine(item.Status);
            }
            Console.ReadKey();

            #region Task1
            //bool a = Compare.CompareTo(7, 2, new Beraberlik());
            //bool c = Compare.CompareTo(2, 2, new Beraberlik());
            //Console.WriteLine(a);
            //Console.WriteLine(c);
            //bool b = Compare.CompareTo(7, 8, new Boyukluk());
            //Console.WriteLine(b);
            //Console.ReadKey();
            #endregion
        }
    }
}
