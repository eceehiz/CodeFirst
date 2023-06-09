﻿namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameKategoriAdtoKategoriAdiInKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriAdi", c => c.String());
            DropColumn("dbo.Kategoris", "KategoriAd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "KategoriAd", c => c.String());
            DropColumn("dbo.Kategoris", "KategoriAdi");
        }
    }
}
