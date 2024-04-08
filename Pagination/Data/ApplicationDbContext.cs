using Microsoft.EntityFrameworkCore;
using Pagination.Models;
using System.Collections.Generic;

namespace Pagination.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        
    }
}

