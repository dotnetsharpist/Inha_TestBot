using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Interfaces;

public interface IUserService
{
    ValueTask<UserResultDto> CreateAsync(UserCreateDto dto);
    ValueTask<PagedResultDto<UserResultDto>> GetAllAsync(PaginationParams @params);
    ValueTask<UserResultDto> GetByEmailAsync(string email);
    ValueTask<UserResultDto> GetByIdAsync(long id);
    ValueTask<bool> UpdateAsync(long id, UserUpdateDto dto);
    ValueTask<bool> DeleteAsync(long id);
}