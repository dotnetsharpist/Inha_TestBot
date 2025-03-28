using System.ComponentModel.DataAnnotations.Schema;
using InhaTestBot.Domain.Commons;

namespace InhaTestBot.Domain.Entities;

public class Test : Auditable
{
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public long CreatedByUserId { get; set; } 
    public bool IsPublic { get; set; } = true;
    [ForeignKey("CreatedByUserId")]
    public BotUser CreatedBy { get; set; } = null!;
    public ICollection<TestQuestion> Questions { get; set; } = new List<TestQuestion>();
}