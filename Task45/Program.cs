using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task45
{

    struct Vector4
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public DateTime dateTime { get; set; }

        public Vector4(float X, float Y, float Z, DateTime dateTime)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.dateTime = dateTime;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2011, 01, 11);
            DateTime date2 = new DateTime(2012, 02, 12);
            DateTime date3 = new DateTime(2013, 03, 13);

            Vector4 point1 = new Vector4(0.0f, 0.0f, 0.0f, date1);
            Vector4 point2 = new Vector4(1.0f, 1.0f, 1.0f, date2);
            Vector4 point3 = new Vector4(2.0f, 2.0f, 2.0f, date3);

            Console.ReadKey();
        }
    }
}
