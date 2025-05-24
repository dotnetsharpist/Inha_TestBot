using InhaTestBot.Domain.Commons;

namespace Hackathon.Services.Dtos;

public class WarehouseResultDto : Auditable
{
    public string Name { get; set; }
    public long CountryId { get; set; }
    public long RegionId { get; set; }
    public long AreaId { get; set; }
    public decimal? Longitude { get; set; }
    public decimal? Latitude { get; set; }
}