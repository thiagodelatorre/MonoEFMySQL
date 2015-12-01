using System;

namespace Models
{
	public class WorkLog
	{
		public int? Id {get;set;}
		public virtual Project Project {get;set;}
		public double Usage {get;set;}
		public string Description {get;set;}
	}
}

