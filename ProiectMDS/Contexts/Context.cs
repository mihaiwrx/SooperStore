using Microsoft.EntityFrameworkCore;
using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Contexts
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Categorie> Categorii { get; set; }
        public DbSet<Comanda> Comenzi { get; set; }
        public DbSet<Cos> Cos { get; set; }
        public DbSet<Furnizor> Furnizori { get; set; }
        public DbSet<Eroare> Erori { get; set; }
        public DbSet<Permisie> Permisii { get; set; }
        public DbSet<Produs> Produse { get; set; }
        public DbSet<Recenzie> Recenzii { get; set; }

        public DbSet<Rol> Roluri { get; set; }
        public DbSet<RolXPermisie> RolXPermisie { get; set; }

        public static bool isMigration = true;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (isMigration)
                optionsBuilder.UseSqlServer(@"Server=.\;Database=SooperStore_dezv;Trusted_connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable(name: "User");
            });
            modelBuilder.Entity<Furnizor>(entity =>
            {
                entity.ToTable(name: "Furnizor");
            });
            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.ToTable(name: "Categorie");
            });
            modelBuilder.Entity<Produs>(entity =>
            {
                entity.ToTable(name: "Produs");
                entity.HasOne(bc => bc.Furnizor).WithMany().HasForeignKey(x => x.FurnizorId);
                 entity.HasOne(bc => bc.Categorie).WithMany().HasForeignKey(x => x.CategorieId);
            });
            modelBuilder.Entity<Recenzie>(entity =>
            {
                entity.ToTable(name: "Recenzie");
                entity.HasOne(bc => bc.Produs).WithMany().HasForeignKey(x => x.ProdusId);
            });
        }
        public Context() { }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }


    }

    
}
