namespace CCA.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CcaUsers",
                c => new
                    {
                        CcaUserId = c.Long(nullable: false, identity: true),
                        CcaAccountId = c.String(),
                        Email = c.String(),
                        HashedPassword = c.String(),
                        PasswordSalt = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        DateUpdated = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.CcaUserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CcaUsers");
        }
    }
}
