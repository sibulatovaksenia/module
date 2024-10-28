using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization
{
    // Авторизація за електронною поштою
    public class EmailAuthorization : IAuthorizationStrategy
    {
        private string _emailCode = "5678";

        public void Authorize()
        {
            SendEmailCode();
            Console.WriteLine("Введите код из электронной почты:");
            string emailCode = Console.ReadLine();

            if (emailCode == _emailCode)
            {
                Console.WriteLine("Авторизация по электронной почте успешна.");
            }
            else
            {
                Console.WriteLine("Неверный код из электронной почты.");
            }
        }

        private void SendEmailCode()
        {
            Console.WriteLine("Отправлен код на электронную почту: " + _emailCode);
        }
    }
}
