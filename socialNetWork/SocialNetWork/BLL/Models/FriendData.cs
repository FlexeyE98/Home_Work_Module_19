using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetWork.BLL.Models
{
    public class FriendData
    {
        public int ID { get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public string Email { get; set; }

    }
}
