using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Interfaces;

public interface IWarehouseService
{
    ValueTask<WarehouseResultDto> CreateAsync(WarehouseCreateDto dto);
    ValueTask<PagedResultDto<WarehouseResultDto>> GetAllAsync(PaginationParams @params);
    ValueTask<WarehouseResultDto> GetByIdAsync(long id);
    //ValueTask<bool> UpdateAsync(long id, WarehouseUpdateDto dto);
    ValueTask<bool> DeleteAsync(long id);
}