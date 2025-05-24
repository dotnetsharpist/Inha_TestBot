using InhaTestBot.Domain.Commons;

namespace InhaTestBot.Domain.Entities;

public class ShipmentIssue : Auditable
{
    public long ShipmentId { get; set; }
    public Shipment Shipment { get; set; }
    public string Reason { get; set; }
    public int EstimatedDelayMinutes { get; set; }
}
