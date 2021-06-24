using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Qminds.Model;
namespace Qminds
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public SQLiteConnection loginconn; 
        public LoginPage()
        {
            InitializeComponent();
            loginconn = DependencyService.Get<ISQLite>().LoginConnection();
            loginconn.CreateTable<User>();
        }

        private void SignupButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
            User user = new User();
            user.Passowrd = PasswordUser.Text;
            user.UserName = EntryUser.Text;
            var data = (from stu in loginconn.Table<User>() select stu).ToList();
            foreach (var item in data)
            {
                if(item.UserName==user.UserName && item.Passowrd==user.Passowrd)
                {
                    DisplayAlert("loginsuccsefuli", "nice", "yes");
                    break;
                    
                }
            }
            
        }
    }
}