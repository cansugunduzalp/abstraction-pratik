

namespace CalisanApp
{
    // Soyut temel sınıf
    public abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        // Soyut metot: Her alt sınıf kendi görevini belirtmek için implement edecek
        public abstract void Gorev();
    }

    // Yazılım Geliştirici sınıfı
    public class YazilimGelistirici : Calisan
    {
        public YazilimGelistirici(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
        }

        // Yazılım Geliştirici için görev metodunu implement et
        public override void Gorev()
        {
            Console.WriteLine("Yazılım Geliştiricisi olarak çalışıyorum.");
        }
    }

    // Proje Yöneticisi sınıfı
    public class ProjeYoneticisi : Calisan
    {
        public ProjeYoneticisi(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
        }

        // Proje Yöneticisi için görev metodunu implement et
        public override void Gorev()
        {
            Console.WriteLine("Proje yöneticisi olarak çalışıyorum.");
        }
    }

    // Satış Temsilcisi sınıfı
    public class SatisTemsilcisi : Calisan
    {
        public SatisTemsilcisi(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
        }

        // Satış Temsilcisi için görev metodunu implement et
        public override void Gorev()
        {
            Console.WriteLine("Satış Temsilcisi olarak çalışıyorum.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Çalışanları oluştur
            Calisan yazilimci = new YazilimGelistirici("Hasan", "Çıldırmış", "Yazılım");
            Calisan projeYoneticisi = new ProjeYoneticisi("Ayşe", "Kaya", "Proje Yönetimi");
            Calisan satisTemsilcisi = new SatisTemsilcisi("Mehmet", "Öztürk", "Satış");

            // Gorev metodunu çağır
            yazilimci.Gorev();
            projeYoneticisi.Gorev();
            satisTemsilcisi.Gorev();
        }
    }
}
