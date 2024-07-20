using Ecomm_Application.Helpers;
using Ecomm_Application.Repositories;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Ecomm_Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration configuration;

        public AuthService(ApplicationDbContext dbContext,IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
        }
        public string Login(AuthRequest request)
        {
            var user=dbContext.users.FirstOrDefault(user=>user.Email==request.UserName && user.password==request.Password);
            if (user != null)
            {
                var authClaims = new List<Claim>
                {
                    new Claim("Id",user.UserId.ToString()),
                    new Claim("UserName",user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                var userRoles = dbContext.userRoles.Where(u => u.UserId == user.UserId).ToList();
                var roleIds = userRoles.Select(r => r.RoleId).ToList();
                var roles=dbContext.roles.Where(r=>roleIds.Contains(r.RoleId)).ToList();    

                foreach(var role in roles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, role.RoleName));
                }
                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: configuration["JWT:ValidIssuer"],
                    audience: configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );


                var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
                return jwtToken;
            }
            return null;
        }
    }
}
