using System;

int num1 = 100; 
object obj1 = num1;

print(num1.GetType());
print(obj1.GetType());

static void print(object value)
{
    Console.WriteLine(value);
}

static string input(string value)
{
    Console.Write(value);
    return Console.ReadLine();
}