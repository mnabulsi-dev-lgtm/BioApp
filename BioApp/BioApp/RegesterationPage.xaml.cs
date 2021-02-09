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
    public partial class RegesterationPage : ContentPage
    {
        List<string> majors = new List<string>
        {
            "علم الحاسوب",
            "هندسة البرمجيات"
        };
        List<string> semesters = new List<string>
        {
            "الفصل الأول",
            "الفصل الثاني",
            "الفصل الصيفي"
        };
        public RegesterationPage()
        {
            InitializeComponent();
            majorsPicker.ItemsSource = majors;
            semsterPicker.ItemsSource = semesters;
            
        }

        private void calculate_Clicked(object sender, EventArgs e)
        {
            string selectedMajor = majorsPicker.SelectedItem as string;
            string selectedsemster = semsterPicker.SelectedItem as string;
            int numberOfHours = Int32.Parse(numberOFHours.Text);
            double disc = Double.Parse(discount.Text)/100;


            double hourPrice, finalCost,semsterCost;

            if(selectedMajor.Equals("علم الحاسوب"))
            {
                hourPrice = 90;
                finalCost = numberOfHours * hourPrice;
            }
            else
            {
                hourPrice = 100;
                finalCost = numberOfHours * hourPrice;
            }

            if(selectedsemster.Equals("الفصل الأول") || selectedsemster.Equals("الفصل الثاني"))
            {
                semsterCost =  finalCost * disc;
                semsterCost = (finalCost - semsterCost) + 340;
            }
            else
            {
                semsterCost = finalCost * disc;
                semsterCost = (finalCost - semsterCost) + 150;
            }

            result.Text = semsterCost.ToString()+" JD";
           
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}