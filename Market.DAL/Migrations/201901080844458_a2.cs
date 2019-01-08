namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Satislar", "ToplamFiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Satislar", "Toplam");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Satislar", "Toplam", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Satislar", "ToplamFiyat");
        }
    }
}
