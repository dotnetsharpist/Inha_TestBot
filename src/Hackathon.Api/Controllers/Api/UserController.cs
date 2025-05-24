using Hackathon.Services.Dtos;
using Hackathon.Services.Interfaces;
using InhaTestBot.Domain.Configurations;
using InhaTestBot.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InhaTestBot.Controllers.Api;

public class UserController(IUserService userService) : BaseController
{
    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(new Response
        {
            Code = 200,
            Message = "Ok👍🏿",
            Data = await userService.GetAllAsync(@params)
        });

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> CreateAsync(UserCreateDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "Ok👍🏿",
            Data = await userService.CreateAsync(dto)
        });

    [HttpGet("{userId}")]
    [AllowAnonymous]
    public async Task<IActionResult> GetByIdAsync(long userId)
        => Ok(new Response
        {
            Code = 200,
            Message = "Ok👍🏿",
            Data = await userService.GetByIdAsync(userId)
        });

    [HttpPut("{userId}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> UpdateAsync(long userId, [FromForm] UserUpdateDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "Ok👍🏿",
            Data = await userService.UpdateAsync(userId, dto)
        });

    [HttpDelete("{userId}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteAsync(long userId)
        => Ok(new Response
        {
            Code = 200,
            Message = "Ok👍🏿",
            Data = await userService.DeleteAsync(userId)
        });

}