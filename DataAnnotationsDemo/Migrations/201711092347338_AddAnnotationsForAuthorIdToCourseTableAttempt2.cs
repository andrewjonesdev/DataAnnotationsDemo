namespace DataAnnotationsDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationsForAuthorIdToCourseTableAttempt2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Courses", name: "Author_Id", newName: "AuthorId");
            RenameIndex(table: "dbo.Courses", name: "IX_Author_Id", newName: "IX_AuthorId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Courses", name: "IX_AuthorId", newName: "IX_Author_Id");
            RenameColumn(table: "dbo.Courses", name: "AuthorId", newName: "Author_Id");
        }
    }
}
