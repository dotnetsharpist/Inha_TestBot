using InhaTestBot.Domain.Commons;
using InhaTestBot.Domain.Enums;

namespace InhaTestBot.Domain.Entities;

public class User : Auditable
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public Role Role { get; set; }
    public string PhoneNumber { get; set; }
    public string PasswordHash { get; set; }
}
