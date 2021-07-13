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
            PersonsAdd();
        }
        public List<Person> GetAll(Expression<Func<Person, bool>> filter = null)
        {
            return
                filter == null ?
                _persons.ToList() :
                _persons.AsQueryable().Where(filter).ToList();
        }
        private static void PersonsAdd()
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
                    Profession = FakeData.NameData.GetCompanyName(),                    
                    Phone = FakeData.PhoneNumberData.GetPhoneNumber(),
                    BirthDate = FakeData.DateTimeData.GetDatetime(new DateTime(1950, 01, 01), new DateTime(2020, 12, 12))
                };
                _persons.Add(person);
            }
        }
    }
}
