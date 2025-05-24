using InhaTestBot.Domain.Commons;

namespace InhaTestBot.Domain.Entities;

public class ContractProduct : Auditable
{
    public long ContractId { get; set; }
    public Contract Contract { get; set; }

    public long ProductId { get; set; }
    public Product Product { get; set; }

    public long ExpectedQuantity { get; set; }
}
