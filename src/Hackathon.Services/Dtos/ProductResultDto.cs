using InhaTestBot.Domain.Commons;

namespace Hackathon.Services.Dtos;

public class ProductResultDto : Auditable
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}