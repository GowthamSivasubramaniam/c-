using E_commerce.Models;
using E_commerce.Data;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
namespace E_commerce.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly ProductDb _Db;
        private readonly IConfiguration _config;
        public AuthController(ProductDb Db ,IConfiguration config)
        {
            _Db = Db;
            _config = config;
        }
        [HttpPost("register")]
        public IActionResult Register ([FromBody] User user)
        {
             _Db.Users.Add(user);
             _Db.SaveChanges();
             return Ok("Registered successfully");
             
        }
        [HttpPost("login")]
    public IActionResult Login([FromBody] User login)
    {
        var user = _Db.Users.FirstOrDefault(u => u.Email == login.Email);
        if (user == null) return Unauthorized();

        var token = GenerateToken(user);
        return Ok(new { token });
    }
    private string GenerateToken(User user)
    {
        var claims = new[]
        {

            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Role, user.Role)
        };

        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Audience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(60),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
    }

}