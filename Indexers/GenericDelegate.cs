using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class GenericDelegate
    {
        public static double Add(int a , double b , float c)
        {
            return a + b + c;
        }

        public static void Diff(int a, double b, float c)
        {
            Console.WriteLine(a - b - c);
        }

        public static bool checklength(string s)
        {
            if (s.Length > 3)
                return true;
            return false;
        }

        static void Main()
        {
            Func<int, double, float, double> func = Add;
            double d = func.Invoke(12, 12.10, 2f);
            Console.WriteLine("Func Delegate called :" + d);
            Console.WriteLine("------------------------------------------");
            Action<int,double,float> act = (a,b,c)=> Console.WriteLine("Action delegate Called :" + (a + b + c));
            act.Invoke(12, 12.01, 12f);
            Console.WriteLine("--------------------------------------------------------------------------");
            Predicate<string> prd = checklength;
            bool s = prd.Invoke("Ranjeet");
            Console.WriteLine("Predicate delegate called :" + s);
            Console.WriteLine("--------------------------------------------------------------------------");
            Action<int, double, float> ac = Diff;
            ac.Invoke(122,21.12,12.1F);           
            Console.WriteLine("Predicate delegate called :" + s);
            Console.ReadLine();
        }
    }
}
