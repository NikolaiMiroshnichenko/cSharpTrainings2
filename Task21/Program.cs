﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string");
            string s = Console.ReadLine();
            s = s.ToLower();
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
