namespace CodeFirstEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePost : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Postid = c.Int(nullable: false, identity: true),
                        datePublish = c.DateTime(nullable: false),
                        Title = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.Postid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
        }
    }
}
