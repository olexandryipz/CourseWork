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
        public string Currency;
        public string Name;
        //tut
        public CountryInformation(string Currency, string Name) //tut

        {
            this.Name = Name; //tut
            this.Currency = Currency;
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Country.gaga.SearchSystem.Children.Remove(this);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            CurrencyInfo.Text = Currency; //tut
            NameInfo.Text = Name;
        }
    }
}
