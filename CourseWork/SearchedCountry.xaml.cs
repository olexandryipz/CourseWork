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
        public Country country { get; set; }
        public string Text {  get; set; }

        public SearchedCountry(Country country)
        {
            this.country = country;
            InitializeComponent();
        }

        private void Hello(object sender, RoutedEventArgs e)
        {
            CountryInformation Control = new CountryInformation(country);
            Country.Mwd.SearchSystem.Children.Add(Control);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            SearchButton.Content = country.Name;
        }
    }
}