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

            countries.Add(new Country("Україна", "Київ", "UAH", "українська", 40000000));
            countries.Add(new Country("Молдова", "Кишиньов", "LEU", "ромунська", 40000000));
            countries.Add(new Country("Сполучені Штати Америки", "Вашингтон", "USD", "англійська", 328000000));
            countries.Add(new Country("Канада", "Оттава", "CAD", "англійська, французька", 38000000));

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
                countryInfoTextBlock.Text = $"Назва країни: {country.Name}, Столиця: {country.Capital}, Валюта: {country.Currency}, Мова: {country.Language}, Кількість населення: {country.Population:N0}";
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