namespace MySqlComMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contatoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Email = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contatoes");
        }
    }
}
