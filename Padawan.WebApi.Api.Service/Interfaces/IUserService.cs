using Padawan.WebApi.Api.Service.ViewModels;
using Padawan.WebApi.Domain.Interfaces;
using Padawan.WebApi.Model;
using System.Collections.Generic;

namespace Padawan.WebApi.Api.Service.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> GetAll();
        bool Create(UserViewModel userViewModel);
        UserViewModel GetById(int id);
        User Login(UserViewModel userViewModel);
        UserAuthenticateResponseViewModel Authenticate(UserViewModel userAuthenticateRequestViewModel);
    }
}
