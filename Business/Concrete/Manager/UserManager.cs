using Business.Abstract.User;
using Core.Infrastructure.Data;
using Core.Infrastructure.Data.PagedList;
using Core.Infrastructure.Data.Results;
using Entities.Concrete;
using Entities.Containers.Request.User;
using Entities.Containers.Requests.User;
using Newtonsoft.Json;
using ServiceLayer.Helper;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Business.Concrete.Manager
{
    public class UserManager : IUserService
    {
        private readonly HttpClient _apiClient;
        private readonly string _postfix;
        public UserManager()
        {
            _apiClient = new ApiHelper()._client;
            _postfix = "users";
        }

        /// <summary>
        /// Create User
        /// </summary>
        /// <param name="request"></param>
        /// <returns>users</returns>
        public async Task<ApiSuccessResult<users>> CreateUserbyRequest(RequestCreateUser request)
        {
            var result = new ApiSuccessResult<users>();

            var response = await _apiClient.PostAsync(_postfix, new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                var responseApi = await response.Content.ReadAsStringAsync();
                var baseResult = JsonConvert.DeserializeObject<ApiResult>(responseApi);
                if (baseResult.code != (int)HttpStatusCode.Created)
                {
                    var errorResult = JsonConvert.DeserializeObject<ApiErrorResult>(responseApi);
                    throw new Exception(string.Join(Environment.NewLine, errorResult.data.Select(s => $"{ s.field}:{s.message}")));
                }
                result = JsonConvert.DeserializeObject<ApiSuccessResult<users>>(responseApi);
            }
            else
                throw new Exception(response.ReasonPhrase);

            return result;
        }
        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task DeleteUserbyRequest(RequestDeleteUser request)
        {
            var response = await _apiClient.DeleteAsync($"{_postfix}/{request.id}");
            if (response.IsSuccessStatusCode)
            {
                var responseApi = await response.Content.ReadAsStringAsync();
                var baseResult = JsonConvert.DeserializeObject<ApiResult>(responseApi);
                if (baseResult.code != (int)HttpStatusCode.NoContent)
                    throw new Exception(((HttpStatusCode)baseResult.code).ToString());
            }
            else
                throw new Exception(response.ReasonPhrase);
        }

        /// <summary>
        /// Update User
        /// </summary>
        /// <param name="request"></param>
        /// <returns>users</returns>
        public async Task<ApiSuccessResult<users>> UpdateUserbyRequest(RequestUpdateUser request)
        {
            var result = new ApiSuccessResult<users>();

            var response = await _apiClient.PutAsync($"{_postfix}/{request.id}", new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                var responseApi = await response.Content.ReadAsStringAsync();
                var baseResult = JsonConvert.DeserializeObject<ApiResult>(responseApi);
                if (baseResult.code != (int)HttpStatusCode.OK)
                {
                    var errorResult = JsonConvert.DeserializeObject<ApiErrorResult>(responseApi);
                    throw new Exception(string.Join(Environment.NewLine, errorResult.data.Select(s => $"{ s.field}:{s.message}")));
                }
                result = JsonConvert.DeserializeObject<ApiSuccessResult<users>>(responseApi);
            }
            else
                throw new Exception(response.ReasonPhrase);

            return result;
        }
        /// <summary>
        /// Get user paged list by request
        /// </summary>
        /// <param name="request"></param>
        /// <returns>PagedList<users></returns>
        public async Task<ApiPagedListResult<users>> GetUserPagedListbyRequest(RequestGetUserPagedList request)
        {
            var result = new ApiPagedListResult<users>();
            var sbApiParameterList = new StringBuilder(_postfix);
            sbApiParameterList.AppendFormat("?page={0}&limit={1}", request.page, request.limit);

            if (request.id.HasValue)
                sbApiParameterList.AppendFormat("&id={0}", request.id.Value);

            if (!string.IsNullOrEmpty(request.name))
                sbApiParameterList.AppendFormat("&name={0}", request.name);

            if (!string.IsNullOrEmpty(request.email))
                sbApiParameterList.AppendFormat("&email={0}", request.email);

            if (request.gender.HasValue)
                sbApiParameterList.AppendFormat("&gender={0}", request.gender.ToString());

            if (request.status.HasValue)
                sbApiParameterList.AppendFormat("&status={0}", request.status.ToString());

            var response = await _apiClient.GetAsync(sbApiParameterList.ToString());

            if (response.IsSuccessStatusCode)
            {
                var responseApi = await response.Content.ReadAsStringAsync();
                var baseResult = JsonConvert.DeserializeObject<ApiResult>(responseApi);
                if (baseResult.code != (int)HttpStatusCode.OK)
                {
                    var errorResult = JsonConvert.DeserializeObject<ApiErrorResult>(responseApi);
                    throw new Exception(string.Join(Environment.NewLine, errorResult.data.Select(s => $"{ s.field}:{s.message}")));
                }
                result = JsonConvert.DeserializeObject<ApiPagedListResult<users>>(responseApi);
            }
            else
                throw new Exception(response.ReasonPhrase);

            return result;
        }
        /// <summary>
        /// Get User by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>users</returns>
        public async Task<users> GetUserbyId(int id)
        {
            var userResponse = await GetUserPagedListbyRequest(new RequestGetUserPagedList
            {
                id = id
            });
            var user = userResponse.data.FirstOrDefault();
            return user;
        }
    }
}
