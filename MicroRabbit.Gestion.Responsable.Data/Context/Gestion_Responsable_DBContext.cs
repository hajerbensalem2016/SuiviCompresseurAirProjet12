using MicroRabbit.Gestion.Responsable.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Gestion.Responsable.Data.Context
{
  public  class Gestion_Responsable_DBContext : DbContext
    {
        public Gestion_Responsable_DBContext(DbContextOptions<Gestion_Responsable_DBContext> options) : base(options)
        { }

        public DbSet<Filiale> Filiales { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }




    }
}

   