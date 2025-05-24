namespace Hackathon.Services.Dtos;

public class ContractProductCreateDto
{
    public long ContractId { get; set; }
    public long ProductId { get; set; }
    public int ExpectedQuantity { get; set; }
}