
using Server.Endpoints;
using Server.Contracts.Request;
using Server.Contracts.Response;
using FastEndpoints;

namespace Server.Summary;

public class CreateRequestSummary : Summary<CreateUserEndpoint>
{
    public CreateRequestSummary()
    {
        Summary = "Creates a new user";
        Description = "Creates a new user";
        Response<UserResponse>(201, "Successfully creates a new user");
        Response(400, "User not created");
    }
}