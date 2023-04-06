using Microsoft.AspNetCore.Mvc;
using WebDiary.Models;

namespace WebDiary.Controllers
{
    public class HomeController : Controller
    {
        readonly DiaryDbContext db = new DiaryDbContext();
        public IActionResult ListContent()
        {
            
            var listc = db.Contents.ToList();
            return View(listc);
        }

        public IActionResult Add(Content content) 
        {
            if (ModelState.IsValid)
            {
                db.Contents.Add(content);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
