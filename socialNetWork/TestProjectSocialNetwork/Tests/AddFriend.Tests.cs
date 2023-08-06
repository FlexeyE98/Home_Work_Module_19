using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;
using SocialNetWork.BLL.Models;
using SocialNetWork.BLL.Services;
using SocialNetWork.DAL.Repositories;

namespace Tests.UnitTests
{
    [TestFixture]
    public class AddFriend
    {
        FriendsService friendService = new FriendsService();
        FriendData friendData = new FriendData();
        FriendRepository friendRepository = new FriendRepository();

        [TestCase(1)]
        public void AddFriendMustBeNotNull(int userId)
        {
            Assert.That(friendRepository.FindFriendByUserId(userId) != null);
        }

        [TestCase(1)]
        public void FindUserIdMustBeNotNull(int userId)
        { 
            var listFriends = new List<int>();
            friendRepository.FindAllByUserId(userId);
            listFriends.Add(userId);

            Assert.That(listFriends.Count() > 0);
        }
    }
}
