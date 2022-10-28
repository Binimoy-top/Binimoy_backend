using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace test111binimoy.JwtToken
{
    public class tokenManager
    {
        public static string Secret = "asdasdasdasdajkjafsfyafavsfjafaasdas";
        public static string GenerateToken(string username)
        {
            byte[] key = Convert.FromBase64String(Secret);
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(key);
            SecurityTokenDescriptor descriptor = new SecurityTokenDescriptor{
                Subject = new ClaimsIdentity(claims: new[] { new Claim(type: ClaimTypes.Name, value: username) }),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials=new SigningCredentials(securityKey,algorithm:SecurityAlgorithms.HmacSha256)
            };
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            JwtSecurityToken token = handler.CreateJwtSecurityToken(descriptor);
            return handler.WriteToken(token);
        }
    }
}