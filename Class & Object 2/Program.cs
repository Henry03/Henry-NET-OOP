using System;

namespace UserBootcamp
{
    class User
    {
        static void Main(string[] args)
        {
            UserBootcamp _userBootcamp = new UserBootcamp();
            _userBootcamp.NamaUser = "Henry";

            Console.WriteLine("Nama : " + _userBootcamp.NamaUser);
        }
    }
    public class UserBootcamp
    {
        string nama;
        string role;
        int emoney;

        public string NamaUser
        {
            get => nama; set => nama = value;
            //get; set;
        }

        public string RoleUser
        {
            get { return role; }
            set { role = value; }
        }

        public int Emoney
        {
            get { return emoney; }
            set { emoney = value; }
        }
    }
}