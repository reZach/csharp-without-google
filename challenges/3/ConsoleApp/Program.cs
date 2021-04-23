using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person
                {
                    FullName = "Jonny Hopkins",
                    Age = 33,
                    Gender = Gender.Male
                },
                new Person
                {
                    FullName = "Ashley Ricker",
                    Age = 51,
                    Gender = Gender.Female
                }
            };

            Json

            File.WriteAllBytes
        }
    }

    public class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
