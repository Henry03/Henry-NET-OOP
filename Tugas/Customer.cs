using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas
{
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
}
