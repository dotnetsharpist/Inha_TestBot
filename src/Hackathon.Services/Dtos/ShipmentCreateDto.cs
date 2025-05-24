using InhaTestBot.Domain.Enums;

namespace Hackathon.Services.Dtos;

public class ShipmentCreateDto
{
    public long SupplierId { get; set; }
    public long WarehouseId { get; set; }
    public long ContractId { get; set; }
    public string Details { get; set; }
    public Status Status { get; set; } = Status.Created;
    public DateTime AcceptedAt { get; set; }
    public DateTime DeliveryStartedAt { get; set; }
    public DateTime EstimatedDeliveryAt { get; set; }
    public RiskLevel RiskLevel { get; set; } = RiskLevel.Low;
}