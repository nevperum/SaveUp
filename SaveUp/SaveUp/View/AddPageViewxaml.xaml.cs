using SaveUp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SaveUp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPageViewxaml : ContentPage
    {
        public AddPageViewxaml(AddPageViewModel apvm)
        {
            BindingContext = apvm;
            InitializeComponent();
         
        }
        public AddPageViewxaml()
        {
            BindingContext = new AddPageViewModel();
            InitializeComponent();

        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}