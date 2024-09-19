using System;

namespace Encapsulation
{
    // Class lingkaran dengan enkapsulasi
    public class Lingkaran
    {
        // Private field untuk menyimpan nilai radius
        private double radius;

        // Public property untuk mengakses dan mengatur radius
        public double Radius
        {
            get { return radius; }
            set {
                if(value > 0)
                {
                    radius = value; 
                }
                else
                {
                    throw new ArgumentException("Radius harus lebih dari nol");
                }
            }

        }
        // method untuk hitung luas lingkaran
        public double Luas ()
        {
            return 3.14 * radius * radius;
        }

        // Ckass tabung menggunakan lingkaran sebagai komponen
        public class Tabung
        {
            private Lingkaran lingkaran;
            private double tinggi;

            // Konstruktor untuk inisiasi tabung
            public Tabung(double radius, double tinggi)
            {
                lingkaran = new Lingkaran();
                lingkaran.Radius = radius; // Menggunakan property untuk mengatur radius
                this.tinggi = tinggi;
            }

           public double HitungVolume()
            {
                return lingkaran.Luas() * tinggi;
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Tabung tabung = new Tabung(1, 20);
                    Console.WriteLine("Luas tabung : " + tabung.HitungVolume());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

             
    }
}