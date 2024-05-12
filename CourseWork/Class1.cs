using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WorldCountriesSearchSystem;

namespace CourseWork
{
    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public string Language { get; set; }
        public int Population { get; set; }
        public string Region { get; set; }
        public static MainWindow gaga { get; set; }
        public Image Image { get; set; }
        public Image Photo { get; set; }

        public Country(string name, string capital, string currency, string language, int population, string region, Image Image, Image Photo)
        {
            Name = name;
            Capital = capital;
            Currency = currency;
            Language = language;
            Population = population;
            Region = region;
            this.Image = Image;
            this.Photo = Photo;
        }
    }
}