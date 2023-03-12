using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages_Ogrenci_Kayit.Data;
using Razor_Pages_Ogrenci_Kayit.Model;

namespace Razor_Pages_Ogrenci_Kayit.Pages
{
    public class SilmeModel : PageModel
    {
        private readonly DbOgrenciler _db;
        [BindProperty]
        public Ogrenci? Ogrenci { get; set; }
        [BindProperty]
        public Kurs? Kurs { get; set; }
        public SilmeModel(DbOgrenciler db)
        {
            _db = db;

        }

        public ActionResult OnGet(int? id)
        {
            if (id != null)
            {
                Ogrenci = _db.Ogrencis.FirstOrDefault(i => i.Id == id);
                Kurs = _db.Kurs.FirstOrDefault(k => k.KursId == Ogrenci.KursId);
                return Page();
            }
            return NotFound();
        }
        public ActionResult OnPost()
        {
            if (Ogrenci != null)
            {
                _db.Ogrencis.Remove(Ogrenci);
                _db.SaveChanges();
                return RedirectToPage("Ogrenciler");
            }
            return NotFound();
        }
    }
}
