using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Qminds;
using Qminds.Model;
namespace Qminds
{
    public partial class MainPage : ContentPage
    {
        List<example> examples = new List<example>()
        {
            new example(){Id=0, PH=1,BX=1,p=1,SO2=1,AL=1,Date=DateTime.Now,Type="xvanchkara",Wine="usaxelouri",Grapes="adesa",Volume=100,Mass=100,Isvisible=false, TotalTime="10d 5h"},
            new example(){Id=1, PH=1,BX=1,p=1,SO2=1,AL=1,Date=DateTime.Now,Type="xvanchkara",Wine="usaxelouri",Grapes="adesa",Volume=100,Mass=100,Isvisible=false, TotalTime="10d 5h"},
            new example(){Id=2, PH=1,BX=1,p=1,SO2=1,AL=1,Date=DateTime.Now,Type="xvanchkara",Wine="usaxelouri",Grapes="adesa",Volume=100,Mass=100,Isvisible=false, TotalTime="10d 5h"},
        };
        public MainPage()
        {
            InitializeComponent();
            mylist.ItemsSource = examples;
        }

        private void mylist_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as example;
            Navigation.PushAsync(new ExamplePage(details));
            //Navigation.PushAsync(new ExamplePage(details.NameInLabel, details.Id,details.PH,details.BX,details.p,details.SO2,details.AL,details.Date,details.Type,details.Wine,
            //details.Grapes,details.Volume,details.Mass,details.Isvisible));
        }

    }

}