using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab18Erik.Model;

namespace Lab18Erik.Models
{
    public class Lab18ErikContext : DbContext
    {
        public Lab18ErikContext (DbContextOptions<Lab18ErikContext> options)
            : base(options)
        {
        }

        public DbSet<Lab18Erik.Model.Destenation> Destenation { get; set; }

        public DbSet<Lab18Erik.Model.Climate> Climate { get; set; }

        public DbSet<Lab18Erik.Model.Supply> Supply { get; set; }
    }
}
