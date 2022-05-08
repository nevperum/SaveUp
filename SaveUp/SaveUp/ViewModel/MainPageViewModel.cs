using SaveUp.View;
using SaveUp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace SaveUp.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {


            ShowListCommand = new Command(ShowList);
            AddListCommand = new Command(AddList);

        }


        public Command ShowListCommand { get; }
        public Command AddListCommand { get; }



        int budge = 101;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Budge
        {
            get { return $"Gesparte Summe bfeträgt: {budge} CHF"; }




        }

        async void ShowList()
        {
            //   ShowPageViewModel spvm = new ShowPageViewModel();

            await Application.Current.MainPage.Navigation.PushAsync(new ShowPageView());

        }
        async void AddList()
        {
            //   ShowPageViewModel spvm = new ShowPageViewModel();

            await Application.Current.MainPage.Navigation.PushAsync(new AddPageViewxaml());

        }
    }


}


