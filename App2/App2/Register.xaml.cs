using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Qminds.Model;
namespace Qminds
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        SQLiteConnection loginconn;
        public Register()
        {
            InitializeComponent();
            loginconn = DependencyService.Get<ISQLite>().LoginConnection();
            loginconn.CreateTable<User>();
        }

        private void RegiterButton_Clicked(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = EntryUsername.Text;
            user.Passowrd = EntryPassword.Text;
            user.Email = EntryEmail.Text;
            user.Phone =long.Parse(EntryPhoneNumber.Text);
            loginconn.Insert(user);
            EntryUsername.Text = "";
            EntryPassword.Text = "";
            EntryEmail.Text = "";
            EntryPhoneNumber.Text = "";
            DisplayAlert("register", "registersuccesfyly", "ok");
        }
    }
}