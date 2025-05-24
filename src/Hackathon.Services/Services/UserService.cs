using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using Hackathon.Services.Interfaces;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Services;

public class UserService : IUserService
{
    public ValueTask<UserResultDto> CreateAsync(UserCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<PagedResultDto<UserResultDto>> GetAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public ValueTask<UserResultDto> GetByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }

    public ValueTask<UserResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> UpdateAsync(long id, UserUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}