using SocialNetWork.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using SocialNetWork.BLL.Models;
using SocialNetWork.DAL.Entities;
using SocialNetWork.BLL.Exceptions;

namespace SocialNetWork.BLL.Services
{
    public class FriendsService
    {
        IFriendRepository friendRepository;
        IUserRepository userRepository;

        public FriendsService()
        {
            friendRepository = new FriendRepository();
            userRepository = new UserRepository();
        }

        public IEnumerable<Friend> MyFriendId(int recipientId)
        {
            var friends = new List<Friend>();
            friendRepository.FindAllByUserId(recipientId).ToList().ForEach(f =>
            {
                var recipientUser = userRepository.FindById(f.user_id);

                friends.Add(new Friend(f.id, f.user_id, recipientUser.id));
            });

            friendRepository.FindFriendByUserId(recipientId).ToList().ForEach((f) =>
            {
                var senderUser = userRepository.FindById(f.friend_id);
                friends.Add(new Friend(f.id, f.user_id, senderUser.id));

            });
            return friends;

        }

        public void AddFriend(FriendData friendData)
        {
            var addUser = userRepository.FindByEmail(friendData.Email);

            if (friendData is null) throw new UserNotFoundException();

            var friendEntity = new FriendEntity()
            {
                id = friendData.ID,
                user_id = friendData.SenderId,
                friend_id = addUser.id,
            };


            if (friendRepository.Create(friendEntity) == 0)
                throw new Exception();
        }
    }

}



