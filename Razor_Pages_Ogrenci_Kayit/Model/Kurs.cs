namespace Razor_Pages_Ogrenci_Kayit.Model
{
    public class Kurs
    {
        public int KursId { get; set; }
        public string KursAdi { get; set; }

        public ICollection<Ogrenci> Ogrencis { get; set; }

    }
}
