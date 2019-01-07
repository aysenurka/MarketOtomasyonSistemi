namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entitiescreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alislar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        KategoriAd = c.String(nullable: false, maxLength: 30),
                        Aciklama = c.String(maxLength: 100),
                        Kdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.Satislar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UrunDetaylar",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urunler", "KategoriId", "dbo.Kategoriler");
            DropIndex("dbo.Urunler", new[] { "KategoriId" });
            DropTable("dbo.UrunDetaylar");
            DropTable("dbo.Satislar");
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategoriler");
            DropTable("dbo.Alislar");
        }
    }
}
