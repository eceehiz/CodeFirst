namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMusterisTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(),
                    })
                .PrimaryKey(t => t.KategoriId);
            
            CreateTable(
                "dbo.Uruns",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        UrunAd = c.String(),
                        UrunMarka = c.String(),
                        UrunKategori = c.String(),
                        UrunStok = c.Int(nullable: false),
                        Kategori_KategoriId = c.Int(),
                        Tedarikci_TedarikciId = c.Int(),
                    })
                .PrimaryKey(t => t.UrunId)
                .ForeignKey("dbo.Kategoris", t => t.Kategori_KategoriId)
                .ForeignKey("dbo.Tedarikcis", t => t.Tedarikci_TedarikciId)
                .Index(t => t.Kategori_KategoriId)
                .Index(t => t.Tedarikci_TedarikciId);
            
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        MusteriId = c.Int(nullable: false, identity: true),
                        MusteriAd = c.String(),
                        MusteriSoyad = c.String(),
                    })
                .PrimaryKey(t => t.MusteriId);
            
            CreateTable(
                "dbo.Tedarikcis",
                c => new
                    {
                        TedarikciId = c.Int(nullable: false, identity: true),
                        SirketAdi = c.String(),
                        Sehir = c.String(),
                    })
                .PrimaryKey(t => t.TedarikciId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Uruns", "Tedarikci_TedarikciId", "dbo.Tedarikcis");
            DropForeignKey("dbo.Uruns", "Kategori_KategoriId", "dbo.Kategoris");
            DropIndex("dbo.Uruns", new[] { "Tedarikci_TedarikciId" });
            DropIndex("dbo.Uruns", new[] { "Kategori_KategoriId" });
            DropTable("dbo.Tedarikcis");
            DropTable("dbo.Musteris");
            DropTable("dbo.Uruns");
            DropTable("dbo.Kategoris");
        }
    }
}
