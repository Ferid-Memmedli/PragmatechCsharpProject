using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder
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
}
