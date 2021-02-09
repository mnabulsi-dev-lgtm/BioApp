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
    public partial class CoursesPage : ContentPage
    {
        List<string> courses = new List<string>
        {
            "Xamarin","Security","IOT","Java","Data Structure"
        };
        public CoursesPage()
        {
            InitializeComponent();
            coursesListView.ItemsSource = courses;
        }
    }

    
}