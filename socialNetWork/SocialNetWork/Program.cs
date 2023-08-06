using SocialNetWork.BLL.Exceptions;
using SocialNetWork.BLL.Models;
using SocialNetWork.BLL.Services;
using SocialNetWork.PLL.Views;

namespace SocialNetWork
{
    class Program
    {
        static MessageService messageService;
        static UserService userService;
        public static MainView mainView;
        public static RegistrationView registrationView;
        public static AuthenticationView authenticationView;
        public static UserMenuView userMenuView;
        public static UserInfoView userInfoView;
        public static UserDataUpdateView userDataUpdateView;
        public static MessageSendingView messageSendingView;
        public static UserIncomingMessageView userIncomingMessageView;
        public static UserOutcomingMessageView userOutcomingMessageView;
        public static FriendsService friendsService;
        public static FriendsIncomingRequestView friendsIncomingRequestView;
        public static FriendsView friendsView;

        static void Main(string[] args)
        {
            userService = new UserService();
            messageService = new MessageService();
            friendsService = new FriendsService();
            friendsIncomingRequestView = new FriendsIncomingRequestView();
            friendsView = new FriendsView(friendsService, userService);

            mainView = new MainView();
            registrationView = new RegistrationView(userService);
            authenticationView = new AuthenticationView(userService);
            userMenuView = new UserMenuView(userService);
            userInfoView = new UserInfoView();
            userDataUpdateView = new UserDataUpdateView(userService);
            messageSendingView = new MessageSendingView(messageService, userService);
            userIncomingMessageView = new UserIncomingMessageView();
            userOutcomingMessageView = new UserOutcomingMessageView();

            while (true)
            {
                mainView.Show();
            }
        }
    }
}




      
