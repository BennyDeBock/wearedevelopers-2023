using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace microservices_workshop.Controllers;

[ApiController]
[Route("[controller]")]
public class BeerController : Controller
{
    private readonly ILogger<BeerController> _logger;

    public BeerController(ILogger<BeerController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "CreateBeer")]
    public IEnumerable<Beer> Post()
    {
        return null;
    }

    [HttpGet]

    [HttpGet(Name = "GetBeerFromStock")]
    public IEnumerable<Beer> Put()
    {
        return null;
    }
}

