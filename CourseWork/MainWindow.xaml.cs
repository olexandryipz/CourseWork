using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CourseWork;
using System.Xml.XPath;

namespace WorldCountriesSearchSystem
{
    public partial class MainWindow : Window
    {
        public static List<Country> countries;
        public int Rate = 2;

        public MainWindow()
        {
            InitializeComponent();
            countries = new List<Country>();
            countries.Add(new Country("Бельгія", "Брюссель", "EUR", "нідерландська, французька, німецька", 11432580, 30528, 32, getImage("bel"), new Image(), 0));
            countries.Add(new Country("Болгарія", "Софія", "BGN", "болгарська", 7000119, 110879, 359, getImage("bolgaria"), new Image(), 0));
            countries.Add(new Country("Ватикан", "Ватикан", "EUR", "італійська, латинська", 825, 44, 379, getImage("vat"), new Image(), 0));
            countries.Add(new Country("Велика Британія", "Лондон", "GBP", "англійська", 67886011, 242495, 44, getImage("eng"), new Image(), 0));
            countries.Add(new Country("Греція", "Афіни", "EUR", "грецька", 10423054, 131957, 30, getImage("greece"), new Image(), 0));
            countries.Add(new Country("Данія", "Копенгаген", "DKK", "датська", 5797446, 42924, 45, getImage("dan"), new Image(), 0));
            countries.Add(new Country("Ірландія", "Дублін", "EUR", "ірландська, англійська", 4921500, 70273, 353, getImage("ireland"), new Image(), 0));
            countries.Add(new Country("Іспанія", "Мадрид", "EUR", "іспанська", 46723749, 505990, 34, getImage("spain"), new Image(), 0));
            countries.Add(new Country("Італія", "Рим", "EUR", "італійська", 60390560, 301340, 39, getImage("ita"), new Image(), 0));
            countries.Add(new Country("Латвія", "Рига", "EUR", "латиська", 1886198, 64559, 371, getImage("lat"), new Image(), 0));
            countries.Add(new Country("Литва", "Вільнюс", "EUR", "литовська", 2717120, 65300, 370, getImage("lit"), new Image(), 0));
            countries.Add(new Country("Люксембург", "Люксембург", "EUR", "французька, нідерландська, німецька", 625978, 2586, 352, getImage("lux"), new Image(), 0));
            countries.Add(new Country("Молдова", "Кишинів", "MDL", "молдовська, румунська", 2681735, 33846, 373, getImage("mol"), new Image(), 0));
            countries.Add(new Country("Нідерланди", "Амстердам", "EUR", "нідерландська", 17134872, 41543, 31, getImage("net"), new Image(), 0));
            countries.Add(new Country("Німеччина", "Берлін", "EUR", "німецька", 83149300, 357022, 49, getImage("ger"), new Image(), 0));
            countries.Add(new Country("Норвегія", "Осло", "NOK", "норвезька", 5421241, 323802, 47, getImage("nor"), new Image(), 0));
            countries.Add(new Country("Польща", "Варшава", "PLN", "польська", 38386000, 312696, 48, getImage("pln"), new Image(), 0));
            countries.Add(new Country("Португалія", "Лісабон", "EUR", "португальська", 10276617, 92090, 351, getImage("por"), new Image(), 0));
            countries.Add(new Country("Румунія", "Бухарест", "RON", "румунська", 19286123, 238397, 40, getImage("rum"), new Image(), 0));
            countries.Add(new Country("Словаччина", "Братислава", "EUR", "словацька", 5450421, 49035, 421, getImage("slov"), new Image(), 0));
            countries.Add(new Country("Словенія", "Любляна", "EUR", "словенська", 2078938, 20273, 386, getImage("slo"), new Image(), 0));
            countries.Add(new Country("Угорщина", "Будапешт", "HUF", "угорська", 9660351, 93030, 36, getImage("hun"), new Image(), 0));
            countries.Add(new Country("Україна", "Київ", "UAH", "українська", 41723998, 603500, 380, getImage("ukr"), getImage("kyiv"), 0));
            countries.Add(new Country("Фінляндія", "Гельсінкі", "EUR", "фінська, шведська", 5540720, 338424, 358, getImage("fin"), new Image(), 0));
            countries.Add(new Country("Франція", "Париж", "EUR", "французька", 67076000, 551695, 33, getImage("fra"), new Image(), 0));
            countries.Add(new Country("Чехія", "Прага", "CZK", "чеська", 10610055, 78865, 420, getImage("czh"), new Image(), 0));
            countries.Add(new Country("Швейцарія", "Берн", "CHF", "німецька, французька, італійська", 8591360, 41284, 41, getImage("swc"), new Image(), 0));
            countries.Add(new Country("Швеція", "Стокгольм", "SEK", "шведська", 10391000, 450295, 46, getImage("swd"), new Image(), 0));

            searchTextBox.TextChanged += searchTextBox_TextChanged;
        }


