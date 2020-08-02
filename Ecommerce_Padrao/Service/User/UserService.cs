using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Models.Config;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Service.User
{
    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;
        List<Models.User.User> users = new List<Models.User.User>
        {
            new Models.User.User
            {
                UserId=Guid.NewGuid(),
                UserName="teste",
                Password="123456",
                Role="atendente"
            }
        };

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public Models.User.User Authenticate(Models.User.User user)
        {
            Models.User.User logado = users.SingleOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);

            if (logado == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.ApiSecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name,logado.UserName),
                    new Claim(ClaimTypes.Role,logado.Role)
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            logado.Token = tokenHandler.WriteToken(token);

            return logado;
        }
    }
}
