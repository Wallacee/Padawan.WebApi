using Padawan.WebApi.Infra;
using Padawan.WebApi.Infra.Paging;
using Padawan.WebApi.Model;
using System.Collections.Generic;

namespace Padawan.WebApi.Domain.Interfaces
{
    public interface IPhotoRepository : IRepository<Photo>
    {
        IEnumerable<Photo> FindAllByUserId(int id);
        Photo FindById(int id);
        PagedList<Photo> GetPagined(PagingParameters pagingParameters, int userId);
    }
}
