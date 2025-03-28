using InhaTestBot.Domain.Enums;

namespace InhaTestBot.Services.Dtos.BotUser;

public class BotUserResultDto
{
    public long UserId { get; set; }
    public string? Username { get; set; } 
    public string FullName { get; set; } = null!;
    public BotUserRole Role { get; set; } = BotUserRole.User;
}