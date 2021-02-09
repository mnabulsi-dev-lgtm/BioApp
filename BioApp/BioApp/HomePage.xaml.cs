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
    public partial class HomePage : MasterDetailPage
    {
        List<string> pages = new List<string>
        {
            "Courses","Marks","Regestration","More Details"
        };
        public HomePage()
        {
            InitializeComponent();
            myListView.ItemsSource = pages;
            Detail = new NavigationPage(new CoursesPage());
        }

        private void myListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string pagePressed = myListView.SelectedItem as string;
            switch (pagePressed.ToLower())
            {
                case "courses":
                    Detail = new NavigationPage(new CoursesPage());
                    break;

                case "marks":
                    Detail = new NavigationPage(new MarksPage());
                    break;

                case "regestration":
                    Detail = new NavigationPage(new RegesterationPage());
                    break;

                case "more details":
                    Detail = new NavigationPage(new MorePages());
                    break;
            }
            IsPresented = false;
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}