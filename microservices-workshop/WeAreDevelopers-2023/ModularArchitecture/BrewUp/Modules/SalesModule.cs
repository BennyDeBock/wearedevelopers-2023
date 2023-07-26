using System;

namespace BrewUp.Modules;

public class SalesModule : IModule
{
	public SalesModule()
	{
	}

    public bool IsEnabled => throw new NotImplementedException();

    public int Order => throw new NotImplementedException();

    public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
    {
        throw new NotImplementedException();
    }

    public IServiceCollection RegisterModule(WebApplicationBuilder builder)
    {

        throw new NotImplementedException();
    }
}

