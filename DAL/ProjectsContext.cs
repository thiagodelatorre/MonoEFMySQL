using System;
using System.Data.Entity;
using Models;

namespace DAL
{
	public class ProjectsContext : DbContext
	{
		public DbSet<Project> Projects { get; set; }
		public DbSet<ProjectGroup> ProjectGroups { get; set; }
		public DbSet<WorkLog> WorkLogs {get;set;}
	}
}

