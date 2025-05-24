using InhaTestBot.Domain.Commons;

namespace InhaTestBot.Domain.Entities;

public class Country : Auditable
{ 
    public string Name { get; set; }
}