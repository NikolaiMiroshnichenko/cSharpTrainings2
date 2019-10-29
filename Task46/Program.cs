using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task46
{
    public class Human
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public DateTime birthDay { get; set; }

        public Human(string name, string lastName, DateTime birthDay)
        {
            this.name = name;
            this.lastName = lastName;
            this.birthDay = birthDay;
        }
        public override string ToString()
        {
            Console.WriteLine($"Name is: {name}, LastName is: {lastName}, BirthDay is: {birthDay}");
            return "";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2001, 01, 01);
            DateTime date2 = new DateTime(2002, 02, 02);
            DateTime date3 = new DateTime(2003, 03, 03);

            Human human1 = new Human("Evdosiy", "Evdosiysky", date1);
            Human human2 = new Human("Ludvig", "Ludvigovsky", date2);
            Human human3 = new Human("Aristarh", "Aristarhovsky", date3);

            Stack<Human> humans = new Stack<Human>();

            humans.Push(human1);
            humans.Push(human2);
            humans.Push(human3);

            humans.Pop();
            human1.ToString();
            humans.Pop();
            human2.ToString();
            humans.Pop();
            human3.ToString();

            Console.ReadKey();
        }
    }
}
