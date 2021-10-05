using System;
using HouseFunction;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Console.WriteLine("Hello World!");
            Program.Example();

            House Armando = new House();

            Console.WriteLine(Armando.Owner);
            Console.WriteLine("just write something");
            Armando.TerminalInput = Console.ReadLine();
            Console.WriteLine("you wrote: " + Armando.TerminalInput);

        }
        public static int Example()
        {
            return 4;
        }
    }
}
