using Entities.Enums;

namespace Entities.Containers.Request.User
{
    public class RequestSaveUser
    {
        public string name { get; set; }
        public string email { get; set; }
        public EnumGender _gender { get; set; }
        public string gender => _gender.ToString();
        public EnumStatus _status { get; set; }
        public string status => _status.ToString();
    }
}
