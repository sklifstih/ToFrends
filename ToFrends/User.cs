using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToFrends
{
    internal class User : IUser
    {

        private string adress, login, pass; 



        public User(string adress, string login, string pass)
        {
            this.adress = adress;
            this.login = login;
            this.pass = pass;
        }

        public string Adress => adress;

        public string Login => login;

        public string Pass => pass;

        // Введите логин

        // Введите пароль

        // Введите электронную почту

        // Введите имя

    }
}
