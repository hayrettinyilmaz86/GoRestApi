
using Entities.Enums;

namespace WinUI.Model.User
{
    public class SaveUserModel
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public EnumGender gender { get; set; }
        public EnumStatus status { get; set; }
    }
}
