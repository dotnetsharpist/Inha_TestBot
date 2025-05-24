using Hackathon.Services.Dtos;
using Hackathon.Services.Interfaces;
using InhaTestBot.Domain.Configurations;
using InhaTestBot.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InhaTestBot.Controllers.Api;

[Authorize]
public class ShipmentController(IShipmentService shipmentService) : BaseController
{
    [HttpGet]
    [Authorize(Roles = "Admin,UzAutoMotors,Supplier")]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(new Response
        {
            Code = 200,
            Message = "Shipments fetched 🚚",
            Data = await shipmentService.GetAllAsync(@params)
        });

    [HttpGet("{id}")]
    [Authorize(Roles = "Admin,UzAutoMotors,Supplier")]
    public async Task<IActionResult> GetByIdAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "Shipment details ✅",
            Data = await shipmentService.GetByIdAsync(id)
        });

    [HttpPost]
    [Authorize(Roles = "Admin,Supplier")]
    public async Task<IActionResult> CreateAsync(ShipmentCreateDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "Shipment created ✈️",
            Data = await shipmentService.CreateAsync(dto)
        });

    [HttpPut("{id}")]
    [Authorize(Roles = "Admin,UzAutoMotors")]
    public async Task<IActionResult> UpdateAsync(long id, [FromForm] ShipmentUpdateDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "Shipment updated ✏️",
            Data = await shipmentService.UpdateAsync(id, dto)
        });

    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "Shipment deleted 🗑️",
            Data = await shipmentService.DeleteAsync(id)
        });
}
