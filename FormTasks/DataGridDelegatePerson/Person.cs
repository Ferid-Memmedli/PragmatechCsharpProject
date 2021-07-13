using System;

namespace DataGridDelegatePerson
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Profession { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString() => $"{Id}) {Name} {Surname}";
    }
}
