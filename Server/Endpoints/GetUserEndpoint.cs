using Server.Contracts.Request;
using Server.Contracts.Response;
using Server.Domain;
using Server.Mapping;
using Server.Service;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace Server.Endpoints;


[HttpGet("user/{id:guid}"), AllowAnonymous]
public class GetUserEndpoint : Endpoint<GetUserRequest, UserResponse>
{
    private readonly IUserService _userService;

    public GetUserEndpoint(IUserService userService)
    {
        _userService = userService;
    }

    public override async Task HandleAsync(GetUserRequest req, CancellationToken ct)
    {
        User? user = await _userService.GetAsync(req.Id);
        if(user is null)
        {
            await SendNotFoundAsync(ct);
            return;
        }
        
        UserResponse res = user.ToUserResponse();
        await SendOkAsync(res, ct);
    }
}
