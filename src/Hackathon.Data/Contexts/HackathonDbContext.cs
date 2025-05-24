using InhaTestBot.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InhaTestBot.Data.Contexts;

public class HackathonDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Area> Areas { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<ContractProduct> ContractProducts { get; set; }
    public DbSet<Shipment> Shipments { get; set; }
    public DbSet<ContractIssue> ContractIssues { get; set; }
    public DbSet<ShipmentIssue> ShipmentIssues { get; set; }
}