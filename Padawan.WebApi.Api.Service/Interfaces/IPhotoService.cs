using Padawan.WebApi.Api.Service.ViewModels;
using Padawan.WebApi.Infra.Paging;
using System.Collections.Generic;

namespace Padawan.WebApi.Api.Service.Interfaces
{
    public interface IPhotoService
    {
        //bool Create(PhotoViewModel photoViewModel);
        bool Create(IEnumerable<PhotoViewModel> photoViewModelList);
        List<PhotoViewModel> FindAllByUser(int id);
        PhotoViewModel FindById(int id);
        List<PhotoViewModel> GetPagined(PagingParameters pagingParameters, int userId);

    }
}
