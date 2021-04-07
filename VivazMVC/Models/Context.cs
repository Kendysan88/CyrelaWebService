using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VivazMVC.Models
{
    public class Context : DbContext
    {
        //Método que configura o  Entity Framework
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString: @"User ID=XXXXXXX;Password=XXXXXXX;Host=localhost;Port=5432;Database=NomeDoBanco;Pooling=true;");
        }
    }
}
