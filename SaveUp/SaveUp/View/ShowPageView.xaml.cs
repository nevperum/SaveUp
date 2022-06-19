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
    public partial class ShowPageView : ContentPage
    {
        public ShowPageView()
        {
            InitializeComponent();
            BindingContext = new ShowPageViewModel();
        }
        public ShowPageView(ShowPageViewModel spvm)
        {
            BindingContext = spvm;
            InitializeComponent();
        }
    }
}