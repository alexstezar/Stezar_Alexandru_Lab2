using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stezar_Alexandru_Lab2.Models;

namespace Stezar_Alexandru_Lab2.Data
{
    public class Stezar_Alexandru_Lab2Context : DbContext
    {
        public Stezar_Alexandru_Lab2Context (DbContextOptions<Stezar_Alexandru_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Stezar_Alexandru_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Stezar_Alexandru_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Stezar_Alexandru_Lab2.Models.Category>? Category { get; set; }
    }
}
