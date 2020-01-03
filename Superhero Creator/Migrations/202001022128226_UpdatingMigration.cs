namespace Superhero_Creator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingMigration : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Superheroes");
            AddColumn("dbo.Superheroes", "id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Superheroes", "superheroName", c => c.String());
            AddPrimaryKey("dbo.Superheroes", "id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Superheroes");
            AlterColumn("dbo.Superheroes", "superheroName", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Superheroes", "id");
            AddPrimaryKey("dbo.Superheroes", "superheroName");
        }
    }
}
