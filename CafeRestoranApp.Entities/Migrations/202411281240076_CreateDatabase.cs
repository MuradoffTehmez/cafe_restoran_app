namespace CafeRestoranApp.Entities.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menu",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    MenuAdi = c.String(maxLength: 50, unicode: false),
                    Aciklama = c.String(maxLength: 50, unicode: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Urun",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    MennuID = c.Int(nullable: false),
                    UrunKodu = c.String(maxLength: 50, unicode: false),
                    Uruni = c.String(),
                    Qiymet1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Qiymet2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Tarix = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menu", t => t.MennuID, cascadeDelete: true)
                .Index(t => t.MennuID);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Urun", "MennuID", "dbo.Menu");
            DropIndex("dbo.Urun", new[] { "MennuID" });
            DropTable("dbo.Urun");
            DropTable("dbo.Menu");
        }
    }
}
