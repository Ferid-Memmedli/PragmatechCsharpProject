using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataGridDelegatePerson
{
    public interface IManager
    {
        List<Person> GetAll(Expression<Func<Person, bool>> filter = null);
        List<Person> GetAllOrderByProfession(Expression<Func<Person, bool>> filter = null);
    }
}
