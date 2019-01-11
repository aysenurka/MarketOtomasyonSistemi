namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class duzeltme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(nullable: false, maxLength: 30),
                        Aciklama = c.String(maxLength: 100),
                        UstKategoriId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoriler", t => t.UstKategoriId)
                .Index(t => t.KategoriAd, unique: true)
                .Index(t => t.UstKategoriId);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrunAd = c.String(nullable: false, maxLength: 30),
                        UrunStok = c.Int(nullable: false),
                        UrunFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.UrunAd, unique: true)
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.UrunDetaylar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrunId = c.Int(nullable: false),
                        Barkod = c.String(maxLength: 11),
                        Adet = c.Int(nullable: false),
                        BirimAdet = c.Int(nullable: false),
                        ToplamAdet = c.Int(nullable: false),
                        Kdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Kar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Indirim = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AlisFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SatisFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UrunAlısTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Urunler", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.UrunId)
                .Index(t => t.Barkod, unique: true);
            
            CreateTable(
                "dbo.SatisDetaylar",
                c => new
                    {
                        UrunId = c.Int(nullable: false),
                        SatisId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UrunId, t.SatisId })
                .ForeignKey("dbo.Satislar", t => t.SatisId, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.UrunId)
                .Index(t => t.SatisId);
            
            CreateTable(
                "dbo.Satislar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ToplamFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SatisTarih = c.DateTime(nullable: false),
                        OdemeTipi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);


            Sql("alter table dbo.UrunDetaylar drop column ToplamAdet");
            Sql("alter table dbo.UrunDetaylar add [ToplamAdet] as ([Adet]*[BirimAdet])");

            Sql("alter table dbo.UrunDetaylar drop column AlisFiyat");
            Sql("alter table dbo.UrunDetaylar add [AlisFiyat] as [Fiyat]+[Fiyat]*[Kdv]");
            Sql("alter table dbo.UrunDetaylar drop column SatisFiyat");
            Sql("alter table dbo.UrunDetaylar add [SatisFiyat] as (([Fiyat]+[Fiyat]*[Kdv])-([Fiyat]+[Fiyat]*[Kdv])*[Indirim]+([Fiyat]+[Fiyat]*[Kdv])*[Kar]-([Fiyat]+[Fiyat]*[Kdv])*[Kar]*Indirim)");


        }

        public override void Down()
        {
            DropForeignKey("dbo.SatisDetaylar", "UrunId", "dbo.Urunler");
            DropForeignKey("dbo.SatisDetaylar", "SatisId", "dbo.Satislar");
            DropForeignKey("dbo.UrunDetaylar", "UrunId", "dbo.Urunler");
            DropForeignKey("dbo.Urunler", "KategoriId", "dbo.Kategoriler");
            DropForeignKey("dbo.Kategoriler", "UstKategoriId", "dbo.Kategoriler");
            DropIndex("dbo.SatisDetaylar", new[] { "SatisId" });
            DropIndex("dbo.SatisDetaylar", new[] { "UrunId" });
            DropIndex("dbo.UrunDetaylar", new[] { "Barkod" });
            DropIndex("dbo.UrunDetaylar", new[] { "UrunId" });
            DropIndex("dbo.Urunler", new[] { "KategoriId" });
            DropIndex("dbo.Urunler", new[] { "UrunAd" });
            DropIndex("dbo.Kategoriler", new[] { "UstKategoriId" });
            DropIndex("dbo.Kategoriler", new[] { "KategoriAd" });
            DropTable("dbo.Satislar");
            DropTable("dbo.SatisDetaylar");
            DropTable("dbo.UrunDetaylar");
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategoriler");
        }
    }
}
