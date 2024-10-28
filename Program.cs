using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] registeredUsers = new User[]
            {
                new User("user1", "password1"),
                new User("user2", "password2"),
                new User("user3", "password3")
            };

            UserAuthorization userAuth = new UserAuthorization();

            Console.WriteLine("Выберите способ авторизации:");
            Console.WriteLine("1 - Логин и пароль");
            Console.WriteLine("2 - СМС");
            Console.WriteLine("3 - Электронная почта");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    userAuth.SetAuthorizationStrategy(new LoginPasswordAuthorization(registeredUsers));
                    break;
                case "2":
                    userAuth.SetAuthorizationStrategy(new SmsAuthorization());
                    break;
                case "3":
                    userAuth.SetAuthorizationStrategy(new EmailAuthorization());
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    return;
            }

            userAuth.Authorize();
        }
    }
}


