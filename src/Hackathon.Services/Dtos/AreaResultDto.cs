using InhaTestBot.Domain.Commons;

namespace Hackathon.Services.Dtos;

public class AreaResultDto : Auditable
{
    public string Name { get; set; }
    public long RegionId { get; set; }
}