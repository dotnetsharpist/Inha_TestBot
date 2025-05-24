using InhaTestBot.Domain.Commons;
using InhaTestBot.Domain.Enums;

namespace Hackathon.Services.Dtos;

public class ShipmentResultDto : Auditable
{
    public long SupplierId { get; set; }
    public long WarehouseId { get; set; }
    public long ContractId { get; set; }
    public string Details { get; set; }
    public Status Status { get; set; }
    public DateTime AcceptedAt { get; set; }
    public DateTime DeliveryStartedAt { get; set; }
    public DateTime EstimatedDeliveryAt { get; set; }
    public RiskLevel RiskLevel { get; set; }
}