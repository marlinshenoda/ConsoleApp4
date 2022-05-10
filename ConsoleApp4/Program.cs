using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv your namn");
            var namn=Console.ReadLine();
            Console.WriteLine("skriv your lön");
            int lön = int.Parse(Console.ReadLine());
            Console.WriteLine(namn+"ha lön"+lön);
        }
    }
}
