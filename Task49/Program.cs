using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task49
{
    public class Program
    {
        public static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            a.GetInfo();
            b.GetInfo();
            c.GetInfo();
            Console.ReadKey();
        }
    }

    public class A
    {
        public void GetInfo()
        {
            Console.WriteLine("A");
        }
    }

    public class B : A
    {
        public void GetInfo()
        {
            Console.WriteLine("B");
        }
    }

    public class C : B
    {
        public void GetInfo()
        {
            Console.WriteLine("C");
        }
    }

}
