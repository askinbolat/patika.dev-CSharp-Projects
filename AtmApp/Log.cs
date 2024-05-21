using System;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;


namespace AtmApp
{
    public class Log
    {
            public void LoginSuccessLog(string Identify,string Name)
            {
                string writeLog = $"{Identify} kimlik numaralı {Name} kişisi {DateTime.Now} - tarihinde başarılı giriş yaptı.";
                TransactionLog(Identify,writeLog);
            }
            
            
            public void LoginFailedLog(string Identify,string Name)
            {
                string writeLog= $"{Identify} kimlik numaralı, {Name} kişisi {DateTime.Now} - tarihinde hatalı giriş yaptı";
                TransactionLog(Identify, writeLog);
            }
           
           
            public void DepositMoneyLog(string identify, string name, string amount,int balance)
            {
                string writeLog = $"{identify} kimlik numaralı {name} kişisi {DateTime.Now} - tarihinde {amount} TL para yatırdı.";
                string[] writeBalanceLog = { $"Adı: {name}", $"Bakiye: {balance}" };
                BalanceLog(identify, writeBalanceLog);
                TransactionLog(identify, writeLog);
            }

            
            
            public void WiewBalanceLog(string identify,string name)
            {
                string writeLog = $"{identify} kimlik numaralı {name} kişisi {DateTime.Now} - tarihinde bakiyeyi görüntüledi.";
                TransactionLog(identify, writeLog);   
            }
           
           
            public void CheckandCreate()
            {
                if (!Directory.Exists(@"C:\Atm App"))
                {
                    Directory.CreateDirectory(@"C:\Atm App");
                    
                    foreach (var item in DataBase.UserList)
                    {
                        string identifyLocation=$@"C:\Atm App\{item.Identify} Log.txt";
                        FileStream fs1= new FileStream(identifyLocation,FileMode.OpenOrCreate,FileAccess.Write);

                        string balanceLogLocation = $@"C:\Atm App\{item.Identify} Account.txt";
                        FileStream fs2 = new FileStream(balanceLogLocation, FileMode.OpenOrCreate, FileAccess.Write);

                        fs1.Close();
                        fs2.Close();
                        
                        string[] userDefaultAccountInfo={ $"Adı: {item.Name}", $"Bakiye: {item.Balance}" };
                        BalanceLog(item.Identify,userDefaultAccountInfo);
                    }
                }
                else
                {
                    string filesLocation = @"C:\Atm App\";
                    string[] getAccountFileNames = Directory.GetFiles(filesLocation, "*Account.txt");
                    string[] getIdFileName = Directory.GetFiles(filesLocation, "*Log.txt");
                    for (int i = 0; i < DataBase.UserList.Count; i++)
                    {
                        string fileLocation = getAccountFileNames[i];
                        string[] getLines = File.ReadAllLines(fileLocation);
                        int balance = int.Parse(getLines[2].Substring(8));

                        string fileName = getIdFileName[i].Substring(11, 11);
                        var userBalance = DataBase.UserList.FirstOrDefault(x => x.Identify == fileName);
                        userBalance.Balance=balance;
                }
            }
        }
        
        
        public void TransactionLog(string identify, string log)
        {
            string idLogLocation = $@"C:\Atm App\{identify} Log.txt";
            FileStream fs1 = new FileStream(idLogLocation, FileMode.OpenOrCreate, FileAccess.Write);
            fs1.Close();
            File.AppendAllText(idLogLocation, Environment.NewLine + log);
        }
        
        
        public void BalanceLog(string identify,string[] balanceLog)
        {
            File.WriteAllLines($@"C:\Atm App\{identify} Account.txt", balanceLog);
        }

    }
}