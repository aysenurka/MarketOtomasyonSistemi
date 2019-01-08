namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relationfixed : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Urunler", "UrunDetayId", "dbo.UrunDetaylar");
            DropIndex("dbo.Urunler", new[] { "UrunDetayId" });
            AddColumn("dbo.Satislar", "SatisTarih", c => c.DateTime(nullable: false));
            CreateIndex("dbo.UrunDetaylar", "UrunId");
            AddForeignKey("dbo.UrunDetaylar", "UrunId", "dbo.Urunler", "Id", cascadeDelete: true);
            DropColumn("dbo.Urunler", "UrunDetayId");
            DropColumn("dbo.Satislar", "SatisDetayTarih");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Satislar", "SatisDetayTarih", c => c.DateTime(nullable: false));
            AddColumn("dbo.Urunler", "UrunDetayId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.UrunDetaylar", "UrunId", "dbo.Urunler");
            DropIndex("dbo.UrunDetaylar", new[] { "UrunId" });
            DropColumn("dbo.Satislar", "SatisTarih");
            CreateIndex("dbo.Urunler", "UrunDetayId");
            AddForeignKey("dbo.Urunler", "UrunDetayId", "dbo.UrunDetaylar", "Id", cascadeDelete: true);
        }
    }
}
