namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uniquefields : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Urunler", "UrunAd", unique: true);
            CreateIndex("dbo.Kategoriler", "KategoriAd", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Kategoriler", new[] { "KategoriAd" });
            DropIndex("dbo.Urunler", new[] { "UrunAd" });
        }
    }
}
