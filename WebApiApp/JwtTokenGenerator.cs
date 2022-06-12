using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApiApp
{
    public class JwtTokenGenerator
    {
        public string GenerateToken()
        {
            SymmetricSecurityKey securityKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Recepreceprecep1."));

            SigningCredentials credentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);

            List<Claim> claims = new List<Claim>();
            claims.Add(new(ClaimTypes.Role,"Member"));


            JwtSecurityToken token = new JwtSecurityToken(issuer:"http://localhost",audience:"http://localhost",notBefore:DateTime.Now,expires:DateTime.Now.AddMinutes(2),signingCredentials:credentials);

            JwtSecurityTokenHandler handler = new();
            return handler.WriteToken(token);
        }
    }
}
