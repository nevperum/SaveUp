using SaveUp.View;
using SaveUp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace SaveUp.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        // Konstruktor
        public MainPageViewModel(System.Collections.ObjectModel.ObservableCollection<DatSpar> data)
        {

            // öffnet Command show list
            ShowListCommand = new Command(ShowList);
            // öffnet Command show list
            AddListCommand = new Command(AddList);

            foreach (var item in data)
            {
                budge = budge + item.preis;

            }

        }

        public MainPageViewModel()
        {
            // öffnet Command show list
            ShowListCommand = new Command(ShowList);
            // öffnet Command show list
            AddListCommand = new Command(AddList);
        }
     

        // Erstellung Commands
        public Command ShowListCommand { get; }
        public Command AddListCommand { get; }

       

        double budge = 1010000000;

        // Für veränderung von objekten während dem Benützen

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        // Budge hollen
        public string Budge
        {
            get { return $"Gesparte Summe beträgt: {budge} CHF"; }
            set {  OnPropertyChanged(nameof(Budge)); }



        }
        // öffnet die Seite ShowPage
        async void ShowList()
        {
            //   ShowPageViewModel spvm = new ShowPageViewModel();

            await Application.Current.MainPage.Navigation.PushAsync(new ShowPageView());

        }
        // öffnet die Seite AddPage
        async void AddList()
        {
            //   ShowPageViewModel spvm = new ShowPageViewModel();

            await Application.Current.MainPage.Navigation.PushAsync(new AddPageViewxaml());

        }
    }


}


