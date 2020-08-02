using Service.User.Request;
using Service.User.Response;

namespace Service.User
{
    public interface IUserService
    {
        Models.User.User Authenticate(Models.User.User user);
    }
}
