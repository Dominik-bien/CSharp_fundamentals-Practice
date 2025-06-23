namespace Day4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetFirstNameMaxLengthAndRequiredAtPatientTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "FirstName", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "FirstName", c => c.String());
        }
    }
}
