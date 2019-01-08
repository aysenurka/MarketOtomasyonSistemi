namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class barkodunique : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UrunDetaylar", "Barkod", c => c.String(maxLength: 11));
            CreateIndex("dbo.UrunDetaylar", "Barkod", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.UrunDetaylar", new[] { "Barkod" });
            AlterColumn("dbo.UrunDetaylar", "Barkod", c => c.String());
        }
    }
}
