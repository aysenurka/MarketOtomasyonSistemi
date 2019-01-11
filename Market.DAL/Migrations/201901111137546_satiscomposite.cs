namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class satiscomposite : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.SatisDetaylar", name: "SatisId", newName: "Id");
            RenameColumn(table: "dbo.SatisDetaylar", name: "UrunId", newName: "Id2");
            RenameIndex(table: "dbo.SatisDetaylar", name: "IX_SatisId", newName: "IX_Id");
            RenameIndex(table: "dbo.SatisDetaylar", name: "IX_UrunId", newName: "IX_Id2");
            DropPrimaryKey("dbo.SatisDetaylar");
            AddPrimaryKey("dbo.SatisDetaylar", new[] { "Id", "Id2" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.SatisDetaylar");
            AddPrimaryKey("dbo.SatisDetaylar", new[] { "UrunId", "SatisId" });
            RenameIndex(table: "dbo.SatisDetaylar", name: "IX_Id2", newName: "IX_UrunId");
            RenameIndex(table: "dbo.SatisDetaylar", name: "IX_Id", newName: "IX_SatisId");
            RenameColumn(table: "dbo.SatisDetaylar", name: "Id2", newName: "UrunId");
            RenameColumn(table: "dbo.SatisDetaylar", name: "Id", newName: "SatisId");
        }
    }
}
