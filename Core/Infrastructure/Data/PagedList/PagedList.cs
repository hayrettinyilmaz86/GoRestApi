using Core.Infrastructure.Data.Results;
using Core.Infrastructure.Entities;
using System.Collections.Generic;

namespace Core.Infrastructure.Data.PagedList
{
    public class ApiPagedListResult<T> : ApiSuccessResult<List<T>> where T : class, IEntity, new()
    {
        public PagedListMeta meta { get; set; }
    }
}
