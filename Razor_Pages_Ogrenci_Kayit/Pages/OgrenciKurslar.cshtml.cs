using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages_Ogrenci_Kayit.Data;
using Razor_Pages_Ogrenci_Kayit.Model;

namespace Razor_Pages_Ogrenci_Kayit.Pages
{
    public class OgrenciKurslarModel : PageModel
    {
        private readonly DbOgrenciler? _db;

        public List<Kurs>? Kurslar { get; set; }
        public List<Ogrenci>?  Ogrenciler { get; set; }
        public OgrenciKurslarModel(DbOgrenciler db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Kurslar = _db.Kurs.ToList();
            Ogrenciler = _db.Ogrencis.ToList();
        }
    }
}
