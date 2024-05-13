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
using CourseWork;

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
            countries.Add(new Country("Андорра", "Андорра-ла-Велья", "EUR (євро)", "каталонська", 78000, 468, 376, getImage("and"), new Image()));
            countries.Add(new Country("Бельгія", "Брюссель", "EUR (євро)", "нідерландська, французька, німецька", 11432580, 30528, 32, getImage("bel"), new Image()));
            countries.Add(new Country("Білорусь", "Мінськ", "BYN (білоруський рубль)", "білоруська, російська", 9491800, 207600, 375, getImage("belarus"), new Image()));
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
            countries.Add(new Country("Кіпр", "Нікосія", "EUR (євро)", "грецька, турецька", 1207359, 9251, 357, getImage("cypr"), new Image()));
            countries.Add(new Country("Латвія", "Рига", "EUR (Євро)", "латиська", 1886198, 64559, 371, getImage("lat"), new Image()));
            countries.Add(new Country("Литва", "Вільнюс", "EUR (Євро)", "литовська", 2717120, 65300, 370, getImage("lit"), new Image()));
            countries.Add(new Country("Ліхтенштейн", "Вадуц", "CHF (Швейцарський франк)", "німецька", 38128, 160, 423, getImage("lie"), new Image()));
            countries.Add(new Country("Люксембург", "Люксембург", "EUR (Євро)", "французька, нідерландська, німецька", 625978, 2586, 352, getImage("lux"), new Image()));
            countries.Add(new Country("Македонія (Північна)", "Скоп'є", "MKD (Македонський денар)", "македонська", 2083374, 25713, 389, getImage("mac"), new Image()));
            countries.Add(new Country("Мальта", "Валлетта", "EUR (Євро)", "мальтійська, англійська", 441543, 316, 356, getImage("mal"), new Image()));
            countries.Add(new Country("Молдова", "Кишинів", "MDL (Молдовський лей)", "молдовська, румунська", 2681735, 33846, 373, getImage("mol"), new Image()));
            countries.Add(new Country("Монако", "Монако", "EUR (Євро)", "французька", 39244, 2, 377, getImage("mona"), new Image()));
            countries.Add(new Country("Нідерланди", "Амстердам", "EUR (Євро)", "нідерландська", 17134872, 41543, 31, getImage("net"), new Image()));
            countries.Add(new Country("Німеччина", "Берлін", "EUR (Євро)", "німецька", 83149300, 357022, 49, getImage("ger"), new Image()));
            countries.Add(new Country("Норвегія", "Осло", "NOK (Норвезька крона)", "норвезька", 5421241, 323802, 47, getImage("nor"), new Image()));
            countries.Add(new Country("Польща", "Варшава", "PLN (Польський злотий)", "польська", 38386000, 312696, 48, getImage("pln"), new Image()));
            countries.Add(new Country("Португалія", "Лісабон", "EUR (Євро)", "португальська", 10276617, 92090, 351, getImage("por"), new Image()));
            countries.Add(new Country("Румунія", "Бухарест", "RON (Румунський лей)", "румунська", 19286123, 238397, 40, getImage("rum"), new Image()));
            countries.Add(new Country("Сан-Марино", "Сан-Марино", "EUR (Євро)", "італійська", 33400, 61, 378, getImage("snm"), new Image()));
            countries.Add(new Country("Сербія", "Белград", "RSD (Сербський динар)", "сербська", 6920058, 88361, 381, getImage("ser"), new Image()));
            countries.Add(new Country("Словаччина", "Братислава", "EUR (Євро)", "словацька", 5450421, 49035, 421, getImage("slov"), new Image()));
            countries.Add(new Country("Словенія", "Любляна", "EUR (Євро)", "словенська", 2078938, 20273, 386, getImage("slo"), new Image()));
            countries.Add(new Country("Туреччина", "Анкара", "TRY (турецька ліра)", "турецька", 84339067, 783562, 90, getImage("turkey"), new Image()));
            countries.Add(new Country("Угорщина", "Будапешт", "HUF (угорський форинт)", "угорська", 9660351, 93030, 36, getImage("hun"), new Image()));
            countries.Add(new Country("Україна", "Київ", "UAH (українська гривня)", "українська", 41723998, 603500, 380, getImage("ukr"), new Image()));
            countries.Add(new Country("Фінляндія", "Гельсінкі", "EUR (євро)", "фінська, шведська", 5540720, 338424, 358, getImage("fin"), new Image()));
            countries.Add(new Country("Франція", "Париж", "EUR (євро)", "французька", 67076000, 551695, 33, getImage("fra"), new Image()));
            countries.Add(new Country("Хорватія", "Загреб", "HRK (хорватська куна)", "хорватська", 4087843, 56594, 385, getImage("cro"), new Image()));
            countries.Add(new Country("Чехія", "Прага", "CZK (чеська крона)", "чеська", 10610055, 78865, 420, getImage("czh"), new Image()));
            countries.Add(new Country("Швейцарія", "Берн", "CHF (швейцарський франк)", "німецька, французька, італійська", 8591360, 41284, 41, getImage("swc"), new Image()));
            countries.Add(new Country("Швеція", "Стокгольм", "SEK (шведська крона)", "шведська", 10391000, 450295, 46, getImage("swd"), new Image()));

            searchTextBox.TextChanged += searchTextBox_TextChanged;
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