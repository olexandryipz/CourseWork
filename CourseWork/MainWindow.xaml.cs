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

            countries.Add(new Country("Австралія", "Канберра", "AUD", "англійська", 24500000, "Океаніка", getImage("avs")));
            countries.Add(new Country("Австрія", "Відень", "EUR", "німецька", 8800000, "Європа", getImage("avst")));
            countries.Add(new Country("Азербайджан", "Баку", "AZN", "азербайджанська", 9900000, "Азія", getImage("azer")));
            countries.Add(new Country("Албанія", "Тирана", "ALL", "албанська", 2900000, "Європа", getImage("alb")));
            countries.Add(new Country("Алжир", "Алжир", "DZD", "арабська, берберська", 42200000, "Африка", getImage("alj")));
            countries.Add(new Country("Ангола", "Луанда", "AOA", "португальська", 28600000, "Африка", getImage("ang")));
            countries.Add(new Country("Андорра", "Андорра-ла-Велья", "EUR", "каталонська", 80000, "Європа", getImage("and")));
            countries.Add(new Country("Антигуа і Барбуда", "Сент-Джонс", "XCD", "англійська", 100000, "Північна Америка", getImage("ant")));
            countries.Add(new Country("Аргентина", "Буенос-Айрес", "ARS", "іспанська", 44300000, "Південна Америка", getImage("arg")));
            countries.Add(new Country("Афганістан", "Кабул", "AFN", "пушту, дарі", 35500000, "Азія", getImage("afg")));
            countries.Add(new Country("Багамські Острови", "Нассау", "BSD", "англійська", 400000, "Північна Америка", getImage("bag")));
            countries.Add(new Country("Бангладеш", "Дакка", "BDT", "бенгальська", 164700000, "Азія", getImage("ban")));
            countries.Add(new Country("Барбадос", "Бриджтаун", "BBD", "англійська", 300000, "Північна Америка", getImage("bar")));
            countries.Add(new Country("Бахрейн", "Манама", "BHD", "арабська", 1500000, "Азія", getImage("bah")));
            countries.Add(new Country("Беліз", "Бельмопан", "BZD", "англійська", 400000, "Північна Америка", getImage("beliz")));
            countries.Add(new Country("Бельгія", "Брюссель", "EUR", "нідерландська, французька, німецька", 11200000, "Європа", getImage("bel")));
            countries.Add(new Country("Бенін", "Порто-Ново", "XOF", "французька", 12100000, "Африка", getImage("ben")));
            countries.Add(new Country("Білорусь", "Мінськ", "BYN", "білоруська, російська", 9485000, "Європа", getImage("belarus")));
            countries.Add(new Country("Болгарія", "Софія", "BGN", "болгарська", 7000000, "Європа", getImage("bolgaria")));
            countries.Add(new Country("Болівія", "Сукре", "BOB", "іспанська, аймара, кечуа, гуарані", 11300000, "Південна Америка", getImage("bol")));
            countries.Add(new Country("Боснія і Герцеговина", "Сараєво", "BAM", "боснійська, сербська, хорватська", 3300000, "Європа", getImage("bos")));
            countries.Add(new Country("Ботсвана", "Габороне", "BWP", "англійська, тсвана", 2300000, "Африка", getImage("bot")));
            countries.Add(new Country("Бразилія", "Бразиліа", "BRL", "португальська", 212000000, "Південна Америка", getImage("brasil")));
            countries.Add(new Country("Бруней", "Бандар-Сері-Бегаван", "BND", "малаїзька, англійська", 440000, "Азія", getImage("brunei")));
            countries.Add(new Country("Буркіна-Фасо", "Уагадугу", "XOF", "французька", 20900000, "Африка", getImage("burkina")));
            countries.Add(new Country("Бурунді", "Гітега", "BIF", "кірунді, французька", 11800000, "Африка", getImage("bur")));
            countries.Add(new Country("Бутан", "Тхімпху", "BTN", "дзонг-кха", 800000, "Азія", getImage("but")));
            countries.Add(new Country("Вануату", "Порт-Віла", "VUV", "біслама, англійська, французька", 300000, "Океаніка", getImage("van")));
            countries.Add(new Country("Ватикан", "Ватикан", "EUR", "італійська, латинська", 800, "Європа", getImage("vat")));
            countries.Add(new Country("Велика Британія", "Лондон", "GBP", "англійська", 66000000, "Європа", getImage("eng")));
            countries.Add(new Country("Венесуела", "Каракас", "VES", "іспанська", 28800000, "Південна Америка", getImage("ven")));
            countries.Add(new Country("Вірменія", "Єреван", "AMD", "вірменська", 2950000, "Азія", getImage("vir")));
            countries.Add(new Country("В'єтнам", "Ханой", "VND", "в'єтнамська", 96200000, "Азія", getImage("vie")));
            countries.Add(new Country("Габон", "Лібревіль", "XAF", "французька", 2060000, "Африка", getImage("gabon")));
            countries.Add(new Country("Гаїті", "Порт-о-Пренс", "HTG", "французька, креольська", 11000000, "Північна Америка", getImage("gaiti")));
            countries.Add(new Country("Гайана", "Джорджтаун", "GYD", "англійська", 770000, "Південна Америка", getImage("gayana")));
            countries.Add(new Country("Гамбія", "Банжул", "GMD", "англійська", 2100000, "Африка", getImage("gambia")));
            countries.Add(new Country("Гана", "Аккра", "GHS", "англійська", 31000000, "Африка", getImage("gana")));
            countries.Add(new Country("Гватемала", "Гватемала", "GTQ", "іспанська", 17700000, "Північна Америка", getImage("gva")));
            countries.Add(new Country("Гвінея", "Конакрі", "GNF", "фула, сусу, малінке, французька", 12900000, "Африка", getImage("gvi")));
            countries.Add(new Country("Гвінея-Бісау", "Бісау", "XOF", "португальська", 1620000, "Африка", getImage("guibis")));
            countries.Add(new Country("Гондурас", "Тегусігальпа", "HNL", "іспанська", 10000000, "Північна Америка", getImage("gonduras")));
            countries.Add(new Country("Гренада", "Сент-Джорджес", "XCD", "англійська", 107000, "Північна Америка", getImage("grenada")));
            countries.Add(new Country("Греція", "Афіни", "EUR", "грецька", 10700000, "Європа", getImage("greece")));
            countries.Add(new Country("Грузія", "Тбілісі", "GEL", "грузинська", 4000000, "Азія", getImage("georgia")));
            countries.Add(new Country("Данія", "Копенгаген", "DKK", "датська", 5800000, "Європа", getImage("dan")));
            countries.Add(new Country("Джибуті", "Джибуті", "DJF", "арабська, французька", 900000, "Африка", getImage("dji")));
            countries.Add(new Country("Домініка", "Розо", "XCD", "англійська", 71000, "Північна Америка", getImage("domi")));
            countries.Add(new Country("Домініканська Республіка", "Санто-Домінго", "DOP", "іспанська", 11000000, "Північна Америка", getImage("dom")));
            countries.Add(new Country("Єгипет", "Каїр", "EGP", "арабська", 101000000, "Африка", getImage("egypt")));
            countries.Add(new Country("Замбія", "Лусака", "ZMW", "англійська", 17800000, "Африка", getImage("zam")));
            countries.Add(new Country("Зімбабве", "Хараре", "ZWL", "англійська, шона, ндебеле", 15000000, "Африка", getImage("zim")));
            countries.Add(new Country("Ізраїль", "Єрусалим", "ILS", "іврит, арабська", 9000000, "Азія", getImage("isreal")));
            countries.Add(new Country("Індія", "Нью-Делі", "INR", "хінді, англійська", 1380000000, "Азія", getImage("india")));
            countries.Add(new Country("Індонезія", "Джакарта", "IDR", "індонезійська", 270000000, "Азія", getImage("indo")));
            countries.Add(new Country("Ірак", "Багдад", "IQD", "арабська, курдська", 40000000, "Азія", getImage("iraq")));
            countries.Add(new Country("Іран", "Тегеран", "IRR", "перська", 82000000, "Азія", getImage("iran")));
            countries.Add(new Country("Ірландія", "Дублін", "EUR", "ірландська, англійська", 4900000, "Європа", getImage("ireland")));
            countries.Add(new Country("Ісландія", "Рейк'явік", "ISK", "ісландська", 340000, "Європа", getImage("iceland")));
            countries.Add(new Country("Іспанія", "Мадрид", "EUR", "іспанська", 47000000, "Європа", getImage("spain")));
            countries.Add(new Country("Італія", "Рим", "EUR", "італійська", 60200000, "Європа", getImage("ita")));
            countries.Add(new Country("Йорданія", "Амман", "JOD", "арабська", 10200000, "Азія", getImage("ior")));
            countries.Add(new Country("Кабо-Верде", "Прая", "CVE", "португальська", 560000, "Африка", getImage("kabo")));
            countries.Add(new Country("Казахстан", "Нур-Султан", "KZT", "казахська, російська", 18800000, "Азія", getImage("kaz")));
            countries.Add(new Country("Камбоджа", "Пномпень", "KHR", "кхмерська", 16900000, "Азія", getImage("cam")));
            countries.Add(new Country("Камерун", "Яунде", "XAF", "французька, англійська", 26500000, "Африка", getImage("cam")));
            countries.Add(new Country("Канада", "Оттава", "CAD", "англійська, французька", 37700000, "Північна Америка", getImage("can")));
            countries.Add(new Country("Катар", "Доха", "QAR", "арабська", 2880000, "Азія", getImage("qat")));
            countries.Add(new Country("Кенія", "Найробі", "KES", "суахілі, англійська", 54000000, "Африка", getImage("ken")));
            countries.Add(new Country("Киргизстан", "Бішкек", "KGS", "кіргизька, російська", 6500000, "Азія", getImage("kyr")));
            countries.Add(new Country("Кіпр", "Нікосія", "EUR", "грецька, турецька", 1207000, "Європа", getImage("cypr")));
            countries.Add(new Country("Кірибаті", "Тарава", "AUD", "англійська, гілбертійська", 120000, "Океанія", getImage("kir")));
            countries.Add(new Country("Китай", "Пекін", "CNY", "китайська", 1400000000, "Азія", getImage("chi")));
            countries.Add(new Country("Колумбія", "Богота", "COP", "іспанська", 51000000, "Південна Америка", getImage("col")));
            countries.Add(new Country("Коморські Острови", "Мороні", "KMF", "французька, арабська", 800000, "Африка", getImage("kom")));
            countries.Add(new Country("Конго (Браззавіль)", "Браззавіль", "XAF", "французька", 5500000, "Африка", getImage("kong")));
            countries.Add(new Country("Конго (Кіншаса)", "Кіншаса", "CDF", "французька", 90000000, "Африка", getImage("kon")));
            countries.Add(new Country("Коста-Ріка", "Сан-Хосе", "CRC", "іспанська", 5100000, "Північна Америка", getImage("kos")));
            countries.Add(new Country("Кот-д'Івуар", "Ямусукро", "XOF", "французька", 26000000, "Африка", getImage("kot")));
            countries.Add(new Country("Куба", "Гавана", "CUP", "іспанська", 11300000, "Північна Америка", getImage("kub")));
            countries.Add(new Country("Кувейт", "Кувейт", "KWD", "арабська", 4200000, "Азія", getImage("kyv")));
            countries.Add(new Country("Лаос", "В'єнтьян", "LAK", "лаоська", 7400000, "Азія", getImage("lao")));
            countries.Add(new Country("Латвія", "Рига", "EUR", "латиська", 1900000, "Європа", getImage("lat")));
            countries.Add(new Country("Лесото", "Масеру", "LSL", "сесото, англійська", 2000000, "Африка", getImage("les")));
            countries.Add(new Country("Литва", "Вільнюс", "EUR", "литовська", 2800000, "Європа", getImage("lit")));
            countries.Add(new Country("Ліберія", "Монровія", "LRD", "англійська", 5100000, "Африка", getImage("lib")));
            countries.Add(new Country("Ліван", "Бейрут", "LBP", "арабська", 6850000, "Азія", getImage("liva")));
            countries.Add(new Country("Лівія", "Тріполі", "LYD", "арабська", 6700000, "Африка", getImage("liv")));
            countries.Add(new Country("Ліхтенштейн", "Вадуц", "CHF", "німецька", 38000, "Європа", getImage("lie")));
            countries.Add(new Country("Люксембург", "Люксембург", "EUR", "французька, нідерландська, німецька", 620000, "Європа", getImage("lux")));
            countries.Add(new Country("Маврикій", "Порт-Луї", "MUR", "маврикійська", 1400000, "Африка", getImage("mavr")));
            countries.Add(new Country("Мавританія", "Нуакшот", "MRU", "арабська", 4400000, "Африка", getImage("mav")));
            countries.Add(new Country("Мадагаскар", "Антананаріву", "MGA", "малагасійська, французька", 27000000, "Африка", getImage("mad")));
            countries.Add(new Country("Македонія (Північна)", "Скоп'є", "MKD", "македонська", 2100000, "Європа", getImage("mac")));
            countries.Add(new Country("Малаві", "Лілонгве", "MWK", "чева, англійська", 19000000, "Африка", getImage("malavi")));
            countries.Add(new Country("Малайзія", "Куала-Лумпур", "MYR", "малаїзійська", 32000000, "Азія", getImage("mala")));
            countries.Add(new Country("Малі", "Бамако", "XOF", "французька", 20000000, "Африка", getImage("mali")));
            countries.Add(new Country("Мальдіви", "Мале", "MVR", "мальдівська", 440000, "Азія", getImage("mald")));
            countries.Add(new Country("Мальта", "Валлетта", "EUR", "мальтійська, англійська", 440000, "Європа", getImage("mal")));
            countries.Add(new Country("Марокко", "Рабат", "MAD", "арабська", 37000000, "Африка", getImage("mar")));
            countries.Add(new Country("Маршаллові Острови", "Маджуро", "USD", "англійська, маршалльська", 59000, "Океанія", getImage("mai")));
            countries.Add(new Country("Мексика", "Мехіко", "MXN", "іспанська", 129000000, "Північна Америка", getImage("mex")));
            countries.Add(new Country("Мозамбік", "Мапуту", "MZN", "португальська", 31000000, "Африка", getImage("moz")));
            countries.Add(new Country("Молдова", "Кишинів", "MDL", "молдовська, румунська", 2700000, "Європа", getImage("mol")));
            countries.Add(new Country("Монако", "Монако", "EUR", "французька", 39000, "Європа", getImage("mona")));
            countries.Add(new Country("Монголія", "Улан-Батор", "MNT", "монгольська", 3300000, "Азія", getImage("mon")));
            countries.Add(new Country("М'янма", "Найп'їдо", "MMK", "бірманська", 54000000, "Азія", getImage("mya")));
            countries.Add(new Country("Намібія", "Віндгук", "NAD", "англійська", 2500000, "Африка", getImage("nam")));
            countries.Add(new Country("Науру", "Ярен", "AUD", "науру", 11000, "Океанія", getImage("nau")));
            countries.Add(new Country("Непал", "Катманду", "NPR", "непальська", 29000000, "Азія", getImage("nep")));
            countries.Add(new Country("Нігер", "Ніамей", "XOF", "французька", 24000000, "Африка", getImage("nig")));
            countries.Add(new Country("Нігерія", "Абуджа", "NGN", "англійська", 206000000, "Африка", getImage("nige")));
            countries.Add(new Country("Нідерланди", "Амстердам", "EUR", "нідерландська", 17500000, "Європа", getImage("net")));
            countries.Add(new Country("Нікарагуа", "Манагуа", "NIO", "іспанська", 6600000, "Північна Америка", getImage("nik")));
            countries.Add(new Country("Німеччина", "Берлін", "EUR", "німецька", 83000000, "Європа", getImage("ger")));
            countries.Add(new Country("Нова Зеландія", "Веллінгтон", "NZD", "англійська, маорі", 5000000, "Океанія", getImage("nwz")));
            countries.Add(new Country("Норвегія", "Осло", "NOK", "норвезька", 5300000, "Європа", getImage("nor")));
            countries.Add(new Country("Об'єднані Арабські Емірати", "Абу-Дабі", "AED", "арабська", 9900000, "Азія", getImage("oae")));
            countries.Add(new Country("Оман", "Маскат", "OMR", "арабська", 5000000, "Азія", getImage("oma")));
            countries.Add(new Country("Пакистан", "Ісламабад", "PKR", "урду, англійська", 220000000, "Азія", getImage("pak")));
            countries.Add(new Country("Палау", "Нгеруулмуд", "USD", "англійська, палауанська", 18000, "Океанія", getImage("pal")));
            countries.Add(new Country("Панама", "Панама", "PAB", "іспанська", 4200000, "Північна Америка", getImage("pan")));
            countries.Add(new Country("Папуа-Нова Гвінея", "Порт-Морсбі", "PGK", "англійська", 9000000, "Океанія", getImage("pap")));
            countries.Add(new Country("Парагвай", "Асунсьйон", "PYG", "іспанська, гуарані", 7200000, "Південна Америка", getImage("para")));
            countries.Add(new Country("Перу", "Ліма", "PEN", "іспанська", 33000000, "Південна Америка", getImage("per")));
            countries.Add(new Country("Південна Корея", "Сеул", "KRW", "корейська", 51000000, "Азія", getImage("korea")));
            countries.Add(new Country("Південний Судан", "Джуба", "SSP", "англійська", 13000000, "Африка", getImage("pis")));
            countries.Add(new Country("Південно-Африканська респ", "Преторія", "ZAR", "англійська", 60000000, "Африка", getImage("par")));
            countries.Add(new Country("Північна Корея", "Пхеньян", "KPW", "корейська", 25000000, "Азія", getImage("nrk")));
            countries.Add(new Country("Польща", "Варшава", "PLN", "польська", 38000000, "Європа", getImage("pln")));
            countries.Add(new Country("Португалія", "Лісабон", "EUR", "португальська", 10200000, "Європа", getImage("por")));
            countries.Add(new Country("Руанда", "Кігалі", "RWF", "руанда, французька, англійська", 13000000, "Африка", getImage("rwanda")));
            countries.Add(new Country("Румунія", "Бухарест", "RON", "румунська", 19000000, "Європа", getImage("rum")));
            countries.Add(new Country("Сальвадор", "Сан-Сальвадор", "SVC", "іспанська", 6700000, "Північна Америка", getImage("sal")));
            countries.Add(new Country("Самоа", "Апіа", "WST", "самоанська, англійська", 200000, "Океанія", getImage("sam")));
            countries.Add(new Country("Сан-Марино", "Сан-Марино", "EUR", "італійська", 34000, "Європа", getImage("snm")));
            countries.Add(new Country("Сан-Томе і Принсіпі", "Сан-Томе", "STN", "португальська", 210000, "Африка", getImage("stp")));
            countries.Add(new Country("Саудівська Аравія", "Рияд", "SAR", "арабська", 35000000, "Азія", getImage("sua")));
            countries.Add(new Country("Свазіленд", "Мбабане", "SZL", "свазі", 1400000, "Африка", getImage("esv")));
            countries.Add(new Country("Сейшельські Острови", "Вікторія", "SCR", "сейшельська, французька, англійська", 97000, "Африка", getImage("sei")));
            countries.Add(new Country("Сенегал", "Дакар", "XOF", "французька", 16700000, "Африка", getImage("sen")));
            countries.Add(new Country("Сент-Вінсент і Гренадини", "Кінгстаун", "XCD", "англійська", 110000, "Північна Америка", getImage("svg")));
            countries.Add(new Country("Сент-Кіттс і Невіс", "Бастер", "XCD", "англійська", 56000, "Північна Америка", getImage("skn")));
            countries.Add(new Country("Сент-Люсія", "Кастрі", "XCD", "англійська", 180000, "Північна Америка", getImage("sls")));
            countries.Add(new Country("Сербія", "Белград", "RSD", "сербська", 6900000, "Європа", getImage("ser")));
            countries.Add(new Country("Сирія", "Дамаск", "SYP", "арабська", 17000000, "Азія", getImage("sir")));
            countries.Add(new Country("Сінгапур", "Сінгапур", "SGD", "англійська, малайська", 5900000, "Азія", getImage("sin")));
            countries.Add(new Country("Словаччина", "Братислава", "EUR", "словацька", 5500000, "Європа", getImage("slov")));
            countries.Add(new Country("Словенія", "Любляна", "EUR", "словенська", 2100000, "Європа", getImage("slo")));
            countries.Add(new Country("Соломонові Острови", "Хоніара", "SBD", "англійська", 700000, "Океанія", getImage("sol")));
            countries.Add(new Country("Сомалі", "Могадішо", "SOS", "сомалі", 16000000, "Африка", getImage("som")));
            countries.Add(new Country("Судан", "Хартум", "SDG", "арабська", 44000000, "Африка", getImage("sud")));
            countries.Add(new Country("Суринам", "Парамарибо", "SRD", "голландська", 600000, "Південна Америка", getImage("sur")));
            countries.Add(new Country("Східний Тимор", "Ділі", "USD", "тетум, португальська", 1300000, "Азія", getImage("tim")));
            countries.Add(new Country("США", "Вашингтон", "USD", "англійська", 331000000, "Північна Америка", getImage("sha")));
            countries.Add(new Country("Сьєрра-Леоне", "Фрітаун", "SLL", "англійська", 8000000, "Африка", getImage("sil")));
            countries.Add(new Country("Таджикистан", "Душанбе", "TJS", "таджицька", 9200000, "Азія", getImage("taj")));
            countries.Add(new Country("Таїланд", "Бангкок", "THB", "тайська", 69000000, "Азія", getImage("tail")));
            countries.Add(new Country("Тайвань", "Тайпей", "TWD", "китайська", 24000000, "Азія", getImage("tai")));
            countries.Add(new Country("Танзанія", "Додома", "TZS", "суахілі, англійська", 61000000, "Африка", getImage("tan")));
            countries.Add(new Country("Того", "Ломе", "XOF", "французька", 8200000, "Африка", getImage("tog")));
            countries.Add(new Country("Тонга", "Нукуалофа", "TOP", "тонганська, англійська", 100000, "Океанія", getImage("ton")));
            countries.Add(new Country("Тринідад і Тобаго", "Порт-оф-Спейн", "TTD", "англійська", 1399000, "Північна Америка", getImage("tat")));
            countries.Add(new Country("Туніс", "Туніс", "TND", "арабська", 11722000, "Африка", getImage("tun")));
            countries.Add(new Country("Туреччина", "Анкара", "TRY", "турецька", 84339000, "Європа", getImage("turkey")));
            countries.Add(new Country("Туркменістан", "Ашгабат", "TMT", "туркменська", 5942000, "Азія", getImage("tur")));
            countries.Add(new Country("Уганда", "Кампала", "UGX", "англійська, свахілі", 44200000, "Африка", getImage("uga")));
            countries.Add(new Country("Угорщина", "Будапешт", "HUF", "угорська", 9773000, "Європа", getImage("hun")));
            countries.Add(new Country("Узбекистан", "Ташкент", "UZS", "узбецька", 34740000, "Азія", getImage("uzb")));
            countries.Add(new Country("Україна", "Київ", "UAH", "українська", 41592000, "Європа", getImage("ukr")));
            countries.Add(new Country("Уругвай", "Монтевідео", "UYU", "іспанська", 3477000, "Південна Америка", getImage("uru")));
            countries.Add(new Country("Фіджі", "Сува", "FJD", "фіджійська, англійська", 896000, "Океанія", getImage("fij")));
            countries.Add(new Country("Філіппіни", "Маніла", "PHP", "філіппінська", 111206000, "Азія", getImage("phi")));
            countries.Add(new Country("Фінляндія", "Гельсінкі", "EUR", "фінська, шведська", 5540720, "Європа", getImage("fin")));
            countries.Add(new Country("Франція", "Париж", "EUR", "французька", 67076000, "Європа", getImage("fra")));
            countries.Add(new Country("Хорватія", "Загреб", "HRK", "хорватська", 4087843, "Європа", getImage("cro")));
            countries.Add(new Country("ЦАР", "Бангі", "XAF", "французька, санго", 4827000, "Африка", getImage("car")));
            countries.Add(new Country("Чад", "Нджамена", "XAF", "французька, арабська", 16877000, "Африка", getImage("chd")));
            countries.Add(new Country("Чехія", "Прага", "CZK", "чеська", 10610000, "Європа", getImage("czh")));
            countries.Add(new Country("Чилі", "Сантьяго", "CLP", "іспанська", 19107216, "Південна Америка", getImage("chl")));
            countries.Add(new Country("Швейцарія", "Берн", "CHF", "німецька, французька, італійська", 8591360, "Європа", getImage("swc")));
            countries.Add(new Country("Швеція", "Стокгольм", "SEK", "шведська", 10391000, "Європа", getImage("swd")));
            countries.Add(new Country("Шрі-Ланка", "Коломбо", "LKR", "сингальська, тамільська", 21803000, "Азія", getImage("sri")));
            countries.Add(new Country("Ямайка", "Кінгстон", "JMD", "англійська", 2948279, "Північна Америка", getImage("jam")));
            countries.Add(new Country("Японія", "Токіо", "JPY", "японська", 126476461, "Азія", getImage("jpn")));


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
                SearchedCountry countryInfoTextBlock = new SearchedCountry($"{country.Name}.", country.Currency, country.Name, country.Capital, country.Language, country.Region, country.Population, country.Image); //tut
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