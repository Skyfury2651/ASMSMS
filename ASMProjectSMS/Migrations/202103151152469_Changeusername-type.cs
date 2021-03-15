namespace ASMProjectSMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changeusernametype : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        phoneNumber = c.String(),
                        email = c.String(),
                        status = c.Int(nullable: false),
                        secret_code = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
