using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using Hackathon.Services.Interfaces;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Services;

public class ContractIssueService : IContractIssueService
{
    public ValueTask<ContractIssueResultDto> CreateAsync(ContractIssueCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<PagedResultDto<ContractIssueResultDto>> GetAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ContractIssueResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}