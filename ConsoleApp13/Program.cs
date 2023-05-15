using System;

namespace UcusRezervasyonKonsolUygulamasi
{
    public interface IMusteri
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        int Yas { get; set; }
    }

    public interface IUcus
    {
        string Kalkis { get; set; }
        string Varis { get; set; }
        DateTime KalkisZamani { get; set; }
        DateTime VarisZamani { get; set; }
        string UcusNumarasi { get; set; }
    }

    public interface IRezervasyon
    {
        IMusteri Musteri { get; set; }
        IUcus Ucus { get; set; }
        string RezervasyonNumarasi { get; set; }
    }

    public class Musteri : IMusteri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string CepTelefonu { get; set; }
    }

    public class Ucus : IUcus
    {
        public string Kalkis { get; set; }
        public string Varis { get; set; }
        public DateTime KalkisZamani { get; set; }
        public DateTime VarisZamani { get; set; }
        public string UcusNumarasi { get; set; }
    }

    public class Rezervasyon : IRezervasyon
    {
        public IMusteri Musteri { get; set; }
        public IUcus Ucus { get; set; }
        public string RezervasyonNumarasi { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Müşteri ve uçuş bilgileri girilir
            IMusteri musteri = new Musteri
            {
                Ad = "Hakan",
                Soyad = "Yetis",
                Yas = 30
            };

            IUcus ucus = new Ucus
            {
                Kalkis = "Istanbul",
                Varis = "Ankara",
                KalkisZamani = DateTime.Now.AddHours(2),
                VarisZamani = DateTime.Now.AddHours(3),
                UcusNumarasi = "TK123"
            };

            // Rezervasyon yapılır
            IRezervasyon rezervasyon = new Rezervasyon
            {
                Musteri = musteri,
                Ucus = ucus,
                RezervasyonNumarasi = "RN123456"
            };

            // Rezervasyon bilgileri ekrana basılır
            Console.WriteLine($"Müşteri: {rezervasyon.Musteri.Ad} {rezervasyon.Musteri.Soyad}");
            Console.WriteLine($"Uçuş: {rezervasyon.Ucus.Kalkis} - {rezervasyon.Ucus.Varis}");
            Console.WriteLine($"Uçuş No: {rezervasyon.Ucus.UcusNumarasi}");
            Console.WriteLine($"Rezervasyon No: {rezervasyon.RezervasyonNumarasi}");
        }
    }
}