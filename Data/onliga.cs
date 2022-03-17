using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using onliga.Models;

namespace onliga.Data
{
    public class Onliga : DbContext
    {
        public Onliga(DbContextOptions<Onliga> options) : base(options) { }
        public virtual DbSet<User> Users { get; set; }

    }
}