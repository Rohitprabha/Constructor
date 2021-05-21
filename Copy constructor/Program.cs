using System;

namespace Copy_Constructor
{
    class CopyCon
    {
        public string name;
        public int number;
        public CopyCon(string name, int number)         // parametrized constructor
        {
            this.name = name;
            this.number = number;
        }
        public CopyCon(CopyCon c)                // copy constructor
        {
            name = c.name;
            number = c.number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CopyCon c1 = new CopyCon("Rohit", 23);     //creating object c1 and provide value to the object

            CopyCon c2 = new CopyCon(c1);           // Creating object c2 and copy the data of c1 object into c2 object

            Console.WriteLine(c1.number);
            Console.WriteLine(c1.name);

            Console.WriteLine(c2.number);
            Console.WriteLine(c2.name);
        }
    }
}
