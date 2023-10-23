using Microsoft.AspNetCore.Identity;

namespace TestMitra2.Models.Domain
{
    public class User : IdentityUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
