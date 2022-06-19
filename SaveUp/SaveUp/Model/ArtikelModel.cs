using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SaveUp.Model
{
    public class ArtikelModel : ContentPage
    {
        public ArtikelModel()
        {
         
        }
          public class DatSpar
    {
        public double preis { get; set; }
        public string datum { get; set; }
        public string name { get; set; }
    }
    }
}