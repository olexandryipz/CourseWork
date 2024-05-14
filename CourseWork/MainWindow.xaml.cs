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
        ObservableCollection<Country> countries;

        public MainWindow()
        {
            InitializeComponent();
            countries = new ObservableCollection<Country>();

            countries.Add(new Country("Албанія", "Тирана", "ALL (албанський лек)", "албанська", 2877797, 28748, 355, getImage("alb"), new Image()));
            countries.Add(new Country("Бельгія", "Брюссель", "EUR (євро)", "нідерландська, французька, німецька", 11432580, 30528, 32, getImage("bel"), new Image()));
            countries.Add(new Country("Болгарія", "Софія", "BGN (болгарський лев)", "болгарська", 7000119, 110879, 359, getImage("bolgaria"), new Image()));
            countries.Add(new Country("Боснія і Герцеговина", "Сараєво", "BAM (конвертована марка)", "боснійська, сербська, хорватська", 3280819, 51209, 387, getImage("bos"), new Image()));
            countries.Add(new Country("Ватикан", "Ватикан", "EUR (євро)", "італійська, латинська", 825, 44, 379, getImage("vat"), new Image()));
            countries.Add(new Country("Велика Британія", "Лондон", "GBP (британський фунт стерлінгів)", "англійська", 67886011, 242495, 44, getImage("eng"), new Image()));
            countries.Add(new Country("Греція", "Афіни", "EUR (євро)", "грецька", 10423054, 131957, 30, getImage("greece"), new Image()));
            countries.Add(new Country("Данія", "Копенгаген", "DKK (датська крона)", "датська", 5797446, 42924, 45, getImage("dan"), new Image()));
            countries.Add(new Country("Ірландія", "Дублін", "EUR (євро)", "ірландська, англійська", 4921500, 70273, 353, getImage("ireland"), new Image()));
            countries.Add(new Country("Ісландія", "Рейк'явік", "ISK (ісландська крона)", "ісландська", 341243, 103000, 354, getImage("iceland"), new Image()));
            countries.Add(new Country("Іспанія", "Мадрид", "EUR (євро)", "іспанська", 46723749, 505990, 34, getImage("spain"), new Image()));
            countries.Add(new Country("Італія", "Рим", "EUR (євро)", "італійська", 60390560, 301340, 39, getImage("ita"), new Image()));
            countries.Add(new Country("Латвія", "Рига", "EUR (євро)", "латиська", 1886198, 64559, 371, getImage("lat"), new Image()));
            countries.Add(new Country("Литва", "Вільнюс", "EUR (євро)", "литовська", 2717120, 65300, 370, getImage("lit"), new Image()));
            countries.Add(new Country("Люксембург", "Люксембург", "EUR (євро)", "французька, нідерландська, німецька", 625978, 2586, 352, getImage("lux"), new Image()));
            countries.Add(new Country("Македонія (Північна)", "Скоп'є", "MKD (македонський денар)", "македонська", 2083374, 25713, 389, getImage("mac"), new Image()));
            countries.Add(new Country("Молдова", "Кишинів", "MDL (молдовський лей)", "молдовська, румунська", 2681735, 33846, 373, getImage("mol"), new Image()));
            countries.Add(new Country("Нідерланди", "Амстердам", "EUR (євро)", "нідерландська", 17134872, 41543, 31, getImage("net"), new Image()));
            countries.Add(new Country("Німеччина", "Берлін", "EUR (євро)", "німецька", 83149300, 357022, 49, getImage("ger"), new Image()));
            countries.Add(new Country("Норвегія", "Осло", "NOK (норвезька крона)", "норвезька", 5421241, 323802, 47, getImage("nor"), new Image()));
            countries.Add(new Country("Польща", "Варшава", "PLN (польський злотий)", "польська", 38386000, 312696, 48, getImage("pln"), new Image()));
            countries.Add(new Country("Португалія", "Лісабон", "EUR (євро)", "португальська", 10276617, 92090, 351, getImage("por"), new Image()));
            countries.Add(new Country("Румунія", "Бухарест", "RON (румунський лей)", "румунська", 19286123, 238397, 40, getImage("rum"), new Image()));
            countries.Add(new Country("Словаччина", "Братислава", "EUR (євро)", "словацька", 5450421, 49035, 421, getImage("slov"), new Image()));
            countries.Add(new Country("Словенія", "Любляна", "EUR (євро)", "словенська", 2078938, 20273, 386, getImage("slo"), new Image()));
            countries.Add(new Country("Угорщина", "Будапешт", "HUF (угорський форинт)", "угорська", 9660351, 93030, 36, getImage("hun"), new Image()));
            countries.Add(new Country("Україна", "Київ", "UAH (українська гривня)", "українська", 41723998, 603500, 380,  getImage("ukr"), new Image()));
            countries.Add(new Country("Фінляндія", "Гельсінкі", "EUR (євро)", "фінська, шведська", 5540720, 338424, 358, getImage("fin"), new Image()));
            countries.Add(new Country("Франція", "Париж", "EUR (євро)", "французька", 67076000, 551695, 33, getImage("fra"), new Image()));
            countries.Add(new Country("Хорватія", "Загреб", "HRK (хорватська куна)", "хорватська", 4087843, 56594, 385, getImage("cro"), new Image()));
            countries.Add(new Country("Чехія", "Прага", "CZK (чеська крона)", "чеська", 10610055, 78865, 420, getImage("czh"), new Image()));
            countries.Add(new Country("Швейцарія", "Берн", "CHF (швейцарський франк)", "німецька, французька, італійська", 8591360, 41284, 41, getImage("swc"), new Image()));
            countries.Add(new Country("Швеція", "Стокгольм", "SEK (шведська крона)", "шведська", 10391000, 450295, 46, getImage("swd"), new Image()));

            searchTextBox.TextChanged += searchTextBox_TextChanged;
        }

        public class CurrencyDownloader
        {
            public void DownloadCurrencies(Action<string> appendLine, CancellationToken cancellationToken)
            {
                bool isOK = false;

                appendLine("Завантаження актуального курсу валют.");

                XPathDocument xPathDoc;
                XPathNavigator? xPathDocNavigator = null;

                try
                {
                    xPathDoc = new XPathDocument("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange");
                    xPathDocNavigator = xPathDoc.CreateNavigator();

                    isOK = true;
                }
                catch (Exception ex)
                {
                    appendLine("Помилка завантаження або аналізу ХМЛ файлу: " + ex.Message);
                }

                if (isOK)
                {
                    XPathNodeIterator? КурсВалюти = xPathDocNavigator?.Select("/exchange/currency");
                    while (КурсВалюти!.MoveNext())
                    {
                        if (cancellationToken.IsCancellationRequested)
                            break;

                        XPathNavigator? current = КурсВалюти.Current;

                        string НазваВалюти = current?.SelectSingleNode("txt")?.Value ?? "";
                        string Коротко = current?.SelectSingleNode("cc")?.Value ?? "";
                        decimal Курс = decimal.Parse(current?.SelectSingleNode("rate")?.Value.Replace(".", ",") ?? "0");
                        DateTime ДатаКурсу = DateTime.Parse(current?.SelectSingleNode("exchangedate")?.Value ?? DateTime.MinValue.ToString());

                        appendLine($"Назва валюти: {НазваВалюти}. Коротка назва {Коротко}. Курс до гривні: {Курс}. Дата курсу {ДатаКурсу}");
                    }
                }
            }
        }



        public Image getImage(string flags)
        {
            string path = $"C:\\Users\\Oleksandr\\OneDrive\\Рабочий стол\\CourseWork\\CourseWork\\Images\\{flags}.png";
            Image image = new Image();
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
                SearchedCountry countryInfoTextBlock = new SearchedCountry(country); //tut
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

        private void SortByCurrency(object sender, RoutedEventArgs e)
        {
            Scroll.Visibility = Visibility.Visible;
            var sortedCountries = countries.OrderBy(country => country.Currency).ToList();

            resultStackPanel.Children.Clear();

            foreach (var country in sortedCountries)
            {
                var countryInfoTextBlock = new TextBlock();
                countryInfoTextBlock.Text = $"Країна: {country.Name}. Валюта: {country.Currency}.";
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
            CurrencyDownloader currencyDownloader = new CurrencyDownloader();

            Task.Run(() => currencyDownloader.DownloadCurrencies(AppendLine, cts.Token));
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
    }
}