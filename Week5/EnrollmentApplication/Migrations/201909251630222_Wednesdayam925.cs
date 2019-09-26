namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Wednesdayam925 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrollments", "isActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Enrollments", "AssignedCampus", c => c.String());
            AddColumn("dbo.Enrollments", "EnrollmentSemester", c => c.String());
            AddColumn("dbo.Enrollments", "EnrollmentYear", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Enrollments", "EnrollmentYear");
            DropColumn("dbo.Enrollments", "EnrollmentSemester");
            DropColumn("dbo.Enrollments", "AssignedCampus");
            DropColumn("dbo.Enrollments", "isActive");
        }
    }
}
