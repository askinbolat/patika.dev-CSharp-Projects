using System;

namespace AreaCalculation
{
    public class AreaCalculation
    {
        public void Calculation()
        {   
            newinput:;
            Console.Write("İşlem yapmak istediğiniz şekli giriniz (Daire,Üçgen,Kare,Dikdörtgen): ");
            string input= Console.ReadLine().ToLower();

            if (input=="kare")
            {
                Console.Write("Karenin kenar uzunluğunu giriniz:");
                int kareKenar =int.Parse(Console.ReadLine());
                Console.Write("Karenin hesaplanmak istenen boyutunu giriniz(Çevre,Alan,Hacim):");
                string kareHesap=Console.ReadLine().ToLower();
                if (kareHesap=="çevre")
                {
                    Console.WriteLine("Karenin çevresi="+kareKenar*4);
                }
                else if (kareHesap=="alan")
                {
                    Console.WriteLine("Karenin alanı="+Math.Pow(kareKenar,2));
                }
                else
                {
                    Console.WriteLine("Karenin Hacimi="+Math.Pow(kareKenar,3));
                }
            }
            else if (input=="daire")
            {
                Console.Write("Dairenin yarıçapını giriniz:");
                double daireYaricap =int.Parse(Console.ReadLine());
                Console.Write("Dairenin hesaplanmak istenen boyutunu giriniz(Çevre,Alan,Hacim):");
                string daireHesap=Console.ReadLine().ToLower();
                if (daireHesap=="çevre")
                {
                    Console.WriteLine("Dairenin çevresi="+2*daireYaricap*Math.PI);
                }
                else if (daireHesap=="alan")
                {
                    Console.WriteLine("Dairenin alanı="+Math.Pow(daireYaricap,2)*Math.PI);
                }
                else
                {
                    Console.WriteLine("Dairenin Hacimi="+(4/3)*Math.Pow(daireYaricap,3)*Math.PI);
                }
            
            }
            else if (input=="üçgen")
            {
                Console.Write("üçgenin kenar uzunluğunu giriniz:");
                int ucgenKenar =int.Parse(Console.ReadLine());
                Console.Write("Üçgenin hesaplanmak istenen boyutunu giriniz(Çevre,Alan):");
                string ucgenHesap=Console.ReadLine().ToLower();
                if (ucgenHesap=="çevre")
                {
                    Console.WriteLine("Üçgenin çevresi="+ucgenKenar*3);
                }
                else if (ucgenHesap=="alan")
                {
                    Console.WriteLine("Üçgenin alanı="+Math.Pow(ucgenKenar,2)*(Math.Sqrt(3)/4));
                }
               
            }
            else if (input=="dikdörtgen")
            {
                Console.Write("Dikdörgenin ilk kenar uzunluğunu giriniz:");
                int dikdörtgenilkKenar =int.Parse(Console.ReadLine());
                Console.Write("Dikdörgenin ikinci kenar uzunluğunu giriniz:");
                int dikdörtgenikinciKenar =int.Parse(Console.ReadLine());
                Console.Write("Dikdörgenin hesaplanmak istenen boyutunu giriniz(Çevre,Alan):");
                string dikdörtgenHesap=Console.ReadLine().ToLower();
                if (dikdörtgenHesap=="çevre")
                {
                    Console.WriteLine("Dikdörtgenin çevresi="+(dikdörtgenilkKenar*2+dikdörtgenikinciKenar*2));
                }
                else if (dikdörtgenHesap=="alan")
                {
                    Console.WriteLine("Karenin alanı="+dikdörtgenilkKenar*dikdörtgenikinciKenar);
                }
                
            }
            else
            {
                Console.WriteLine("Geçersiz bir şekil girdiniz. Lütfen baştan giriniz: ");
                goto newinput;
            }
        }
    }
}