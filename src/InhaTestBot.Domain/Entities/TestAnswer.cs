using InhaTestBot.Domain.Commons;

namespace InhaTestBot.Domain.Entities;

public class TestAnswer : Auditable
{
    public long AttemptId { get; set; }
    public long QuestionId { get; set; }
    public long SelectedOptionId { get; set; }

    public bool IsCorrect { get; set; }

    // Navigation
    public TestAttempt Attempt { get; set; } = null!;
    public TestQuestion Question { get; set; } = null!;
    
    public TestOption SelectedOption { get; set; } = null!;
}
