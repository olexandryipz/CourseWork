using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WorldCountriesSearchSystem
{
    public partial class MainWindow : Window
    {
        ObservableCollection<Country> countries;

        public MainWindow()
        {
            InitializeComponent();
            countries = new ObservableCollection<Country>();

            countries.Add(new Country("Австралія", "Канберра", "AUD", "англійська", 24500000));
            countries.Add(new Country("Австрія", "Відень", "EUR", "німецька", 8800000));
            countries.Add(new Country("Азербайджан", "Баку", "AZN", "азербайджанська", 9900000));
            countries.Add(new Country("Албанія", "Тирана", "ALL", "албанська", 2900000));
            countries.Add(new Country("Алжир", "Алжир", "DZD", "арабська, берберська", 42200000));
            countries.Add(new Country("Ангола", "Луанда", "AOA", "португальська", 28600000));
            countries.Add(new Country("Андорра", "Андорра-ла-Велья", "EUR", "каталонська", 80000));
            countries.Add(new Country("Антигуа і Барбуда", "Сент-Джонс", "UAH", "англійська", 100000));
            countries.Add(new Country("Аргентина", "Буенос-Айрес", "ARS", "іспанська", 44300000));
            countries.Add(new Country("Афганістан", "Кабул", "AFN", "пушту, дарі", 35500000));
            countries.Add(new Country("Багамські Острови", "Нассау", "BSD", "англійська", 400000));
            countries.Add(new Country("Бангладеш", "Дакка", "BDT", "бенгальська", 164700000));
            countries.Add(new Country("Барбадос", "Бриджтаун", "BBD", "англійська", 300000));
            countries.Add(new Country("Бахрейн", "Манама", "BHD", "арабська", 1500000));
            countries.Add(new Country("Беліз", "Бельмопан", "BZD", "англійська", 400000));
            countries.Add(new Country("Бельгія", "Брюссель", "EUR", "нідерландська, французька, німецька", 11200000));

            countries.Add(new Country("Бахрейн", "Манама", "BHD", "арабська", 1500000));

            countries.Add(new Country("Бахрейн", "Манама", "BHD", "арабська", 1500000));

            countries.Add(new Country("Бахрейн", "Манама", "BHD", "арабська", 1500000));

            countries.Add(new Country("Бахрейн", "Манама", "BHD", "арабська", 1500000));

            countries.Add(new Country("Бахрейн", "Манама", "BHD", "арабська", 1500000));

            countries.Add(new Country("Бахрейн", "Манама", "BHD", "арабська", 1500000));

            searchTextBox.TextChanged += searchTextBox_TextChanged;
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = searchTextBox.Text.ToLower();
            var filteredCountries = countries.Where(country => country.Name.ToLower().Contains(searchText)).ToList();
            resultStackPanel.Children.Clear();
            foreach (var country in filteredCountries)
            {
                var countryInfoTextBlock = new TextBlock();
                countryInfoTextBlock.Text = $"Назва країни: {country.Name}, Столиця: {country.Capital}, Валюта: {country.Currency}, Офіційна мова: {country.Language}, Кількість населення: {country.Population:N0}";
                resultStackPanel.Children.Add(countryInfoTextBlock);
            }
        }

        public class Country
        {
            public string Name { get; set; }
            public string Capital { get; set; }
            public string Currency { get; set; }
            public string Language { get; set; }
            public int Population { get; set; }

            public Country(string name, string capital, string currency, string language, int population)
            {
                Name = name;
                Capital = capital;
                Currency = currency;
                Language = language;
                Population = population;
            }
        }
    }
}