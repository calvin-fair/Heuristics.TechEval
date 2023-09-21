using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Heuristics.TechEval.Web.Models {

	/// <summary>
	/// DTO representing the creation of a new Member
	/// </summary>
	public class NewMember {
		public string Name { get; set; }
		public string Email { get; set; }
        public string Category { get; set; }
    }
}