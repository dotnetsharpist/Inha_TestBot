using InhaTestBot.Domain.Configurations;
using InhaTestBot.Services.Dtos.BotUser;
using InhaTestBot.Services.Dtos.Commons;

namespace InhaTestBot.Services.Interfaces;

public interface IBotUserService
{
    ValueTask<BotUserResultDto> GetBotUserByUserId(long userId);
    ValueTask<PagedResultDto<BotUserResultDto>> GetBotUsers(PaginationParams @params);
    ValueTask AddBotUser(BotUserCreationDto dto);
}