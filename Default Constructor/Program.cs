using System;

namespace Default_Constructor
{
    class DefaultCon
    {
        public int num;
        public string name;
        public DefaultCon()                    //this would be invoked while the object of that class created.
        {
            Console.WriteLine("Constructor Called");
            name = "Ram";
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            DefaultCon DefaultCon1 = new DefaultCon();          //invoke default constructor.
            Console.WriteLine(DefaultCon1.num);
            Console.WriteLine(DefaultCon1.name);                //Default constructor provides the default values
        }
    }
}
