using InhaTestBot.Data.Contexts;
using InhaTestBot.Data.Interfaces;
using InhaTestBot.Domain.Entities;

namespace InhaTestBot.Data.Implementations;

public class UnitOfWork(TestDbContext dbContext) : IUnitOfWork
{
    
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    public IRepository<BotUser> BotUsers { get; private set; } = new Repository<BotUser>(dbContext);
    public IRepository<Test> Tests { get; private set; } = new Repository<Test>(dbContext);
    public IRepository<TestQuestion> TestQuestions { get; private set; } = new Repository<TestQuestion>(dbContext);
    public IRepository<TestOption> TestOptions { get; private set; } = new Repository<TestOption>(dbContext);
    public IRepository<TestAttempt> TestAttempts { get; private set; } = new Repository<TestAttempt>(dbContext);
    public IRepository<TestAnswer> TestAnswers { get; private set; } = new Repository<TestAnswer>(dbContext);

    public async Task<bool> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync() >= 0;
    }
}