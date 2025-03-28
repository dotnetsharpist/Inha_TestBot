using InhaTestBot.Domain.Configurations;
using InhaTestBot.Models;
using InhaTestBot.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InhaTestBot.Controllers;

[ApiController]
[Route("[controller]")]
public class BotUserController(IBotUserService service) : ControllerBase
{
    [HttpGet("{userId:long}")]
    public async ValueTask<IActionResult> GetByUserId(long userId)
        => Ok(new Response
        {
            Code = 200,
            Message = "Ok👍🏿",
            Data = await service.GetBotUserByUserId(userId)
        });
    
    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(new Response
        {
            Code = 200,
            Message = "Ok👍🏿",
            Data = await service.GetBotUsers(@params)
        });
}