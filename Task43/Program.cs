using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task43
{
    class Person
    {
        public string name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.name = "Ryan";
            Person person2 = new Person();
            person2.name = "Rayn";
            Person person3 = new Person();
            person3.name = "Arnold";
            Person person4 = new Person();
            person4.name = "Ash";
            Person person5 = new Person();
            person5.name = "Ann";

            Queue<Person> persons = new Queue<Person>();
            persons.Enqueue(person1);
            persons.Enqueue(person2);
            persons.Enqueue(person3);
            persons.Enqueue(person4);
            persons.Enqueue(person5);

            Person peekedQueuePerson = persons.Peek();
            Console.WriteLine(peekedQueuePerson.name);

            Console.ReadKey();

        }
    }
}
