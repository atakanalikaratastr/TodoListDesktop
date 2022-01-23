using Microsoft.EntityFrameworkCore;
using NTier.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTier.DataAccess.Concrete.EntityFramework
{
    public class NTier_Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NK59MDB\SQLEXPRESS;Database=TodoList_db;Trusted_Connection=true");
        }
        public DbSet<Task> Tasks { get; set; }
    }
}
