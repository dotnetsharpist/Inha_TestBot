using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Interfaces;

public interface IProductService
{
    ValueTask<ProductResultDto> CreateAsync(ProductCreateDto dto);
    ValueTask<PagedResultDto<ProductResultDto>> GetAllAsync(PaginationParams @params);
    ValueTask<ProductResultDto> GetByIdAsync(long id);
    //ValueTask<bool> UpdateAsync(long id, ProductUpdateDto dto);
    ValueTask<bool> DeleteAsync(long id);
}