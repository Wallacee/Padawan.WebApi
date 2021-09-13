using AutoMapper;
using Padawan.WebApi.Api.Service.ViewModels;
using Padawan.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padawan.WebApi.Api.Service.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            CreateMap<UserViewModel, User>();
            CreateMap<User, UserViewModel>();

            CreateMap<PhotoViewModel, Photo>();
            CreateMap<Photo, PhotoViewModel>();
        }
    }
}
