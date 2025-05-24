using Hackathon.Services.Dtos;
using Hackathon.Services.Interfaces;
using InhaTestBot.Domain.Configurations;
using InhaTestBot.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InhaTestBot.Controllers.Api;

[Authorize]
public class SupplierController(ISupplierService supplierService) : BaseController
{
    [HttpGet]
    [Authorize(Roles = "Admin,UzAutoMotors")]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(new Response
        {
            Code = 200,
            Message = "Suppliers fetched 👷‍♂️",
            Data = await supplierService.GetAllAsync(@params)
        });

    [HttpGet("{id}")]
    [Authorize(Roles = "Admin,UzAutoMotors,Supplier")]
    public async Task<IActionResult> GetByIdAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "Supplier info retrieved ✅",
            Data = await supplierService.GetByIdAsync(id)
        });

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> CreateAsync(SupplierCreateDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "Supplier created 🏭",
            Data = await supplierService.CreateAsync(dto)
        });

    /*
    [HttpPut("{id}")]
    [Authorize(Roles = "Admin,Supplier")]
    public async Task<IActionResult> UpdateAsync(long id, [FromForm] SupplierUpdateDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "Supplier updated ✏️",
            Data = await supplierService.UpdateAsync(id, dto)
        });
        */

    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "Supplier deleted 🗑️",
            Data = await supplierService.DeleteAsync(id)
        });
}