namespace EntityFrameworkAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Madealumnidonornullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "AlumniDonor", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "AlumniDonor", c => c.Boolean(nullable: false));
        }
    }
}
