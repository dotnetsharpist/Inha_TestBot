using InhaTestBot.Domain.Commons;

namespace InhaTestBot.Domain.Entities;

public class Supplier : Auditable
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }

    public long CountryId { get; set; }
    public Country Country { get; set; }

    public long RegionId { get; set; }
    public Region Region { get; set; }

    public long AreaId { get; set; }
    public Area Area { get; set; }

    public decimal? Longitude { get; set; }
    public decimal? Latitude { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }

    public bool IsActive { get; set; }
}
