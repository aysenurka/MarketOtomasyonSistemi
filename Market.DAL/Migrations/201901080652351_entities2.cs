namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entities2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alislar", "AlisTarih", c => c.DateTime(nullable: false));
            AddColumn("dbo.Alislar", "UrunDetayId", c => c.Guid(nullable: false));
            AddColumn("dbo.Urunler", "UrunDetayId", c => c.Guid(nullable: false));
            AddColumn("dbo.Satislar", "SatisTarih", c => c.DateTime(nullable: false));
            AddColumn("dbo.Satislar", "UrunDetayId", c => c.Guid(nullable: false));
            AddColumn("dbo.UrunDetaylar", "UrunId", c => c.Guid(nullable: false));
            AddColumn("dbo.UrunDetaylar", "Barkod", c => c.String());
            AddColumn("dbo.UrunDetaylar", "Adet", c => c.Short(nullable: false));
            AddColumn("dbo.UrunDetaylar", "BirimAdet", c => c.Int(nullable: false));
            AddColumn("dbo.UrunDetaylar", "ToplamAdet", c => c.Int(nullable: false));
            AddColumn("dbo.UrunDetaylar", "Fiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.UrunDetaylar", "AlisFiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.UrunDetaylar", "SatisFiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            CreateIndex("dbo.Alislar", "UrunDetayId");
            CreateIndex("dbo.Urunler", "UrunDetayId");
            CreateIndex("dbo.Satislar", "UrunDetayId");
            AddForeignKey("dbo.Urunler", "UrunDetayId", "dbo.UrunDetaylar", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Alislar", "UrunDetayId", "dbo.UrunDetaylar", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Satislar", "UrunDetayId", "dbo.UrunDetaylar", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Satislar", "UrunDetayId", "dbo.UrunDetaylar");
            DropForeignKey("dbo.Alislar", "UrunDetayId", "dbo.UrunDetaylar");
            DropForeignKey("dbo.Urunler", "UrunDetayId", "dbo.UrunDetaylar");
            DropIndex("dbo.Satislar", new[] { "UrunDetayId" });
            DropIndex("dbo.Urunler", new[] { "UrunDetayId" });
            DropIndex("dbo.Alislar", new[] { "UrunDetayId" });
            DropColumn("dbo.UrunDetaylar", "SatisFiyat");
            DropColumn("dbo.UrunDetaylar", "AlisFiyat");
            DropColumn("dbo.UrunDetaylar", "Fiyat");
            DropColumn("dbo.UrunDetaylar", "ToplamAdet");
            DropColumn("dbo.UrunDetaylar", "BirimAdet");
            DropColumn("dbo.UrunDetaylar", "Adet");
            DropColumn("dbo.UrunDetaylar", "Barkod");
            DropColumn("dbo.UrunDetaylar", "UrunId");
            DropColumn("dbo.Satislar", "UrunDetayId");
            DropColumn("dbo.Satislar", "SatisTarih");
            DropColumn("dbo.Urunler", "UrunDetayId");
            DropColumn("dbo.Alislar", "UrunDetayId");
            DropColumn("dbo.Alislar", "AlisTarih");
        }
    }
}
