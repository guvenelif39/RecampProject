﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class RecampDatabaseContext:DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RecampDatabase;Trusted_Connection=true");
        }
        public DbSet<Car> Car { get; set; }

        public DbSet<Color> Color { get; set; }
        public DbSet<Brand> Brand { get; set; }
    }
}
