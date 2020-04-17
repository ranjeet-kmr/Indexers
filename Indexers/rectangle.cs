using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{

    public delegate void callRectangle(double a, double b);
   sealed  class rectangle
    {
        public static void Area(double length, double breadth)
        {
            Console.WriteLine("Area of Rectangle : " + length *breadth);
        }

        public static void Perimeter(double length, double breadth)
        {
            Console.WriteLine("Perimeter of Rectangle : " + 2 *(length + breadth));
        }


        static void Main()
        {
            Console.WriteLine("using name of the class");
            rectangle.Area(12.32, 34.21);
            rectangle.Perimeter(34.10,11.10);

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("using delegate to call the method");
            var d = new callRectangle(Area);
            d.Invoke(12.32, 34.21);
            var c = new callRectangle(Perimeter);
            c.Invoke(12.32, 34.21);

            // call them with single instance of delegate

            callRectangle l  = Area;
            l += Perimeter;
            l.Invoke(54.12, 34.21);

            Console.WriteLine("----------------------------");
            Console.WriteLine("using anonoumous methods");

            // callRectangle any = delegate(double j , double b) anonomous method 
            callRectangle any =  ( j,  b) => //lambda function
            {
                Console.WriteLine("Anonomous method call: " + j*b);
            };
            any.Invoke(11.10, 12.10);
            Console.ReadLine();

        }

    }
}
