using Server.Contracts.Request;
using Server.Contracts.Response;
using Server.Domain;
using Server.Mapping;
using Server.Service;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace Server.Endpoints;

[HttpPost("users"), AllowAnonymous]
public class CreateUserEndpoint : Endpoint<CreateUserRequest, UserResponse>
{
    private readonly IUserService _userService;
    public CreateUserEndpoint(IUserService userService)
    {
        _userService = userService;
    }

    public override async Task HandleAsync(CreateUserRequest req, CancellationToken ct)
    {
        var user = req.ToUser();

        await _userService.CreateAsync(user);

        var res = user.ToUserResponse();
        await SendCreatedAtAsync<GetUserEndpoint>(
            new { Id = user.Id.Value }, res, generateAbsoluteUrl: true, cancellation: ct);
    }
}
