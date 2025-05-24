using InhaTestBot.Domain.Commons;

namespace Hackathon.Services.Dtos;

public class ContractResultDto : Auditable
{
    public long SupplierId { get; set; }
    public string DeliveryTerms { get; set; }
    public string PenaltyConditions { get; set; }
}