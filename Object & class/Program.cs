using System;

namespace UserManagement
{
    class User
    {
        // Atribut
        string nama = "Henry";
        string role = "Dev";
        int emoney = 1000000000;

        // Method
        public void UserDetail()
        {
            Console.WriteLine("Ini detail usernya");

        }

        // Membuat Object
        static void Main(string[] args)
        {
            // Kelas adalah blueprint dari object
            User userbootcamp = new User();

            userbootcamp.UserDetail();
            Console.WriteLine("Nama : " + userbootcamp.nama);
            Console.WriteLine("Role : " + userbootcamp.role);
            Console.WriteLine("Emoney : " + userbootcamp.emoney);
        }
    }
}