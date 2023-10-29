using FastEndpoints;
using FE.API.Requests;
using FE.API.Responses;

namespace FE.API.Endpoints;

public class MyEndpoint : Endpoint<MyRequest, MyResponse>
{
    public override void Configure()
    {
        Post("/api/user/create");
        AllowAnonymous();
    }
    public override async Task HandleAsync(MyRequest req, CancellationToken ct)
    {
        await SendAsync(new MyResponse
        {
            FullName = $"{req.FirstName} {req.LastName}",
            Age = req.Age
        });
    }
}
