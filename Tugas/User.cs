using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas
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
}
