using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Padawan.WebApi.Api.Service.Interfaces;
using Padawan.WebApi.Api.Service.ViewModels;
using Padawan.WebApi.Infra.Paging;
using System.Collections.Generic;

namespace Padawan.WebApi.Api.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly IPhotoService photoService;

        public IPhotoService PhotoService => photoService;

        public PhotoController(IPhotoService photoService)
        {
            this.photoService = photoService;
        }

        //[Route("Create")]
        //[HttpGet]
        //public IActionResult Create(PhotoViewModel photoViewModel)
        //{
        //    return Ok(PhotoService.Create(photoViewModel));
        //}

        [Route("Create")]
        [HttpPost]
        public IActionResult Create(IEnumerable<PhotoViewModel> photoViewModelList)
        {
            return Ok(PhotoService.Create(photoViewModelList));
        }

        [Route("FindAllByUser")]
        [HttpGet]
        public IActionResult FindAllByUser(int userId)
        {
            return Ok(PhotoService.FindAllByUser(userId));
        }

        [Route("FindById")]
        [HttpGet]
        public IActionResult FindById(int id)
        {
            return Ok(PhotoService.FindById(id));
        }

        [EnableCors("EnableCORS")]
        [Route("FindPagined")]
        [HttpPost]
        public IActionResult FindPagined(PagingParameters pagingParameters, int userId)
        {
            return Ok(PhotoService.GetPagined(pagingParameters, userId));
        }
    }
}
