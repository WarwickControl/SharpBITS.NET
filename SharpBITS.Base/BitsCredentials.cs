using System;
using System.Collections.Generic;
using System.Text;
using System.Security;

using SharpBits;

namespace SharpBits.Base
{
    public class BitsCredentials
    {
        AuthenticationScheme authenticationScheme;
        AuthenticationTarget authenticationTarget;
        string  userName;
        string password;

        public AuthenticationScheme AuthenticationScheme
        {
            get { return this.authenticationScheme; }
            set { this.authenticationScheme = value; }
        }

        public AuthenticationTarget AuthenticationTarget
        {
            get { return this.authenticationTarget; }
            set { this.authenticationTarget = value; }
        }

        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
    }
}
