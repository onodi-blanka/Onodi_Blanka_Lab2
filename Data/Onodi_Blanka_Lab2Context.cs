﻿using System;
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

        public DbSet<Onodi_Blanka_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Onodi_Blanka_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Onodi_Blanka_Lab2.Models.Category>? Category { get; set; }

        public DbSet<Onodi_Blanka_Lab2.Models.Member>? Member { get; set; }

        public DbSet<Onodi_Blanka_Lab2.Models.Borrowing>? Borrowing { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(e => e.Borrowing)
            .WithOne(e => e.Book)
                .HasForeignKey<Borrowing>("BookID");
        }

    
}
}