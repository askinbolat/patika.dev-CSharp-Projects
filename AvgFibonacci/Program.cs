using System;

namespace fibonacciAvarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ortalaması hesaplanacak fibonacci serisinin derinliğini giriniz: ");
            int depth =int.Parse(Console.ReadLine());
            fibonacciAvarage.Avarage(depth);
        }
    }
}