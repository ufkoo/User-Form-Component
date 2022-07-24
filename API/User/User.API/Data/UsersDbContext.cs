using Users.API.Models;
using Microsoft.EntityFrameworkCore;

namespace User.API.Data
{
    public class UsersDbContext: DbContext 
    {

        public UsersDbContext(DbContextOptions options) : base(options) { }

        //db set

        public DbSet<> Users { get; set; }
    }
}
