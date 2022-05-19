using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Core_neptune.Models.Context
{
    public class CoreContext : DbContext
    {
        public CoreContext(){}

        public CoreContext(DbContextOptions<CoreContext> options): base (options){}
        
        protected override void OnConfiguring(DbContextOptionsBuilder options){
            options.UseSqlite($"Data Source = MonDbSqlite.db");
        }
        
        public DbSet<Personne> Personne {get;set;}

        public DbSet<Hobbie> Hobbie {get;set;}
    }
}