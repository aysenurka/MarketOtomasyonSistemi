namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class son2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UrunDetaylar", "UrunAdetAciklama", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UrunDetaylar", "UrunAdetAciklama");
        }
    }
}
