using System;
namespace mvvm.Models
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public string FullName => FirstName + " " + LastName;

    }
}