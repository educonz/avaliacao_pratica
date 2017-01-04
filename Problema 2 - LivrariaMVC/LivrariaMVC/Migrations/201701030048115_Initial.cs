namespace LivrariaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeAutor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Editoras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeEditora = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Livroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        IdAutor = c.Int(nullable: false),
                        Ano = c.Int(nullable: false),
                        IdEditora = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Autors", t => t.IdAutor, cascadeDelete: true)
                .ForeignKey("dbo.Editoras", t => t.IdEditora, cascadeDelete: true)
                .Index(t => t.IdAutor)
                .Index(t => t.IdEditora);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livroes", "IdEditora", "dbo.Editoras");
            DropForeignKey("dbo.Livroes", "IdAutor", "dbo.Autors");
            DropIndex("dbo.Livroes", new[] { "IdEditora" });
            DropIndex("dbo.Livroes", new[] { "IdAutor" });
            DropTable("dbo.Livroes");
            DropTable("dbo.Editoras");
            DropTable("dbo.Autors");
        }
    }
}
