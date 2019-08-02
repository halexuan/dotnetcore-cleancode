using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.SRP.Model
{
    class UserSettings
    {
        private User User;
        private UserAuth Auth;

        public UserSettings(User user)
        {
            User = user;
            Auth = new UserAuth(user);
        }

        public void ChangeSettings(UserSettings settings)
        {
            if (Auth.VerifyCredentials())
            {
                // ...
            }
        }

    }
}
