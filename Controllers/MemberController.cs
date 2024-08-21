using Microsoft.AspNetCore.Mvc;
using NetCore.Data;
using NetCore.Models;

namespace NetCore.Controllers
{
    public class MemberController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MemberController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Member> objMemberList = _db.Members.ToList();
            return View(objMemberList);
        }

        [HttpPost]
        public IActionResult Index(string p1, string p2, string p3, string p4)
        {
            /*
            return Json(new
            {
                test = q
            });
            */

            List<Member> objMemberList = null;
            if (p1 != null && p1 != "") objMemberList = _db.Members.Where(u => u.Cname == p1).ToList();

            if (p2 != null && p2 != "" && objMemberList!= null) objMemberList = objMemberList.Where(u => u.Ename == p2).ToList();
            else if (p2 != null && p2 != "" && objMemberList == null) objMemberList = _db.Members.Where(u => u.Ename == p2).ToList();

            if (p3 != null && p3 != "" && objMemberList != null) objMemberList = objMemberList.Where(u => u.Email == p3).ToList();
            else if (p3 != null && p3 != "" && objMemberList == null) objMemberList = _db.Members.Where(u => u.Email == p3).ToList();

            if (p4 != null && p4 != "" && objMemberList != null) objMemberList = objMemberList.Where(u => u.Tel == p4).ToList();
            else if (p4 != null && p4 != "" && objMemberList == null) objMemberList = _db.Members.Where(u => u.Tel == p4).ToList();


            return Json(new { data = objMemberList });
        }
    }
}
