using JWTApi_Training.Models;

namespace JWTApi_Training.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RigisterModel model);
        Task<AuthModel> LoginAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
