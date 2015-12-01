using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Models;

namespace Projects.Controllers
{
	public class HomeController : BaseController
	{
		public ActionResult Index ()
		{
//			var mvcName = typeof(Controller).Assembly.GetName ();
//			var isMono = Type.GetType ("Mono.Runtime") != null;
//
//			ViewData ["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
//			ViewData ["Runtime"] = isMono ? "Mono" : ".NET";

			return View ();
		}

		public ActionResult Projects(int? id)
		{
			List<Project> Projects = (List<Project>)this.Business.GetProjects (id);

			return View (Projects);
		}

		[HttpGet]
		public ActionResult AddProject()
		{
//			Project model = new Project ();
//			model.Name = "Test3";
			return View ();
		}

		[HttpPost]
		public ActionResult AddProject(Project model)
		{
			if (ModelState.IsValid) {
				Business.AddProject (model);

				return RedirectToAction ("Projects");
			}

			return View (model);
		}

		//TODO: add date on the worklog
		public ActionResult WorkLog()
		{
			WorkLog model = new WorkLog ();
			model.Project = new Project ();

			return View (model);
		}

		[HttpPost]
		public ActionResult WorkLog(WorkLog model)
		{
			if (ModelState.IsValid) {
				model = Business.AddWorkLog (model);

				return RedirectToAction ("Projects");
			}

			return View(model);
		}
	}
}

