using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Создай класс Pants (штаны), Shirt (рубашка), у каждого из которых будет только одно свойство 
  * – поле с названием Color типа enum (создай отдельно enum Color, который имеет только значения
   * Black,Red,White,Green,Blue). Подумай, что общего между Shirt и Pants. Создай. Отрази эту ситуацию в коде.
   */
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
