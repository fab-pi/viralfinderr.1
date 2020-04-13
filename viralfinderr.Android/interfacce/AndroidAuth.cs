using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Firebase.Auth;
using viralfinderr.Droid.interfacce;
using viralfinderr.interfacce;
using Xamarin.Forms;


[assembly: Xamarin.Forms.Dependency(typeof(AndroidAuth))]
namespace viralfinderr.Droid.interfacce
{
    public class AndroidAuth : FireAuth
    {
        public AndroidAuth()
        {
        }

        public async Task<string> LoginWithEmailPassword(string email, string password)
        {
            try
            {
                var user = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);

                var token = await user.User.GetIdTokenAsync(false);
                return token.Token;

            }
            catch (FirebaseAuthInvalidCredentialsException e)
            {
                e.PrintStackTrace();
                return "";

            }
        }



        public async Task<string> RegisterWithEmailPassword(string email, string password)
        {
            try
            {

                var user = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);

                var token = await user.User.GetIdTokenAsync(false);
                return token.Token;

            }
            catch (FirebaseAuthInvalidCredentialsException e)
            {
                e.PrintStackTrace();
                return "";

            }
        }


    }
}
