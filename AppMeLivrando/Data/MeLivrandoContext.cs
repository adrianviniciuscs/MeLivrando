using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppMeLivrando.Models;

namespace MeLivrando.Data
{
    public class MeLivrandoContext : DbContext
    {
        public MeLivrandoContext (DbContextOptions<MeLivrandoContext> options)
            : base(options)
        {
        }

        public DbSet<AppMeLivrando.Models.Book> Book { get; set; } = default!;
    }
}
