using InhaTestBot.Domain.Commons;
using InhaTestBot.Domain.Enums;

namespace Hackathon.Services.Dtos;

public class UserResultDto : Auditable
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public Role Role { get; set; }
    public string PhoneNumber { get; set; }
}