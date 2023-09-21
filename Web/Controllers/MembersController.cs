using System.Linq;
using System.Web.Mvc;
using Heuristics.TechEval.Core;
using Heuristics.TechEval.Web.Models;
using Heuristics.TechEval.Core.Models;
using Newtonsoft.Json;
using System;

namespace Heuristics.TechEval.Web.Controllers {

	public class MembersController : Controller {

		private readonly DataContext _context;

		public MembersController() {
			_context = new DataContext();
		}

		public ActionResult List() {
			var allMembers = _context.Members.ToList();

			return View(allMembers);
        }

		[HttpPost]
		public ActionResult New(NewMember data) {
			var newMember = new Member {
				Name = data.Name,
				Email = data.Email,
                Category = data.Category,
                LastUpdated = DateTime.Now
			};
            ValidMemberInfo(newMember);

            _context.Members.Add(newMember);
			_context.SaveChanges();

			return Json(JsonConvert.SerializeObject(newMember));
		}

        [HttpPost]
        public ActionResult Edit(Member data)
        {
            var memb = _context.Members.Where(m => m.Id == data.Id).FirstOrDefault();
            ValidMemberInfo(data);

            memb.Email = data.Email;
			memb.Name = data.Name;
            memb.Category = data.Category;
			memb.LastUpdated = DateTime.Now;

            _context.SaveChanges();

            return Json(JsonConvert.SerializeObject(memb));
        }

		private Boolean NotADuplicate(String email)
		{
            var allMembs = from membs in _context.Members select membs;

            if (!String.IsNullOrEmpty(email))
            {
                var memb = allMembs.Where(s => s.Email.Contains(email));

				if (memb.Count() > 0)
				{
                    throw new Exception("Member already exist.");
                }
            }

            return true;
		}

        private Boolean ValidMemberInfo(Member data)
        {
            if (data.Email != null && data.Name != null)
            {
                NotADuplicate(data.Email);
                return true;
            }

            throw new Exception("Either email or name is missing.");
        }
    }
}