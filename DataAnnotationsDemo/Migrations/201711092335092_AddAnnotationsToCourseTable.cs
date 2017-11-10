namespace DataAnnotationsDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationsToCourseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "AuthorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false, maxLength: 2000));
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Courses", "Description", c => c.String());
            DropColumn("dbo.Courses", "AuthorId");
        }
    }
}
