using IdentityModel.Client;

namespace Bookstore.Client.Service
{
    public interface ITokenService
    {
        Task<TokenResponse> GetToken(string scope);
    }
}
