using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace SaveUp 
{
    public partial class MainPage : INotifyPropertyChanged 
    {
        public MainPage()
        {

            InitializeComponent();
            BindingContext = this;
            ShowListCommand = new Command(ShowListCommand);


           

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Command ShowListCommand { get; }

        public Command AddListCommand { get;  }
        void INotifyPropertyChanged(int budge)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
        }

        int budge = 101;
        public string Budge
        {
            get { return $"Gesparte Summe beträgt: {budge} CHF"; }
            


   
        }

       async void ShowList()
        {
            Show
        }
    }


}
