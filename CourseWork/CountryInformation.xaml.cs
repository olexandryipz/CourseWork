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
        public string Name;
        public string Capital;
        public string Currency;
        public string Language;
        public int Population;
        public string Region;
        public Image Image;

        //tut
        public CountryInformation(string Currency, string Name, string Capital, string Language, string Region, int Population, Image Image) //tut

        {
            this.Name = Name; //tut
            this.Currency = Currency;
            this.Capital = Capital;
            this.Language = Language;
            this.Region = Region;
            this.Population = Population;
            this.Image = Image;
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Country.gaga.SearchSystem.Children.Remove(this);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            NameInfo.Text = "Назва країни: " + Name;
            CurrencyInfo.Text = "Валюта: " + Currency; //tut
            CapitalInfo.Text = "Столиця: " + Capital;
            LanguageInfo.Text = "Мова: " + Language;
            RegionInfo.Text = "Регіон: " + Region;
            PopulationInfo.Text = "Кількість населення: " + Population.ToString();
            ImageInfo.Source = Image.Source;
        }
    }
}
