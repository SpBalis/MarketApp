using System.Threading.Tasks;
using market.API.Models;

namespace market.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);//login user
         Task<bool> UserExists(string username);//check if user exists
        object GetSection(string v);
    }
}