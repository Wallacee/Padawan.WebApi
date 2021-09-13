using Padawan.WebApi.Domain.Interfaces;
using Padawan.WebApi.Model;
using System.Collections.Generic;

namespace Padawan.WebApi.Dal.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(Context context) : base(context) { }

        public IEnumerable<User> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }

        public User GetById(int id)
        {
            return Find(x => x.Id == id && !x.IsDeleted);
        }

        public User Login(User user)
        {
            return Find(x => x.Email == user.Email && x.Password == user.Password);
        }
    }
}
