using System.Data.Entity.Migrations.Infrastructure;

namespace EF
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkLogs : DbMigration, IMigrationMetadata
    {
        	string IMigrationMetadata.Id {
			get { return "201512011201116_WorkLogs"; }
		}

		string IMigrationMetadata.Source {
			get { return null; }
		}


		string IMigrationMetadata.Target {
			get { return "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"; }
		}

	public override void Up()
        {
            CreateTable(
                "dbo.WorkLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usage = c.Double(nullable: false),
                        Description = c.String(unicode: false),
                        Project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Project_Id);
            
            AddColumn("dbo.Projects", "UsedHours", c => c.Double(nullable: false));
            AlterColumn("dbo.Projects", "EstimationHours", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkLogs", "Project_Id", "dbo.Projects");
            DropIndex("dbo.WorkLogs", new[] { "Project_Id" });
            AlterColumn("dbo.Projects", "EstimationHours", c => c.Int(nullable: false));
            DropColumn("dbo.Projects", "UsedHours");
            DropTable("dbo.WorkLogs");
        }
    }
}
