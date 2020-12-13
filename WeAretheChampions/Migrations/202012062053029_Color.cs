namespace WeAretheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Color : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Color",
                c => new
                    {
                        RenkId = c.Int(nullable: false, identity: true),
                        ColorName = c.String(),
                    })
                .PrimaryKey(t => t.RenkId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Color");
        }
    }
}
