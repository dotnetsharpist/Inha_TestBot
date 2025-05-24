using Hackathon.Services.Interfaces;
using Hackathon.Services.Mappers;
using Hackathon.Services.Services;

namespace InhaTestBot.Configurations.Layers;

public static class ServicesConfigurationLayer
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddScoped<ICountryService, CountryService>();
        builder.Services.AddScoped<IRegionService, RegionService>();
        builder.Services.AddScoped<IAreaService, AreaService>();
        builder.Services.AddScoped<ISupplierService, SupplierService>();
        builder.Services.AddScoped<IWarehouseService, WarehouseService>();
        builder.Services.AddScoped<IProductService, ProductService>();
        builder.Services.AddScoped<IContractService, ContractService>();
        builder.Services.AddScoped<IContractProductService, ContractProductService>();
        builder.Services.AddScoped<IShipmentService, ShipmentService>();
        builder.Services.AddScoped<IContractIssueService, ContractIssueService>();
        builder.Services.AddScoped<IShipmentIssueService, ShipmentIssueService>();
        builder.Services.AddAutoMapper(typeof(MapperProfile));
    }
}