using InhaTestBot.Domain.Commons;

namespace Hackathon.Services.Dtos;

public class SupplierResultDto : Auditable
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public long CountryId { get; set; }
    public long RegionId { get; set; }
    public long AreaId { get; set; }
    public decimal? Longitude { get; set; }
    public decimal? Latitude { get; set; }
    public long UserId { get; set; }
    public bool IsActive { get; set; }
}