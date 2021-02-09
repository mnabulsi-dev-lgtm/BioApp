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
    public partial class show : ContentPage
    {
        public show()
        {
            InitializeComponent();
           double x = Convert.ToDouble( Application.Current.Properties["xmark"]) ;
            double d = Convert.ToDouble(  Application.Current.Properties["dmark"]);
            if (x >= 50)
            {
                box1.Color = Color.Green;
            }
            else box1.Color = Color.Red;

            if (d >= 50)
            {
                box2.Color = Color.Green;
            }
            else box2.Color = Color.Red;
        }
    }
}