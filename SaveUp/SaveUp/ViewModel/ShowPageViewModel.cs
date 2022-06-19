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
    public class ShowPageViewModel : ContentPage
    {
        public ShowPageViewModel()
        {
            InitializeComponent();
        }

        private ObservableCollection<DatSpar> data;

        public ObservableCollection<DatSpar> Data { get { return data; } set { data = value; OnPropertyChanged(); } }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public ShowPageViewModel(System.Collections.ObjectModel.ObservableCollection<DatSpar> data)
        {

            this.Data = data;



    }

    private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}