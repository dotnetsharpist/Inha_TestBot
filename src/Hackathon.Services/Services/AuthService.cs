using Hackathon.Services.Dtos;
using Hackathon.Services.Interfaces;

namespace Hackathon.Services.Services;

public class AuthService : IAuthService
{
    public ValueTask<LoginResultDto> AuthenticateAsync(LoginDto dto)
    {
        throw new NotImplementedException();
    }
}