using InhaTestBot.Domain.Commons;

namespace InhaTestBot.Domain.Entities;

public class TestOption : Auditable
{
    public long QuestionId { get; set; }
    public string Text { get; set; } = null!;
    public bool IsCorrect { get; set; } = false;
    
    public TestQuestion Question { get; set; } = null!;
}
