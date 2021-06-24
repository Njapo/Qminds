using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace Qminds
{
    public class example
    {
        public string Warning { get; set; }
        public string NameInLabel => "example" + Id.ToString();
        public int Id { get; set; }
        public double PH { get; set; }
        public double BX { get; set; }
        public double p { get; set; }
        public double SO2 { get; set; }
        public double AL { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Wine { get; set; }
        public string Grapes { get; set; }
        public int Volume { get; set; }
        public int Mass { get; set; }
        public bool Isvisible { get; set; }
        public string TotalTime { get; set; }
    } 
}
