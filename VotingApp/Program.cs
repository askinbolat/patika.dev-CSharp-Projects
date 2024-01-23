using System;
using System.Net.Http.Headers;

namespace VotingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Datas instance =new Datas();
            foreach (var item in instance.categoryList)
            {
                Console.WriteLine($"Kategori numaraları {item.categoryId}-Kategori isimleri {item.CategoryName}");
            }
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Oy vermek için (1)\nSonuçları görmek için (2) tuşlayınız.");
            int choose=int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Transactions.Vote();
                    break;
                case 2:
                    Transactions.Results();
                    break;
                default:
                    break;
            }

            
        }
    }
}