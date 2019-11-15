using System;
using System.Linq;

namespace zadaca3
{
    class Program
    {
        static void Main(string[] args)
        {
            string vnes;

            Console.WriteLine("Vnesi go tesktot.");

            vnes = Console.ReadLine();


            string rezultat = string.Join(" ", vnes.Split(' ').Select(x => new string(x.Reverse().ToArray())));

            Console.WriteLine(rezultat);

            Console.ReadLine();
        }
    }
}