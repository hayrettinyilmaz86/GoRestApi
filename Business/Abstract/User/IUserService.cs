using Core.Infrastructure.Data.PagedList;
using Core.Infrastructure.Data.Results;
using Entities.Concrete;
using Entities.Containers.Request.User;
using System.Threading.Tasks;
using Entities.Containers.Requests.User;

namespace Business.Abstract.User
{
    public interface IUserService
    {
        Task<ApiPagedListResult<users>> GetUserPagedListbyRequest(RequestGetUserPagedList request);
        Task<ApiSuccessResult<users>> CreateUserbyRequest(RequestCreateUser request);
        Task<ApiSuccessResult<users>> UpdateUserbyRequest(RequestUpdateUser request);
        Task DeleteUserbyRequest(RequestDeleteUser request);
        Task<users> GetUserbyId(int id);
    }
}
