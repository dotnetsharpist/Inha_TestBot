using InhaTestBot.Data.Contexts;
using InhaTestBot.Data.Interfaces;
using InhaTestBot.Domain.Entities;

namespace InhaTestBot.Data.Implementations;

public class UnitOfWork(HackathonDbContext dbContext) : IUnitOfWork
{
    
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    public IRepository<User> Users { get; } = new Repository<User>(dbContext);
    public IRepository<Country> Countries { get; } = new Repository<Country>(dbContext);
    public IRepository<Region> Regions { get; } = new Repository<Region>(dbContext);
    public IRepository<Area> Areas { get; } = new Repository<Area>(dbContext);
    public IRepository<Supplier> Suppliers { get; } = new Repository<Supplier>(dbContext);
    public IRepository<Warehouse> Warehouses { get; } = new Repository<Warehouse>(dbContext);
    public IRepository<Product> Products { get; } = new Repository<Product>(dbContext);
    public IRepository<Contract> Contracts { get; } = new Repository<Contract>(dbContext);
    public IRepository<ContractProduct> ContractProducts { get; } = new Repository<ContractProduct>(dbContext);
    public IRepository<Shipment> Shipments { get; } = new Repository<Shipment>(dbContext);
    public IRepository<ContractIssue> ContractIssues { get; } = new Repository<ContractIssue>(dbContext);
    public IRepository<ShipmentIssue> ShipmentIssues { get; } = new Repository<ShipmentIssue>(dbContext);

    public async Task<bool> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync() >= 0;
    }
}