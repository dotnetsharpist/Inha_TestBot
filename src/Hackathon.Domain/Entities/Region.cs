using InhaTestBot.Domain.Commons;

namespace InhaTestBot.Domain.Entities;

public class Region : Auditable
{
    public string Name { get; set; }
    public long CountryId { get; set; }
    public Country Country { get; set; }
}
