﻿using SocialNetWork.BLL.Models;
using SocialNetWork.BLL.Services;
using System;
using System.Collections.Generic;
using System.Text;


namespace SocialNetWork.PLL.Views
{
    public class UserMenuView
    {
        UserService userService;
        public UserMenuView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            while (true)
            {
                Console.WriteLine("Входящие сообщения: {0}", user.IncomingMessages.Count());
                Console.WriteLine("Исходящие сообщения: {0}", user.OutgoingMessages.Count());
                Console.WriteLine("Друзья: {0}", user.MyFriends.Count());
                Console.WriteLine("Просмотреть информацию о моём профиле (нажмите 1)");
                Console.WriteLine("Редактировать мой профиль (нажмите 2)");
                Console.WriteLine("Добавить в друзья (нажмите 3)");
                Console.WriteLine("Написать сообщение (нажмите 4)");
                Console.WriteLine("Просмотреть входящие сообщения (нажмите 5)");
                Console.WriteLine("Просмотреть исходящие сообщения (нажмите 6)");
                Console.WriteLine("Просмотреть запросы в друзья (нажмите 7)");
                Console.WriteLine("Выйти из профиля (нажмите 8)");

                string keyValue = Console.ReadLine();

                if (keyValue == "8") break;

                switch (keyValue)
                {
                    case "1":
                        {
                            Program.userInfoView.Show(user);
                            break;
                        }
                    case "2":
                        {
                            Program.userDataUpdateView.Show(user);
                            break;
                        }

                        case "3":
                        { 
                            Program.friendsView.ShowFriends(user);
                            break;
                        
                        }

                    case "4":
                        {
                            Program.messageSendingView.Show(user);
                            break;
                        }

                    case "5":
                        {

                            Program.userIncomingMessageView.Show(user.IncomingMessages);
                            break;
                        }

                    case "6":
                        {
                            Program.userOutcomingMessageView.Show(user.OutgoingMessages);
                            break;
                        }
                    case "7":
                        {
                            Program.friendsIncomingRequestView.Show(user.MyFriends);
                            break;
                        }
                }
            }

        }
    }
}