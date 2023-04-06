using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyDiaryWeb.Models;

namespace MyDiaryWeb.Controllers
{
    public class HomeController : Controller
    {
        readonly DiaryDbContext db = new DiaryDbContext();
        public IActionResult Index()
        {

            var contents = db.Contents.ToList();
            return View(contents);
        }

        

        [HttpPost]
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
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var content = db.Contents.Find(id);
            if (content == null)
            {
                return NotFound();
            }
            db.Contents.Remove(content);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(Content c)
        {
            if (ModelState.IsValid)
            {
                db.Contents.Update(c);
                db.SaveChanges();
            }
            return View(c);
            
        }
    }
}
