namespace microservices_workshop.Controllers;

public class Order
{

    public Order()
    {
        OrderDate = DateTime.Now;
    }
    public int Id { get; set; }
    // Metadata    
    public string? CustomerName { get; set; }
    public string? CustomerAddress { get; set; }
    
    // Order details
    
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Total { get; set; }
    public DateTime OrderDate { get; set; }
}