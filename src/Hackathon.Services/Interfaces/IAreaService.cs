using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;

namespace Hackathon.Services.Interfaces;

public interface IAreaService
{
    ValueTask<AreaResultDto> CreateAsync(AreaCreateDto dto);
    ValueTask<PagedResultDto<AreaResultDto>> GetAllAsync();
    ValueTask<AreaResultDto> GetByIdAsync(long id);
    //ValueTask<bool> UpdateAsync(long id, AreaUpdateDto dto);
    ValueTask<bool> DeleteAsync(long id);
}
