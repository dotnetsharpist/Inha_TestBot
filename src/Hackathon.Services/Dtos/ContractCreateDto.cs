namespace Hackathon.Services.Dtos;

public class ContractCreateDto
{
    public long SupplierId { get; set; }
    public string DeliveryTerms { get; set; }
    public string PenaltyConditions { get; set; }
}