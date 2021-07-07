using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DelegateTask
{
    public class DataSource : IManager
    {
        private static List<Person> _persons = new List<Person>();

        public void Add(Person entity)
        {
            _persons.Add(entity);
        }
        public List<Person> GetAll(Expression<Func<Person, bool>> filter = null)
        {
            return
                filter == null ?
                _persons.ToList() :
                _persons.AsQueryable().Where(filter).ToList();
        }
    }
}
