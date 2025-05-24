using Hackathon.Services.Dtos;
using Hackathon.Services.Dtos.Commons;
using InhaTestBot.Domain.Configurations;

namespace Hackathon.Services.Interfaces;

public interface IContractProductService
{
    ValueTask<ContractProductResultDto> CreateAsync(ContractProductCreateDto dto);
    ValueTask<PagedResultDto<ContractProductResultDto>> GetAllAsync(PaginationParams @params);
    ValueTask<ContractProductResultDto> GetByIdAsync(long id);
    //ValueTask<bool> UpdateAsync(long id, ContractProductUpdateDto dto);
    ValueTask<bool> DeleteAsync(long id);
}