        public void DownloadCurrencies(Action<string> appendLine, CancellationToken cancellationToken)
        {
            XPathDocument xPathDoc;
            XPathNavigator? xPathDocNavigator = null;


            xPathDoc = new XPathDocument("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange");
            xPathDocNavigator = xPathDoc.CreateNavigator();

            XPathNodeIterator? КурсВалюти = xPathDocNavigator?.Select("/exchange/currency");
            while (КурсВалюти!.MoveNext())
            {
                if (cancellationToken.IsCancellationRequested)
                    break;

                XPathNavigator? current = КурсВалюти.Current;

                string currencyName = current?.SelectSingleNode("txt")?.Value ?? "";
                string value = current?.SelectSingleNode("cc")?.Value ?? "";
                decimal rate = decimal.Parse(current?.SelectSingleNode("rate")?.Value.Replace(".", ",") ?? "0");
                DateTime currencyDate = DateTime.Parse(current?.SelectSingleNode("exchangedate")?.Value ?? DateTime.MinValue.ToString());
                for (int index = 0; index < countries.Count; index++)
                {
                    if (value == countries[index].Currency)
                    {
                        countries[index].Rate = (double)rate;
                    }
                }
            }
        }
        public Image getImage(string flags)
        {
            Image image = new Image();
            string path = $"C:\\Users\\Oleksandr\\OneDrive\\Рабочий стол\\CourseWork\\CourseWork\\Images\\{flags}.png";
            image.Source = new BitmapImage(new Uri(path));
            return image;
        }
        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = searchTextBox.Text.ToLower();
            var filteredCountries = countries.Where(country => country.Name.ToLower().Contains(searchText)).ToList();
            resultStackPanel.Children.Clear();
            foreach (var country in filteredCountries)
            {
                SearchedCountry countryInfoTextBlock = new SearchedCountry(country);
                countryInfoTextBlock.MouseDown += EventEvent;
                resultStackPanel.Children.Add(countryInfoTextBlock);
            }
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void EventEvent(object sender, MouseButtonEventArgs e)
        {

            MessageBox.Show("lesha");
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SortByAlphabet(object sender, RoutedEventArgs e)
        {
            Scroll.Visibility = Visibility.Visible;
            var sortedCountries = countries.OrderBy(country => country.Name).ToList();

            resultStackPanel.Children.Clear();

            foreach (var country in sortedCountries)
            {
                var countryInfoTextBlock = new TextBlock();
                countryInfoTextBlock.Text = $"Країна: {country.Name}.";
                resultStackPanel.Children.Add(countryInfoTextBlock);
            }
        }

        private void SortByPopulation(object sender, RoutedEventArgs e)
        {
            Scroll.Visibility = Visibility.Visible;
            var sortedCountries = countries.OrderBy(country => country.Population).ToList();

            resultStackPanel.Children.Clear();

            foreach (var country in sortedCountries)
            {
                var countryInfoTextBlock = new TextBlock();
                countryInfoTextBlock.Text = $"Країна: {country.Name}. Населення: {country.Population:N0}.";
                resultStackPanel.Children.Add(countryInfoTextBlock);
            }
        }

        private void searchTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            TextBox searchTextBox = (TextBox)sender;
            if (searchTextBox.Text == "")
            {
                Scroll.Visibility = Visibility.Hidden;
            }
            else
            {
                Scroll.Visibility = Visibility.Visible;
            }
        }

        private void KnowCurrency(object sender, RoutedEventArgs e)
        {
            CancellationTokenSource cts = new CancellationTokenSource();


            DownloadCurrencies(AppendLine, cts.Token);
        }

        private void AppendLine(string text)
        {
            Dispatcher.Invoke(() =>
            {
                resultStackPanel.Children.Add(new TextBlock { Text = text });
            });
        }


        private void SortByLanguage(object sender, RoutedEventArgs e)
        {
            Scroll.Visibility = Visibility.Visible;
            var sortedCountries = countries.OrderBy(country => country.Language).ToList();

            resultStackPanel.Children.Clear();

            foreach (var country in sortedCountries)
            {
                var countryInfoTextBlock = new TextBlock();
                countryInfoTextBlock.Text = $"Країна: {country.Name}. Мова: {country.Language}.";
                resultStackPanel.Children.Add(countryInfoTextBlock);
            }
        }

        public Brush color;
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            color = button.Background;
            button.Background = Brushes.LightGray;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.Background = color;
        }

        private void ClearResults(object sender, RoutedEventArgs e)
        {
            resultStackPanel.Children.Clear();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Country.gaga = this;
            CancellationTokenSource cts = new CancellationTokenSource();


            DownloadCurrencies(AppendLine, cts.Token);
        }

        private void SortByArea(object sender, RoutedEventArgs e)
        {
            Scroll.Visibility = Visibility.Visible;
            var sortedCountries = countries.OrderBy(country => country.Area).ToList();

            resultStackPanel.Children.Clear();

            foreach (var country in sortedCountries)
            {
                var countryInfoTextBlock = new TextBlock();
                countryInfoTextBlock.Text = $"Країна: {country.Name}. Площа: {country.Area:N0} км².";
                resultStackPanel.Children.Add(countryInfoTextBlock);
            }
        }

        private void SortByRate(object sender, RoutedEventArgs e)
        {
            Scroll.Visibility = Visibility.Visible;
            var sortedCountries = countries.OrderBy(country => country.Rate).ToList();

            resultStackPanel.Children.Clear();

            foreach (var country in sortedCountries)
            {
                var countryInfoTextBlock = new TextBlock();
                countryInfoTextBlock.Text = $"Країна: {country.Name}. Валюта: {country.Currency}. Актуальний курс валюти до гривні: {country.Rate}.";
                resultStackPanel.Children.Add(countryInfoTextBlock);
            }
        }
    }
}