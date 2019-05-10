using System;
using DF.Test.AsyncTest;

namespace AsyncTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BL bl = new BL();
            Console.WriteLine("Hello World!");
            bl.DoSomethingsNoAwaitAsync().Wait();
            Console.WriteLine();
            Console.WriteLine("And we're back!");
            Console.ReadLine();
        }
    }
}
