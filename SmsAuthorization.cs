using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization
{
    // Авторизація за СМС
    public class SmsAuthorization : IAuthorizationStrategy
    {
        private string _smsCode = "1234";

        public void Authorize()
        {
            SendSmsCode();
            Console.WriteLine("Введите код СМС:");
            string smsCode = Console.ReadLine();

            if (smsCode == _smsCode)
            {
                Console.WriteLine("Авторизация по СМС успешна.");
            }
            else
            {
                Console.WriteLine("Неверный код СМС.");
            }
        }

        private void SendSmsCode()
        {
            Console.WriteLine("Отправлен код СМС: " + _smsCode);
        }
    }
}
