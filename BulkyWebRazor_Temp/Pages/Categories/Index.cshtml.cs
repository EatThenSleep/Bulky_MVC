using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public List<Category>? CategoryList { get; set; }
        public int Id { get; set; }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }

        public void onPost()
        {
            Category? category = _db.Categories.Find(Id);
            _db.Categories.Remove(category);
            _db.SaveChanges();
        }
    }
}
