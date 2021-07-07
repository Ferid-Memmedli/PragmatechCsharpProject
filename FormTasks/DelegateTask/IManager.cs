using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DelegateTask
{
    public interface IManager
    {
        List<Person> GetAll(Expression<Func<Person, bool>> filter = null);
        void Add(Person entity);
    }
}
