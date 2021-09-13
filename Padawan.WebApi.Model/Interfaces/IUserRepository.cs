using Padawan.WebApi.Model;
using System.Collections.Generic;

namespace Padawan.WebApi.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Login(User user);
    }
}
