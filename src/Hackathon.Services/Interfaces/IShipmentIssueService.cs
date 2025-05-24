using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Interfaces;

public interface IShipmentIssueService
{
    ValueTask<ShipmentIssueResultDto> CreateAsync(ShipmentIssueCreateDto dto);
    ValueTask<PagedResultDto<ShipmentIssueResultDto>> GetAllAsync(PaginationParams @params);
    ValueTask<ShipmentIssueResultDto> GetByIdAsync(long id);
    //ValueTask<bool> UpdateAsync(long id, ShipmentIssueUpdateDto dto);
    ValueTask<bool> DeleteAsync(long id);
}