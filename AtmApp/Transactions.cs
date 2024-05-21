using System;

namespace AtmApp
{
    public class Transactions
    {
        DataBase newDataBase=new DataBase();
        Log newLog=new Log();
       public void withDrawMoney()
       {
            TryWithDrawMoney:
            Console.Write("Kimlik numaranızı giriniz:");
            string identify=Console.ReadLine();
            Console.Write("Kart şifrenizi giriniz:");
            string password=Console.ReadLine();

            var userIdentify=DataBase.UserList.FirstOrDefault(k=>k.Identify==identify);
            
            if (userIdentify != null && userIdentify.Password==password)
            {   
                newLog.LoginSuccessLog(userIdentify.Identify,userIdentify.Name);
                Console.WriteLine($"Sayın {userIdentify.Name}, çekmek istediğiniz tutarı giriniz:");
                int amount= Math.Abs(int.Parse(Console.ReadLine()));
                if (amount<userIdentify.Balance)
                {
                    Console.WriteLine("Hesabınızda yeterli miktar bulunmamaktadır.");
                }
                else
                {
                    userIdentify.Balance-=amount;
                    Console.WriteLine("Para çekme işlemi başarılı.");
                }
            }
            else
            {   
                newLog.LoginFailedLog(userIdentify.Identify,userIdentify.Name);
                Console.WriteLine("Girdiğiniz bilgiler yanlış.\nBilgilerinizi kontrol ederek tekrar deneyiniz...");

                goto TryWithDrawMoney;
            }
       }


        public void Deposite()
        {
            TryDeposite:
            Console.Write("Kimlik numaranızı giriniz:");
            string identify=Console.ReadLine();
            Console.Write("Kart şifrenizi giriniz:");
            string password=Console.ReadLine();

            var userIdentify=DataBase.UserList.FirstOrDefault(k=>k.Identify==identify);
            
            if (userIdentify != null && userIdentify.Password==password)
            {
                newLog.LoginSuccessLog(userIdentify.Identify,userIdentify.Name);
                Console.WriteLine($"Sayın {userIdentify.Name}, yatırmak istediğiniz tutarı giriniz:");
                int amount= Math.Abs(int.Parse(Console.ReadLine()));
                
                userIdentify.Balance+=amount;
                newLog.DepositMoneyLog(userIdentify.Identify,userIdentify.Name,userIdentify.Name,userIdentify.Balance);
            }
            else
            {
                newLog.LoginFailedLog(userIdentify.Identify,userIdentify.Name);
                Console.WriteLine("Girdiğiniz bilgiler yanlış.\nBilgilerinizi kontrol ederek tekrar deneyiniz...");

                goto TryDeposite;
            }
        }
        
        public void CreditDebtPayment()
        {
            TryCreditDebt:
            Console.Write("Kimlik numaranızı giriniz:");
            string identify=Console.ReadLine();
            Console.Write("Kart şifrenizi giriniz:");
            string password=Console.ReadLine();

            var userIdentify=DataBase.UserList.FirstOrDefault(k=>k.Identify==identify);
            
            if (userIdentify != null && userIdentify.Password==password)
            {
                newLog.LoginSuccessLog(userIdentify.Identify,userIdentify.Name);
                Console.WriteLine($"Sayın {userIdentify.Name}, kredi borcunuz={userIdentify.CreditDebt}");
                Console.WriteLine("Kredi kartı borcunuzu ödemek için (1) tuşlayınız ");
                int CreditDebtChoose=int.Parse(Console.ReadLine());
                if (CreditDebtChoose==1)
                {
                    if (userIdentify.Balance>=userIdentify.CreditDebt)
                    {
                        userIdentify.Balance-=userIdentify.CreditDebt;
                        userIdentify.CreditDebt=0;
                        Console.WriteLine("Kredi kartı borcunuz ödendi");
                    }
                    else
                    {
                        Console.WriteLine("Hesabınızda yeterli miktar bulunmamaktadır.");
                    }
                }
                else
                {
                    
                    Console.WriteLine("Hatalı tuşlama yaptınız.");
                    goto TryCreditDebt;
                }
               
            }
            else
            {
                newLog.LoginFailedLog(userIdentify.Identify,userIdentify.Name);
                Console.WriteLine("Girdiğiniz bilgiler yanlış.\nBilgilerinizi kontrol ederek tekrar deneyiniz...");

                goto TryCreditDebt;
            }
        }

        public void BalanceCheck()
        {
            TryBalanceCheck:
            Console.Write("Kimlik numaranızı giriniz:");
            string identify=Console.ReadLine();
            Console.Write("Kart şifrenizi giriniz:");
            string password=Console.ReadLine();

            var userIdentify=DataBase.UserList.FirstOrDefault(k=>k.Identify==identify);
            
            if (userIdentify != null && userIdentify.Password==password)
            {   
                newLog.LoginSuccessLog(userIdentify.Identify,userIdentify.Name);
                Console.WriteLine($"Sayın {userIdentify.Name}, hesabınızda {userIdentify.Balance} TL bulunmaktadır.");
                newLog.WiewBalanceLog(userIdentify.Identify,userIdentify.Name);
                
            }
            else
            {
                newLog.LoginFailedLog(userIdentify.Identify,userIdentify.Name);
                Console.WriteLine("Girdiğiniz bilgiler yanlış.\nBilgilerinizi kontrol ederek tekrar deneyiniz...");

                goto TryBalanceCheck;
            }
        }
    }
}

