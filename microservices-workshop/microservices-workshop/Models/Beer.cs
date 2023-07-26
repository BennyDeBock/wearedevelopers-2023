namespace microservices_workshop.Controllers;

public class Beer
{
    public Beer(string name, string? brewery, string? country, double price, double abv, string? description)
    {
        this.Id = Guid.NewGuid();
        this.Name = name;
        this.Brewery = brewery;
        this.Country = country;
        this.Price = price;
        this.Abv = abv;
        this.Description = description;
    }
        
    public Guid Id { get; set; }
    public string Name { get; set; }
    
    public string? Brewery { get; set; }
    
    public string? Country { get; set; }
    
    public double Price { get; set; }
    
    public double Abv { get; set; }
    
    public string? Description { get; set; }
    
}