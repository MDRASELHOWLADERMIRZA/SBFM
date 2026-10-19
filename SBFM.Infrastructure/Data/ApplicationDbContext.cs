using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBFM.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace SBFM.Infrastructure.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base() { }
        public DbSet<Income> Incomes => Set<Income>();
    }
}
