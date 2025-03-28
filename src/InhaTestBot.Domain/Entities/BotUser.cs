using InhaTestBot.Domain.Commons;
using InhaTestBot.Domain.Enums;

namespace InhaTestBot.Domain.Entities;

public class BotUser : Auditable
{
    public long UserId { get; set; }
    public string? Username { get; set; } 
    public string FullName { get; set; } = null!;
    public BotUserRole Role { get; set; } = BotUserRole.User;

    //public string? LanguageCode { get; set; } // e.g., "en", "uz", "ru"
}
