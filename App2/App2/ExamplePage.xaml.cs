using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Qminds
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExamplePage : ContentPage
    {
        public ExamplePage(string name, int Id, double PH, double BX, double p, double SO2, double AL, DateTime Date, string Type, string Wine, string Grapes, int Volume, int Mass, bool Isvisible)
        {
            InitializeComponent();
            NameEntry.Text += name;
            MassEntry.Text += Mass.ToString();
            VolumeEntry.Text += Volume.ToString();
            TypeEntry.Text += Type;
            GrapesEntry.Text += Grapes;
            WineEntry.Text += Wine;
            DateEntry.Text += Date.ToString();
        }
        public ExamplePage(example example)
        {
            InitializeComponent();
            NameEntry.Text += example.NameInLabel;
            MassEntry.Text += example.Mass.ToString();
            VolumeEntry.Text += example.Volume.ToString();
            TypeEntry.Text += example.Type;
            GrapesEntry.Text += example.Grapes;
            WineEntry.Text += example.Wine;
            DateEntry.Text += example.Date.ToString();
            Totaltime.Text = example.TotalTime;
            PhNowLabel.Text = example.PH.ToString();
            BXNowLabel.Text = example.BX.ToString();
            pNowLabel.Text = example.p.ToString();
            SO2NowLabel.Text = example.SO2.ToString();
            AlNowLabel.Text = example.AL.ToString();
            double totalph = 7;
            double totalbx = 10;
            double totalp = 1.1;
            double totalso2 = 10;
            double totalal = 3;
            Phprogressbar.Progress = example.PH/totalph;
            BXprogressbar.Progress = example.BX / totalbx;
            pProgressbar.Progress = example.p / totalp;
            SO2progressbar.Progress = example.SO2 / totalso2;
            Alprogressbar.Progress = example.AL / totalal;
        }

         
    }
}