using System;
using System.Threading.Tasks;
using Firebase.Auth;
using viralfinderr.interfacce;
using viralfinderr.iOS.interfacce;
using Xamarin.Forms;

[assembly: Dependency(typeof(IosAuth))]
namespace viralfinderr.iOS.interfacce
{
    public interface IosAuth : FireAuth
    {


        public async Task<string> LoginWithEmailPassword(string email, string password)
        {
            try
            {
                var user = await Auth.DefaultInstance.SignInWithPasswordAsync(email, password);
                return await user.User.GetIdTokenAsync();

            }
            catch(Exception e)
            {
                return e.StackTrace;

            }



        }

        public async Task<string> RegisterWithEmailPassword(string email, string password)
        {
            try
            {
                var user = await Auth.DefaultInstance.CreateUserAsync(email, password);
                return await user.User.GetIdTokenAsync();

            }catch(Exception e)
            {
                return e.StackTrace;
            }
        }


    }
}
