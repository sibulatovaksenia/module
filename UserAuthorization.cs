using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization
{
    // Клас для виконання авторизації користувача
    public class UserAuthorization
    {
        private IAuthorizationStrategy _authorizationStrategy;

        public void SetAuthorizationStrategy(IAuthorizationStrategy strategy)
        {
            _authorizationStrategy = strategy;
        }

        public void Authorize()
        {
            _authorizationStrategy.Authorize();
        }
    }
}
