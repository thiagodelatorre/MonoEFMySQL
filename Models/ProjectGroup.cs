using System;
using System.Collections.Generic;

namespace Models
{
	public class ProjectGroup
	{
		public int? Id { get; set; }
		public string Name { get; set; }
		public double Usage { get; set; }
		public virtual IEnumerable<Project> Projects {get;set;}
	}
}

