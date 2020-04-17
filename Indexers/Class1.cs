using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Class1
    {
        public static void add(int a , int b)
        {
            Console.WriteLine(a+b);
        }
    }

    class Class2
    {
        public static void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Main()
        {
            Class1.add(12,11);
            //var 
            Console.ReadLine();
            
        }
    }
}
