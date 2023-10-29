using FastEndpoints;
using FE.API.Responses;

namespace FE.API.Endpoints;

public class MyGetEndpoint : EndpointWithoutRequest<MyResponse>
{
    public override void Configure()
    {
        Get("/api/person");
        AllowAnonymous();
    }

    public override Task HandleAsync(CancellationToken ct)
    {
        Response = new()
        {
            FullName = "john doe",
            Age = 24
        };
        return Task.CompletedTask;
    }
}
