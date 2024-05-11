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

            countries.Add(new Country("Австралія", "Канберра", "AUD", "англійська", 24500000, "Океаніка", new Image()));
            countries.Add(new Country("Австрія", "Відень", "EUR", "німецька", 8800000, "Європа", new Image()));
            countries.Add(new Country("Азербайджан", "Баку", "AZN", "азербайджанська", 9900000, "Азія", new Image()));
            countries.Add(new Country("Албанія", "Тирана", "ALL", "албанська", 2900000, "Європа", new Image()));
            countries.Add(new Country("Алжир", "Алжир", "DZD", "арабська, берберська", 42200000, "Африка", new Image()));
            countries.Add(new Country("Ангола", "Луанда", "AOA", "португальська", 28600000, "Африка", new Image()));
            countries.Add(new Country("Андорра", "Андорра-ла-Велья", "EUR", "каталонська", 80000, "Європа", new Image()));
            countries.Add(new Country("Антигуа і Барбуда", "Сент-Джонс", "XCD", "англійська", 100000, "Північна Америка", new Image()));
            countries.Add(new Country("Аргентина", "Буенос-Айрес", "ARS", "іспанська", 44300000, "Південна Америка", new Image()));
            countries.Add(new Country("Афганістан", "Кабул", "AFN", "пушту, дарі", 35500000, "Азія", new Image()));
            countries.Add(new Country("Багамські Острови", "Нассау", "BSD", "англійська", 400000, "Північна Америка", new Image()));
            countries.Add(new Country("Бангладеш", "Дакка", "BDT", "бенгальська", 164700000, "Азія", new Image()));
            countries.Add(new Country("Барбадос", "Бриджтаун", "BBD", "англійська", 300000, "Північна Америка", new Image()));
            countries.Add(new Country("Бахрейн", "Манама", "BHD", "арабська", 1500000, "Азія", new Image()));
            countries.Add(new Country("Беліз", "Бельмопан", "BZD", "англійська", 400000, "Північна Америка", new Image()));
            countries.Add(new Country("Бельгія", "Брюссель", "EUR", "нідерландська, французька, німецька", 11200000, "Європа", new Image()));
            countries.Add(new Country("Бенін", "Порто-Ново", "XOF", "французька", 12100000, "Африка", new Image()));
            countries.Add(new Country("Білорусь", "Мінськ", "BYN", "білоруська, російська", 9485000, "Європа", new Image()));
            countries.Add(new Country("Болгарія", "Софія", "BGN", "болгарська", 7000000, "Європа", new Image()));
            countries.Add(new Country("Болівія", "Сукре", "BOB", "іспанська, аймара, кечуа, гуарані", 11300000, "Південна Америка", new Image()));
            countries.Add(new Country("Боснія і Герцеговина", "Сараєво", "BAM", "боснійська, сербська, хорватська", 3300000, "Європа", new Image()));
            countries.Add(new Country("Ботсвана", "Габороне", "BWP", "англійська, тсвана", 2300000, "Африка", new Image()));
            countries.Add(new Country("Бразилія", "Бразиліа", "BRL", "португальська", 212000000, "Південна Америка", new Image()));
            countries.Add(new Country("Бруней", "Бандар-Сері-Бегаван", "BND", "малаїзька, англійська", 440000, "Азія", new Image()));
            countries.Add(new Country("Буркіна-Фасо", "Уагадугу", "XOF", "французька", 20900000, "Африка", new Image()));
            countries.Add(new Country("Бурунді", "Гітега", "BIF", "кірунді, французька", 11800000, "Африка", new Image()));
            countries.Add(new Country("Бутан", "Тхімпху", "BTN", "дзонг-кха", 800000, "Азія", new Image()));
            countries.Add(new Country("Вануату", "Порт-Віла", "VUV", "біслама, англійська, французька", 300000, "Океаніка", new Image()));
            countries.Add(new Country("Ватикан", "Ватикан", "EUR", "італійська, латинська", 800, "Європа", new Image()));
            countries.Add(new Country("Велика Британія", "Лондон", "GBP", "англійська", 66000000, "Європа", new Image()));
            countries.Add(new Country("Венесуела", "Каракас", "VES", "іспанська", 28800000, "Південна Америка", new Image()));
            countries.Add(new Country("Вірменія", "Єреван", "AMD", "вірменська", 2950000, "Азія", new Image()));
            countries.Add(new Country("В'єтнам", "Ханой", "VND", "в'єтнамська", 96200000, "Азія", new Image()));
            countries.Add(new Country("Габон", "Лібревіль", "XAF", "французька", 2060000, "Африка", new Image()));
            countries.Add(new Country("Гаїті", "Порт-о-Пренс", "HTG", "французька, креольська", 11000000, "Північна Америка", new Image()));
            countries.Add(new Country("Гайана", "Джорджтаун", "GYD", "англійська", 770000, "Південна Америка", new Image()));
            countries.Add(new Country("Гамбія", "Банжул", "GMD", "англійська", 2100000, "Африка", new Image()));
            countries.Add(new Country("Гана", "Аккра", "GHS", "англійська", 31000000, "Африка", new Image()));
            countries.Add(new Country("Гватемала", "Гватемала", "GTQ", "іспанська", 17700000, "Північна Америка", new Image()));
            countries.Add(new Country("Гвінея", "Конакрі", "GNF", "фула, сусу, малінке, французька", 12900000, "Африка", new Image()));
            countries.Add(new Country("Гвінея-Бісау", "Бісау", "XOF", "португальська", 1620000, "Африка", new Image()));
            countries.Add(new Country("Гондурас", "Тегусігальпа", "HNL", "іспанська", 10000000, "Північна Америка", new Image()));
            countries.Add(new Country("Гренада", "Сент-Джорджес", "XCD", "англійська", 107000, "Північна Америка", new Image()));
            countries.Add(new Country("Греція", "Афіни", "EUR", "грецька", 10700000, "Європа", new Image()));
            countries.Add(new Country("Грузія", "Тбілісі", "GEL", "грузинська", 4000000, "Азія", new Image()));
            countries.Add(new Country("Данія", "Копенгаген", "DKK", "датська", 5800000, "Європа", new Image()));
            countries.Add(new Country("Джибуті", "Джибуті", "DJF", "арабська, французька", 900000, "Африка", new Image()));
            countries.Add(new Country("Домініка", "Розо", "XCD", "англійська", 71000, "Північна Америка", new Image()));
            countries.Add(new Country("Домініканська Республіка", "Санто-Домінго", "DOP", "іспанська", 11000000, "Північна Америка", new Image()));
            countries.Add(new Country("Єгипет", "Каїр", "EGP", "арабська", 101000000, "Африка", new Image()));
            countries.Add(new Country("Замбія", "Лусака", "ZMW", "англійська", 17800000, "Африка", new Image()));
            countries.Add(new Country("Зімбабве", "Хараре", "ZWL", "англійська, шона, ндебеле", 15000000, "Африка", new Image()));
            countries.Add(new Country("Ізраїль", "Єрусалим", "ILS", "іврит, арабська", 9000000, "Азія", new Image()));
            countries.Add(new Country("Індія", "Нью-Делі", "INR", "хінді, англійська", 1380000000, "Азія", new Image()));
            countries.Add(new Country("Індонезія", "Джакарта", "IDR", "індонезійська", 270000000, "Азія", new Image()));
            countries.Add(new Country("Ірак", "Багдад", "IQD", "арабська, курдська", 40000000, "Азія", new Image()));
            countries.Add(new Country("Іран", "Тегеран", "IRR", "перська", 82000000, "Азія", new Image()));
            countries.Add(new Country("Ірландія", "Дублін", "EUR", "ірландська, англійська", 4900000, "Європа", new Image()));
            countries.Add(new Country("Ісландія", "Рейк'явік", "ISK", "ісландська", 340000, "Європа", new Image()));
            countries.Add(new Country("Іспанія", "Мадрид", "EUR", "іспанська", 47000000, "Європа", new Image()));
            countries.Add(new Country("Італія", "Рим", "EUR", "італійська", 60200000, "Європа", new Image()));
            countries.Add(new Country("Йорданія", "Амман", "JOD", "арабська", 10200000, "Азія", new Image()));
            countries.Add(new Country("Кабо-Верде", "Прая", "CVE", "португальська", 560000, "Африка", new Image()));
            countries.Add(new Country("Казахстан", "Нур-Султан", "KZT", "казахська, російська", 18800000, "Азія", new Image()));
            countries.Add(new Country("Камбоджа", "Пномпень", "KHR", "кхмерська", 16900000, "Азія", new Image()));
            countries.Add(new Country("Камерун", "Яунде", "XAF", "французька, англійська", 26500000, "Африка", new Image()));
            countries.Add(new Country("Канада", "Оттава", "CAD", "англійська, французька", 37700000, "Північна Америка", new Image()));
            countries.Add(new Country("Катар", "Доха", "QAR", "арабська", 2880000, "Азія", new Image()));
            countries.Add(new Country("Кенія", "Найробі", "KES", "суахілі, англійська", 54000000, "Африка", new Image()));
            countries.Add(new Country("Кипр", "Нікозія", "EUR", "грецька, турецька", 1207000, "Європа", new Image()));
            countries.Add(new Country("Киргизстан", "Бішкек", "KGS", "кіргизька, російська", 6500000, "Азія", new Image()));
            countries.Add(new Country("Кіпр", "Нікосія", "EUR", "грецька, турецька", 1207000, "Європа", new Image()));
            countries.Add(new Country("Кірибаті", "Тарава", "AUD", "англійська, гілбертійська", 120000, "Океанія", new Image()));
            countries.Add(new Country("Китай", "Пекін", "CNY", "китайська", 1400000000, "Азія", new Image()));
            countries.Add(new Country("Колумбія", "Богота", "COP", "іспанська", 51000000, "Південна Америка", new Image()));
            countries.Add(new Country("Коморські Острови", "Мороні", "KMF", "французька, арабська", 800000, "Африка", new Image()));
            countries.Add(new Country("Конго (Браззавіль)", "Браззавіль", "XAF", "французька", 5500000, "Африка", new Image()));
            countries.Add(new Country("Конго (Кіншаса)", "Кіншаса", "CDF", "французька", 90000000, "Африка", new Image()));
            countries.Add(new Country("Коста-Ріка", "Сан-Хосе", "CRC", "іспанська", 5100000, "Північна Америка", new Image()));
            countries.Add(new Country("Кот-д'Івуар", "Ямусукро", "XOF", "французька", 26000000, "Африка", new Image()));
            countries.Add(new Country("Куба", "Гавана", "CUP", "іспанська", 11300000, "Північна Америка", new Image()));
            countries.Add(new Country("Кувейт", "Кувейт", "KWD", "арабська", 4200000, "Азія", new Image()));
            countries.Add(new Country("Кюрасао", "Вільємстад", "ANG", "нідерландська, пап'яменто", 160000, "Північна Америка", new Image()));
            countries.Add(new Country("Лаос", "В'єнтьян", "LAK", "лаоська", 7400000, "Азія", new Image()));
            countries.Add(new Country("Латвія", "Рига", "EUR", "латиська", 1900000, "Європа", new Image()));
            countries.Add(new Country("Лесото", "Масеру", "LSL", "сесото, англійська", 2000000, "Африка", new Image()));
            countries.Add(new Country("Литва", "Вільнюс", "EUR", "литовська", 2800000, "Європа", new Image()));
            countries.Add(new Country("Ліберія", "Монровія", "LRD", "англійська", 5100000, "Африка", new Image()));
            countries.Add(new Country("Ліван", "Бейрут", "LBP", "арабська", 6850000, "Азія", new Image()));
            countries.Add(new Country("Лівія", "Тріполі", "LYD", "арабська", 6700000, "Африка", new Image()));
            countries.Add(new Country("Ліхтенштейн", "Вадуц", "CHF", "німецька", 38000, "Європа", new Image()));
            countries.Add(new Country("Люксембург", "Люксембург", "EUR", "французька, нідерландська, німецька", 620000, "Європа", new Image()));
            countries.Add(new Country("Маврикій", "Порт-Луї", "MUR", "маврикійська", 1400000, "Африка", new Image()));
            countries.Add(new Country("Мавританія", "Нуакшот", "MRU", "арабська", 4400000, "Африка", new Image()));
            countries.Add(new Country("Мадагаскар", "Антананаріву", "MGA", "малагасійська, французька", 27000000, "Африка", new Image()));
            countries.Add(new Country("Македонія (Північна)", "Скоп'є", "MKD", "македонська", 2100000, "Європа", new Image()));
            countries.Add(new Country("Малаві", "Лілонгве", "MWK", "чева, англійська", 19000000, "Африка", new Image()));
            countries.Add(new Country("Малайзія", "Куала-Лумпур", "MYR", "малаїзійська", 32000000, "Азія", new Image()));
            countries.Add(new Country("Малі", "Бамако", "XOF", "французька", 20000000, "Африка", new Image()));
            countries.Add(new Country("Мальдіви", "Мале", "MVR", "мальдівська", 440000, "Азія", new Image()));
            countries.Add(new Country("Мальта", "Валлетта", "EUR", "мальтійська, англійська", 440000, "Європа", new Image()));
            countries.Add(new Country("Марокко", "Рабат", "MAD", "арабська", 37000000, "Африка", new Image()));
            countries.Add(new Country("Маршаллові Острови", "Маджуро", "USD", "англійська, маршалльська", 59000, "Океанія", new Image()));
            countries.Add(new Country("Мексика", "Мехіко", "MXN", "іспанська", 129000000, "Північна Америка", new Image()));
            countries.Add(new Country("Мозамбік", "Мапуту", "MZN", "португальська", 31000000, "Африка", new Image()));
            countries.Add(new Country("Молдова", "Кишинів", "MDL", "молдовська, румунська", 2700000, "Європа", new Image()));
            countries.Add(new Country("Монако", "Монако", "EUR", "французька", 39000, "Європа", new Image()));
            countries.Add(new Country("Монголія", "Улан-Батор", "MNT", "монгольська", 3300000, "Азія", new Image()));
            countries.Add(new Country("М'янма", "Найп'їдо", "MMK", "бірманська", 54000000, "Азія", new Image()));
            countries.Add(new Country("Намібія", "Віндгук", "NAD", "англійська", 2500000, "Африка", new Image()));
            countries.Add(new Country("Науру", "Ярен", "AUD", "науру", 11000, "Океанія", new Image()));
            countries.Add(new Country("Непал", "Катманду", "NPR", "непальська", 29000000, "Азія", new Image()));
            countries.Add(new Country("Нігер", "Ніамей", "XOF", "французька", 24000000, "Африка", new Image()));
            countries.Add(new Country("Нігерія", "Абуджа", "NGN", "англійська", 206000000, "Африка", new Image()));
            countries.Add(new Country("Нідерланди", "Амстердам", "EUR", "нідерландська", 17500000, "Європа", new Image()));
            countries.Add(new Country("Нікарагуа", "Манагуа", "NIO", "іспанська", 6600000, "Північна Америка", new Image()));
            countries.Add(new Country("Німеччина", "Берлін", "EUR", "німецька", 83000000, "Європа", new Image()));
            countries.Add(new Country("Нова Зеландія", "Веллінгтон", "NZD", "англійська, маорі", 5000000, "Океанія", new Image()));
            countries.Add(new Country("Норвегія", "Осло", "NOK", "норвезька", 5300000, "Європа", new Image()));
            countries.Add(new Country("Об'єднані Арабські Емірати", "Абу-Дабі", "AED", "арабська", 9900000, "Азія", new Image()));
            countries.Add(new Country("Оман", "Маскат", "OMR", "арабська", 5000000, "Азія", new Image()));
            countries.Add(new Country("Пакистан", "Ісламабад", "PKR", "урду, англійська", 220000000, "Азія", new Image()));
            countries.Add(new Country("Палау", "Нгеруулмуд", "USD", "англійська, палауанська", 18000, "Океанія", new Image()));
            countries.Add(new Country("Панама", "Панама", "PAB", "іспанська", 4200000, "Північна Америка", new Image()));
            countries.Add(new Country("Папуа-Нова Гвінея", "Порт-Морсбі", "PGK", "англійська, ток-пісінг", 9000000, "Океанія", new Image()));
            countries.Add(new Country("Парагвай", "Асунсьйон", "PYG", "іспанська, гуарані", 7200000, "Південна Америка", new Image()));
            countries.Add(new Country("Перу", "Ліма", "PEN", "іспанська", 33000000, "Південна Америка", new Image()));
            countries.Add(new Country("Південна Корея", "Сеул", "KRW", "корейська", 51000000, "Азія", new Image()));
            countries.Add(new Country("Південний Судан", "Джуба", "SSP", "англійська", 13000000, "Африка", new Image()));
            countries.Add(new Country("Південно-Африканська Республіка", "Преторія", "ZAR", "англійська", 60000000, "Африка", new Image()));
            countries.Add(new Country("Північна Корея", "Пхеньян", "KPW", "корейська", 25000000, "Азія", new Image()));
            countries.Add(new Country("Польща", "Варшава", "PLN", "польська", 38000000, "Європа", new Image()));
            countries.Add(new Country("Португалія", "Лісабон", "EUR", "португальська", 10200000, "Європа", new Image()));
            countries.Add(new Country("Руанда", "Кігалі", "RWF", "руанда, французька, англійська", 13000000, "Африка", new Image()));
            countries.Add(new Country("Румунія", "Бухарест", "RON", "румунська", 19000000, "Європа", new Image()));
            countries.Add(new Country("Сальвадор", "Сан-Сальвадор", "SVC", "іспанська", 6700000, "Північна Америка", new Image()));
            countries.Add(new Country("Самоа", "Апіа", "WST", "самоанська, англійська", 200000, "Океанія", new Image()));
            countries.Add(new Country("Сан-Марино", "Сан-Марино", "EUR", "італійська", 34000, "Європа", new Image()));
            countries.Add(new Country("Сан-Томе і Принсіпі", "Сан-Томе", "STN", "португальська", 210000, "Африка", new Image()));
            countries.Add(new Country("Саудівська Аравія", "Рияд", "SAR", "арабська", 35000000, "Азія", new Image()));
            countries.Add(new Country("Свазіленд", "Мбабане", "SZL", "свазі", 1400000, "Африка", new Image()));
            countries.Add(new Country("Сейшельські Острови", "Вікторія", "SCR", "сейшельська, французька, англійська", 97000, "Африка", new Image()));
            countries.Add(new Country("Сенегал", "Дакар", "XOF", "французька", 16700000, "Африка", new Image()));
            countries.Add(new Country("Сент-Вінсент і Гренадини", "Кінгстаун", "XCD", "англійська", 110000, "Північна Америка", new Image()));
            countries.Add(new Country("Сент-Кіттс і Невіс", "Бастер", "XCD", "англійська", 56000, "Північна Америка", new Image()));
            countries.Add(new Country("Сент-Люсія", "Кастрі", "XCD", "англійська", 180000, "Північна Америка", new Image()));
            countries.Add(new Country("Сербія", "Белград", "RSD", "сербська", 6900000, "Європа", new Image()));
            countries.Add(new Country("Сирія", "Дамаск", "SYP", "арабська", 17000000, "Азія", new Image()));
            countries.Add(new Country("Сінгапур", "Сінгапур", "SGD", "англійська, малайська, китайська, тамільська", 5900000, "Азія", new Image()));
            countries.Add(new Country("Словаччина", "Братислава", "EUR", "словацька", 5500000, "Європа", new Image()));
            countries.Add(new Country("Словенія", "Любляна", "EUR", "словенська", 2100000, "Європа", new Image()));
            countries.Add(new Country("Соломонові Острови", "Хоніара", "SBD", "англійська", 700000, "Океанія", new Image()));
            countries.Add(new Country("Сомалі", "Могадішо", "SOS", "сомалі", 16000000, "Африка", new Image()));
            countries.Add(new Country("Судан", "Хартум", "SDG", "арабська", 44000000, "Африка", new Image()));
            countries.Add(new Country("Суринам", "Парамарибо", "SRD", "голландська", 600000, "Південна Америка", new Image()));
            countries.Add(new Country("Східний Тимор", "Ділі", "USD", "тетум, португальська", 1300000, "Азія", new Image()));
            countries.Add(new Country("США", "Вашингтон, округ Колумбія", "USD", "англійська", 331000000, "Північна Америка", new Image()));
            countries.Add(new Country("Сьєрра-Леоне", "Фрітаун", "SLL", "англійська", 8000000, "Африка", new Image()));
            countries.Add(new Country("Таджикистан", "Душанбе", "TJS", "таджицька", 9200000, "Азія", new Image()));
            countries.Add(new Country("Таїланд", "Бангкок", "THB", "тайська", 69000000, "Азія", new Image()));
            countries.Add(new Country("Тайвань", "Тайпей", "TWD", "китайська", 24000000, "Азія", new Image()));
            countries.Add(new Country("Танзанія", "Додома", "TZS", "суахілі, англійська", 61000000, "Африка", new Image()));
            countries.Add(new Country("Того", "Ломе", "XOF", "французька", 8200000, "Африка", new Image()));
            countries.Add(new Country("Тонга", "Нукуалофа", "TOP", "тонганська, англійська", 100000, "Океанія", new Image()));
            countries.Add(new Country("Тринідад і Тобаго", "Порт-оф-Спейн", "TTD", "англійська", 1399000, "Північна Америка", new Image()));
            countries.Add(new Country("Туніс", "Туніс", "TND", "арабська", 11722000, "Африка", new Image()));
            countries.Add(new Country("Туреччина", "Анкара", "TRY", "турецька", 84339000, "Європа", new Image()));
            countries.Add(new Country("Туркменістан", "Ашгабат", "TMT", "туркменська", 5942000, "Азія", new Image()));
            countries.Add(new Country("Уганда", "Кампала", "UGX", "англійська, свахілі", 44200000, "Африка", new Image()));
            countries.Add(new Country("Угорщина", "Будапешт", "HUF", "угорська", 9773000, "Європа", new Image()));
            countries.Add(new Country("Узбекистан", "Ташкент", "UZS", "узбецька", 34740000, "Азія", new Image()));
            countries.Add(new Country("Україна", "Київ", "UAH", "українська", 41592000, "Європа", new Image()));
            countries.Add(new Country("Уругвай", "Монтевідео", "UYU", "іспанська", 3477000, "Південна Америка", new Image()));
            countries.Add(new Country("Фіджі", "Сува", "FJD", "фіджійська, англійська", 896000, "Океанія", new Image()));
            countries.Add(new Country("Філіппіни", "Маніла", "PHP", "філіппінська", 111206000, "Азія", new Image()));
            countries.Add(new Country("Фінляндія", "Гельсінкі", "EUR", "фінська, шведська", 5540720, "Європа", new Image()));
            countries.Add(new Country("Франція", "Париж", "EUR", "французька", 67076000, "Європа", new Image()));
            countries.Add(new Country("Хорватія", "Загреб", "HRK", "хорватська", 4087843, "Європа", new Image()));
            countries.Add(new Country("Центральноафриканська Республіка", "Бангі", "XAF", "французька, санго", 4827000, "Африка", new Image()));
            countries.Add(new Country("Чад", "Нджамена", "XAF", "французька, арабська", 16877000, "Африка", new Image()));
            countries.Add(new Country("Чехія", "Прага", "CZK", "чеська", 10610000, "Європа", new Image()));
            countries.Add(new Country("Чилі", "Сантьяго", "CLP", "іспанська", 19107216, "Південна Америка", new Image()));
            countries.Add(new Country("Швейцарія", "Берн", "CHF", "німецька, французька, італійська, ретороманська", 8591360, "Європа", new Image()));
            countries.Add(new Country("Швеція", "Стокгольм", "SEK", "шведська", 10391000, "Європа", new Image()));
            countries.Add(new Country("Шрі-Ланка", "Коломбо", "LKR", "сингальська, тамільська", 21803000, "Азія", new Image()));
            countries.Add(new Country("Ямайка", "Кінгстон", "JMD", "англійська", 2948279, "Північна Америка", new Image()));
            countries.Add(new Country("Японія", "Токіо", "JPY", "японська", 126476461, "Азія", new Image()));


              searchTextBox.TextChanged += searchTextBox_TextChanged;
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = searchTextBox.Text.ToLower();
            var filteredCountries = countries.Where(country => country.Name.ToLower().Contains(searchText)).ToList();
            resultStackPanel.Children.Clear();
            foreach (var country in filteredCountries)
            {
                SearchedCountry countryInfoTextBlock = new SearchedCountry($"Країна: {country.Name}.", country.Currency, country.Name); //tut
                countryInfoTextBlock.MouseDown += EventEvent;
                resultStackPanel.Children.Add(countryInfoTextBlock);
            }
        }

        private void EventEvent(object sender, MouseButtonEventArgs e)
        {

            MessageBox.Show("lesha");
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {

            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Scroll.Visibility = Visibility.Visible;
            var sortedCountries = countries.OrderBy(country => country.Population).ToList();

            resultStackPanel.Children.Clear();

            foreach (var country in sortedCountries)
            {
                var countryInfoTextBlock = new TextBlock();
                countryInfoTextBlock.Text = $"Країна: {country.Name}. Столиця: {country.Capital}. Валюта: {country.Currency}. Мова: {country.Language}. Населення: {country.Population:N0}. Регіон: {country.Region}.";
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

        private void SortByCurrency_Click(object sender, RoutedEventArgs e)
        {
            Scroll.Visibility = Visibility.Visible;
            var sortedCountries = countries.OrderBy(country => country.Currency).ToList();

            resultStackPanel.Children.Clear();

            foreach (var country in sortedCountries)
            {
                var countryInfoTextBlock = new TextBlock();
                countryInfoTextBlock.Text = $"Країна: {country.Name}. Столиця: {country.Capital}. Валюта: {country.Currency}. Мова: {country.Language}. Населення: {country.Population:N0}. Регіон: {country.Region}.";
                resultStackPanel.Children.Add(countryInfoTextBlock);
            }
        }

        private void SortAlphabetically_Click(object sender, RoutedEventArgs e)
        {
            Scroll.Visibility = Visibility.Visible;
            var sortedCountries = countries.OrderBy(country => country.Name).ToList();

            resultStackPanel.Children.Clear();

            foreach (var country in sortedCountries)
            {
                var countryInfoTextBlock = new TextBlock();
                countryInfoTextBlock.Text = $"Країна: {country.Name}. Столиця: {country.Capital}. Валюта: {country.Currency}. Мова: {country.Language}. Населення: {country.Population:N0}. Регіон: {country.Region}.";
                resultStackPanel.Children.Add(countryInfoTextBlock);
            }
        }

        private void SortByLanguage_Click(object sender, RoutedEventArgs e)
        {
            Scroll.Visibility = Visibility.Visible;
            var sortedCountries = countries.OrderBy(country => country.Language).ToList();

            resultStackPanel.Children.Clear();

            foreach (var country in sortedCountries)
            {
                var countryInfoTextBlock = new TextBlock();
                countryInfoTextBlock.Text = $"Країна: {country.Name}. Столиця: {country.Capital}. Валюта: {country.Currency}. Мова: {country.Language}. Населення: {country.Population:N0}. Регіон: {country.Region}.";
                resultStackPanel.Children.Add(countryInfoTextBlock);
            }
        }

        private void ClearResults_Click(object sender, RoutedEventArgs e)
        {
            resultStackPanel.Children.Clear();
        }

        private void SortByRegion_Click(object sender, RoutedEventArgs e)
        {
            Scroll.Visibility = Visibility.Visible;
            var sortedCountries = countries.OrderBy(country => country.Region).ToList();

            resultStackPanel.Children.Clear();

            foreach (var country in sortedCountries)
            {
                var countryInfoTextBlock = new TextBlock();
                countryInfoTextBlock.Text = $"Країна: {country.Name}. Столиця: {country.Capital}. Валюта: {country.Currency}. Мова: {country.Language}. Населення: {country.Population:N0}. Регіон: {country.Region}.";
                resultStackPanel.Children.Add(countryInfoTextBlock);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Country.gaga = this;
        }
    }
}