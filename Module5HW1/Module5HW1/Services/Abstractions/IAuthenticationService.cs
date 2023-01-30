using System.Threading.Tasks;
using Module5HW1.Model;

namespace Module5HW1.Services.Abstractions;
public interface IAuthenticationService
{
    Task<LoginResult> Login(string login, string password);
    Task<RegisterResult> Register(string login, string password);
}
