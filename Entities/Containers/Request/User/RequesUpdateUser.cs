
using Entities.Containers.Request.User;

namespace Entities.Containers.Requests.User
{
    public class RequestUpdateUser : RequestSaveUser
    {
        public int id { get; set; }
    }
}
