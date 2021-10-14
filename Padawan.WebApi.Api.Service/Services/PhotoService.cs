using AutoMapper;
using Padawan.WebApi.Api.Service.Interfaces;
using Padawan.WebApi.Api.Service.ViewModels;
using Padawan.WebApi.Domain.Interfaces;
using Padawan.WebApi.Infra.Paging;
using Padawan.WebApi.Model;
using System.Collections.Generic;

namespace Padawan.WebApi.Api.Service.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly IPhotoRepository photoRepository;
        private readonly IMapper mapper;

        public IPhotoRepository PhotoRepository => photoRepository;
        public IMapper Mapper => mapper;

        public PhotoService(IPhotoRepository photoRepository, IMapper mapper)
        {
            this.photoRepository = photoRepository;
            this.mapper = mapper;
        }


        public List<PhotoViewModel> FindAllByUser(int id)
        {
            return mapper.Map<List<PhotoViewModel>>(photoRepository.FindAllByUserId(id));
        }

        public PhotoViewModel FindById(int id)
        {
            return mapper.Map<PhotoViewModel>(photoRepository.FindById(id));
        }

        public List<PhotoViewModel> GetPagined(PagingParameters pagingParameters, int userId)
        {
            return mapper.Map<List<PhotoViewModel>>(photoRepository.GetPagined(pagingParameters, userId));
        }

        public bool Create(PhotoViewModel photoViewModel)
        {
            mapper.Map<Photo>(photoViewModel);

            return true;
        }

        public bool Create(IEnumerable<PhotoViewModel> photoViewModelList)
        {
            photoRepository.Create(mapper.Map<List<Photo>>(photoViewModelList));
            return true;
        }
    }
}
