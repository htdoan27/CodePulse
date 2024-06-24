using Microsoft.AspNetCore.Identity;

namespace CodePulse.API.Respositories.Interface
{
    public interface ITokenRespository
    {
        string CreateJwtToken(IdentityUser user, List<string> roles);
    }
}
