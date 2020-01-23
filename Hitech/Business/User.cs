using Hitech.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitech.Business
{
    public class Userr
    {
        private int userName;
        private string password;


        public string Password { get => password; set => password = value; }
        public int UserName { get => userName; set => userName = value; }

        public bool VerifyUser(Userr myUser)
        {
            return UserDB.IsValidUser(myUser);
        }

        public void SaPass(Userr au)
        {
            UserDB.SavePass(au);
        }
    }

}
