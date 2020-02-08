using System;

namespace FizBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var basic = new FizzBuzzBasic2();
            basic.Run();

            Console.Write("\r\nPress ANY key to exit");
            Console.ReadKey();
        }
    }
}
