using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Interfaces;

public interface ISupplierService
{
    ValueTask<SupplierResultDto> CreateAsync(SupplierCreateDto dto);
    ValueTask<PagedResultDto<SupplierResultDto>> GetAllAsync(PaginationParams @params);
    ValueTask<SupplierResultDto> GetByIdAsync(long id);
    //ValueTask<bool> UpdateAsync(long id, SupplierUpdateDto dto);
    ValueTask<bool> DeleteAsync(long id);
}
