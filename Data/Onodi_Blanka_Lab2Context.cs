using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Onodi_Blanka_Lab2.Models;

namespace Onodi_Blanka_Lab2.Data
{
    public class Onodi_Blanka_Lab2Context : DbContext
    {
        public Onodi_Blanka_Lab2Context (DbContextOptions<Onodi_Blanka_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Onodi_Blanka_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
