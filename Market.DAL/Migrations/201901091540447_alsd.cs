namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alsd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoriler", "AltKategoriId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kategoriler", "AltKategoriId");
        }
    }
}
