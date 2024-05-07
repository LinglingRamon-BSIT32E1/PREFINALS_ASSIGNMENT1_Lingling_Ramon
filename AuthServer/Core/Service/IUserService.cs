namespace AuthServer.Core.Service;
using System.Threading.Tasks;

public class IUserService
{
    public interface IUserServices
    {
        Task<bool> RegisterAsync(string username, string password);
        Task<string> LoginAsync(string username, string password);
    }
}
