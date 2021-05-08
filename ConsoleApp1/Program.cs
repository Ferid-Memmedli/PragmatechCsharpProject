using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    enum WeekDays
    {
        Sunday = 1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    enum Gender
    {
        Unknown,
        Male,
        Female
    }
    class Employee
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }
    class MyGenericArray<T>
    {
        private T[] array;
        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }
        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }
    class MyGenericClass<T>
    {
        private T genericMemberVariable;
        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }
        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);
            return genericMemberVariable;
        }
        public T genericProperty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion1
            //MyGenericArray<int> intArray = new MyGenericArray<int>(5);

            //for (int c = 0; c < 5; c++)
            //    intArray.setItem(c, c * 5);

            //for (int c = 0; c < 5; c++)
            //    Console.Write(intArray.getItem(c) + " ");

            //MyGenericArray<char> charArray = new MyGenericArray<char>(5);

            //for (int c = 0; c < 5; c++)
            //    charArray.setItem(c, (char)(c + 97));

            //for (int c = 0; c < 5; c++)
            //    Console.Write(charArray.getItem(c) + " ");
            #endregion

            #region MyRegion
            //Console.WriteLine((int)WeekDays.Sunday + " " + WeekDays.Sunday);
            //Console.WriteLine((int)WeekDays.Monday + " " + WeekDays.Monday);
            //Console.WriteLine((int)WeekDays.Tuesday + " " + WeekDays.Tuesday);
            //Console.WriteLine((int)WeekDays.Wednesday + " " + WeekDays.Wednesday);
            //Console.WriteLine((int)WeekDays.Thursday + " " + WeekDays.Thursday);
            //Console.WriteLine((int)WeekDays.Friday + " " + WeekDays.Friday);
            //Console.WriteLine((int)WeekDays.Saturday + " " + WeekDays.Saturday);

            //List<Employee> empList = new List<Employee>
            //{
            //    new Employee() { Name = "Anurag", Gender = 0 },
            //    new Employee() { Name = "Pranaya", Gender = 1 },
            //    new Employee() { Name = "Priyanka", Gender = 2 },
            //    new Employee() { Name = "Sambit", Gender = 3 }
            //};

            //foreach (var emp in empList)
            //    Console.WriteLine($"Name = { emp.Name } && Gender = { GetGender(emp.Gender) }");

            //int[] Values = (int[])Enum.GetValues(typeof(Gender));
            //foreach (int value in Values)
            //    Console.WriteLine(value);

            //string[] Names = Enum.GetNames(typeof(Gender));
            //foreach (string Name in Names)
            //    Console.WriteLine(Name);

            //foreach (var item in Enum.GetNames(typeof(WeekDays)))
            //    Console.WriteLine(item);

            //WeekDays day = (WeekDays)Enum.ToObject(typeof(WeekDays), 3);
            //Console.WriteLine(day.ToString());

            //var day1 = (WeekDays)Enum.Parse(typeof(WeekDays), "Wednesday");
            //Console.WriteLine(day1.ToString());
            #endregion
        }
        static string GetGender(int gender)
        {
            switch (gender)
            {
                case (int)Gender.Unknown:
                    return "Unknown";
                case (int)Gender.Male:
                    return "Male";
                case (int)Gender.Female:
                    return "Female";
                default:
                    return "Invalid Data for Gender";
            }
        }
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
