using SocialNetWork.BLL.Services;
using System;
using System.Collections.Generic;
using System.Text;
using SocialNetWork.BLL.Models;
using SocialNetWork.PLL.Helpers;
using SocialNetWork.BLL.Exceptions;

namespace SocialNetWork.PLL.Views
{
    public class FriendsView
    {
        UserService userService;
        FriendsService friendsService;

        public FriendsView(FriendsService friendsService, UserService userService)
        {
            this.friendsService = friendsService;
            this.userService = userService;
        }

        public void ShowFriends(User user)
        {
            var friendData = new FriendData();

            Console.WriteLine("Для добавления в друзья введите почту друга: ");
            friendData.Email = Console.ReadLine();
            friendData.SenderId = user.Id;
            
            try
            {
                friendsService.AddFriend(friendData);
                SuccessMessage.Show("Запрос в друзья успешно отправлен!");
                user = userService.FindByEmail(friendData.Email);
            }
 
               catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }
        
        }
    }
}
