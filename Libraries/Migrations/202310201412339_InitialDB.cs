namespace Libraries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
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
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 450),
                        Role = c.String(),
                        LastLogin = c.DateTime(nullable: false),
                        FName = c.String(),
                        LName = c.String(),
                        Department = c.String(),
                        DOJ = c.DateTime(nullable: false),
                        MgrId = c.Int(nullable: false),
                        Seniority = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EmpCode = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.UserId)
                .Index(t => t.UserName, unique: true)
                .Index(t => t.EmpCode, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "EmpCode" });
            DropIndex("dbo.Users", new[] { "UserName" });
            DropTable("dbo.Users");
            DropTable("dbo.SearchParameters");
        }
    }
}
