using SocialNetWork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetWork.PLL.Views
{
    public class FriendsIncomingRequestView

    {
        public void Show(IEnumerable<Friend> outcomingFriends)
        {
            Console.Write("Друзья: ");
            if (outcomingFriends.Count() == 0)
            {
                Console.WriteLine("Друзей пока нет :(");
                return;
            }
            outcomingFriends.ToList().ForEach(f =>
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ID пользователя: {0}", f.FriendId);
                Console.ForegroundColor = ConsoleColor.White;
            });
        }
    }
}
