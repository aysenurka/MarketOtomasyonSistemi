namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altustkat : DbMigration
    {
        public override void Up()
        {
            Sql("alter table dbo.UrunDetaylar drop column ToplamAdet");
            Sql("alter table dbo.UrunDetaylar add [ToplamAdet] as ([Adet]*[BirimAdet])");

            Sql("alter table dbo.UrunDetaylar drop column AlisFiyat");
            Sql("alter table dbo.UrunDetaylar add [AlisFiyat] as [Fiyat]+[Fiyat]*[Kdv]");
            Sql("alter table dbo.UrunDetaylar drop column SatisFiyat");
            Sql("alter table dbo.UrunDetaylar add [SatisFiyat] as (([Fiyat]+[Fiyat]*[Kdv])-([Fiyat]+[Fiyat]*[Kdv])*[Indirim]+([Fiyat]+[Fiyat]*[Kdv])*[Kar]-([Fiyat]+[Fiyat]*[Kdv])*[Kar]*Indirim)");
        }
        
        public override void Down()
        {
        }
    }
}
