using InhaTestBot.Domain.Commons;

namespace InhaTestBot.Domain.Entities;

public class Contract : Auditable
{
    public long SupplierId { get; set; }
    public Supplier Supplier { get; set; }

    public string DeliveryTerms { get; set; }
    public string PenaltyConditions { get; set; }
    public DateTime CreatedAt { get; set; }
}
