using InhaTestBot.Domain.Commons;

namespace InhaTestBot.Domain.Entities;

public class TestAttempt : Auditable
{
    public long TestId { get; set; }
    public long BotUserId { get; set; }

    public DateTime StartedAt { get; set; } = DateTime.UtcNow;
    public DateTime? CompletedAt { get; set; }

    public int CorrectCount { get; set; }
    public int TotalQuestions { get; set; }

    // Navigation
    public Test Test { get; set; } = null!;
    public BotUser BotUser { get; set; } = null!;
    public ICollection<TestAnswer> Answers { get; set; } = new List<TestAnswer>();
}
