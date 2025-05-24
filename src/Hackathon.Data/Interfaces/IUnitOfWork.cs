using InhaTestBot.Domain.Entities;
using InhaTestBot.Domain.Enums;

namespace InhaTestBot.Data.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IRepository<User> Users { get; }
    IRepository<Country> Countries { get; }
    IRepository<Region> Regions { get; }
    IRepository<Area> Areas { get; }
    IRepository<Supplier> Suppliers { get; }
    IRepository<Warehouse> Warehouses { get; }
    IRepository<Product> Products { get; }
    IRepository<Contract> Contracts { get; }
    IRepository<ContractProduct> ContractProducts { get; }
    IRepository<Shipment> Shipments { get; }
    IRepository<ContractIssue> ContractIssues { get; }
    IRepository<ShipmentIssue> ShipmentIssues { get; }
}