using InhaTestBot.Domain.Commons;

namespace InhaTestBot.Domain.Entities;

public class TestQuestion : Auditable
{
    public long TestId { get; set; }
    public string QuestionText { get; set; } = null!;
    public int Order { get; set; }

    public Test Test { get; set; } = null!;
    public ICollection<TestOption> Options { get; set; } = new List<TestOption>();
}
