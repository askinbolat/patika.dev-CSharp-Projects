using System;
using System.Reflection.Emit;

namespace triangle
{
    public class DravTriangle
    {
        public void dravTriangle()
        {
            Console.WriteLine("Üçgenin ilk kenar uzunluğunu giriniz   :");
            int a =int.Parse(Console.ReadLine());
            Console.WriteLine("Üçgenin ikinci kenar uzunluğunu giriniz   :");
            int b =int.Parse(Console.ReadLine());
            Console.WriteLine("Üçgenin üçüncü kenar uzunluğunu giriniz   :");
            int c =int.Parse(Console.ReadLine());

            if ((a<=Math.Abs(b+c)&&a>=Math.Abs(b-c))&&(b<=Math.Abs(a+c)&&b>=Math.Abs(a-c))&&(c<=Math.Abs(b+a)&&c>=Math.Abs(b-a)))
            {
                Console.WriteLine("Üçgen başarıyla oluşturuldu. Kenar uzunlukları {0},{1},{2}:",a,b,c);
            }
            else
            {
                Console.WriteLine("Girilen değerler üçgen oluşturmak için gerekli koşulu sağlamıyor");
            }

        }
    }
}