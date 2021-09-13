using AutoMapper;
using Padawan.WebApi.Api.Service.Interfaces;
using Padawan.WebApi.Api.Service.ViewModels;
using Padawan.WebApi.Auth;
using Padawan.WebApi.Domain.Interfaces;
using Padawan.WebApi.Model;
using System;
using System.Collections.Generic;

namespace Padawan.WebApi.Api.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public IUserRepository UserRepository => userRepository;
        public IMapper Mapper => mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }


        public List<UserViewModel> GetAll()
        {
            return mapper.Map<List<UserViewModel>>(UserRepository.GetAll());
        }

        public bool Create(UserViewModel userViewModel)
        {
            UserRepository.Create(mapper.Map<User>(userViewModel));

            return true;
        }

        public UserViewModel GetById(int id)
        {
            return mapper.Map<UserViewModel>(UserRepository.GetById(id));
        }

        public User Login(UserViewModel userViewModel)
        {
            return UserRepository.Login(mapper.Map<User>(userViewModel));
        }

        public UserAuthenticateResponseViewModel Authenticate(UserViewModel userAuthenticateRequestViewModel)
        {
            User user = UserRepository.Find(x =>
            !x.IsDeleted &&
            x.Email.ToLower() == userAuthenticateRequestViewModel.Email.ToLower() &&
            x.Password.ToLower() == userAuthenticateRequestViewModel.Password.ToLower());

            if (user == null)
                return null;

              return new UserAuthenticateResponseViewModel(mapper.Map<UserViewModel>(user), TokenService.GenerateToken(user));

        }
    }
}
