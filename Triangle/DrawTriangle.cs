using System;
using System.Reflection.Emit;

namespace triangle
{
    public class DravTriangle
    {
        public void dravTriangle()
        {
           Console.Write("Üçgenin ilk kenar uzunluğunu giriniz :");
           int uzunluk =int.Parse(Console.ReadLine());
           

           for (int i = 0; i <= uzunluk; i++)
           {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
           }

        }
    }
}