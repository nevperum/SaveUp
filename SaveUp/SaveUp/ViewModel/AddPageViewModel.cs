using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Xamarin.Forms;
using static SaveUp.Model.ArtikelModel;

namespace SaveUp.ViewModel


{

  
    public class AddPageViewModel : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public DatSpar datSpar = new DatSpar();
        public double Preis { get { return datSpar.preis; } set { datSpar.preis = value; OnPropertyChanged(nameof(Preis)); } }
        public string Name { get { return datSpar.name; } set { datSpar.name = value; OnPropertyChanged(nameof(Name)); } }
        public string Datum { get { return datSpar.datum; } set { datSpar.datum = value; OnPropertyChanged(); } }
        private ObservableCollection<DatSpar> data = new ObservableCollection<DatSpar>();
        public ObservableCollection<DatSpar> Data { get { return data; } set { data = value; OnPropertyChanged(); } }

        public Command CommitCommand { get; }
        public AddPageViewModel()
        {
            // öffnet Command show list
            CommitCommand = new Command(Commit);

        }

        public void Commit()
        {
            data.Add(datSpar);
            MainPageViewModel mpvm = new MainPageViewModel(data);
            App.Current.MainPage = new NavigationPage(new MainPage(mpvm));

        }
    }
}