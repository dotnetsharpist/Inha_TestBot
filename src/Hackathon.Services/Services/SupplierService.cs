using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using Hackathon.Services.Interfaces;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Services;

public class SupplierService : ISupplierService
{
    public ValueTask<SupplierResultDto> CreateAsync(SupplierCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<PagedResultDto<SupplierResultDto>> GetAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public ValueTask<SupplierResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}