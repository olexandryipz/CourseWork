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

            countries.Add(new Country("Австралія", "Канберра", "AUD (австралійський долар)", "англійська", 24500000, "Океаніка", getImage("avs"), new Image()));
            countries.Add(new Country("Австрія", "Відень", "EUR (євро)", "німецька", 8800000, "Європа", getImage("avst"), new Image()));
            countries.Add(new Country("Азербайджан", "Баку", "AZN (азербайджанський манат)", "азербайджанська", 9900000, "Азія", getImage("azer"), new Image()));
            countries.Add(new Country("Албанія", "Тирана", "ALL (албанський лек)", "албанська", 2900000, "Європа", getImage("alb"), new Image()));
            countries.Add(new Country("Алжир", "Алжир", "DZD (алжирський динар)", "арабська, берберська", 42200000, "Африка", getImage("alj"), new Image()));
            countries.Add(new Country("Ангола", "Луанда", "AOA (ангольська кванза)", "португальська", 28600000, "Африка", getImage("ang"), new Image()));
            countries.Add(new Country("Андорра", "Андорра-ла-Велья", "EUR (євро)", "каталонська", 80000, "Європа", getImage("and"), new Image()));
            countries.Add(new Country("Антигуа і Барбуда", "Сент-Джонс", "XCD (східнокарибський долар)", "англійська", 100000, "Північна Америка", getImage("ant"), new Image()));
            countries.Add(new Country("Аргентина", "Буенос-Айрес", "ARS (аргентинське песо)", "іспанська", 44300000, "Південна Америка", getImage("arg"), new Image()));
            countries.Add(new Country("Афганістан", "Кабул", "AFN (афгані)", "пушту, дарі", 35500000, "Азія", getImage("afg"), new Image()));
            countries.Add(new Country("Багамські Острови", "Нассау", "BSD (багамський долар)", "англійська", 400000, "Північна Америка", getImage("bag"), new Image()));
            countries.Add(new Country("Бангладеш", "Дакка", "BDT (бангладеська така)", "бенгальська", 164700000, "Азія", getImage("ban"), new Image()));
            countries.Add(new Country("Барбадос", "Бриджтаун", "BBD (барбадоський долар)", "англійська", 300000, "Північна Америка", getImage("bar"), new Image()));
            countries.Add(new Country("Бахрейн", "Манама", "BHD (бахрейнський динар)", "арабська", 1500000, "Азія", getImage("bah"), new Image()));
            countries.Add(new Country("Беліз", "Бельмопан", "BZD (белізький долар)", "англійська", 400000, "Північна Америка", getImage("beliz"), new Image()));
            countries.Add(new Country("Бельгія", "Брюссель", "EUR (євро)", "нідерландська, французька, німецька", 11200000, "Європа", getImage("bel"), new Image()));
            countries.Add(new Country("Бенін", "Порто-Ново", "XOF (західноафриканський франк)", "французька", 12100000, "Африка", getImage("ben"), new Image()));
            countries.Add(new Country("Білорусь", "Мінськ", "BYN (білоруський рубль)", "білоруська, російська", 9485000, "Європа", getImage("belarus"), new Image()));
            countries.Add(new Country("Болгарія", "Софія", "BGN (болгарський лев)", "болгарська", 7000000, "Європа", getImage("bolgaria"), new Image()));
            countries.Add(new Country("Болівія", "Сукре", "BOB (болівійський болівіано)", "іспанська, аймара, кечуа, гуарані", 11300000, "Південна Америка", getImage("bol"), new Image()));
            countries.Add(new Country("Боснія і Герцеговина", "Сараєво", "BAM (конвертована марка)", "боснійська, сербська, хорватська", 3300000, "Європа", getImage("bos"), new Image()));
            countries.Add(new Country("Ботсвана", "Габороне", "BWP (ботсванська пула)", "англійська, тсвана", 2300000, "Африка", getImage("bot"), new Image()));
            countries.Add(new Country("Бразилія", "Бразиліа", "BRL (бразильський реал)", "португальська", 212000000, "Південна Америка", getImage("brasil"), new Image()));
            countries.Add(new Country("Бруней", "Бандар-Сері-Бегаван", "BND (брунейський долар)", "малаїзька, англійська", 440000, "Азія", getImage("brunei"), new Image()));
            countries.Add(new Country("Буркіна-Фасо", "Уагадугу", "XOF (західноафриканський франк)", "французька", 20900000, "Африка", getImage("burkina"), new Image()));
            countries.Add(new Country("Бурунді", "Гітега", "BIF (бурундійський франк)", "кірунді, французька", 11800000, "Африка", getImage("bur"), new Image()));
            countries.Add(new Country("Бутан", "Тхімпху", "BTN (бутанський нгултрум)", "дзонг-кха", 800000, "Азія", getImage("but"), new Image()));
            countries.Add(new Country("Вануату", "Порт-Віла", "VUV (вануатська вату)", "біслама, англійська, французька", 300000, "Океаніка", getImage("van"), new Image()));
            countries.Add(new Country("Ватикан", "Ватикан", "EUR (євро)", "італійська, латинська", 800, "Європа", getImage("vat"), new Image()));
            countries.Add(new Country("Велика Британія", "Лондон", "GBP (британський фунт стерлінгів)", "англійська", 66000000, "Європа", getImage("eng"), new Image()));
            countries.Add(new Country("Венесуела", "Каракас", "VES (венесуельський болівар)", "іспанська", 28800000, "Південна Америка", getImage("ven"), new Image()));
            countries.Add(new Country("Вірменія", "Єреван", "AMD (вірменський драм)", "вірменська", 2950000, "Азія", getImage("vir"), new Image()));
            countries.Add(new Country("В'єтнам", "Ханой", "VND (в'єтнамський донг)", "в'єтнамська", 96200000, "Азія", getImage("vie"), new Image()));
            countries.Add(new Country("Габон", "Лібревіль", "XAF (центральноафриканський франк)", "французька", 2060000, "Африка", getImage("gabon"), new Image()));
            countries.Add(new Country("Гаїті", "Порт-о-Пренс", "HTG (гаїтянський гурд)", "французька, креольська", 11000000, "Північна Америка", getImage("gaiti"), new Image()));
            countries.Add(new Country("Гайана", "Джорджтаун", "GYD (гаянський долар)", "англійська", 770000, "Південна Америка", getImage("gayana"), new Image()));
            countries.Add(new Country("Гамбія", "Банжул", "GMD (гамбійський даласі)", "англійська", 2100000, "Африка", getImage("gambia"), new Image()));
            countries.Add(new Country("Гана", "Аккра", "GHS (ганський седі)", "англійська", 31000000, "Африка", getImage("gana"), new Image()));
            countries.Add(new Country("Гватемала", "Гватемала", "GTQ (гватемальський кетсаль)", "іспанська", 17700000, "Північна Америка", getImage("gva"), new Image()));
            countries.Add(new Country("Гвінея", "Конакрі", "GNF (гвінейський франк)", "фула, сусу, малінке, французька", 12900000, "Африка", getImage("gvi"), new Image()));
            countries.Add(new Country("Гвінея-Бісау", "Бісау", "XOF (західноафриканський франк)", "португальська", 1620000, "Африка", getImage("guibis"), new Image()));
            countries.Add(new Country("Гондурас", "Тегусігальпа", "HNL (гондураська лемпіра)", "іспанська", 10000000, "Північна Америка", getImage("gonduras"), new Image()));
            countries.Add(new Country("Гренада", "Сент-Джорджес", "XCD (східнокарибський долар)", "англійська", 107000, "Північна Америка", getImage("grenada"), new Image()));
            countries.Add(new Country("Греція", "Афіни", "EUR (євро)", "грецька", 10700000, "Європа", getImage("greece"), new Image()));
            countries.Add(new Country("Грузія", "Тбілісі", "GEL (грузинський ларі)", "грузинська", 4000000, "Азія", getImage("georgia"), new Image()));
            countries.Add(new Country("Данія", "Копенгаген", "DKK (датська крона)", "датська", 5800000, "Європа", getImage("dan"), new Image()));
            countries.Add(new Country("Джибуті", "Джибуті", "DJF (джибутійський франк)", "арабська, французька", 900000, "Африка", getImage("dji"), new Image()));
            countries.Add(new Country("Домініка", "Розо", "XCD (східнокарибський долар)", "англійська", 71000, "Північна Америка", getImage("domi"), new Image()));
            countries.Add(new Country("Домініканська Республіка", "Санто-Домінго", "DOP (домініканський песо)", "іспанська", 11000000, "Північна Америка", getImage("dom"), new Image()));
            countries.Add(new Country("Єгипет", "Каїр", "EGP (єгипетський фунт)", "арабська", 101000000, "Африка", getImage("egypt"), new Image()));
            countries.Add(new Country("Замбія", "Лусака", "ZMW (замбійська квача)", "англійська", 17800000, "Африка", getImage("zam"), new Image()));
            countries.Add(new Country("Зімбабве", "Хараре", "ZWL (зімбабвійський долар)", "англійська, шона, ндебеле", 15000000, "Африка", getImage("zim"), new Image()));
            countries.Add(new Country("Ізраїль", "Єрусалим", "ILS (ізраїльський новий шекель)", "іврит, арабська", 9000000, "Азія", getImage("isreal"), new Image()));
            countries.Add(new Country("Індія", "Нью-Делі", "INR (індійська рупія)", "хінді, англійська", 1380000000, "Азія", getImage("india"), new Image()));
            countries.Add(new Country("Індонезія", "Джакарта", "IDR (індонезійська рупія)", "індонезійська", 270000000, "Азія", getImage("indo"), new Image()));
            countries.Add(new Country("Ірак", "Багдад", "IQD (іракський динар)", "арабська, курдська", 40000000, "Азія", getImage("iraq"), new Image()));
            countries.Add(new Country("Іран", "Тегеран", "IRR (іранський ріал)", "перська", 82000000, "Азія", getImage("iran"), new Image()));
            countries.Add(new Country("Ірландія", "Дублін", "EUR (євро)", "ірландська, англійська", 4900000, "Європа", getImage("ireland"), new Image()));
            countries.Add(new Country("Ісландія", "Рейк'явік", "ISK (ісландська крона)", "ісландська", 340000, "Європа", getImage("iceland"), new Image()));
            countries.Add(new Country("Іспанія", "Мадрид", "EUR (євро)", "іспанська", 47000000, "Європа", getImage("spain"), new Image()));
            countries.Add(new Country("Італія", "Рим", "EUR (євро)", "італійська", 60200000, "Європа", getImage("ita"), new Image()));
            countries.Add(new Country("Йорданія", "Амман", "JOD (йорданський динар)", "арабська", 10200000, "Азія", getImage("ior"), new Image()));
            countries.Add(new Country("Кабо-Верде", "Прая", "CVE (кабовердський ескудо)", "португальська", 560000, "Африка", getImage("kabo"), new Image()));
            countries.Add(new Country("Казахстан", "Нур-Султан", "KZT (казахстанський тенге)", "казахська, російська", 18800000, "Азія", getImage("kaz"), new Image()));
            countries.Add(new Country("Камбоджа", "Пномпень", "KHR (камбоджійський рієль)", "кхмерська", 16900000, "Азія", getImage("cam"), new Image()));
            countries.Add(new Country("Камерун", "Яунде", "XAF (центральноафриканський франк)", "французька, англійська", 26500000, "Африка", getImage("cam"), new Image()));
            countries.Add(new Country("Канада", "Оттава", "CAD (канадський долар)", "англійська, французька", 37700000, "Північна Америка", getImage("can"), new Image()));
            countries.Add(new Country("Катар", "Доха", "QAR (катарський ріял)", "арабська", 2880000, "Азія", getImage("qat"), new Image()));
            countries.Add(new Country("Кенія", "Найробі", "KES (кенійський шилінг)", "суахілі, англійська", 54000000, "Африка", getImage("ken"), new Image()));
            countries.Add(new Country("Киргизстан", "Бішкек", "KGS (киргизький сом)", "кіргизька, російська", 6500000, "Азія", getImage("kyr"), new Image()));
            countries.Add(new Country("Кіпр", "Нікосія", "EUR (євро)", "грецька, турецька", 1207000, "Європа", getImage("cypr"), new Image()));
            countries.Add(new Country("Кірибаті", "Тарава", "AUD (австралійський долар)", "англійська, гілбертійська", 120000, "Океанія", getImage("kir"), new Image()));
            countries.Add(new Country("Китай", "Пекін", "CNY (Китайський юань)", "китайська", 1400000000, "Азія", getImage("chi"), new Image()));
            countries.Add(new Country("Колумбія", "Богота", "COP (Колумбійське песо)", "іспанська", 51000000, "Південна Америка", getImage("col"), new Image()));
            countries.Add(new Country("Коморські Острови", "Мороні", "KMF (Коморський франк)", "французька, арабська", 800000, "Африка", getImage("kom"), new Image()));
            countries.Add(new Country("Конго (Браззавіль)", "Браззавіль", "XAF (Центральноафриканський франк)", "французька", 5500000, "Африка", getImage("kong"), new Image()));
            countries.Add(new Country("Конго (Кіншаса)", "Кіншаса", "CDF (Конголезький франк)", "французька", 90000000, "Африка", getImage("kon"), new Image()));
            countries.Add(new Country("Коста-Ріка", "Сан-Хосе", "CRC (Костариканський колон)", "іспанська", 5100000, "Північна Америка", getImage("kos"), new Image()));
            countries.Add(new Country("Кот-д'Івуар", "Ямусукро", "XOF (Західноафриканський франк)", "французька", 26000000, "Африка", getImage("kot"), new Image()));
            countries.Add(new Country("Куба", "Гавана", "CUP (Кубинське песо)", "іспанська", 11300000, "Північна Америка", getImage("kub"), new Image()));
            countries.Add(new Country("Кувейт", "Кувейт", "KWD (Кувейтський динар)", "арабська", 4200000, "Азія", getImage("kyv"), new Image()));
            countries.Add(new Country("Лаос", "В'єнтьян", "LAK (Лаоський кіп)", "лаоська", 7400000, "Азія", getImage("lao"), new Image()));
            countries.Add(new Country("Латвія", "Рига", "EUR (Євро)", "латиська", 1900000, "Європа", getImage("lat"), new Image()));
            countries.Add(new Country("Лесото", "Масеру", "LSL (Лесотський лоті)", "сесото, англійська", 2000000, "Африка", getImage("les"), new Image()));
            countries.Add(new Country("Литва", "Вільнюс", "EUR (Євро)", "литовська", 2800000, "Європа", getImage("lit"), new Image()));
            countries.Add(new Country("Ліберія", "Монровія", "LRD (Ліберійський долар)", "англійська", 5100000, "Африка", getImage("lib"), new Image()));
            countries.Add(new Country("Ліван", "Бейрут", "LBP (Ліванський фунт)", "арабська", 6850000, "Азія", getImage("liva"), new Image()));
            countries.Add(new Country("Лівія", "Тріполі", "LYD (Лівійський динар)", "арабська", 6700000, "Африка", getImage("liv"), new Image()));
            countries.Add(new Country("Ліхтенштейн", "Вадуц", "CHF (Швейцарський франк)", "німецька", 38000, "Європа", getImage("lie"), new Image()));
            countries.Add(new Country("Люксембург", "Люксембург", "EUR (Євро)", "французька, нідерландська, німецька", 620000, "Європа", getImage("lux"), new Image()));
            countries.Add(new Country("Маврикій", "Порт-Луї", "MUR (Маврикійська рупія)", "маврикійська", 1400000, "Африка", getImage("mavr"), new Image()));
            countries.Add(new Country("Мавританія", "Нуакшот", "MRU (Мавританська угія)", "арабська", 4400000, "Африка", getImage("mav"), new Image()));
            countries.Add(new Country("Мадагаскар", "Антананаріву", "MGA (Малагасійський аріарі)", "малагасійська, французька", 27000000, "Африка", getImage("mad"), new Image()));
            countries.Add(new Country("Македонія (Північна)", "Скоп'є", "MKD (Македонський денар)", "македонська", 2100000, "Європа", getImage("mac"), new Image()));
            countries.Add(new Country("Малаві", "Лілонгве", "MWK (Малавійська квача)", "чева, англійська", 19000000, "Африка", getImage("malavi"), new Image()));
            countries.Add(new Country("Малайзія", "Куала-Лумпур", "MYR (Малайзійський ринггіт)", "малаїзійська", 32000000, "Азія", getImage("mala"), new Image()));
            countries.Add(new Country("Малі", "Бамако", "XOF (Західноафриканський франк)", "французька", 20000000, "Африка", getImage("mali"), new Image()));
            countries.Add(new Country("Мальдіви", "Мале", "MVR (Мальдівська руфія)", "мальдівська", 440000, "Азія", getImage("mald"), new Image()));
            countries.Add(new Country("Мальта", "Валлетта", "EUR (Євро)", "мальтійська, англійська", 440000, "Європа", getImage("mal"), new Image()));
            countries.Add(new Country("Марокко", "Рабат", "MAD (Марокканський дирхам)", "арабська", 37000000, "Африка", getImage("mar"), new Image()));
            countries.Add(new Country("Маршаллові Острови", "Маджуро", "USD (Долар США)", "англійська, маршалльська", 59000, "Океанія", getImage("mai"), new Image()));
            countries.Add(new Country("Мексика", "Мехіко", "MXN (Мексиканське песо)", "іспанська", 129000000, "Північна Америка", getImage("mex"), new Image()));
            countries.Add(new Country("Мозамбік", "Мапуту", "MZN (Мозамбіцький метикал)", "португальська", 31000000, "Африка", getImage("moz"), new Image()));
            countries.Add(new Country("Молдова", "Кишинів", "MDL (Молдовський лей)", "молдовська, румунська", 2700000, "Європа", getImage("mol"), new Image()));
            countries.Add(new Country("Монако", "Монако", "EUR (Євро)", "французька", 39000, "Європа", getImage("mona"), new Image()));
            countries.Add(new Country("Монголія", "Улан-Батор", "MNT (Монгольський тугрик)", "монгольська", 3300000, "Азія", getImage("mon"), new Image()));
            countries.Add(new Country("М'янма", "Найп'їдо", "MMK (М'янманський кіат)", "бірманська", 54000000, "Азія", getImage("mya"), new Image()));
            countries.Add(new Country("Намібія", "Віндгук", "NAD (Намібійський долар)", "англійська", 2500000, "Африка", getImage("nam"), new Image()));
            countries.Add(new Country("Науру", "Ярен", "AUD (Австралійський долар)", "науру", 11000, "Океанія", getImage("nau"), new Image()));
            countries.Add(new Country("Непал", "Катманду", "NPR (Непальська рупія)", "непальська", 29000000, "Азія", getImage("nep"), new Image()));
            countries.Add(new Country("Нігер", "Ніамей", "XOF (Західноафриканський франк)", "французька", 24000000, "Африка", getImage("nig"), new Image()));
            countries.Add(new Country("Нігерія", "Абуджа", "NGN (Нігерійська найра)", "англійська", 206000000, "Африка", getImage("nige"), new Image()));
            countries.Add(new Country("Нідерланди", "Амстердам", "EUR (Євро)", "нідерландська", 17500000, "Європа", getImage("net"), new Image()));
            countries.Add(new Country("Нікарагуа", "Манагуа", "NIO (Нікарагуанська кордоба)", "іспанська", 6600000, "Північна Америка", getImage("nik"), new Image()));
            countries.Add(new Country("Німеччина", "Берлін", "EUR (Євро)", "німецька", 83000000, "Європа", getImage("ger"), new Image()));
            countries.Add(new Country("Нова Зеландія", "Веллінгтон", "NZD (Новозеландський долар)", "англійська, маорі", 5000000, "Океанія", getImage("nwz"), new Image()));
            countries.Add(new Country("Норвегія", "Осло", "NOK (Норвезька крона)", "норвезька", 5300000, "Європа", getImage("nor"), new Image()));
            countries.Add(new Country("Об'єднані Арабські Емірати", "Абу-Дабі", "AED (Дирхам ОАЕ)", "арабська", 9900000, "Азія", getImage("oae"), new Image()));
            countries.Add(new Country("Оман", "Маскат", "OMR (Оманський ріал)", "арабська", 5000000, "Азія", getImage("oma"), new Image()));
            countries.Add(new Country("Пакистан", "Ісламабад", "PKR (Пакистанська рупія)", "урду, англійська", 220000000, "Азія", getImage("pak"), new Image()));
            countries.Add(new Country("Палау", "Нгеруулмуд", "USD (Долар США)", "англійська, палауанська", 18000, "Океанія", getImage("pal"), new Image()));
            countries.Add(new Country("Панама", "Панама", "PAB (Панамська бальбоа)", "іспанська", 4200000, "Північна Америка", getImage("pan"), new Image()));
            countries.Add(new Country("Папуа-Нова Гвінея", "Порт-Морсбі", "PGK (Папуа-Новогвіне́йська кіна)", "англійська", 9000000, "Океанія", getImage("pap"), new Image()));
            countries.Add(new Country("Парагвай", "Асунсьйон", "PYG (Парагвайський гуарані)", "іспанська, гуарані", 7200000, "Південна Америка", getImage("para"), new Image()));
            countries.Add(new Country("Перу", "Ліма", "PEN (Перуанський сол)", "іспанська", 33000000, "Південна Америка", getImage("per"), new Image()));
            countries.Add(new Country("Південна Корея", "Сеул", "KRW (Південнокорейський вон)", "корейська", 51000000, "Азія", getImage("korea"), new Image()));
            countries.Add(new Country("Південний Судан", "Джуба", "SSP (Південносуданський фунт)", "англійська", 13000000, "Африка", getImage("pis"), new Image()));
            countries.Add(new Country("Південно-Африканська респ", "Преторія", "ZAR (Ранд)", "англійська", 60000000, "Африка", getImage("par"), new Image()));
            countries.Add(new Country("Північна Корея", "Пхеньян", "KPW (Північнокорейський вон)", "корейська", 25000000, "Азія", getImage("nrk"), new Image()));
            countries.Add(new Country("Польща", "Варшава", "PLN (Польський злотий)", "польська", 38000000, "Європа", getImage("pln"), new Image()));
            countries.Add(new Country("Португалія", "Лісабон", "EUR (Євро)", "португальська", 10200000, "Європа", getImage("por"), new Image()));
            countries.Add(new Country("Руанда", "Кігалі", "RWF (Руандський франк)", "руанда, французька, англійська", 13000000, "Африка", getImage("rwanda"), new Image()));
            countries.Add(new Country("Румунія", "Бухарест", "RON (Румунський лей)", "румунська", 19000000, "Європа", getImage("rum"), new Image()));
            countries.Add(new Country("Сальвадор", "Сан-Сальвадор", "SVC (Сальвадорський колон)", "іспанська", 6700000, "Північна Америка", getImage("sal"), new Image()));
            countries.Add(new Country("Самоа", "Апіа", "WST (Самоанська тала)", "самоанська, англійська", 200000, "Океанія", getImage("sam"), new Image()));
            countries.Add(new Country("Сан-Марино", "Сан-Марино", "EUR (Євро)", "італійська", 34000, "Європа", getImage("snm"), new Image()));
            countries.Add(new Country("Сан-Томе і Принсіпі", "Сан-Томе", "STN (Добра)", "португальська", 210000, "Африка", getImage("stp"), new Image()));
            countries.Add(new Country("Саудівська Аравія", "Рияд", "SAR (Саудівський ріял)", "арабська", 35000000, "Азія", getImage("sua"), new Image()));
            countries.Add(new Country("Свазіленд", "Мбабане", "SZL (Лілангені)", "свазі", 1400000, "Африка", getImage("esv"), new Image()));
            countries.Add(new Country("Сейшельські Острови", "Вікторія", "SCR (Сейшельський рупій)", "сейшельська, французька, англійська", 97000, "Африка", getImage("sei"), new Image()));
            countries.Add(new Country("Сенегал", "Дакар", "XOF (Західноафриканський франк)", "французька", 16700000, "Африка", getImage("sen"), new Image()));
            countries.Add(new Country("Сент-Вінсент і Гренадини", "Кінгстаун", "XCD (Східнокарибський долар)", "англійська", 110000, "Північна Америка", getImage("svg"), new Image()));
            countries.Add(new Country("Сент-Кіттс і Невіс", "Бастер", "XCD (Східнокарибський долар)", "англійська", 56000, "Північна Америка", getImage("skn"), new Image()));
            countries.Add(new Country("Сент-Люсія", "Кастрі", "XCD (Східнокарибський долар)", "англійська", 180000, "Північна Америка", getImage("sls"), new Image()));
            countries.Add(new Country("Сербія", "Белград", "RSD (Сербський динар)", "сербська", 6900000, "Європа", getImage("ser"), new Image()));
            countries.Add(new Country("Сирія", "Дамаск", "SYP (Сирійський фунт)", "арабська", 17000000, "Азія", getImage("sir"), new Image()));
            countries.Add(new Country("Сінгапур", "Сінгапур", "SGD (Сінгапурський долар)", "англійська, малайська", 5900000, "Азія", getImage("sin"), new Image()));
            countries.Add(new Country("Словаччина", "Братислава", "EUR (Євро)", "словацька", 5500000, "Європа", getImage("slov"), new Image()));
            countries.Add(new Country("Словенія", "Любляна", "EUR (Євро)", "словенська", 2100000, "Європа", getImage("slo"), new Image()));
            countries.Add(new Country("Соломонові Острови", "Хоніара", "SBD (Соломонівський долар)", "англійська", 700000, "Океанія", getImage("sol"), new Image()));
            countries.Add(new Country("Сомалі", "Могадішо", "SOS (сомалійський шилінг)", "сомалі", 16000000, "Африка", getImage("som"), new Image()));
            countries.Add(new Country("Судан", "Хартум", "SDG (суданський фунт)", "арабська", 44000000, "Африка", getImage("sud"), new Image()));
            countries.Add(new Country("Суринам", "Парамарибо", "SRD (суринамський долар)", "голландська", 600000, "Південна Америка", getImage("sur"), new Image()));
            countries.Add(new Country("Східний Тимор", "Ділі", "USD (долар США)", "тетум, португальська", 1300000, "Азія", getImage("tim"), new Image()));
            countries.Add(new Country("США", "Вашингтон", "USD (долар США)", "англійська", 331000000, "Північна Америка", getImage("sha"), new Image()));
            countries.Add(new Country("Сьєрра-Леоне", "Фрітаун", "SLL (леоне)", "англійська", 8000000, "Африка", getImage("sil"), new Image()));
            countries.Add(new Country("Таджикистан", "Душанбе", "TJS (таджицький сомоні)", "таджицька", 9200000, "Азія", getImage("taj"), new Image()));
            countries.Add(new Country("Таїланд", "Бангкок", "THB (таїландський бат)", "тайська", 69000000, "Азія", getImage("tail"), new Image()));
            countries.Add(new Country("Тайвань", "Тайпей", "TWD (новий тайванський долар)", "китайська", 24000000, "Азія", getImage("tai"), new Image()));
            countries.Add(new Country("Танзанія", "Додома", "TZS (танзанійський шилінг)", "суахілі, англійська", 61000000, "Африка", getImage("tan"), new Image()));
            countries.Add(new Country("Того", "Ломе", "XOF (західноафриканський франк)", "французька", 8200000, "Африка", getImage("tog"), new Image()));
            countries.Add(new Country("Тонга", "Нукуалофа", "TOP (тонганська паанга)", "тонганська, англійська", 100000, "Океанія", getImage("ton"), new Image()));
            countries.Add(new Country("Тринідад і Тобаго", "Порт-оф-Спейн", "TTD (тринідадський долар)", "англійська", 1399000, "Північна Америка", getImage("tat"), new Image()));
            countries.Add(new Country("Туніс", "Туніс", "TND (туніський динар)", "арабська", 11722000, "Африка", getImage("tun"), new Image()));
            countries.Add(new Country("Туреччина", "Анкара", "TRY (турецька ліра)", "турецька", 84339000, "Європа", getImage("turkey"), new Image()));
            countries.Add(new Country("Туркменістан", "Ашгабат", "TMT (туркменський манат)", "туркменська", 5942000, "Азія", getImage("tur"), new Image()));
            countries.Add(new Country("Уганда", "Кампала", "UGX (угандійський шилінг)", "англійська, свахілі", 44200000, "Африка", getImage("uga"), new Image()));
            countries.Add(new Country("Угорщина", "Будапешт", "HUF (угорський форинт)", "угорська", 9773000, "Європа", getImage("hun"), new Image()));
            countries.Add(new Country("Узбекистан", "Ташкент", "UZS (узбекський сум)", "узбецька", 34740000, "Азія", getImage("uzb"), new Image()));
            countries.Add(new Country("Україна", "Київ", "UAH (українська гривня)", "українська", 41592000, "Європа", getImage("ukr"), getImage("kyiv")));
            countries.Add(new Country("Уругвай", "Монтевідео", "UYU (уругвайський песо)", "іспанська", 3477000, "Південна Америка", getImage("uru"), new Image()));
            countries.Add(new Country("Фіджі", "Сува", "FJD (фіджійський долар)", "фіджійська, англійська", 896000, "Океанія", getImage("fij"), new Image()));
            countries.Add(new Country("Філіппіни", "Маніла", "PHP (філіппінське песо)", "філіппінська", 111206000, "Азія", getImage("phi"), new Image()));
            countries.Add(new Country("Фінляндія", "Гельсінкі", "EUR (євро)", "фінська, шведська", 5540720, "Європа", getImage("fin"), new Image()));
            countries.Add(new Country("Франція", "Париж", "EUR (євро)", "французька", 67076000, "Європа", getImage("fra"), new Image()));
            countries.Add(new Country("Хорватія", "Загреб", "HRK (хорватська куна)", "хорватська", 4087843, "Європа", getImage("cro"), new Image()));
            countries.Add(new Country("ЦАР", "Бангі", "XAF (Центральноафриканський франк)", "французька, санго", 4827000, "Африка", getImage("car"), new Image()));
            countries.Add(new Country("Чад", "Нджамена", "XAF (Центральноафриканський франк)", "французька, арабська", 16877000, "Африка", getImage("chd"), new Image()));
            countries.Add(new Country("Чехія", "Прага", "CZK (чеська крона)", "чеська", 10610000, "Європа", getImage("czh"), getImage("chz")));
            countries.Add(new Country("Чилі", "Сантьяго", "CLP (чилійське песо)", "іспанська", 19107216, "Південна Америка", getImage("chl"), getImage("chili")));
            countries.Add(new Country("Швейцарія", "Берн", "CHF (швейцарський франк)", "німецька, французька, італійська", 8591360, "Європа", getImage("swc"), getImage("bern")));
            countries.Add(new Country("Швеція", "Стокгольм", "SEK (шведська крона)", "шведська", 10391000, "Європа", getImage("swd"), getImage("stock")));
            countries.Add(new Country("Шрі-Ланка", "Коломбо", "LKR (шрі-ланкійська рупія)", "сингальська, тамільська", 21803000, "Азія", getImage("sri"), getImage("srilanka")));
            countries.Add(new Country("Ямайка", "Кінгстон", "JMD (ямайський долар)", "англійська", 2948279, "Північна Америка", getImage("jam"), getImage("jama")));
            countries.Add(new Country("Японія", "Токіо", "JPY (японська єна)", "японська", 126476461, "Азія", getImage("jpn"), getImage("tokyo")));

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
                countryInfoTextBlock.Text = $"Країна: {country.Name}. Столиця: {country.Capital}. Валюта: {country.Currency}. Мова: {country.Language}. Населення: {country.Population:N0}. Регіон: {country.Region}.";
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


        private void SortByAlphabet(object sender, RoutedEventArgs e)
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

        private void SortByLanguage(object sender, RoutedEventArgs e)
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

        private void ClearResults(object sender, RoutedEventArgs e)
        {
            resultStackPanel.Children.Clear();
        }

        private void SortByRegion(object sender, RoutedEventArgs e)
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