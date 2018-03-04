namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNewFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Address_Email", c => c.String(nullable: true));
            AddColumn("dbo.Person", "CreditsEarned", c => c.Int());
            AddColumn("dbo.Person", "Gpa", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Gpa");
            DropColumn("dbo.Person", "CreditsEarned");
            DropColumn("dbo.Person", "Address_Email");
        }
    }
}
