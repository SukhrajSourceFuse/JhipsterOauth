using System.Security.Claims;

namespace JhipsterOauth.Test.Configuration;

public class MockClaimsPrincipalProvider
{
    public MockClaimsPrincipalProvider(ClaimsPrincipal user)
    {
        User = user;
    }

    public ClaimsPrincipal User { get; }
}
