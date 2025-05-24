using InhaTestBot.Domain.Commons;
using InhaTestBot.Domain.Enums;

namespace InhaTestBot.Domain.Entities;

public class Shipment : Auditable
{
    public long SupplierId { get; set; }
    public Supplier Supplier { get; set; }

    public int WarehouseId { get; set; }
    public Warehouse Warehouse { get; set; }

    public long ContractId { get; set; }
    public Contract Contract { get; set; }

    public string Details { get; set; }

    public Status Status { get; set; } = Status.Created;

    public DateTime AcceptedAt { get; set; }
    public DateTime DeliveryStartedAt { get; set; }
    public DateTime EstimatedDeliveryAt { get; set; }

    public RiskLevel RiskLevel { get; set; } = RiskLevel.Low;
}
