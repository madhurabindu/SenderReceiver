using System;

namespace SenderReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start sending data");
            Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Sender Hello" + i.ToString());
            }
        }
    }
}
