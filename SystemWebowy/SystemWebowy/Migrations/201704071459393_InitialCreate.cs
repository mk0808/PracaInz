namespace SystemWebowy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dostawa",
                c => new
                    {
                        DostawaId = c.Int(nullable: false, identity: true),
                        RodzajDostawy = c.String(),
                        KosztDostawy = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.DostawaId);
            
            CreateTable(
                "dbo.Zamowienie",
                c => new
                    {
                        ZamowienieId = c.Int(nullable: false, identity: true),
                        DataZamowienia = c.DateTime(nullable: false),
                        KwotaZaplaty = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Platnosc = c.Int(nullable: false),
                        DostawaId = c.Int(nullable: false),
                        Uwagi = c.String(),
                        KlientId = c.Int(nullable: false),
                        DataDoreczenia = c.DateTime(nullable: false),
                        GodzinaDoreczenia = c.Time(nullable: false, precision: 7),
                        StatusZamowienia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ZamowienieId)
                .ForeignKey("dbo.Dostawa", t => t.DostawaId, cascadeDelete: true)
                .Index(t => t.DostawaId);
            
            CreateTable(
                "dbo.PozycjaZamowienia",
                c => new
                    {
                        PozycjaZamowieniaId = c.Int(nullable: false, identity: true),
                        ZamowienieId = c.Int(nullable: false),
                        ProduktId = c.Int(nullable: false),
                        Ilosc = c.Int(nullable: false),
                        CenaZakupu = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PozycjaZamowieniaId)
                .ForeignKey("dbo.Produkt", t => t.ProduktId, cascadeDelete: true)
                .ForeignKey("dbo.Zamowienie", t => t.ZamowienieId, cascadeDelete: true)
                .Index(t => t.ZamowienieId)
                .Index(t => t.ProduktId);
            
            CreateTable(
                "dbo.Produkt",
                c => new
                    {
                        ProduktId = c.Int(nullable: false, identity: true),
                        NazwaProduktu = c.String(),
                        OpisProduktu = c.String(),
                        KategoriaId = c.Int(nullable: false),
                        SmakId = c.Int(nullable: false),
                        Dostepnosc = c.Boolean(nullable: false),
                        CenaS = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CenaM = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CenaL = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProduktId)
                .ForeignKey("dbo.Kategoria", t => t.KategoriaId, cascadeDelete: true)
                .ForeignKey("dbo.Smak", t => t.SmakId, cascadeDelete: true)
                .Index(t => t.KategoriaId)
                .Index(t => t.SmakId);
            
            CreateTable(
                "dbo.Kategoria",
                c => new
                    {
                        KategoriaId = c.Int(nullable: false, identity: true),
                        NazwaKategorii = c.String(),
                    })
                .PrimaryKey(t => t.KategoriaId);
            
            CreateTable(
                "dbo.Smak",
                c => new
                    {
                        SmakId = c.Int(nullable: false, identity: true),
                        NazwaSmaku = c.String(),
                    })
                .PrimaryKey(t => t.SmakId);
            
            CreateTable(
                "dbo.Zdjecie",
                c => new
                    {
                        ZdjecieId = c.Int(nullable: false, identity: true),
                        Zdj = c.Binary(),
                        ImageMimeType = c.String(),
                        Produkt_ProduktId = c.Int(),
                    })
                .PrimaryKey(t => t.ZdjecieId)
                .ForeignKey("dbo.Produkt", t => t.Produkt_ProduktId)
                .Index(t => t.Produkt_ProduktId);
            
            CreateTable(
                "dbo.PozycjaZamowieniaSpec",
                c => new
                    {
                        PozycjaZamowieniaSpecId = c.Int(nullable: false, identity: true),
                        ZamowienieId = c.Int(nullable: false),
                        KreatorId = c.Int(nullable: false),
                        Ilosc = c.Int(nullable: false),
                        CenaZakupu = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PozycjaZamowieniaSpecId)
                .ForeignKey("dbo.Kreator", t => t.KreatorId, cascadeDelete: true)
                .ForeignKey("dbo.Zamowienie", t => t.ZamowienieId, cascadeDelete: true)
                .Index(t => t.ZamowienieId)
                .Index(t => t.KreatorId);
            
            CreateTable(
                "dbo.Kreator",
                c => new
                    {
                        KreatorId = c.Int(nullable: false, identity: true),
                        LiczbaPieter = c.Int(nullable: false),
                        Wielkosc = c.String(),
                        Kształt = c.String(),
                        Biszkopt = c.String(),
                        Nadzienie = c.String(),
                        Smak = c.String(),
                        Polewa = c.String(),
                        Dekoracja = c.String(),
                        Kolor = c.String(),
                        Dodatki = c.String(),
                        Uwagi = c.String(),
                        Wycena = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.KreatorId);
            
            CreateTable(
                "dbo.Klient",
                c => new
                    {
                        KlientId = c.Int(nullable: false, identity: true),
                        Imie = c.String(nullable: false, maxLength: 50),
                        DrugieImie = c.String(maxLength: 50),
                        Nazwisko = c.String(nullable: false, maxLength: 50),
                        DataUrodzenia = c.DateTime(nullable: false),
                        DataZalozenia = c.DateTime(nullable: false),
                        Email = c.String(nullable: false),
                        Haslo = c.String(nullable: false),
                        KodPocztowy = c.String(nullable: false, maxLength: 6),
                        Miejscowosc = c.String(nullable: false, maxLength: 50),
                        Adres = c.String(nullable: false, maxLength: 100),
                        Telefon = c.String(),
                        StatusKonta = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.KlientId);
            
            CreateTable(
                "dbo.Pracownik",
                c => new
                    {
                        PracownikId = c.Int(nullable: false, identity: true),
                        ImiePracownika = c.String(),
                        DrugieImPrac = c.String(),
                        NazwiskoPracownika = c.String(),
                        DataUr = c.DateTime(nullable: false),
                        LoginPrac = c.String(),
                        HasloPrac = c.String(),
                        StatusKonta = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PracownikId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PozycjaZamowieniaSpec", "ZamowienieId", "dbo.Zamowienie");
            DropForeignKey("dbo.PozycjaZamowieniaSpec", "KreatorId", "dbo.Kreator");
            DropForeignKey("dbo.PozycjaZamowienia", "ZamowienieId", "dbo.Zamowienie");
            DropForeignKey("dbo.PozycjaZamowienia", "ProduktId", "dbo.Produkt");
            DropForeignKey("dbo.Zdjecie", "Produkt_ProduktId", "dbo.Produkt");
            DropForeignKey("dbo.Produkt", "SmakId", "dbo.Smak");
            DropForeignKey("dbo.Produkt", "KategoriaId", "dbo.Kategoria");
            DropForeignKey("dbo.Zamowienie", "DostawaId", "dbo.Dostawa");
            DropIndex("dbo.PozycjaZamowieniaSpec", new[] { "KreatorId" });
            DropIndex("dbo.PozycjaZamowieniaSpec", new[] { "ZamowienieId" });
            DropIndex("dbo.Zdjecie", new[] { "Produkt_ProduktId" });
            DropIndex("dbo.Produkt", new[] { "SmakId" });
            DropIndex("dbo.Produkt", new[] { "KategoriaId" });
            DropIndex("dbo.PozycjaZamowienia", new[] { "ProduktId" });
            DropIndex("dbo.PozycjaZamowienia", new[] { "ZamowienieId" });
            DropIndex("dbo.Zamowienie", new[] { "DostawaId" });
            DropTable("dbo.Pracownik");
            DropTable("dbo.Klient");
            DropTable("dbo.Kreator");
            DropTable("dbo.PozycjaZamowieniaSpec");
            DropTable("dbo.Zdjecie");
            DropTable("dbo.Smak");
            DropTable("dbo.Kategoria");
            DropTable("dbo.Produkt");
            DropTable("dbo.PozycjaZamowienia");
            DropTable("dbo.Zamowienie");
            DropTable("dbo.Dostawa");
        }
    }
}
