using InhaTestBot.Domain.Commons;

namespace Hackathon.Services.Dtos;

public class RegionResultDto : Auditable
{
    public string Name { get; set; }
    public long CountryId { get; set; }
}