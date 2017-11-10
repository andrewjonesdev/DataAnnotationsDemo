namespace DataAnnotationsDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationsForAuthorIdToCourseTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "AuthorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "AuthorId", c => c.Int(nullable: false));
        }
    }
}
