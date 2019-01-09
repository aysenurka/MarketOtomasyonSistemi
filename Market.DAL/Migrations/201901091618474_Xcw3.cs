namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Xcw3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Kategoriler", "AltKategoriId");
            RenameColumn(table: "dbo.Kategoriler", name: "UstKategoriId", newName: "AltKategoriId");
            RenameIndex(table: "dbo.Kategoriler", name: "IX_UstKategoriId", newName: "IX_AltKategoriId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Kategoriler", name: "IX_AltKategoriId", newName: "IX_UstKategoriId");
            RenameColumn(table: "dbo.Kategoriler", name: "AltKategoriId", newName: "UstKategoriId");
            AddColumn("dbo.Kategoriler", "AltKategoriId", c => c.Int());
        }
    }
}
