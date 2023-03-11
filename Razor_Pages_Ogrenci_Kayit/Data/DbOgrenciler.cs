using Microsoft.EntityFrameworkCore;
using Razor_Pages_Ogrenci_Kayit.Model;

namespace Razor_Pages_Ogrenci_Kayit.Data
{
    public class DbOgrenciler:DbContext
    {
        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Kurs> Kurs { get; set; }
        public DbOgrenciler(DbContextOptions<DbOgrenciler> options):base(options) 
        {
            
        }
    }
}
