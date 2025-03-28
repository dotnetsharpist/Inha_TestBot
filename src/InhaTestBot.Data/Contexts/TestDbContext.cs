using InhaTestBot.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InhaTestBot.Data.Contexts;

public class TestDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<BotUser> BotUsers { get; init; }
    public DbSet<Test> Tests { get; init; }
    public DbSet<TestQuestion> TestQuestions { get; init; }
    public DbSet<TestOption> TestOptions { get; init; }
    public DbSet<TestAttempt> TestAttempts { get; init; }
    public DbSet<TestAnswer> TestAnswers { get; init; }
}