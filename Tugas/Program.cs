using System;

namespace tugas
{
    public class User
    {
        private string nama;
        private string role;
        private int emoney;

        public string NamaUser
        {
            get { return nama; }
            set { nama = value; }
        }

        public string RoleUser
        {
            get { return role; }
            set { role = value; }
        }

        public int EmoneyUser
        {
            get { return emoney; }
            set { emoney = value; }
        }
    }

    public class Customer : User
    {
        public Customer(string nama, string role, int emoney)
        {
            this.NamaUser = nama;
            this.RoleUser = role;
            this.EmoneyUser = emoney;
        }

        public int GetEmoney()
        {
            return this.EmoneyUser;
        }
    }

    public class Admin : User
    {
        public Admin(string nama, string role, int emoney)
        {
            this.NamaUser = nama;
            this.RoleUser = role;
            this.EmoneyUser = emoney;
        }

        public void AddEmoney(Customer customer, int emoney)
        {
            customer.EmoneyUser += emoney;
        }

        public int GetEmoney(Customer customer)
        {
            return customer.EmoneyUser;
        }

    }

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
                Console.WriteLine("Pilih customer (william/surya) : ");
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
        }
    }
}