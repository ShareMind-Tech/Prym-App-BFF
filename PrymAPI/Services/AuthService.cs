namespace PrymAPI.Services
{
    public class AuthService
    {
        private readonly IConfiguration _config;

        public AuthService(IConfiguration config)
        {
            _config = config;
        }

        public bool ValidateUser(string username, string password)
        {
            var storedUsername = _config["AdminSettings:Username"];
            var storedPassword = _config["AdminSettings:Password"];

            return username == storedUsername && password == storedPassword;
        }
    }
}
