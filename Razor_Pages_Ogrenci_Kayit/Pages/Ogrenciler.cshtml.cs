using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_Pages_Ogrenci_Kayit.Pages
{
    public class OgrencilerModel : PageModel
    {
        private readonly ILogger<OgrencilerModel> _logger;

        public OgrencilerModel(ILogger<OgrencilerModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}