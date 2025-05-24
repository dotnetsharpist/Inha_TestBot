namespace Hackathon.Services.Dtos;

public class ShipmentIssueCreateDto
{
    public long ShipmentId { get; set; }
    public string Reason { get; set; }
    public int EstimatedDelayMinutes { get; set; }
}