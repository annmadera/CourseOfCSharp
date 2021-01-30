using Episode1;
using System;

namespace episode1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            User badUser = new User("test@test.pl","giveMePassword");
            badUser.Age.Equals(10);
            badUser.Password = "xyz";

        }
    }
}
