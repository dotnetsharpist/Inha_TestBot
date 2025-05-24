using Hackathon.Services.Dtos;

namespace Hackathon.Services.Interfaces;

public interface IAuthService
{
    ValueTask<LoginResultDto> AuthenticateAsync(LoginDto dto);

}