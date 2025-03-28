using AutoMapper;
using InhaTestBot.Data.Interfaces;
using InhaTestBot.Domain.Configurations;
using InhaTestBot.Domain.Entities;
using InhaTestBot.Services.Dtos.BotUser;
using InhaTestBot.Services.Dtos.Commons;
using InhaTestBot.Services.Extensions;
using InhaTestBot.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InhaTestBot.Services.Services;

public class BotUserService(IUnitOfWork unitOfWork, IMapper mapper) : IBotUserService
{
    public async ValueTask<BotUserResultDto> GetBotUserByUserId(long userId)
    {
        var botUser = await unitOfWork.BotUsers.SelectAsync(bu => bu.UserId == userId);
        return mapper.Map<BotUserResultDto>(botUser);
    }

    public async ValueTask<PagedResultDto<BotUserResultDto>> GetBotUsers(PaginationParams @params)
    {
        var query = unitOfWork.BotUsers.SelectAll()
            .Where(bt => !bt.IsDeleted);

        var totalCount = await query.CountAsync();

        var botUsers = await query
            .ToPagedList(@params)
            .ToListAsync();

        return new PagedResultDto<BotUserResultDto>()
        {
            TotalCount = totalCount,
            Items = mapper.Map<List<BotUserResultDto>>(botUsers)
        };
    }
    
    public async ValueTask AddBotUser(BotUserCreationDto dto)
    {
        var exists = await unitOfWork.BotUsers
            .SelectAsync(bu => bu.UserId == dto.UserId);

        if (exists is not null)
            return;
        
        var mappedBotUser = mapper.Map<BotUser>(dto);
        await unitOfWork.BotUsers.InsertAsync(mappedBotUser);
        await unitOfWork.BotUsers.SaveAsync();
    }
}