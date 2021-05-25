using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdenisHesaplama
{
    public abstract class IdGenerator
    {
        protected IdGenerator()
        {
            _id = counter;
            counter += 1;
        }
        static int counter = 1;
        int _id;
        public int Id => _id;
    }

    public class Product : IdGenerator
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public double EDV { get; } = 0.18;
        public string NamePrice()
        {
            return $"Ad : {Name}, Qiymet : {Price}";
        }
    }
}
