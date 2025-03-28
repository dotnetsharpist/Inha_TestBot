using InhaTestBot.Services.Handlers;
using InhaTestBot.Services.Infrastructure;
using InhaTestBot.Services.Interfaces;
using InhaTestBot.Services.Mappers;
using InhaTestBot.Services.Services;

namespace InhaTestBot.Configurations.Layers;

public static class ServicesConfigurationLayer
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IBotUserService, BotUserService>();
        builder.Services.AddScoped<UpdateHandler>();
        builder.Services.ConfigureTelegramBotMvc();
        builder.Services.AddScoped<IStateService, StateService>();
        builder.Services.AddScoped<RedisService>();
        builder.Services.AddAutoMapper(typeof(MapperProfile));
    }
}