using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using onliga.Models;

namespace onliga.Data
{
    public class onligaContext : DbContext
    {
        public onligaContext (DbContextOptions<onligaContext> options)
            : base(options)
        {
        }

        public DbSet<onliga.Models.Book> Book { get; set; }
    }
}