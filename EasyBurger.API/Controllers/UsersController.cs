using EasyBurger.API.Infra.Repositories;
using EasyBurger.API.Models.Requests;
using EasyBurger.API.Services;
using Microsoft.AspNetCore.Mvc;
using static BCrypt.Net.BCrypt;

namespace EasyBurger.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserRepository _repository;
        private readonly TokenService _tokenService;

        public UsersController(UserRepository repository, TokenService tokenService)
        {
            _repository = repository;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var user = await _repository.GetBy(x => x.Email == request.Email);

            if (user is null || !Verify(user.Password, request.Password))
                return BadRequest(new { erro = "Email e/ou senha inválidos" });

            var token = _tokenService.GenerateToken(user);

            return Ok(token);
        }
    }
}
