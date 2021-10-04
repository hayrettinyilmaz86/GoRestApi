using Business.Abstract.User;
using Business.Concrete.Manager;
using Entities.Enums;
using System;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest
{
    public class UnitTesting
    {

        #region Property  
        public IUserService userService = new UserManager();
        #endregion

        [Fact]
        public async void UserTests()
        {
            await CreateUser();
        }
        private async Task CreateUser()
        {
            var randomNumber = new Random().Next(10000, 100000);
            var email = $"mail{randomNumber}@mail.com";
            var name = $"name{randomNumber}";
            var status = EnumStatus.active;
            var gender = EnumGender.male;

            var result = await userService.CreateUserbyRequest(new Entities.Containers.Requests.User.RequestCreateUser
            {
                name = name,
                email = email,
                _gender = gender,
                _status = status
            });
            Assert.True(result.data.id > 0);
            Assert.Equal(result.data.email, email);
            Assert.Equal(result.data.name, name);
            Assert.Equal(result.data.gender, gender.ToString());
            Assert.Equal(result.data.status, status.ToString());

            await GetUserById(result.data.id);

        }
        private async Task GetUserById(int userId)
        {
            var user = await userService.GetUserbyId(userId);
            Assert.NotNull(user);

            await GetUserPagedList(userId);
        }
        private async Task GetUserPagedList(int userId)
        {
            var userList = await userService.GetUserPagedListbyRequest(new Entities.Containers.Request.User.RequestGetUserPagedList
            {
                id = userId
            });
            Assert.True(userList.data.Count == 1);

            await UpdateUser(userId);
        }
        private async Task UpdateUser(int userId)
        {
            var randomNumber = new Random().Next(10000, 100000);
            var email = $"mail{randomNumber}@mail.com";
            var name = $"name{randomNumber}";
            var status = EnumStatus.active;
            var gender = EnumGender.male;

            var result = await userService.UpdateUserbyRequest(new Entities.Containers.Requests.User.RequestUpdateUser
            {
                id = userId,
                name = name,
                email = email,
                _gender = gender,
                _status = status
            });
            Assert.Equal(result.data.id, userId);
            Assert.Equal(result.data.email, email);
            Assert.Equal(result.data.name, name);
            Assert.Equal(result.data.gender, gender.ToString());
            Assert.Equal(result.data.status, status.ToString());

            await DeleteUser(userId);
        }
        private async Task DeleteUser(int userId)
        {
            await userService.DeleteUserbyRequest(new Entities.Containers.Requests.User.RequestDeleteUser
            {
                id = userId
            });

            var user = await userService.GetUserbyId(userId);
            Assert.Null(user);
        }
    }
}
