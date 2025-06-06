using InhaTestBot.Domain.Commons;

namespace InhaTestBot.Domain.Entities;

public class Product : Auditable
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
}
