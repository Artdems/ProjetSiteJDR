using Microsoft.EntityFrameworkCore;
using ProjetPerso.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetPerso.DBContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option) : base(option) { }

        public DbSet<Personnage> Personnages { get; set; }
    }
}
