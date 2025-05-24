using InhaTestBot.Domain.Commons;

namespace InhaTestBot.Domain.Entities;

public class Warehouse : Auditable
{
    public string Name { get; set; }

    public long CountryId { get; set; }
    public Country Country { get; set; }

    public long RegionId { get; set; }
    public Region Region { get; set; }

    public long AreaId { get; set; }
    public Area Area { get; set; }

    public decimal? Longitude { get; set; }
    public decimal? Latitude { get; set; }
}
