using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using Hackathon.Services.Interfaces;

namespace Hackathon.Services.Services;

public class AreaService : IAreaService
{
    public ValueTask<AreaResultDto> CreateAsync(AreaCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<PagedResultDto<AreaResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask<AreaResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}