using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseWork
{
    /// <summary>
    /// Interaction logic for SearchedCountry.xaml
    /// </summary>
    public partial class SearchedCountry : UserControl
    {
        public string Text { get; set; }

        public string Name { get; set; }
        public string Currency { get; set; }
        public string Capital {  get; set; }
        public string Language {  get; set; }
        public string Region {  get; set; }
        public int Population {  get; set; }
        public Image Image { get; set; }

        //tut
        public SearchedCountry(string text, string Currency, string Name, string Capital, string Language, string Region, int Population, Image Image) //tut
        {
            this.Text = text;
            this.Name = Name;
            this.Currency = Currency;
            this.Capital = Capital;
            this.Language = Language;
            this.Region = Region;
            this.Population = Population;
            this.Image = Image;
            InitializeComponent();
        }

        private void Hello(object sender, RoutedEventArgs e)
        {
            CountryInformation Denis = new CountryInformation(Currency, Name, Capital, Language, Region, Population, Image); //tut
            Country.gaga.SearchSystem.Children.Add(Denis);
        }
    }
}