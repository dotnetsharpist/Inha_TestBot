using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using Hackathon.Services.Interfaces;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Services;

public class ContractService : IContractService
{
    public ValueTask<ContractResultDto> CreateAsync(ContractCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<PagedResultDto<ContractResultDto>> GetAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ContractResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}