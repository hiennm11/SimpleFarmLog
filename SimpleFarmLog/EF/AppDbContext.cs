using Microsoft.EntityFrameworkCore;
using SimpleFarmLog.Entities;
using SimpleFarmLog.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FluentAPI Relationship
            //Boar
            modelBuilder.Entity<Boar>().HasKey(a => a.Id);
            modelBuilder.Entity<Boar>().HasOne(a => a.Herd).WithMany(x => x.Boars);
            modelBuilder.Entity<Boar>().Property(a => a.StartDate).HasDefaultValue(DateTime.Now);
            modelBuilder.Entity<Boar>().Property(a => a.Color).HasDefaultValue(Color.Black);
            modelBuilder.Entity<Boar>().Property(a => a.Gender).HasDefaultValue(Gender.Male);
            modelBuilder.Entity<Boar>().Property(a => a.Number).HasDefaultValue(0);

            //Herd
            modelBuilder.Entity<BoarHerd>().HasKey(a => a.Id);          
            modelBuilder.Entity<BoarHerd>().Property(a => a.InitDate).HasDefaultValue(DateTime.Now);
            modelBuilder.Entity<BoarHerd>().Property(a => a.Number).HasDefaultValue(0);

            //Medicine
            modelBuilder.Entity<Medicine>().HasKey(a => a.Id);            
            modelBuilder.Entity<Medicine>().Property(a => a.Amount).HasDefaultValue(0);

            //Fodder
            modelBuilder.Entity<Fodder>().HasKey(a => a.Id);          
            modelBuilder.Entity<Fodder>().Property(a => a.Amount).HasDefaultValue(0);

            //Ingre
            modelBuilder.Entity<Ingredient>().HasKey(a => a.Id);           
            modelBuilder.Entity<Ingredient>().Property(a => a.Amount).HasDefaultValue(0);

            //InjectLog
            modelBuilder.Entity<InjectLog>()
                .HasKey(t => new { t.HerdId, t.MedicineId });
            modelBuilder.Entity<InjectLog>()
                .HasOne(il => il.Medicine)
                .WithMany(m => m.InjectLogs)
                .HasForeignKey(il => il.MedicineId);
            modelBuilder.Entity<InjectLog>()
               .HasOne(h => h.BoarHerd)
               .WithMany(m => m.InjectLogs)
               .HasForeignKey(h => h.HerdId);            
            modelBuilder.Entity<InjectLog>().Property(a => a.Amount).HasDefaultValue(0);
            modelBuilder.Entity<InjectLog>().Property(a => a.InjectDate).HasDefaultValue(DateTime.Now);

            //MixLog
            modelBuilder.Entity<MixLog>()
                .HasOne(il => il.Ingredient)
                .WithMany(m => m.MixLogs)
                .HasForeignKey(il => il.IngredientId);
            modelBuilder.Entity<MixLog>()
               .HasOne(h => h.Fodder)
               .WithMany(m => m.MixLogs)
               .HasForeignKey(h => h.FodderId);
            modelBuilder.Entity<MixLog>()
                .HasKey(t => new { t.FodderId, t.IngredientId });
            modelBuilder.Entity<MixLog>().Property(a => a.IngredientAmount).HasDefaultValue(0);
            modelBuilder.Entity<MixLog>().Property(a => a.MixDate).HasDefaultValue(DateTime.Now);

            //SeedLog
            modelBuilder.Entity<SeedLog>()
                .HasOne(il => il.BoarHerd)
                .WithMany(m => m.SeedLogs)
                .HasForeignKey(il => il.HerdId);
            modelBuilder.Entity<SeedLog>()
               .HasOne(h => h.Fodder)
               .WithMany(m => m.SeedLogs)
               .HasForeignKey(h => h.FodderId);
            modelBuilder.Entity<SeedLog>()
                .HasKey(t => new { t.HerdId, t.FodderId });
            modelBuilder.Entity<SeedLog>().Property(a => a.Amount).HasDefaultValue(0);
            modelBuilder.Entity<SeedLog>().Property(a => a.SeedDate).HasDefaultValue(DateTime.Now);

            //PurchaseLog
            modelBuilder.Entity<PurchaseLog>()
                .HasOne(a => a.Ingredient)
                .WithMany(x => x.PurchaseLogs);
            modelBuilder.Entity<PurchaseLog>()
                .HasOne(a => a.Medicine)
                .WithMany(x => x.PurchaseLogs);
            modelBuilder.Entity<PurchaseLog>().HasKey(t => t.PurchaseId);
            modelBuilder.Entity<PurchaseLog>().Property(a => a.Amount).HasDefaultValue(0);
            modelBuilder.Entity<PurchaseLog>().Property(a => a.Price).HasDefaultValue(0);
            modelBuilder.Entity<PurchaseLog>().Property(a => a.PurchaseDate).HasDefaultValue(DateTime.Now);
        }

        public DbSet<Boar> Boars { get; set; }
        public DbSet<BoarHerd> BoarHerds { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Fodder> Fodders { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<InjectLog> InjectLogs { get; set; }
        public DbSet<SeedLog> SeedLogs { get; set; }
        public DbSet<MixLog> MixLogs { get; set; }
        public DbSet<PurchaseLog> PurchaseLogs { get; set; }

    }
}
