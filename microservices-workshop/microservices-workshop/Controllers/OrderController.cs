
using Microsoft.AspNetCore.Mvc;

namespace microservices_workshop.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{

    private readonly ILogger<OrderController> _logger;

    public OrderController(ILogger<OrderController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "PlaceOrder")]
    public IEnumerable<Order> Post(Order order)
    {
        return null;
    }

    [HttpGet(Name = "ChangeOrderStatus")]
    public IEnumerable<Order> Patch()
    {
        return null;
    }
}

