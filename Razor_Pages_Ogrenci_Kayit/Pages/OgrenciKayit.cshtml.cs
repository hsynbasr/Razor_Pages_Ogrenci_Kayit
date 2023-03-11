using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages_Ogrenci_Kayit.Data;
using Razor_Pages_Ogrenci_Kayit.Model;

namespace Razor_Pages_Ogrenci_Kayit.Pages
{
    public class OgrenciKayitModel : PageModel
    {
        [BindProperty]
        public Ogrenci Ogrenci { get; set; }
        public DbOgrenciler _db { get; set; }
        [BindProperty]
        public Kurs Kurs  { get; set; }

        public List<Kurs> Kurslar { get; set; }
        public OgrenciKayitModel(DbOgrenciler db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Kurslar = _db.Kurs.ToList();
        } 
        public ActionResult OnPost(string selectedKursId)
        {
            Ogrenci.KursId = Convert.ToInt32(selectedKursId);
            _db.Ogrencis.Add(Ogrenci);
            _db.SaveChanges();

            return RedirectToPage("Ogrenciler");
        }
    }
}
