namespace Padawan.WebApi.Api.Service.ViewModels
{
    public class UserAuthenticateResponseViewModel
    {
        public UserViewModel UserViewModel { get; set; }
        public string Token { get; set; }

        public UserAuthenticateResponseViewModel(UserViewModel userViewModel, string token)
        {
            UserViewModel = userViewModel;
            Token = token;
        }
    }
}
