using System;
using System.Collections.Generic;

namespace Models
{
	public class Project
	{
		public int? Id { get; set;}
		public string Name {get;set;}
		public double Usage {get;set;}
		public double EstimationHours { get; set;}
		public double UsedHours { get; set;}

		public virtual ProjectGroup ProjectGroup {get;set;}
		public virtual IEnumerable<WorkLog> WorkLogs { get; set;}
	}
}

