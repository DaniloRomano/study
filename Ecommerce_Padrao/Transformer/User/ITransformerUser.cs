using Service.Product.Request;
using Service.Product.Response;
using Service.User.Request;
using Service.User.Response;
using System.Collections.Generic;

namespace Transformer.User
{
    public interface ITransformerUser
    {
        Models.User.User ParseLoginRequestToUser(LoginRequest loginRequest);

        Models.Person.Person ParseUserToPerson(Models.User.User user);

        LoginResponse ParseUserToLoginResponse(Models.User.User user);        

    }
}
