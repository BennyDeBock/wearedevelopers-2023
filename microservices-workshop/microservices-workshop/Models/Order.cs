namespace microservices_workshop.Controllers;

public class Order
{

    public Order(customerName string, customerAddress string, quantity int, price decimal, total decimal, orderDate DateTime)
    {
        this.Id = Guid.NewGuid();
        this.CustomerName = customerName;
        this.CustomerAddress = customerAddress;
        this.Quantity = quantity;
        this.Price = price;
        this.Total = total;
        this.OrderDate = orderDate;
    }
    {
        OrderDate = DateTime.Now;
    }
    // Metadata
    
    public uuid Id { get; set; }
    public string CustomerName { get; set; }
    public string CustomerAddress { get; set; }
    
    public enum Status
    {
        Created,
        Completed,
        Cancelled
    }

    // Order details
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Total { get; set; }
    public DateTime OrderDate { get; set; }
}