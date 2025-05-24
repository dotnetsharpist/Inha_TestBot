namespace Hackathon.Services.Dtos;

public class ContractIssueCreateDto
{
    public long ContractId { get; set; }
    public string Reason { get; set; }
    public int EstimatedDelayMinutes { get; set; }
}