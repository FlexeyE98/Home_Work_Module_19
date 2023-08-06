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
        [Test]
        public void AddFriendMustNotBeNull(int userId)
        {
            var friendService = new FriendsService();
            var friendData = new FriendData();
            var friendRepository = new FriendRepository();


            Assert.That(friendRepository.FindFriendByUserId(userId) != null);



        }


    }
}
