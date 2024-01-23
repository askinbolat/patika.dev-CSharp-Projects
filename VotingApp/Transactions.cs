using System;
using System.Runtime.ConstrainedExecution;

namespace VotingApp
{
    public class Transactions
    {
        public static void Vote()
        {
            Console.WriteLine("Kullanıcı adınızı giriniz:");
            string controlUsername=Console.ReadLine().ToLower();
            Datas instance =new Datas();

            if (instance.userList.Any(u=>u.username==controlUsername))
            {
                Console.WriteLine("Oy vermek istediğiniz kategorinin numarasını giriniz");
                int chosenCategoryId =int.Parse(Console.ReadLine());
                if (instance.categoryList.Any(c=>c.categoryId==chosenCategoryId))
                {
                    var chosenCategory=instance.categoryList.FirstOrDefault(c=>c.categoryId==chosenCategoryId);
                    chosenCategory.categoryId++;
                    Console.WriteLine("Oylama başarılı");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Yanlış bir numara girdiniz");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Kullanıcı kayıtlı değil. İlk önce kayıt olmalısınız.");
                Console.WriteLine("Kayıt olmak istediğiniz kullanıcı adınızı giriniz");
                string newUser=Console.ReadLine();
                instance.userList.Add(new Users{username=newUser});
            }
        }

        public static void Results()
        {
            Datas instance =new Datas();
            double toplam=0;
            foreach (var item in instance.categoryList)
            {
                toplam+=item.categoryVote;
            }
            foreach (var item in instance.categoryList)
            {
                Console.WriteLine($"---{item.CategoryName} isimli kategorinin aldığı oy sayısı {item.categoryVote}\nOy yüzdesi="+(100/toplam));
                
            }
            Console.ReadLine();
        }
    }
}