namespace WeAretheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OyuncuEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Player",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamId = c.Int(nullable: false),
                        PlayerName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Team", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Player", "TeamId", "dbo.Team");
            DropIndex("dbo.Player", new[] { "TeamId" });
            DropTable("dbo.Player");
        }
    }
}
