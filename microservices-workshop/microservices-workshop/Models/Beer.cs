namespace microservices_workshop.Controllers;

public class Beer
{
    public Beer(name string, brewery string?, country string?, price double, abv double, description string?)
    {
        this.Id = Guid.NewGuid();
        this.Name = name;
        this.Brewery = brewery;
        this.Country = country;
        this.Price = price;
        this.Abv = abv;
        this.Description = description;
    }
        
    public uuid Id { get; set; }
    public string Name { get; set; }
    
    public string? Brewery { get; set; }
    
    public string? Country { get; set; }
    
    public double Price { get; set; }
    
    public double Abv { get; set; }
    
    public string? Description { get; set; }
    
}