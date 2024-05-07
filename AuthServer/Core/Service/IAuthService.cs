namespace AuthServer.Core.Service
{
    public interface IAuthService
    {
        string GenerateJwtToken(string username);
    }
}
