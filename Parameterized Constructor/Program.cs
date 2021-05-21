using System;

namespace Parameterized_Constructor
{
    class ParameterizedCon
    {
        public int num;
        public string name;
        public ParameterizedCon(int num, string name)                    //this would be invoked while the object of that class created.
        {
            this.num = num;
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedCon ParameterizedCon1 = new ParameterizedCon(1,"Ram");          //invoke Parameterized constructor.
            Console.WriteLine(ParameterizedCon1.num);
            Console.WriteLine(ParameterizedCon1.name);

            ParameterizedCon ParameterizedCon2 = new ParameterizedCon(2, "Rohit");          //invoke Parameterized constructor.
            Console.WriteLine(ParameterizedCon2.num);
            Console.WriteLine(ParameterizedCon2.name);
        }
    }
}
