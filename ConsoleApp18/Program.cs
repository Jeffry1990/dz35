using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите символ: ");
            string symbol = Console.ReadLine();

            int additionalLength = 4;
            string additionalSymbol = "";

            for (int i = 1; i <= (name.Length + additionalLength); i ++ )
            {
                additionalSymbol += symbol;
            }

            Console.WriteLine(additionalSymbol);
            Console.WriteLine(symbol + " " + name + " " + symbol);
            Console.WriteLine(additionalSymbol);
        }
    }
}
