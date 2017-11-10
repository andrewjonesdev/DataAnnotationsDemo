namespace DataAnnotationsDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationsForAuthorIdRequiredToCourseTableAttempt : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "AuthorId" });
            AlterColumn("dbo.Courses", "AuthorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "AuthorId");
            AddForeignKey("dbo.Courses", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "AuthorId" });
            AlterColumn("dbo.Courses", "AuthorId", c => c.Int());
            CreateIndex("dbo.Courses", "AuthorId");
            AddForeignKey("dbo.Courses", "AuthorId", "dbo.Authors", "Id");
        }
    }
}
