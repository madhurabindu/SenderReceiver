using System;

namespace Receiver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start receiving data");
            Console.ReadLine();
            Console.WriteLine("Waiting for data .... ");
            for (int i = 0; i < 10; i++)
            {
                string input  = Console.ReadLine();
                Console.WriteLine("Receiver: " + input);
            }
        }
    }
}
