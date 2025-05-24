namespace Hackathon.Services.Dtos;

public class WarehouseCreateDto
{
    public string Name { get; set; }
    public long CountryId { get; set; }
    public long RegionId { get; set; }
    public long AreaId { get; set; }
    public decimal? Longitude { get; set; }
    public decimal? Latitude { get; set; }
}