using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization
{
    public class LoginPasswordAuthorization : IAuthorizationStrategy
    {
        private User[] registeredUsers;

        public LoginPasswordAuthorization(User[] users)
        {
            registeredUsers = users;
        }

        // Авторизация по логину и паролю
        public void Authorize()
        {
            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();

            bool isAuthorized = false;

            // Проверка логина и пароля
            foreach (var user in registeredUsers)
            {
                Console.WriteLine($"Проверяем логин: {user.Login} против введенного {login}");
                if (user.Login == login && user.Password == password)
                {
                    Console.WriteLine("Авторизация успешна.");
                    isAuthorized = true;
                    break;
                }
            }

            if (!isAuthorized)
            {
                Console.WriteLine("Неверный логин или пароль.");
            }
        }
    }
}

