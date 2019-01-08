namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class computedtoplamadet : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UrunDetaylar", "ToplamAdet", c => c.Int(nullable: false));
            Sql("alter table dbo.UrunDetaylar drop column ToplamAdet");
            Sql("alter table dbo.UrunDetaylar add [ToplamAdet] as ([Adet]*[BirimAdet])");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UrunDetaylar", "ToplamAdet", c => c.Int(nullable: false));
        }
    }
}
