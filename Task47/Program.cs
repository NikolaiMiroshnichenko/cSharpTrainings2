using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task47
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
            return ($"Name is: {name}, LastName is: {lastName}, BirthDay is: {birthDay}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2001, 01, 01);
            date1.ToShortDateString();
            DateTime date2 = new DateTime(2002, 02, 02);
            date2.ToShortDateString();
            DateTime date3 = new DateTime(2003, 03, 03);
            date3.ToShortDateString();

            Human human1 = new Human("Evdosiy", "Evdosiysky", date1);
            Human human2 = new Human("Ludvig", "Ludvigovsky", date2);
            Human human3 = new Human("Aristarh", "Aristarhovsky", date3);

            string s1 = human1.ToString();
            string s2 = human2.ToString();
            string s3 = human3.ToString();
            string s4 = $"{s1}\n {s2}\n {s3}";

            FileStream fs = new FileStream(@"C:\LearningFiles\Task46.txt", FileMode.OpenOrCreate);
            byte[] array1 = System.Text.Encoding.Default.GetBytes(s4);
            fs.Write(array1, 0, array1.Length);         


        }
    }
}

