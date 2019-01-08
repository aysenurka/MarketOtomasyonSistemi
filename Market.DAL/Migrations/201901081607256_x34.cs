namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class x34 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        KategoriAd = c.String(nullable: false, maxLength: 30),
                        Aciklama = c.String(maxLength: 100),
                        Kdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Kar = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.KategoriAd, unique: true);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UrunAd = c.String(nullable: false, maxLength: 30),
                        UrunStok = c.Short(nullable: false),
                        UrunFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KategoriId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.UrunAd, unique: true)
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.UrunDetaylar",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UrunId = c.Guid(nullable: false),
                        Barkod = c.String(maxLength: 11),
                        Adet = c.Short(nullable: false),
                        BirimAdet = c.Int(nullable: false),
                        ToplamAdet = c.Int(nullable: false),
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
                "dbo.Satislar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ToplamFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SatisTarih = c.DateTime(nullable: false),
                        OdemeTipi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SatisDetaylar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrunDetayId = c.Guid(nullable: false),
                        SatisId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Satislar", t => t.SatisId, cascadeDelete: true)
                .ForeignKey("dbo.UrunDetaylar", t => t.UrunDetayId, cascadeDelete: true)
                .Index(t => t.UrunDetayId)
                .Index(t => t.SatisId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SatisDetaylar", "UrunDetayId", "dbo.UrunDetaylar");
            DropForeignKey("dbo.SatisDetaylar", "SatisId", "dbo.Satislar");
            DropForeignKey("dbo.UrunDetaylar", "UrunId", "dbo.Urunler");
            DropForeignKey("dbo.Urunler", "KategoriId", "dbo.Kategoriler");
            DropIndex("dbo.SatisDetaylar", new[] { "SatisId" });
            DropIndex("dbo.SatisDetaylar", new[] { "UrunDetayId" });
            DropIndex("dbo.UrunDetaylar", new[] { "Barkod" });
            DropIndex("dbo.UrunDetaylar", new[] { "UrunId" });
            DropIndex("dbo.Urunler", new[] { "KategoriId" });
            DropIndex("dbo.Urunler", new[] { "UrunAd" });
            DropIndex("dbo.Kategoriler", new[] { "KategoriAd" });
            DropTable("dbo.SatisDetaylar");
            DropTable("dbo.Satislar");
            DropTable("dbo.UrunDetaylar");
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategoriler");
        }
    }
}
