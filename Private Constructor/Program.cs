using System;

namespace Private_Constructor
{
    public class PrivateCon
    {
        public static int currentCount;                     //Only static members because static members can be called without creating the instance
        private PrivateCon()                                //Private constructor without parameter
        {
            
        }
        private PrivateCon(int currentCount)                                //Private constructor with parameter
        {
            Console.WriteLine("Private Constructor");
            PrivateCon.currentCount = currentCount;                          //cannot access it with this keyword
        }

        public static int IncrementCount()
        {
            return ++currentCount;
        }
    }
    //class Class1 : PrivateCon                         //error PrivateCon.PrivateCon()' is inaccessible due to its protection level
    //{
    //}                               
    class Program
    {
        static void Main(string[] args)
        {
            //PrivateCon obj = new PrivateCon();              //error 'PrivateCon.PrivateCon()' is inaccessible due to its protection level
            Console.WriteLine(PrivateCon.currentCount);
            Console.WriteLine(PrivateCon.IncrementCount());
            PrivateCon.currentCount = 75;
            Console.WriteLine(PrivateCon.IncrementCount());
            PrivateCon.currentCount = 10;
            Console.WriteLine(PrivateCon.IncrementCount());
        }
    }
}
