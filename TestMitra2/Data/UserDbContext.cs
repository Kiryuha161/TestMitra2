using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestMitra2.Models.Domain;

namespace TestMitra2.Data
{
    public class UserDbContext: IdentityDbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public  DbSet<User> Users { get; set; }
    }
}
