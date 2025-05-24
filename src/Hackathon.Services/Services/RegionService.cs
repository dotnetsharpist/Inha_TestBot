using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using Hackathon.Services.Interfaces;

namespace Hackathon.Services.Services;

public class RegionService : IRegionService
{
    public ValueTask<RegionResultDto> CreateAsync(RegionCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<PagedResultDto<RegionResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask<RegionResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}