using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStock
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
    public class Books : IdGenerator
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int StockCount { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
    }
}
