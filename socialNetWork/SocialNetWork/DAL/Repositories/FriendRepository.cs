using SocialNetWork.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetWork.DAL.Repositories
{
    public class FriendRepository : BaseRepository, IFriendRepository
    {
        public IEnumerable<FriendEntity> FindAllByUserId(int userId)
        {
            return Query<FriendEntity>(@"select * from friends where user_id = :user_id", new { user_id = userId });
        }

        public IEnumerable<FriendEntity> FindFriendByUserId(int friendId)
        {
            return Query<FriendEntity>(@"select * from friends where friend_id = :friend_id", new { friend_id = friendId });
        
        
        }

        public int Create(FriendEntity friendEntity)
        {
            return Execute(@"insert into friends (user_id,friend_id) values (:user_id,:friend_id)", friendEntity);
        }

        public int Delete(int id)
        {
            return Execute(@"delete from friends where id = :id_p", new { id_p = id });
        }

    }

    public interface IFriendRepository
    {
        int Create(FriendEntity friendEntity);
        IEnumerable<FriendEntity> FindAllByUserId(int userId);
        IEnumerable<FriendEntity> FindFriendByUserId(int userId);
        int Delete(int id);
    }
}
