using System;
using System.Runtime.ConstrainedExecution;

namespace AtmApp
{
    public class DataBase
    {
        private static List<UserInfo> userList;

        static DataBase()
        {
            userList=new()
            {
                new UserInfo{Identify="123456",Name="Duman",Password="1234",Balance=5000,CreditDebt=2500},
                new UserInfo{Identify="432532",Name="Paşa",Password="1242",Balance=10000,CreditDebt=3000},
                new UserInfo{Identify="413445",Name="Puruşa",Password="3242",Balance=5000,CreditDebt=1500}
            };

        }

        public static List<UserInfo> UserList { get => userList; set => userList = value; }
    }
}