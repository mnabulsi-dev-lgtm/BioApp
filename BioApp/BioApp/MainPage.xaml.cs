using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BioApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void loginButton_Clicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text, password = passwordEntry.Text, v1 = verifyEntry.Text, v2 = verifyEntry2.Text;
            
            if(username!="" && password != "")
            {
                if (v1.Equals(v2))
                    Navigation.PushAsync(new HomePage());
                else
                    DisplayAlert("Wrong Entered!", "Check Your Data", "Done");
            }
            
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("ASU Support","This App For Showing ASU students Their Information","Thanks");
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            string content = "Applied Science University (Arabic: جامعة العلوم التطبيقية الخاصة) is a private university " +
                "located in the Shafa Badran suburb of Amman, in Jordan." +
                " It was established in 1991 as the largest private university " +
                "in Jordan in terms of campus area and number of students' enrollment." +
                " It is ranked among top universities in Jordan, " +
                "its English programs in engineering and physical " +
                "sciences are considered one of the best in Jordan and the Middle East.";

            DisplayAlert("ASU Info", content, "Done");
        }
    }
}
