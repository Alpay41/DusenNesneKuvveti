using System;

public class DusenNesneKuvveti
{
    public static void KuvvetiHesapla(double yukseklik, double agirlik)
    {
        const double yerCekimi = 9.8; // Yer çekimi ivmesi (m/s^2)
        double hiz = Math.Sqrt(2 * yerCekimi * yukseklik); // Düşme hızını hesapla
        double kuvvet = agirlik * hiz; // Kuvveti hesapla

        Console.WriteLine("Nesnenin Yere Uyguladığı Kuvvet: " + kuvvet.ToString("N2") + " N");
    }

    public static void Main(string[] args)
    {
        // Örnek kullanım
        double dusmeYuksekligi = 50.0; // Düşme yüksekliği (metre)
        double agirlik = 70.0; // Nesnenin ağırlığı (kilogram)

        KuvvetiHesapla(dusmeYuksekligi, agirlik);
    }
}
