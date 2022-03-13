using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToFrends
{
    internal class Logout 
    {
        private User user;

        public Logout()
        {
            string ardess, login, pass;
            ardess = null;

            Console.WriteLine("Введите логин:");
            login = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            pass  = Console.ReadLine();
            
            this.user = new User(ardess, login, pass);
        }

        //новое соединение с БД

        // Проверка логина и пароля

        // повторный попытка


        // Введите пароль

        // Введите электронную почту

        // Введите имя





    }
}
