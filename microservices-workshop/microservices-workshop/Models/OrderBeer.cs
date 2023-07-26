namespace microservices_workshop.Controllers;

public class OrderBeer
{
 
    public OrderBeer(Beer beer, int quantity)
    {
        this.Id = Guid.NewGuid();
        this.Beer = beer;
        this.Quantity = quantity;
    }
    
    public Guid Id { get; set; }
    
    public Beer Beer { get; set; }
    
    public int Quantity { get; set; }
    
}