using System;

namespace VotingApp
{
    public class Datas
    {
        public List<Users> userList;
        public List<Categories> categoryList;
        public Datas()
        {
            userList =new()
            {
            new Users{username="duman"},
            new Users{username="pasa"},
            new Users{username="purusa"}
            };

            categoryList=new()
            {
                new Categories{categoryId=55,CategoryName="Horror",categoryVote=1},
                new Categories{categoryId=52,CategoryName="Adventure",categoryVote=1},
                new Categories{categoryId=34,CategoryName="Action",categoryVote=1},
                new Categories{categoryId=67,CategoryName="Crime",categoryVote=1},
                new Categories{categoryId=29,CategoryName="Fiction",categoryVote=1}
            };
            

        }
    }
}