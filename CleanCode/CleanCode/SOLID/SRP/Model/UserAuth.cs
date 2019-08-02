using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.SRP.Model
{
    class UserAuth
    {
        private User User;

        public UserAuth(User user)
        {
            User = user;
        }

        public bool VerifyCredentials()
        {
            // ...
            return true;
        }
    }
}
