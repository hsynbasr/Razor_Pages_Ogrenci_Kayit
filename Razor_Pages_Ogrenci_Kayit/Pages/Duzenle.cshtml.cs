using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Pages_Ogrenci_Kayit.Data;
using Razor_Pages_Ogrenci_Kayit.Model;

namespace Razor_Pages_Ogrenci_Kayit.Pages
{
    public class DuzenleModel : PageModel
    {
        private readonly DbOgrenciler _db;

        public List<Kurs> Kurslar { get; set; }
        [BindProperty]
        public Ogrenci? Ogrenci { get; set; }
        public DuzenleModel(DbOgrenciler db)
        {
            _db = db;
            Kurslar = _db.Kurs.ToList();
        }
        public ActionResult OnGet(int? id)
        {
            
            if (id == null)
                return NotFound();
            Ogrenci = _db.Ogrencis.FirstOrDefault(i => i.Id == id);
            _db.SaveChanges();
            return Page();

        }
        public ActionResult OnPost(string selectedKursId)
        {
            if (selectedKursId!=null)
            {
                Ogrenci.KursId = Convert.ToInt32(selectedKursId);
                _db.Attach(Ogrenci).State = EntityState.Modified;
                _db.SaveChanges();
            }
            return RedirectToPage("Ogrenciler");
        }
    }
}
