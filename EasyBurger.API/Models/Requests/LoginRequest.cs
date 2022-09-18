using System.ComponentModel.DataAnnotations;

namespace EasyBurger.API.Models.Requests
{
    public class LoginRequest
    {
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; } = string.Empty;

        [RegularExpression("@\"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$\"", ErrorMessage = "Senha deve conter uma letra minúscula, uma maiscúla, um número e um caracter especial")]
        public string Password { get; set; } = string.Empty;
    }
}
