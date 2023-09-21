using System.Linq;

namespace Heuristics.TechEval.Core.Models {

	public class Category {

        private readonly DataContext _context;
        private int _membCnt;

        public Category()
        {
            _context = new DataContext();
        }

        public int Id { get; set; }
		public string Name { get; set; }
        public int MemberCount 
        { 
            get { return _membCnt; } 
            set { _membCnt = _context.Members.Where(c => c.Category == Name).Count(); } 
        }
    }
}


