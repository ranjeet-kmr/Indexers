using System;


namespace Indexers
{
     //delegate void Adddelegate(int x, int y);
     //delegate string saydelegate(string s);
    class Delegate
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine( a + b);
        }

        public  string Hello(string name)
        {
            return "Hello" + name;
        }

        static void Main()
        {
            //var k = new Delegate();
            //Console.WriteLine("using instance for non-static methods");
            //var d = new Delegate();
            //d.Add(12, 21);
            //Console.WriteLine("using class name for static methods");
            //string str = Delegate.Hello(" " + "Ranjeet" );
            //Console.WriteLine(str);


            //Delegate m = new Delegate();
            //m.Add(12,11);
            //m.Hello("pk");
            //Console.WriteLine("using delegate to call the method");
            //var a = new Adddelegate(k.Add);
            //a.Invoke(11,12);

            //var ad = new Adddelegate(d.Add);
            //ad(12,32);
            //ad.Invoke(100, 21);
            //var hd = new saydelegate(Hello);
            //var rnj = hd("Ranjeet");
            //var inv = hd.Invoke("Invoke delegate");
            //Console.WriteLine(str + " " + inv);

            Action<int, int> act = Add;
            act.Invoke(12,13);

            // callRectangle any = delegate(double j , double b) anonomous method

            //Action<int, int> v = delegate (int a, int b)
            //{
            //    v.Invoke(12, 11);
            //};
            

            Action<int, int> ac = (a,b)=> {
                Console.WriteLine(a + b);
            };



            Console.ReadLine();
        }
    }
}
