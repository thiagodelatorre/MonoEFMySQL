using System;
using Models;
using DAL;
using System.Collections.Generic;

namespace Business
{
	public class Business
	{
		private DAL.DAL _DAL = null;

		private DAL.DAL DAL { 
			get 
			{ 
				if (_DAL == null)
					_DAL = new DAL.DAL ();
				
				return _DAL; 
			}
		}

		public IEnumerable<Project> GetProjects(int? Id)
		{
			return DAL.GetProjects (Id);
		}

		public Project AddProject(Project p)
		{
			DAL.AddProject (p);
			return p;
		}

		public WorkLog AddWorkLog(WorkLog w)
		{
			return DAL.AddWorkLog (w);
		}
	}
}

