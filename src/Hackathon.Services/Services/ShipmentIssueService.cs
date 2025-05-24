using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using Hackathon.Services.Interfaces;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Services;

public class ShipmentIssueService : IShipmentIssueService
{
    public ValueTask<ShipmentIssueResultDto> CreateAsync(ShipmentIssueCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<PagedResultDto<ShipmentIssueResultDto>> GetAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ShipmentIssueResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}