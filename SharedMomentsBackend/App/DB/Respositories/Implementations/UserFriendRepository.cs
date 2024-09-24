using SharedMomentsBackend.App.DB.Respositories.Base.Implementations;
using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.DB.Respositories.Interfaces;
using SharedMomentsBackend.App.Models.DTOs.Moment;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.Entities;
using System.Linq.Expressions;
using SharedMomentsBackend.App.Extensions;

namespace SharedMomentsBackend.App.DB.Respositories.Implementations
{
    public class UserFriendRepository : GenericRepository<UserFriend>, IUserFriendRepository
    {
        public UserFriendRepository(IUnitOfWork context) : base(context)
        {
        }
    }
}
