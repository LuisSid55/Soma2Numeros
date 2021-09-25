using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("\n------Soma------");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\nPrimeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\nSegundo número:  ");
            n2 = Convert.ToInt32(Console.ReadLine());

            n3 = n1 + n2;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nA resposta é:    {n3}\n");
            Console.ResetColor();
        }
    }
}
