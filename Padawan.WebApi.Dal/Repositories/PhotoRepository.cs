using Padawan.WebApi.Domain.Interfaces;
using Padawan.WebApi.Infra;
using Padawan.WebApi.Infra.Paging;
using Padawan.WebApi.Model;
using System.Collections.Generic;
using System.Linq;

namespace Padawan.WebApi.Dal.Repositories
{
    public class PhotoRepository : Repository<Photo>, IPhotoRepository
    {
        public PhotoRepository(Context context) : base(context) { }

        public bool Create(List<Photo> photos)
        {
            base.Create(photos);
            return true;
        }

        public IEnumerable<Photo> FindAllByUserId(int UserId)
        {
            return Query(x => x.UserId == UserId && !x.IsDeleted);
        }
        public Photo FindById(int id)
        {
            return Find(x => x.Id == id);
        }

        public PagedList<Photo> GetPagined(PagingParameters pagingParameters, int userId)
        {
            return PagedList<Photo>.GetPagedList(FindAllByUserId(userId).OrderBy(u => u.Id), pagingParameters.PageNumber, pagingParameters.PageSize);
        }


    }
}
