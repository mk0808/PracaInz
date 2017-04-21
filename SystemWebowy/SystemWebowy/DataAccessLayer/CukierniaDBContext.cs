using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using SystemWebowy.Models;

namespace SystemWebowy.DataAccessLayer
{
    public class CukierniaDBContext : DbContext
    {
        public CukierniaDBContext() : base("name = CukierniaDBContext")
        {
        }

        public DbSet<Dostawa> Dostawy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Klient> Klienci { get; set; }
        public DbSet<Kreator> Specjalne { get; set; }
        public DbSet<Pracownik> Pracownicy { get; set; }
        public DbSet<Produkt> Produkty { get; set; }
        public DbSet<Smak> Smaki { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<Zdjecie> Zdjecia { get; set; }
        public DbSet<PozycjaZamowienia> PozycjeZamowienia { get; set; }
        public DbSet<PozycjaZamowieniaSpec> PozycjeZamowieniaSpec { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}