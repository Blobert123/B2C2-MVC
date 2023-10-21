using B2C2_2023_Inleveropdracht_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace B2C2_2023_Inleveropdracht_MVC.Data
{
    public class WebsiteDBContext : DbContext
    {
        public WebsiteDBContext(DbContextOptions<WebsiteDBContext> options) : base(options)
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Bestelling> Bestellings { get; set; }
        public DbSet<Klant> Klants { get; set; }
        public DbSet<Klantenkaart> Klantenkaarts { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = @"Data Source=.;Initial Catalog=B2C2 Inleveropdracht;Integrated Security=true;TrustServerCertificate=true;";
            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///Admin
            modelBuilder.Entity<Admin>()
                .Property(n => n.Naam)
                .HasMaxLength(10);

            modelBuilder.Entity<Admin>()
                .Property(w => w.Wachtwoord)
                .HasMaxLength(30);

            Admin adminEntity = new()
            {
                Id = 1,
                Naam = "Admin",
                Wachtwoord = "Wachtwoord"
            };

            modelBuilder.Entity<Admin>()
                .HasData(adminEntity);

            ///Bestelling
            Bestelling bestellingEntity = new()
            {
                Id = 1,
                ProductId = 1,
                TotaalPrijs = 5,
                Punten = 1
            };

            modelBuilder.Entity<Bestelling>()
                .HasData(bestellingEntity);

            ///Klant
            modelBuilder.Entity<Klant>()
                .Property(n => n.Naam)
                .HasMaxLength(10);

            modelBuilder.Entity<Klant>()
                .Property(w => w.Wachtwoord)
                .HasMaxLength(30);

            Klant klantEntity = new()
            {
                Id = 1,
                Naam = "Klant1",
                Wachtwoord = "Wachtwoord"
            };

            modelBuilder.Entity<Klant>()
                .HasData(klantEntity);

            ///Klantenkaart
            Klantenkaart klantenkaartEntity = new()
            {
                Id = 1,
                Punten = 40,
                Korting = 5,
            };

            modelBuilder.Entity<Klantenkaart>()
                .HasData(klantenkaartEntity);

            ///Menu
            Menu menuEntity = new()
            {
                Id = 1,
                ProductId = 1,
            };

            modelBuilder.Entity<Menu>()
                .HasData(menuEntity);

            ///Product
            modelBuilder.Entity<Product>()
                .Property(p => p.Beschrijving)
                .HasMaxLength(250);

            Product productEntity = new()
            {
                Id = 1,
                Naam = "Frikandel",
                Prijs = 2,
                Beschrijving = "Product beschrijving 123"
            };

            modelBuilder.Entity<Product>()
                .HasData(productEntity);
        }
    }
}
