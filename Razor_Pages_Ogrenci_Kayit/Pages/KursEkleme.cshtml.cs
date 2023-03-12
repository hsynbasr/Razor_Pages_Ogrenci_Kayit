using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages_Ogrenci_Kayit.Data;
using Razor_Pages_Ogrenci_Kayit.Model;

namespace Razor_Pages_Ogrenci_Kayit.Pages
{
    public class KursEklemeModel : PageModel
    {
        private readonly DbOgrenciler _db;

        [BindProperty]
        public Kurs Kurs  { get; set; }
        public KursEklemeModel(DbOgrenciler db)
        {
            _db = db;
        }
        public void OnGet()
        {
            
        }
        public ActionResult OnPost()
        {
            _db.Kurs.Add(Kurs);
            _db.SaveChanges();

            return RedirectToPage("OgrenciKurslar");
        }
    }
}
