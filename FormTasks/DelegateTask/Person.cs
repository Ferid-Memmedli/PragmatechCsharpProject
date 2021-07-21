using System;

namespace DelegateTask
{
    public class Person
    {
        private static int _temp = 1;
        public Person() => _temp++;
        public int Id { get; } = _temp;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString() => $"{Id}) {Name} {Surname}";
        public string ToString(Func<Person, string> formatFunc)
        {
            return formatFunc?.Invoke(this);
        }
    }
}
