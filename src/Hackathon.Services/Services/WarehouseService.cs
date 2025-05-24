using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using Hackathon.Services.Interfaces;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Services;

public class WarehouseService : IWarehouseService
{
    public ValueTask<WarehouseResultDto> CreateAsync(WarehouseCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<PagedResultDto<WarehouseResultDto>> GetAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public ValueTask<WarehouseResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}