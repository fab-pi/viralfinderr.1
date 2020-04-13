using System;
namespace viralfinderr.classi
{
    public class UserCheck
    {

        public String email { get; set; }
        public String password { get; set; }

        public UserCheck()
        {
        }

        public UserCheck(String email, String pass)
        {
            this.email = email;
            this.password = pass;
        }

        public bool checkUserInfo()
        {
            return !this.email.Equals("") && this.password.Length >= 6;
        }



    }
}
