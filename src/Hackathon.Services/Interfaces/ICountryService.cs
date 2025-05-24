using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Interfaces;

public interface ICountryService
{
    ValueTask<CountryResultDto> CreateAsync(CountryCreateDto dto);
    ValueTask<PagedResultDto<CountryResultDto>> GetAllAsync();
    ValueTask<CountryResultDto> GetByIdAsync(long id);
    ValueTask<bool> UpdateAsync(long id, CountryUpdateDto dto);
    ValueTask<bool> DeleteAsync(long id);
}
