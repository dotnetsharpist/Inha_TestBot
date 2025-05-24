using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Interfaces;

public interface IShipmentService
{
    ValueTask<ShipmentResultDto> CreateAsync(ShipmentCreateDto dto);
    ValueTask<PagedResultDto<ShipmentResultDto>> GetAllAsync(PaginationParams @params);
    ValueTask<ShipmentResultDto> GetByIdAsync(long id);
    ValueTask<bool> UpdateAsync(long id, ShipmentUpdateDto dto);
    ValueTask<bool> DeleteAsync(long id);
}