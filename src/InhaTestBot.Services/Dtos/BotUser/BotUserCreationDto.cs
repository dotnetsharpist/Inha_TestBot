namespace InhaTestBot.Services.Dtos.BotUser;

public class BotUserCreationDto
{
    public long UserId { get; set; }
    public string? Username { get; set; } 
    public string FullName { get; set; } = null!;
}