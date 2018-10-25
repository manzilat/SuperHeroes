namespace SuperHeroes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedpropertiestodbcontext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SuperHeroes",
                c => new
                    {
                        SuperHeroID = c.Int(nullable: false, identity: true),
                        SuperHeroName = c.String(),
                        AlterEgo = c.String(),
                        PrimarySuperHeroAbility = c.String(),
                        SecondarySuperHeroAbility = c.String(),
                        Catchphrase = c.String(),
                    })
                .PrimaryKey(t => t.SuperHeroID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SuperHeroes");
        }
    }
}
