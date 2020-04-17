using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    static class ExtensionMethod
    {
        
        public static long Factorial(this Int32 x)
        {
            if (x == 0)
                return 1;
            else if (x == 1)
                return 1;
            else if (x == 2)
                return 2;
            return x * Factorial(x - 1);
        }

        static void Main()
        {
            int i = 6;

            long s = i.Factorial();
            //long s = ExtensionMethod.Factorial(5);
           //long s = i.Factorial();
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
