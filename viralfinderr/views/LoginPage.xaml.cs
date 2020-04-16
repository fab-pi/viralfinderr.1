using System;
using System.Collections.Generic;
using viralfinderr.classi;
using viralfinderr.interfacce;
using Xamarin.Forms;

namespace viralfinderr.views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public async void loginButton_Clicked(System.Object sender, System.EventArgs e)
        {
            String email = emailForm.Text;
            String pwd = passForm.Text;

            UserCheck credential = new UserCheck(email, pwd);

            try
            {

                //if (credential.checkUserInfo() && loginButton.IsPressed)
                //{
                    var log = DependencyService.Get<FireAuth>();
                    String token = await log.LoginWithEmailPassword(email, pwd);
                    await DisplayAlert("LOGGED", token, "ok");

                //}
                //else
                  //  await DisplayAlert("LOGIN ERROR", "check forms", "OK");




            }
            catch (Exception myEx)
            {
                Console.WriteLine(myEx.StackTrace);
            }



        }

        public async void registerButton_Clicked(System.Object sender, System.EventArgs e)
        {

            String email = emailForm.Text;
            String pwd = passForm.Text;

            UserCheck credential = new UserCheck(email, pwd);


            try
            {
                //if (registerButton.IsPressed && credential.checkUserInfo())
                //{

                    var log = DependencyService.Get<FireAuth>();
                    String token = await log.RegisterWithEmailPassword(email, pwd);
                    await DisplayAlert("REGISTERED", "successful logged in", "ok");
                    Console.WriteLine("utente registrato");

                //}
                //else
                //    await DisplayAlert("ERROR", "check forms", "OK");



            }
            catch (Exception myEx)
            {
                Console.WriteLine(myEx.StackTrace);
            }


        }

    }
}
