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
        public int Area { get; set; }
        public int Phone { get; set; }
        public static MainWindow Mwd { get; set; }
        public Image Image { get; set; }
        public Image Photo { get; set; }
        public double Rate { get; set; }

        public Country(string name, string capital, string currency, string language, int population, int area, int phone, Image Image, Image Photo, double Rate)
        {
            Name = name;
            Capital = capital;
            Currency = currency;
            Language = language;
            Population = population;
            Area = area;
            Phone = phone;
            this.Image = Image;
            this.Photo = Photo;
            this.Rate = Rate;
        }
    }
}