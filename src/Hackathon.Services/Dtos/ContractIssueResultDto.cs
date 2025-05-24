using InhaTestBot.Domain.Commons;

namespace Hackathon.Services.Dtos;

public class ContractIssueResultDto : Auditable
{
    public long ContractId { get; set; }
    public string Reason { get; set; }
    public int EstimatedDelayMinutes { get; set; }
}