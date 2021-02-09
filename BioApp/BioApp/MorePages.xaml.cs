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
    public partial class MorePages : TabbedPage
    {
        public MorePages()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}