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
    public partial class MarksPage : ContentPage
    {
        public MarksPage()
        {
            InitializeComponent();
            
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["xmark"] = xmark.Text;
            Application.Current.Properties["dmark"] = dataMark.Text;
            Navigation.PushAsync(new show());


        }
    }
}