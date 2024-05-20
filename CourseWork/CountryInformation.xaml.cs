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
    /// Interaction logic for CountryInformation.xaml
    /// </summary>
    public partial class CountryInformation : UserControl

    {
        public Country country { get; set; }
        public CountryInformation(Country country)

        {
            this.country = country;
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Country.gaga.SearchSystem.Children.Remove(this);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            NameInfo.Text = "Назва країни: " + country.Name;
            CurrencyInfo.Text = "Валюта: " + country.Currency;
            CapitalInfo.Text = "Столиця: " + country.Capital;
            LanguageInfo.Text = "Мова: " + country.Language;
            PopulationInfo.Text = "Кількість населення: " + country.Population.ToString();
            AreaInfo.Text = "Площа км.²: " + country.Area.ToString();
            PhoneInfo.Text = "Телефонний код: " + country.Phone.ToString();
            ImageInfo.Source = country.Image.Source;
            PhotoInfo.Source = country.Photo.Source;
            Rate.Text = "Актуальний курс до гривні: " + country.Rate.ToString();
        }
    }
}
