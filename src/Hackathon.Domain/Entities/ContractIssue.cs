using InhaTestBot.Domain.Commons;

namespace InhaTestBot.Domain.Entities;

public class ContractIssue : Auditable
{
    public long ContractId { get; set; }
    public Contract Contract { get; set; }
    public string Reason { get; set; }
    public int EstimatedDelayMinutes { get; set; }
}
