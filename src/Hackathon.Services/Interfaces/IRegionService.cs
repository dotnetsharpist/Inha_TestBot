using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;

namespace Hackathon.Services.Interfaces;

public interface IRegionService
{
    ValueTask<RegionResultDto> CreateAsync(RegionCreateDto dto);
    ValueTask<PagedResultDto<RegionResultDto>> GetAllAsync();
    ValueTask<RegionResultDto> GetByIdAsync(long id);
    //ValueTask<bool> UpdateAsync(long id, RegionUpdateDto dto);
    ValueTask<bool> DeleteAsync(long id);
}