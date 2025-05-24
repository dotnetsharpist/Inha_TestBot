using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Interfaces;

public interface IContractService
{
    ValueTask<ContractResultDto> CreateAsync(ContractCreateDto dto);
    ValueTask<PagedResultDto<ContractResultDto>> GetAllAsync(PaginationParams @params);
    ValueTask<ContractResultDto> GetByIdAsync(long id);
    //ValueTask<bool> UpdateAsync(long id, ContractUpdateDto dto);
    ValueTask<bool> DeleteAsync(long id);
}