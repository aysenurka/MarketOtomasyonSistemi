namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class satisdetay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SatisDetaylar", "Adet", c => c.Int(nullable: false));
            AddColumn("dbo.SatisDetaylar", "BirimFiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SatisDetaylar", "BirimFiyat");
            DropColumn("dbo.SatisDetaylar", "Adet");
        }
    }
}
