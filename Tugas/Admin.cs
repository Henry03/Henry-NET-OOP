using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas
{
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
}
