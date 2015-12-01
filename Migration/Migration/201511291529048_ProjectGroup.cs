using System.Data.Entity.Migrations.Infrastructure;

namespace EF
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjectGroup : DbMigration, IMigrationMetadata
    {
        	string IMigrationMetadata.Id {
			get { return "201511291529048_ProjectGroup"; }
		}

		string IMigrationMetadata.Source {
			get { return null; }
		}


		string IMigrationMetadata.Target {
			get { return "H4sIAAAAAAAAA+1Z3W7bNhS+71MIuhxSy06WojXsFJmTdMbiJIiTYncBLR073ChSE6nAxrAn28Ueaa+wQ/1ZImVb9tZgG3pTOBTPx/Pz8fywf/7+x+DjMmTOC8SSCj50e52u6wD3RUD5Yugmav72vfvx7M3gMgiXzudi24nehoJcDt1npaK+50n/GUIiOyH1YyHFXHV8EXokEN5xt/vB6/U8QAj37I3jDO4TrmgI+jf+NRLch0glhE1EAExmy/hhmkI6NyQEGREfhu7F+bXrnDNK8NwpsLnrEM6FIgq16j9KmKpY8MU0wgXCHlYR4L45YRJybfvr7W0V7x5rxb21YAHlJ1KJcE/A3knuCc8UP8ifbuEr9NYl+lSttNGpx4buXSx+Al99ikUSuY55Xn/EYr156GZe71S3HznZ4lEZciRG5/R9r9fpvftw+u2RM0qYSmIYckhUTNiRc5fMGPV/gNWD+Bn4kCeMVbRD/fBT9W9cwRMjiNXqHua5yuPAdbyalGeIlUIVicyMMVcnx65zgweTGYMy8BWTp0rE8Ak4xERBcEeUgphrDEh9Z55tHKX/LQ5DouEFcZ0JWV4DX6hndCNZus4VXUJQrOQKPHKK9wmFVJzAjjMeJVmUh1wI9Ck0mFSBGHjruLcgQ3sefKXAf4UCNsSlxPSa2vu9SGK5yz11rBvyQhepsIFazyf3wNJN8plGWTIumPNU33gVi/BesDVA7fvTFDX0tb1iy6YHEi9AtSH+uZTCp6lmdbXrWtUsvuSB00bDLOwVSzH4eAdohKxHTYbuN6YvdyAXZtnIue/q8N1Op2f4oGKudfuxripCkel1R0i9DsumVIAVNM8GMqeqYY2GnYJqIASSbB2PRltMzzRibYExESqmWzAGBStbt1HVyE0taVFaUjXC2w+rIIKNVTjXSIl14+1bUca+bKa8rJvKey6vuekaTEgUYVZb92D5gjPNGrDR2+n+jUqYYXi+tPuVUtHyIEzQmACNr3gyqnlFY6kuiCIzovPWKAitbSbJm0lXHNbEYytyBR0LIf07E8R2tLOFQWv3XaFJIVaY1DrYEGVLOm2BCSNxQ8EbCZaEfEPJ3CaclbCqeLbSGiCvT1WEfMmCGHiG/YZvPcu5dZab8dojmIfG8eAQ/v+itwnC6i6qYNbH1yVFPS82MsOoDY0sMPa0C7lO8s0tU2Oyt/zSii01pAbqaP+UWhymX17YDtNvT5UwTQc0bdbGUvelZU/a3mazGFq0sGqisaMkZFEb60VwkFeknY8TVoXKtrgO6v9CA12dJqvpL6yjv3fSnyNG8QKsd0wIp3OQKhug3NPOO+O549/z9OBJGbD27w+vOgdS7dOdk95+M1V19GMCp7u0hV5j7DvZBV9guP/q5AOc3Hp8Tg3eD8nKXBUka/oa8wCWQ/fXVLbvjH98MsSPnNsYk0Tf6Tq/bfXKl5yNK2XzkJG1CfKg0RpJDLFmGWGY2KWKMbWbrcRdTLlPI8KaTLDqW4vroV1bghofLiACrnlvGNfinN1FvQSvX9YdTtjvfcCesFpP/zuH/6wU4oWcCYx2RtutE+6G07Y9D2w5w4J//ceDmp/s2W/3i0GT7D//LmA1O0iy9f/WIMklXZTiun3jqEaFXeWOMZ+Lgul1VYodRq6cgCIBMu88VnROfIWffZAyfWP9TFiiE3M4g2DMbxMVJQpNhXDGqk+2+p5sOT199ajpO7iN0jfMv689akhRe7jl3yWUBaXKV3ZR34Cgr19eSXX0lK6oi1UJdCN4O5zcb2XGeIAwYoglb/mUvMABmj1KuIYF8VdFm7oRY2cAav4eXFCyiEkoM4C18Nkb5GsQLs/+AmhQREChHAAA"; }
		}

	public override void Up()
        {
            CreateTable(
                "dbo.ProjectGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Usage = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Usage = c.Double(nullable: false),
                        EstimationHours = c.Int(nullable: false),
                        ProjectGroup_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProjectGroups", t => t.ProjectGroup_Id)
                .Index(t => t.ProjectGroup_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "ProjectGroup_Id", "dbo.ProjectGroups");
            DropIndex("dbo.Projects", new[] { "ProjectGroup_Id" });
            DropTable("dbo.Projects");
            DropTable("dbo.ProjectGroups");
        }
    }
}
