using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using Hackathon.Services.Interfaces;

namespace Hackathon.Services.Services;

public class CountryService : ICountryService
{
    public ValueTask<CountryResultDto> CreateAsync(CountryCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<PagedResultDto<CountryResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask<CountryResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> UpdateAsync(long id, CountryUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}