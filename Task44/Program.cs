using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task44
{
    enum Color
    {
        Black,
        Red,
        White,
        Green,
        Blue
    }

    class Clothe
    {
       public Color clotheColor;
    }

    class Pants : Clothe
    {
        
    }

    class Shirt : Clothe
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pants jeans = new Pants();
            jeans.clotheColor = Color.Blue;

            Shirt someShirt = new Shirt();
            someShirt.clotheColor = Color.White;

            Console.WriteLine(someShirt.clotheColor);

            Console.ReadKey();

        }
    }
}
