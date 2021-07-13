using DataGridDelegatePerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataGridDelegatePerson
{
    public class DataSource : IManager
    {
        private static readonly List<Person> _persons;
        static DataSource()
        {
            _persons = new List<Person>();
            CustomersAdd();
        }
        private static void CustomersAdd()
        {
            for (int i = 1; i <= 1000; i++)
            {
                var person = new Person
                {
                    Id = i,
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Country = FakeData.PlaceData.GetCountry(),
                    City = FakeData.PlaceData.GetCity(),
                    Email = FakeData.NetworkData.GetDomain(),
                    Phone = FakeData.PhoneNumberData.GetPhoneNumber(),
                    BirthDate = FakeData.DateTimeData.GetDatetime(new DateTime(1950, 12, 12), new DateTime(2020, 12, 12)),
                    Profession = FakeData.NameData.GetCompanyName()
                };
                _persons.Add(person);
            }
        }
        public List<Person> GetAll(Expression<Func<Person, bool>> filter = null)
        {
            return
                filter == null ?
                _persons.ToList() :
                _persons.AsQueryable().Where(filter).ToList();
        }
        public List<Person> GetAllOrderByProfession(Expression<Func<Person, bool>> filter = null)
        {
            return
                filter == null ?
                _persons.OrderBy(p => p.Profession).ToList():
                _persons.AsQueryable().OrderBy(p => p.Profession).Where(filter).ToList();
        }
    }
}
