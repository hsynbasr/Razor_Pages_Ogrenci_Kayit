namespace Razor_Pages_Ogrenci_Kayit.Model
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int KursId { get; set; }
        public Kurs Kurs { get; set; }


    }
}
