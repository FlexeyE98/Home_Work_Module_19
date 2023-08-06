using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetWork.BLL.Models
{
    public class Friend
    {
        public int Id { get; }
        public int UserId { get;}
        public int FriendId { get;}

        public Friend(int id, int userId, int friendId) 
        {
            this.Id = id;
            this.UserId = userId;
            this.FriendId = friendId;
        
        }
    }
}
