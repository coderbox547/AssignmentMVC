namespace Libraries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changetablestructure : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parameters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Json = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.SearchParameters");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SearchParameters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        SearchJson = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Parameters");
        }
    }
}
