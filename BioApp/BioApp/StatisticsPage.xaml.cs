using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BioApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatisticsPage : ContentPage
    {
        public StatisticsPage()
        {
            InitializeComponent();
            double sum = (35 + 91 + 97 + 98 + 98)/5;
            myLabel.Text = "Your Average Is : " + sum.ToString();
            double avg = Double.Parse(sum.ToString());
            if (avg >= 50)
            {
                myLabel.TextColor = Color.Green;
                myProgressBar.ProgressColor = Color.Green;
                myProgressBar.ProgressTo(avg/100, 800, Easing.Linear);
            }
            else
            {
                myLabel.TextColor = Color.Red;
                myProgressBar.ProgressColor = Color.Red;
                myProgressBar.ProgressTo(avg/100, 800, Easing.Linear);
            }
           
        }

         protected override bool OnBackButtonPressed()
        {
            return true;
        }

    }
}