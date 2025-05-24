using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Interfaces;

public interface IContractIssueService
{
    ValueTask<ContractIssueResultDto> CreateAsync(ContractIssueCreateDto dto);
    ValueTask<PagedResultDto<ContractIssueResultDto>> GetAllAsync(PaginationParams @params);
    ValueTask<ContractIssueResultDto> GetByIdAsync(long id);
    //ValueTask<bool> UpdateAsync(long id, ContractIssueUpdateDto dto);
    ValueTask<bool> DeleteAsync(long id);
}