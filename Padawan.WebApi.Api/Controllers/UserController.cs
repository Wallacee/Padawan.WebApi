using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Padawan.WebApi.Api.Service.Interfaces;
using Padawan.WebApi.Api.Service.ViewModels;

namespace Padawan.WebApi.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public IUserService UserService => userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(UserService.GetAll());
        }

        [Route("Create")]
        [HttpPost]
        public IActionResult Create(UserViewModel userViewModel)
        {
            return Ok(UserService.Create(userViewModel));
        }

        [Route("FindById")]
        [HttpGet]
        public IActionResult FindById(int id)
        {
            return Ok(UserService.GetById(id));
        }

        [EnableCors("EnableCORS")]
        [Route("Login")]
        [HttpPost]
        public IActionResult Login(UserViewModel userViewModel)
        {
            var _userViewModel = UserService.Authenticate(userViewModel);

            if (_userViewModel != null)
                return Ok(_userViewModel);
            else
                return NotFound();
        }

        [EnableCors("EnableCors")]
        [Route("Authenticate")]
        [HttpPost]
        public IActionResult Authenticate(UserViewModel userAuthenticateRequestViewModel)
        {
            var _userViewModel = UserService.Authenticate(userAuthenticateRequestViewModel);

            if (_userViewModel != null)
                return Ok(_userViewModel);
            else
                return NotFound();
        }
    }
}
