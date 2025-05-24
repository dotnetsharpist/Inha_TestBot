using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using Hackathon.Services.Interfaces;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Services;

public class ContractProductService : IContractProductService
{
    public ValueTask<ContractProductResultDto> CreateAsync(ContractProductCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<PagedResultDto<ContractProductResultDto>> GetAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ContractProductResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}