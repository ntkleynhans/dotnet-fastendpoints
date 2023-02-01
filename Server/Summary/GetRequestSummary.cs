using Server.Contracts.Request;
using Server.Contracts.Response;
using Server.Endpoints;
using FastEndpoints;

namespace Server.Summary;

public class GetRequestSummary : Summary<GetUserEndpoint>
{
    public GetRequestSummary()
    {
        Summary = "Return user by id";
        Description = "Return user by id";
        Response<UserResponse>(200, "Found user and returned");
        Response(400, "User Not Found");
    }
}
