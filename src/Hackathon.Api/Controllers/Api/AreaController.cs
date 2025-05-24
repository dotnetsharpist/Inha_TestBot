using Hackathon.Services.Dtos;
using Hackathon.Services.Interfaces;
using InhaTestBot.Domain.Configurations;
using InhaTestBot.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InhaTestBot.Controllers.Api;

[Authorize(Roles = "Admin")]
public class AreaController(IAreaService service) : BaseController
{
    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetAllAsync()
        => Ok(new Response
        {
            Code = 200,
            Message = "Ok",
            Data = await service.GetAllAsync()
        });

    [HttpPost]
    public async Task<IActionResult> CreateAsync(AreaCreateDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "Ok",
            Data = await service.CreateAsync(dto)
        });

    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<IActionResult> GetByIdAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "Ok",
            Data = await service.GetByIdAsync(id)
        });

    /*
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(long id, [FromForm] RegionUpdateDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "Ok",
            Data = await service.UpdateAsync(id, dto)
        });
        */

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "Ok",
            Data = await service.DeleteAsync(id)
        });
}
