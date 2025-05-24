using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using Hackathon.Services.Interfaces;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Services;

public class ShipmentService : IShipmentService
{
    public ValueTask<ShipmentResultDto> CreateAsync(ShipmentCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<PagedResultDto<ShipmentResultDto>> GetAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ShipmentResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> UpdateAsync(long id, ShipmentUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}