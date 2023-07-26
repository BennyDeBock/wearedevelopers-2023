namespace microservices_workshop.Controllers;

public class OrderBeer
{
 
    public orderBeer(Beer beer, int quantity)
    {
        this.Id = Guid.NewGuid();
        this.Beer = beer;
        this.Quantity = quantity;
    }
    
    public uuid Id { get; set; }
    
    public Beer Beer { get; set; }
    
    public int Quantity { get; set; }
    
}