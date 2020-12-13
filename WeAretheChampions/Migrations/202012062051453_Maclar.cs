namespace WeAretheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Maclar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Match",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MatchTime = c.DateTime(),
                        Team1Id = c.Int(nullable: false),
                        Team2Id = c.Int(nullable: false),
                        Score1 = c.Int(nullable: false),
                        Score2 = c.Int(nullable: false),
                        Result = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Team", t => t.Team1Id)
                .ForeignKey("dbo.Team", t => t.Team2Id)
                .Index(t => t.Team1Id)
                .Index(t => t.Team2Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Match", "Team2Id", "dbo.Team");
            DropForeignKey("dbo.Match", "Team1Id", "dbo.Team");
            DropIndex("dbo.Match", new[] { "Team2Id" });
            DropIndex("dbo.Match", new[] { "Team1Id" });
            DropTable("dbo.Match");
        }
    }
}
