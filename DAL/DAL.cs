using System;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
	public class DAL
	{
		private ProjectsContext _ProjectsContext = null;

		private ProjectsContext ProjectsContext { 
			get 
			{ 
				if (_ProjectsContext == null)
					_ProjectsContext = new ProjectsContext ();

				return _ProjectsContext; 
			}
		}

		public IEnumerable<Project> GetProjects(int? id)
		{
			if (id != null)
				return ProjectsContext.Projects.Where (p => p.Id == id).ToList ();
			else
				return ProjectsContext.Projects.ToList ();
		}

		public Project AddProject(Project p)
		{
			ProjectsContext.Projects.Add (p);
			ProjectsContext.SaveChanges ();
			return p;
		}

		public WorkLog AddWorkLog(WorkLog w)
		{
			w.Project = ProjectsContext.Projects.Where(p => p.Id == w.Project.Id).Single();

			w.Project.UsedHours += w.Usage;

			ProjectsContext.WorkLogs.Add (w);

			ProjectsContext.SaveChanges ();

			return w;
		}

		public bool Add<T>(T entity)
		{
			return false;
		}

		private Object GetRespectiveSet<T>(T entity)
		{
//			if (T.GetType () == "Project")
//				return ProjectsContext.Projects;
//			else
				throw new NotImplementedException ("Map the type on the GetRespectiveSet on DAL");
		}
	}
}

