using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages_Ogrenci_Kayit.Data;
using Razor_Pages_Ogrenci_Kayit.Model;

namespace Razor_Pages_Ogrenci_Kayit.Pages
{
    public class OgrencilerModel : PageModel
    {
        [BindProperty]
        public List<Kurs> Kurslar { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
        private readonly ILogger<OgrencilerModel> _logger;
        private readonly DbOgrenciler _db;

        public OgrencilerModel(ILogger<OgrencilerModel> logger,DbOgrenciler db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            Kurslar = _db.Kurs.ToList();
            Ogrenciler = _db.Ogrencis.ToList();
        }
    }
}