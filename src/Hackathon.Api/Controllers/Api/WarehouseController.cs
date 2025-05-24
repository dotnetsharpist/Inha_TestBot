using Hackathon.Services.Dtos;
using Hackathon.Services.Interfaces;
using InhaTestBot.Domain.Configurations;
using InhaTestBot.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InhaTestBot.Controllers.Api;

[Authorize]
public class WarehouseController(IWarehouseService warehouseService) : BaseController
{
    [HttpGet]
    [Authorize(Roles = "Admin,UzAutoMotors,Supplier")]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(new Response
        {
            Code = 200,
            Message = "Warehouses fetched 🏬",
            Data = await warehouseService.GetAllAsync(@params)
        });

    [HttpGet("{id}")]
    [Authorize(Roles = "Admin,UzAutoMotors,Supplier")]
    public async Task<IActionResult> GetByIdAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "Warehouse info retrieved ✅",
            Data = await warehouseService.GetByIdAsync(id)
        });

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> CreateAsync(WarehouseCreateDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "Warehouse created 🏗️",
            Data = await warehouseService.CreateAsync(dto)
        });

    /*
    [HttpPut("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> UpdateAsync(long id, [FromForm] WarehouseUpdateDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "Warehouse updated 🛠️",
            Data = await warehouseService.UpdateAsync(id, dto)
        });
        */

    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "Warehouse deleted 🗑️",
            Data = await warehouseService.DeleteAsync(id)
        });
}