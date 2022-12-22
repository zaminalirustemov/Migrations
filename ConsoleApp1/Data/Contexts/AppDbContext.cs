using ConsoleApp1.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data.Contexts
{
    public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-OT3RPGF;Database=UserDataZR;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
