using InhaTestBot.Domain.Commons;

namespace InhaTestBot.Domain.Entities;

public class Area : Auditable
{
    public string Name { get; set; }
    public long RegionId { get; set; }
    public Region Region { get; set; }
}
