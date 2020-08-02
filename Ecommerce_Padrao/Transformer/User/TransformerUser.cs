using Service.User.Request;
using Service.User.Response;

namespace Transformer.User
{
    public class TransformerUser : ITransformerUser
    {
        public Models.User.User ParseLoginRequestToUser(LoginRequest loginRequest)
        {
            return new Models.User.User
            {
                UserName = loginRequest.Username,
                Password = loginRequest.Password
            };
        }

        public Models.Person.Person ParseUserToPerson(Models.User.User user)
        {
            return new Models.Person.Person
            {
                UserId = user.UserId
            };
        }

        public LoginResponse ParseUserToLoginResponse(Models.User.User user)
        {
            return new LoginResponse
            {
                UserId = user.UserId,
                Token = user.Token
            };
        }
    }
}
