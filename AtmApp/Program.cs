using System;
using System.Security.Cryptography.X509Certificates;

namespace AtmApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            TryChoose:
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz...");
            Console.WriteLine("Para Çekmek (1)\nPara Yatırnak (2)\nKredi Kartı Borcu Ödemesi Yapmak (3)\nBakiye Sorgulamak(4)");
            int choosenTransaction =int.Parse(Console.ReadLine());
            
            Transactions instTransactions =new Transactions();
            switch (choosenTransaction)
            {
                case 1:
                    instTransactions.withDrawMoney();
                    break;
                case 2:
                    instTransactions.Deposite();
                    break;
                case 3:
                    instTransactions.CreditDebtPayment();
                    break;
                case 4:
                    instTransactions.BalanceCheck();
                    break;

                default:
                    Console.WriteLine("Yanlış seçim yaptınız.Yapmak istediğiniz işlemi tekrardan giriniz.");
                    goto TryChoose;
                    
            }
          
           
        }
    }
}