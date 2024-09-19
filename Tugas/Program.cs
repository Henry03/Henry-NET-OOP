using System;
using Tugas;

namespace tugas
{
    public class Program
    {
        static void Main(string[] args)
        {
            int saldoAwal = 1000;
            Customer customer = new Customer("William", "Customer", saldoAwal);
            Customer customer2 = new Customer("Surya", "Customer", saldoAwal);
            Admin admin = new Admin("Admin", "Admin", 0);
            string nama;
            string saldo;

            Console.WriteLine("Masukkan role anda (Admin/Customer) :");
            string role = Console.ReadLine();

            if (role == "Admin")
            {
                Console.WriteLine("Pilih customer (William/Surya) : ");
                nama = Console.ReadLine();

                if (nama == customer.NamaUser)
                {
                    Console.WriteLine("Masukkan saldo yang ingin ditambahkan : ");
                    saldo = Console.ReadLine();
                    admin.AddEmoney(customer, Convert.ToInt32(saldo));
                    Console.WriteLine("Saldo Awal : " + saldoAwal);
                    Console.WriteLine("Saldo berhasil ditambah, saldo sekarang : " + admin.GetEmoney(customer));
                }
                else if (nama == customer2.NamaUser)
                {
                    Console.WriteLine("Masukkan saldo yang ingin ditambahkan : ");
                    saldo = Console.ReadLine();
                    admin.AddEmoney(customer2, Convert.ToInt32(saldo));
                    Console.WriteLine("Saldo Awal : " + saldoAwal);
                    Console.WriteLine("Saldo berhasil ditambah, saldo sekarang : " + admin.GetEmoney(customer2));
                }
                else
                {
                    Console.WriteLine("User tidak ditemukan");
                }
            } 
            else if(role == "Customer")
            {
                Console.WriteLine("Masukkan nama : ");
                nama = Console.ReadLine();

                if (nama == customer.NamaUser)
                {
                    //Console.WriteLine("Saldo Awal : " + saldoAwal);
                    Console.WriteLine("Saldo " + customer.NamaUser + " sekarang : " + customer.GetEmoney());
                }
                else if (nama == customer2.NamaUser)
                {
                    //Console.WriteLine("Saldo Awal : " + saldoAwal);
                    Console.WriteLine("Saldo " + customer2.NamaUser +" sekarang : " + customer2.GetEmoney());
                }
                else
                {
                    Console.WriteLine("User tidak ditemukan");
                }
            }
            else
            {
                Console.WriteLine("Role tidak ditemukan");
            }
        }
    }
}