namespace EasyBurger.API.Models
{
    public class AccessToken
    {
        public string Token { get; init; }

        public int ExpirationInMinutes { get; init; }

        public AccessToken(string token, int expirationInMinutes)
        {
            Token = token;
            ExpirationInMinutes = expirationInMinutes;
        }
    }
}
