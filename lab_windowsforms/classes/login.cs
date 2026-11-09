using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_windowsforms.classes
{
    internal class login
    {
        private int id;
        private string userLogin;
        private string userPassword;
        private string userProfile;

        public login(int id, string userLogin, string userPassword, string userProfile)
        {
            this.id = id;
            this.userLogin = userLogin;
            this.userPassword = userPassword;
            this.userProfile = userProfile;
        }


        public bool autenticar(string username, string password) {
                       
            return username == this.userLogin && password == this.userPassword;     
                        
        }
    }
}
