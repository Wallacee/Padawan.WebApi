using Microsoft.Extensions.DependencyInjection;
using Padawan.WebApi.Api.Service.Interfaces;
using Padawan.WebApi.Api.Service.Services;
using Padawan.WebApi.Dal.Repositories;
using Padawan.WebApi.Domain.Interfaces;

namespace Padawan.WebApi.IoC
{
    public static class NativeInjector
    {
        public static void RegisterService(IServiceCollection services)
        {
            #region Services

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPhotoService, PhotoService>();

            #endregion

            #region Repositories

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPhotoRepository, PhotoRepository>();

            #endregion
        }
    }
}
