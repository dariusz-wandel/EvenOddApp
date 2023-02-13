using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            var userNumber = GetNumber();

            if (userNumber % 2 == 0)
                Console.WriteLine("Wprowadzona liczba jest parzysta.");
            else
                Console.WriteLine("Wprowadzona liczba jest nieparzysta.");
        }

        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Wprowadzona wartość nie jest prawidłową liczbą. Spróbuj jeszcze raz.");
                    continue;
                }
                return number;
            }
        }
    }
}
