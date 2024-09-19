using System;

namespace Inheritance
{
    // Parent Class
    public class Lingkaran
    {
        double luas;
        
        // Method
        public double LuasLingkaran(double r)
        {
            luas = 3.14 * r * r;
            return (double)luas;
        }
    }

    // Child Class
    public class Tabung : Lingkaran
    {
        double volume;

        public Tabung(int tinggi, double r)
        {
            // Menggunakan metode luas lingkaran dari kelas lingkaran
            volume = tinggi * this.LuasLingkaran(r);
        }

        public double getVolume()
        {
            return volume;
        }

        static void Main(string[] args)
        {
            // Membuat object
            Tabung _tabung = new Tabung(5, 10);

            // Menampilkan volume tabung
            Console.WriteLine("Volume Tabung : " + _tabung.getVolume());
        }
    }
}