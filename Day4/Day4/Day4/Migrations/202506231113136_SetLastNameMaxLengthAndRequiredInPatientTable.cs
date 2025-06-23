namespace Day4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetLastNameMaxLengthAndRequiredInPatientTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "LastName", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "LastName", c => c.String());
        }
    }
}
