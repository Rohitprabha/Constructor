using System;

namespace Static_Constructor
{
    class Program
    {
        static int x;
        int y;
        static Program()
        {
            Console.WriteLine("static constructor called");
            Console.WriteLine("x={0}", x);
            x = 10;
            //y = 30;                                               //Only static fields are initialize
            Console.WriteLine("x={0}", x);
            //Console.WriteLine("y={0}",y);
        }
        public Program(int y)
        {
            Console.WriteLine("Non-static Constructor Called");
            this.y = y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main method called");                //static constructor is called before main method
            Program p = new Program(20);                            //Non-static Conatructor called
            Console.WriteLine(p.y);

            Program p1 = new Program(50);                           //Non-static Conatructor called
            Console.WriteLine(p1.y);

            Console.WriteLine(x);                               //static field directly called
            //Console.WriteLine(y);                               //An object reference is required for non-static

        }
    }
}
