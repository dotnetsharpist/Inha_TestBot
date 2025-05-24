
using InhaTestBot.Domain.Commons;

namespace Hackathon.Services.Dtos;

public class ContractProductResultDto : Auditable
{
    public long ContractId { get; set; }
    public long ProductId { get; set; }
    public int ExpectedQuantity { get; set; }
}