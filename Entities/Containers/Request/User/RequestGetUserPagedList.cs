using Core.Infrastructure.Request.Base;
using Entities.Enums;

namespace Entities.Containers.Request.User
{
    public class RequestGetUserPagedList : BaseRequestPagedList
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public EnumGender? gender { get; set; }        
        public EnumStatus? status { get; set; } 
    }
}
