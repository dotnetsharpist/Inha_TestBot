
using InhaTestBot.Domain.Entities;

namespace InhaTestBot.Data.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IRepository<BotUser> BotUsers { get; }
    IRepository<Test> Tests { get; }
    IRepository<TestQuestion> TestQuestions { get; }
    IRepository<TestOption> TestOptions { get; }
    IRepository<TestAttempt> TestAttempts { get; }
    IRepository<TestAnswer> TestAnswers { get; }
}