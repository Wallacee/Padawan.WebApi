using System;

namespace Padawan.WebApi.Api.Service.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Update { get; set; }
    }
}
