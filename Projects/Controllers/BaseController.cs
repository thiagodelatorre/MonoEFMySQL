using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projects.Controllers
{
    public abstract class BaseController : Controller
    {
		private Business.Business _Business = null;
		protected Business.Business Business
		{
			get
			{
				if (_Business == null)
					_Business = new Business.Business ();

				return _Business;
			}
		}
    }
}
