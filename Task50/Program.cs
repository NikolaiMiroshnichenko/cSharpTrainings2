using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task50
{
    class Person
    {
        public string firstName { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person { firstName = "qwer", lastname = "qwer", age = 123 };
            Person person2 = new Person { firstName = "qwerty", lastname = "qwerty", age = 1234 };
            Person person3 = new Person { firstName = "qwertyui", lastname = "qwertyui", age = 12345 };
        }
    }
}
