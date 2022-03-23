
using System;
using System.Windows.Forms;

namespace Eu4HackGUI
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DevTools = new System.Windows.Forms.TabPage();
            this.CreateIdeaList = new System.Windows.Forms.Button();
            this.SelectedCountry = new System.Windows.Forms.Label();
            this.CreateCountryList = new System.Windows.Forms.Button();
            this.CreateCountrySelectionSwitch = new System.Windows.Forms.Button();
            this.IdeaSelection = new System.Windows.Forms.TabPage();
            this.SearchCountry = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.IdeaListBox = new System.Windows.Forms.CheckedListBox();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Hack = new System.Windows.Forms.TabPage();
            this.SelectedTypesLabel = new System.Windows.Forms.Label();
            this.TypeCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.Run = new System.Windows.Forms.Button();
            this.ProvinceSelection = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.DevTools.SuspendLayout();
            this.IdeaSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Hack.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.DevTools);
            this.tabControl1.Controls.Add(this.IdeaSelection);
            this.tabControl1.Controls.Add(this.Hack);
            this.tabControl1.Controls.Add(this.ProvinceSelection);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.MinimumSize = new System.Drawing.Size(70, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 428);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // DevTools
            // 
            this.DevTools.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DevTools.Controls.Add(this.CreateIdeaList);
            this.DevTools.Controls.Add(this.SelectedCountry);
            this.DevTools.Controls.Add(this.CreateCountryList);
            this.DevTools.Controls.Add(this.CreateCountrySelectionSwitch);
            this.DevTools.Location = new System.Drawing.Point(4, 31);
            this.DevTools.Name = "DevTools";
            this.DevTools.Padding = new System.Windows.Forms.Padding(3);
            this.DevTools.Size = new System.Drawing.Size(792, 393);
            this.DevTools.TabIndex = 0;
            this.DevTools.Text = "DevTools";
            // 
            // CreateIdeaList
            // 
            this.CreateIdeaList.Location = new System.Drawing.Point(7, 75);
            this.CreateIdeaList.Name = "CreateIdeaList";
            this.CreateIdeaList.Size = new System.Drawing.Size(250, 28);
            this.CreateIdeaList.TabIndex = 3;
            this.CreateIdeaList.Text = "CreateIdeaList";
            this.CreateIdeaList.UseVisualStyleBackColor = true;
            this.CreateIdeaList.Click += new System.EventHandler(this.CreateIdeaList_Click);
            // 
            // SelectedCountry
            // 
            this.SelectedCountry.AutoSize = true;
            this.SelectedCountry.Location = new System.Drawing.Point(641, 6);
            this.SelectedCountry.Name = "SelectedCountry";
            this.SelectedCountry.Size = new System.Drawing.Size(121, 20);
            this.SelectedCountry.TabIndex = 2;
            this.SelectedCountry.Text = "Selected Country";
            // 
            // CreateCountryList
            // 
            this.CreateCountryList.Location = new System.Drawing.Point(7, 41);
            this.CreateCountryList.Name = "CreateCountryList";
            this.CreateCountryList.Size = new System.Drawing.Size(250, 28);
            this.CreateCountryList.TabIndex = 1;
            this.CreateCountryList.Text = "Create country list";
            this.CreateCountryList.UseVisualStyleBackColor = true;
            this.CreateCountryList.Click += new System.EventHandler(this.CreateCountryList_Click);
            // 
            // CreateCountrySelectionSwitch
            // 
            this.CreateCountrySelectionSwitch.Location = new System.Drawing.Point(7, 6);
            this.CreateCountrySelectionSwitch.Name = "CreateCountrySelectionSwitch";
            this.CreateCountrySelectionSwitch.Size = new System.Drawing.Size(250, 28);
            this.CreateCountrySelectionSwitch.TabIndex = 0;
            this.CreateCountrySelectionSwitch.Text = "Create Country Selection Switch";
            this.CreateCountrySelectionSwitch.UseVisualStyleBackColor = true;
            this.CreateCountrySelectionSwitch.Click += new System.EventHandler(this.CreateCountrySelectionSwitch_Click);
            // 
            // IdeaSelection
            // 
            this.IdeaSelection.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IdeaSelection.Controls.Add(this.SearchCountry);
            this.IdeaSelection.Controls.Add(this.splitContainer1);
            this.IdeaSelection.Location = new System.Drawing.Point(4, 31);
            this.IdeaSelection.Name = "IdeaSelection";
            this.IdeaSelection.Padding = new System.Windows.Forms.Padding(3);
            this.IdeaSelection.Size = new System.Drawing.Size(792, 393);
            this.IdeaSelection.TabIndex = 1;
            this.IdeaSelection.Text = "IdeaSelection";
            // 
            // SearchCountry
            // 
            this.SearchCountry.AutoCompleteCustomSource.AddRange(new string[] {
            "Sweden",
            "Denmark",
            "Finland",
            "Gotland",
            "Norway",
            "Holstein",
            "Scandinavia",
            "Estonia",
            "Livonia",
            "Sapmi",
            "Karelia",
            "Iceland",
            "Achaea",
            "Albania",
            "Athens",
            "Bosnia",
            "Bulgaria",
            "Byzantium",
            "Corfu",
            "Croatia",
            "Crete",
            "Cyprus",
            "Dalmatia",
            "Epirus",
            "Greece",
            "The Knights",
            "Morea",
            "Moldavia",
            "Montenegro",
            "Naxos",
            "Ragusa",
            "Romania",
            "Serbia",
            "Transylvania",
            "Wallachia",
            "Hungary",
            "Nitra",
            "Ottomans",
            "Clanricarde",
            "Cornwall",
            "England",
            "Leinster",
            "Ireland",
            "Thomond",
            "Scotland",
            "Tyrone",
            "Wales",
            "Northumberland",
            "Great Britain",
            "Meath",
            "Ulster",
            "Desmond",
            "Sligo",
            "Kildare",
            "Gaeldom",
            "Ormond",
            "Tyrconnell",
            "Offaly",
            "Munster",
            "Mann",
            "The Isles",
            "Brazil",
            "Canada",
            "Chile",
            "Colombia",
            "Haiti",
            "La Plata",
            "Louisiana",
            "Mexico",
            "Peru",
            "Paraguay",
            "Quebec",
            "United Central America",
            "United States",
            "Venezuela",
            "Australia",
            "California",
            "Texas",
            "Cascadia",
            "Alaska",
            "Zealandia",
            "Illinois",
            "Florida",
            "Vermont",
            "Sonora",
            "West Indies",
            "Cuba",
            "Danzig",
            "Krakow",
            "Lithuania",
            "Livonian Order",
            "Mazovia",
            "Poland",
            "Prussia",
            "Kurland",
            "Riga",
            "Teutonic Order",
            "Commonwealth",
            "Galicia–Volhynia",
            "Kiev",
            "Chernigov",
            "Odoyev",
            "Alençon",
            "Strasbourg",
            "Armagnac",
            "Auvergne",
            "Avignon",
            "Bourbonnais",
            "Brittany",
            "Burgundy",
            "Champagne",
            "Corsica",
            "Dauphine",
            "Foix",
            "France",
            "Gascony",
            "Nevers",
            "Normandy",
            "Orleans",
            "Picardy",
            "Provence",
            "Sardinia-Piedmont",
            "Toulouse",
            "Berry",
            "Aachen",
            "Anhalt",
            "Ansbach",
            "Augsburg",
            "Baden",
            "Bavaria",
            "Bohemia",
            "Brandenburg",
            "Bremen",
            "Brunswick",
            "East Frisia",
            "Frankfurt",
            "Germany",
            "Austria",
            "Hamburg",
            "Hanover",
            "Hesse",
            "Holy Roman Empire",
            "Cleves",
            "Cologne",
            "Saxe-Lauenburg",
            "Lorraine",
            "Lüneburg",
            "Magdeburg",
            "Mainz",
            "Meissen",
            "Mecklenburg",
            "Münster",
            "Moravia",
            "Oldenburg",
            "The Palatinate",
            "Pomerania",
            "Saxony",
            "Silesia",
            "Salzburg",
            "Styria",
            "Switzerland",
            "Thuringia",
            "Tirol",
            "Trier",
            "Ulm",
            "Wurzburg",
            "Westphalia",
            "Wurttemberg",
            "Nuremberg",
            "Memmingen",
            "Verden",
            "Nassau",
            "Dortmund",
            "Dithmarschen",
            "Aragon",
            "Castile",
            "Catalonia",
            "Granada",
            "Navarra",
            "Portugal",
            "Spain",
            "Galicia",
            "León",
            "Andalusia",
            "Valencia",
            "Asturias",
            "Majorca",
            "Aquileia",
            "Etruria",
            "Ferrara",
            "Genoa",
            "Italy",
            "Mantua",
            "Milan",
            "Modena",
            "Naples",
            "The Papal State",
            "Parma",
            "Pisa",
            "Sardinia",
            "Savoy",
            "Sicily",
            "Siena",
            "Tuscany",
            "Urbino",
            "Venice",
            "Montferrat",
            "Lucca",
            "Florence",
            "Malta",
            "Brabant",
            "Flanders",
            "Friesland",
            "Gelre",
            "Hainaut",
            "Holland",
            "Liege",
            "Luxembourg",
            "Netherlands",
            "Utrecht",
            "Armenia",
            "Astrakhan",
            "Crimea",
            "Georgia",
            "Kazan",
            "Muscovy",
            "Novgorod",
            "Pskov",
            "Qasim",
            "Russia",
            "Ryazan",
            "Tver",
            "Ruthenia",
            "Yaroslavl",
            "Zaporozhie",
            "Nogai",
            "Sibir",
            "Polotsk",
            "Perm",
            "Theodoro",
            "Bashkiria",
            "Beloozero",
            "Rostov",
            "Great Horde",
            "Golden Horde",
            "Aden",
            "Haasa",
            "Anizah",
            "Arabia",
            "Ardalan",
            "Soran",
            "Dawasir",
            "Eretna",
            "Fadl",
            "Germiyan",
            "Hadramut",
            "Hejaz",
            "Lebanon",
            "Makuria",
            "Medina",
            "Mikhlaf",
            "Mahra",
            "Najd",
            "Najran",
            "Oman",
            "Rassids",
            "Shammar",
            "Sharjah",
            "Shirvan",
            "Yas",
            "Yemen",
            "Hisn Kayfa",
            "Bitlis",
            "Aq Qoyunlu",
            "Aydin",
            "Candar",
            "Dulkadir",
            "Iraq",
            "Karaman",
            "Syria",
            "Trebizond",
            "Saruhan",
            "Mentese",
            "Ramazan",
            "Avaria",
            "Kharabakh",
            "Samtskhe",
            "Ardabil",
            "Mushasha",
            "Rûm",
            "Algiers",
            "Fez",
            "Mamluks",
            "Morocco",
            "Tripoli",
            "Tunis",
            "Egypt",
            "Kabylia",
            "Tafilalt",
            "Sus",
            "Tlemcen",
            "Touggourt",
            "Djerid",
            "Fezzan",
            "Mzab",
            "Salé",
            "Tétouan",
            "Marrakesh",
            "Kazakh",
            "Khiva",
            "Uzbek",
            "Ferghana",
            "Bukhara",
            "Afghanistan",
            "Khorasan",
            "Persia",
            "Qara Qoyunlu",
            "Timurids",
            "Transoxiana",
            "Gilan",
            "Circassia",
            "Gazikumukh",
            "Imereti",
            "Mazandaran",
            "Hormuz",
            "Luristan",
            "Sistan",
            "Biapas",
            "Fars",
            "Kerman",
            "Yazd",
            "Isfahan",
            "Tabriz",
            "Basra",
            "Maregheh",
            "Ajam",
            "Aztec",
            "Cherokee",
            "Chimu",
            "Creek",
            "Huron",
            "Inca",
            "Iroquois",
            "Maya",
            "Shawnee",
            "Zapotec",
            "Ashanti",
            "Benin",
            "Ethiopia",
            "Kongo",
            "Mali",
            "Funj",
            "Songhai",
            "Kilwa",
            "Mutapa",
            "Adal",
            "Hausa",
            "Kanem Bornu",
            "Loango",
            "Oyo",
            "Segu",
            "Sokoto",
            "Jolof",
            "Sofala",
            "Mombasa",
            "Malindi",
            "Ajuuraan",
            "Mogadishu",
            "Ennarea",
            "Aussa",
            "Alodia",
            "Darfur",
            "Geledi",
            "Harar",
            "Hobyo",
            "Kaffa",
            "Medri Bahri",
            "Majeerteen",
            "Marehan",
            "Pate",
            "Warsangali",
            "Semien",
            "Beja",
            "Jimma",
            "Welayta",
            "Damot",
            "Hadiya",
            "Shewa",
            "Janjiro",
            "Dongola",
            "Tyo",
            "Soyo",
            "Kasanje",
            "Luba",
            "Lunda",
            "Chokwe",
            "Kikondja",
            "Kazembe",
            "Yaka",
            "Kalundwe",
            "Kuba",
            "Rwanda",
            "Burundi",
            "Buganda",
            "Nkore",
            "Karagwe",
            "Bunyoro",
            "Busoga",
            "Buha",
            "Maravi",
            "Lundu",
            "Tumbuka",
            "Makua",
            "Butua",
            "Imerina",
            "Sakalava",
            "Betsimisaraka",
            "Mahafaly",
            "Antemoro",
            "Annam",
            "Arakan",
            "Aceh",
            "Ayutthaya",
            "Bali",
            "Banten",
            "Brunei",
            "Champa",
            "Chagatai",
            "Champasak",
            "Dai Viet",
            "Japan",
            "Amago",
            "Asakura",
            "Chosokabe",
            "Date",
            "Hojo",
            "Hosokawa",
            "Hatakeyama",
            "Ikeda",
            "Imagawa",
            "Maeda",
            "Mori",
            "Oda",
            "Otomo",
            "Ouchi",
            "Shiba",
            "Shimazu",
            "Takeda",
            "Tokugawa",
            "Uesugi",
            "Yamana",
            "Nanbu",
            "Ashikaga",
            "Kitabatake",
            "Ainu",
            "Akamatsu",
            "Ando",
            "Chiba",
            "Isshiki",
            "Ito",
            "Kikuchi",
            "Kono",
            "Ogasawara",
            "Shoni",
            "Satake",
            "Toki",
            "Utsunomiya",
            "Tsutsui",
            "Mongolia",
            "Khmer",
            "Korea",
            "Lan Na",
            "Luang Prabang",
            "Lan Xang",
            "Majapahit",
            "Manchu",
            "Makassar",
            "Malacca",
            "Ming",
            "Mataram",
            "Oirat",
            "Pattani",
            "Pegu",
            "Qing",
            "Ryukyu",
            "Shan",
            "Sukhothai",
            "Sulu",
            "Taungu",
            "Tibet",
            "Tonkin",
            "Vientiane",
            "Zhou",
            "Shun",
            "Xi",
            "Yuan",
            "Tungning",
            "Ilkhanate",
            "Kalmyk",
            "Mongol Empire",
            "So",
            "Nivkh",
            "Solon",
            "Donghai",
            "Udege",
            "Yeren",
            "Haixi",
            "Jianzhou",
            "Korchin",
            "Khalkha",
            "Kara Del",
            "Dzungar",
            "Yarkand",
            "Chahar",
            "Khoshuud",
            "Sarig Yogir",
            "Tsang",
            "Kham",
            "Guge",
            "U",
            "Dali",
            "Yi",
            "Miao",
            "Min",
            "Yue",
            "Shu",
            "Ning",
            "Chu",
            "Tang",
            "Wu",
            "Qi",
            "Yan",
            "Jin",
            "Liang",
            "Qin",
            "Huai",
            "Changsheng",
            "Baluchistan",
            "Bengal",
            "Bijapur",
            "Bahmanis",
            "Delhi",
            "Golkonda",
            "Deccan",
            "Marathas",
            "Mughals",
            "Mysore",
            "Vijayanagar",
            "Ahmednagar",
            "Assam",
            "Gujarat",
            "Jaunpur",
            "Madurai",
            "Malwa",
            "Marwar",
            "Mewar",
            "Multan",
            "Nagpur",
            "Nepal",
            "Orissa",
            "Punjab",
            "Sindh",
            "Berar",
            "Jangladesh",
            "Carnatic",
            "Garha",
            "Garjat",
            "Gwalior",
            "Dhundhar",
            "Kashmir",
            "Keladi",
            "Khandesh",
            "Oudh",
            "Venad",
            "Calicut",
            "Mewat",
            "Baroda",
            "Bastar",
            "Bhutan",
            "Bundelkhand",
            "Kotte",
            "Jaisalmer",
            "Kachar",
            "Koch",
            "Kangra",
            "Kutch",
            "Kochin",
            "Manipur",
            "Hadoti",
            "Nagaur",
            "Rohilkhand",
            "Ladakh",
            "Baghelkhand",
            "Jaffna",
            "Patiala",
            "Garhwal",
            "Chanda",
            "Jharkhand",
            "Habsan",
            "Tirhut",
            "Rewa Kantha",
            "Baglana",
            "Tripura",
            "Sadiya",
            "Bharat",
            "Andhra",
            "Maldives",
            "Bishnupur",
            "Sikkim",
            "Idar",
            "Jhalavad",
            "Palitana",
            "Navanagar",
            "Rajkot",
            "Junagarh",
            "Porbandar",
            "Kalinjar",
            "Kalpi",
            "Sambalpur",
            "Patna",
            "Ratanpur",
            "Kalahandi",
            "Keonhjar",
            "Parlakhimidi",
            "Jeypore",
            "Surguja",
            "Kandy",
            "Telingana",
            "Kolathunad",
            "Dang",
            "Doti",
            "Gorkha",
            "Jumla",
            "Limbuwan",
            "Makwanpur",
            "Sirmur",
            "Kathmandu",
            "Kumaon",
            "Gingee",
            "Tanjore",
            "Sirhind",
            "Rajputana",
            "Bar",
            "Lübeck",
            "Smolensk",
            "Nizhny Novgorod",
            "Jerusalem",
            "Malaya",
            "Hindustan",
            "Abenaki",
            "Apache",
            "Assiniboine",
            "Blackfoot",
            "Caddo",
            "Chickasaw",
            "Choctaw",
            "Cheyenne",
            "Comanche",
            "Fox",
            "Illiniwek",
            "Lenape",
            "Mahican",
            "Mikmaq",
            "Miami",
            "Navajo",
            "Ojibwe",
            "Osage",
            "Ottawa",
            "Pawnee",
            "Pequot",
            "Pima",
            "Potawatomi",
            "Powhatan",
            "Pueblo",
            "Shoshone",
            "Sioux",
            "Susquehannock",
            "Cree",
            "Air",
            "Bonoman",
            "Dahomey",
            "Dagbon",
            "Fulo",
            "Jenné",
            "Kano",
            "Kaabu",
            "Kong",
            "Katsina",
            "Mossi",
            "Nupe",
            "Timbuktu",
            "Yao",
            "Yatenga",
            "Macina",
            "Zazzau",
            "Ndongo",
            "Ava",
            "Hsenwi",
            "Johor",
            "Kedah",
            "Ligor",
            "Muan Phuang",
            "Mong Yang",
            "Perak",
            "Mong Mao",
            "Mong Kawng",
            "Mong Pai",
            "Mong Nai",
            "Kale",
            "Hsipaw",
            "Prome",
            "Chukchi",
            "Khodynt",
            "Chavchuveny",
            "Kamchadals",
            "Buryatia",
            "Arapaho",
            "Colima",
            "Chinook",
            "Cocomes",
            "Haida",
            "Itza",
            "Kiche",
            "Kiowa",
            "Mixtec",
            "Salish",
            "Tarascan",
            "Tlapanec",
            "Tlaxcala",
            "Totonac",
            "Wichita",
            "Xiu",
            "Blambangan",
            "Buton",
            "Cirebon",
            "Demak",
            "Pagarruyung",
            "Palembang",
            "Pasai",
            "Siak",
            "Sunda",
            "Kutai",
            "Banjar",
            "Lanfang",
            "Lanao",
            "Luwu",
            "Maguindanao",
            "Ternate",
            "Tidore",
            "Madyas",
            "Pangasinan",
            "Tondo",
            "Maynila",
            "Cebu",
            "Butuan",
            "Cusco",
            "Calchaqui",
            "Mapuche",
            "Muisca",
            "Quito",
            "Cajamarca",
            "Huyla",
            "Potiguara",
            "Tupiniquim",
            "Tupinamba",
            "Tapuia",
            "Guarani",
            "Charrua",
            "Wanka",
            "Chachapoya",
            "Colla",
            "Charca",
            "Pacajes",
            "Arawak",
            "Carib",
            "Ichma",
            "Matlatzinca",
            "Coixtlahuaca",
            "Teotitlan",
            "Xalisco",
            "Guamar",
            "Huastec",
            "Chichimeca",
            "Otomi",
            "Yokotan",
            "Tzotzil",
            "Kaqchikel",
            "Chactemal",
            "Keres",
            "Zuni",
            "Mescalero",
            "Lipan",
            "Chorti",
            "Miskito",
            "Tairona",
            "Can Pech",
            "Tonala",
            "Yaqui",
            "Yokuts",
            "New Providence",
            "Port Royal",
            "Tortuga",
            "Libertatia",
            "Munich",
            "Landshut",
            "Ingolstadt",
            "Passau",
            "Bregenz",
            "Konstanz",
            "Rothenburg",
            "Bayreuth",
            "Regensburg",
            "Geneva",
            "Three Leagues",
            "Opole",
            "Glogow",
            "Bologna",
            "Padua",
            "Saluzzo",
            "Spoleto",
            "Wolgast",
            "Stettin",
            "Goslar",
            "Lusatia",
            "Rügen",
            "Cilli",
            "Herzegovina",
            "Trent",
            "Berg",
            "Mulhouse",
            "Bamberg",
            "Ruppin",
            "Lippe",
            "Paderborn",
            "Calenberg",
            "Donauwörth",
            "Osnabrück",
            "Verona",
            "Coburg",
            "Lotharingia",
            "Perugia",
            "Two Sicilies",
            "Franconia",
            "Swabia",
            "Jan Mayen",
            "Roman Empire",
            "Synthetics",
            "Jomsvikings",
            "Hashashin",
            "Israel",
            "Knights Templar",
            "Trapalanda"});
            this.SearchCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchCountry.BackColor = System.Drawing.Color.DarkGray;
            this.SearchCountry.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchCountry.Location = new System.Drawing.Point(3, 3);
            this.SearchCountry.Name = "SearchCountry";
            this.SearchCountry.Size = new System.Drawing.Size(786, 27);
            this.SearchCountry.TabIndex = 1;
            this.SearchCountry.TextChanged += new System.EventHandler(this.SearchCountry_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.IdeaListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowPanel);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.splitContainer1.Size = new System.Drawing.Size(786, 387);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 4;
            // 
            // IdeaListBox
            // 
            this.IdeaListBox.BackColor = System.Drawing.Color.Gray;
            this.IdeaListBox.CheckOnClick = true;
            this.IdeaListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.IdeaListBox.FormattingEnabled = true;
            this.IdeaListBox.Items.AddRange(new object[] {
            "adm_tech_cost_modifier",
            "administrative_efficiency",
            "advisor_cost",
            "advisor_pool",
            "ae_impact",
            "allowed_marine_fraction",
            "amount_of_banners",
            "army_tradition",
            "army_tradition_decay",
            "army_tradition_from_battle",
            "artillery_cost",
            "artillery_fire",
            "artillery_power",
            "auto_explore_adjacent_to_colony",
            "autonomy_change_time",
            "backrow_artillery_damage",
            "blockade_efficiency",
            "build_cost",
            "build_time",
            "burghers_influence_modifier",
            "burghers_loyalty_modifier",
            "capture_ship_chance",
            "caravan_power",
            "cav_to_inf_ratio",
            "cavalry_cost",
            "cavalry_fire",
            "cavalry_flanking",
            "cavalry_power",
            "church_loyalty_modifier",
            "church_power_modifier",
            "colonists",
            "core_creation",
            "culture_conversion_cost",
            "defensiveness",
            "development_cost",
            "devotion",
            "dip_tech_cost_modifier",
            "diplomatic_annexation_cost",
            "diplomatic_reputation",
            "diplomatic_upkeep",
            "diplomats",
            "discipline",
            "disengagement_chance",
            "drill_gain_modifier",
            "embargo_efficiency",
            "embracement_cost",
            "enforce_religion_cost",
            "envoy_travel_time",
            "expand_administration_cost",
            "fabricate_claims_cost",
            "female_advisor_chance",
            "fire_damage",
            "fire_damage_received",
            "flagship_cost",
            "fort_maintenance_modifier",
            "free_adm_policy",
            "free_dip_policy",
            "free_leader_pool",
            "free_mil_policy",
            "galley_cost",
            "galley_power",
            "garrison_size",
            "general_cost",
            "global_autonomy",
            "global_colonial_growth",
            "global_foreign_trade_power",
            "global_garrison_growth",
            "global_heretic_missionary_strength",
            "global_institution_spread",
            "global_manpower_modifier",
            "global_missionary_strength",
            "global_naval_engagement_modifier",
            "global_own_trade_power",
            "global_prov_trade_power_modifier",
            "global_regiment_cost",
            "global_regiment_recruit_speed",
            "global_sailors_modifier",
            "global_ship_cost",
            "global_ship_recruit_speed",
            "global_ship_trade_power",
            "global_spy_defence",
            "global_tariffs",
            "global_tax_modifier",
            "global_trade_goods_size_modifier",
            "global_trade_power",
            "global_unrest",
            "governing_capacity_modifier",
            "harsh_treatment_cost",
            "has_country_flag",
            "heavy_ship_cost",
            "heavy_ship_power",
            "heir_chance",
            "horde_unity",
            "hostile_attrition",
            "idea_claim_colonies",
            "idea_cost",
            "imperial_authority",
            "imperial_authority_value",
            "imperial_mandate",
            "improve_relation_modifier",
            "infantry_cost",
            "infantry_power",
            "inflation_reduction",
            "interest",
            "justify_trade_conflict_cost",
            "land_attrition",
            "land_forcelimit_modifier",
            "land_maintenance_modifier",
            "land_morale",
            "leader_land_fire",
            "leader_land_manuever",
            "leader_land_shock",
            "leader_naval_fire",
            "leader_naval_manuever",
            "leader_naval_shock",
            "leader_siege",
            "legitimacy",
            "liberty_desire",
            "liberty_desire_from_subject_development",
            "light_ship_cost",
            "light_ship_power",
            "loot_amount",
            "manpower_recovery_speed",
            "max_revolutionary_zeal",
            "may_establish_frontier",
            "may_explore",
            "may_perform_slave_raid",
            "may_perform_slave_raid_on_same_religion",
            "may_recruit_female_generals",
            "merc_maintenance_modifier",
            "mercenary_cost",
            "mercenary_discipline",
            "mercenary_manpower",
            "merchants",
            "meritocracy",
            "migration_cost",
            "mil_tech_cost_modifier",
            "min_autonomy_in_territories",
            "missionaries",
            "missionary_maintenance_cost",
            "monarch_diplomatic_power",
            "monarch_military_power",
            "monthly_fervor_increase",
            "monthly_piety",
            "movement_speed",
            "native_assimilation",
            "native_uprising_chance",
            "naval_attrition",
            "naval_forcelimit_modifier",
            "naval_maintenance_modifier",
            "naval_morale",
            "naval_tradition_from_battle",
            "navy_tradition",
            "navy_tradition_decay",
            "no_religion_penalty",
            "nobles_loyalty_modifier",
            "num_accepted_cultures",
            "own_coast_naval_combat_bonus",
            "papal_influence",
            "placed_merchant_power",
            "possible_dip_policy",
            "possible_policy",
            "power_projection_from_insults",
            "prestige",
            "prestige_decay",
            "prestige_from_land",
            "primary_culture",
            "privateer_efficiency",
            "production_efficiency",
            "province_warscore_cost",
            "range",
            "rebel_support_efficiency",
            "recover_army_morale_speed",
            "recover_navy_morale_speed",
            "reduced_liberty_desire",
            "reelection_cost",
            "reform_progress_growth",
            "reinforce_cost_modifier",
            "reinforce_speed",
            "religion_group",
            "religious_unity",
            "republican_tradition",
            "rival_border_fort_maintenance",
            "sailor_maintenance_modifer",
            "sailors_recovery_speed",
            "same_culture_advisor_cost",
            "ship_durability",
            "ship_power_propagation",
            "shock_damage",
            "shock_damage_received",
            "siege_ability",
            "siege_blockade_progress",
            "spy_offence",
            "stability_cost_modifier",
            "state_maintenance_modifier",
            "sunk_ship_morale_hit_recieved",
            "technology_cost",
            "tolerance_heathen",
            "tolerance_heretic",
            "tolerance_own",
            "trade_company_investment_cost",
            "trade_efficiency",
            "trade_range_modifier",
            "trade_steering",
            "transport_cost",
            "unjustified_demands",
            "vassal_forcelimit_bonus",
            "vassal_income",
            "war_exhaustion",
            "war_exhaustion_cost",
            "yearly_absolutism",
            "yearly_corruption",
            "yearly_tribal_allegiance",
            "years_of_nationalism"});
            this.IdeaListBox.Location = new System.Drawing.Point(0, 0);
            this.IdeaListBox.Name = "IdeaListBox";
            this.IdeaListBox.Size = new System.Drawing.Size(300, 387);
            this.IdeaListBox.Sorted = true;
            this.IdeaListBox.TabIndex = 2;
            this.IdeaListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.IdeaListBox_ItemCheck);
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.AutoSize = true;
            this.flowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Padding = new System.Windows.Forms.Padding(40);
            this.flowPanel.Size = new System.Drawing.Size(520, 387);
            this.flowPanel.TabIndex = 3;
            this.flowPanel.WrapContents = false;
            // 
            // Hack
            // 
            this.Hack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Hack.Controls.Add(this.SelectedTypesLabel);
            this.Hack.Controls.Add(this.TypeCheckListBox);
            this.Hack.Controls.Add(this.Run);
            this.Hack.Location = new System.Drawing.Point(4, 31);
            this.Hack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Hack.Name = "Hack";
            this.Hack.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Hack.Size = new System.Drawing.Size(792, 393);
            this.Hack.TabIndex = 2;
            this.Hack.Text = "Hack";
            // 
            // SelectedTypesLabel
            // 
            this.SelectedTypesLabel.AutoSize = true;
            this.SelectedTypesLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectedTypesLabel.Location = new System.Drawing.Point(234, 369);
            this.SelectedTypesLabel.Name = "SelectedTypesLabel";
            this.SelectedTypesLabel.Size = new System.Drawing.Size(106, 20);
            this.SelectedTypesLabel.TabIndex = 2;
            this.SelectedTypesLabel.Text = "None Selected";
            // 
            // TypeCheckListBox
            // 
            this.TypeCheckListBox.BackColor = System.Drawing.Color.Gray;
            this.TypeCheckListBox.CheckOnClick = true;
            this.TypeCheckListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TypeCheckListBox.FormattingEnabled = true;
            this.TypeCheckListBox.Items.AddRange(new object[] {
            "Country_Ideas",
            "Provinces",
            "Countries"});
            this.TypeCheckListBox.Location = new System.Drawing.Point(3, 4);
            this.TypeCheckListBox.Name = "TypeCheckListBox";
            this.TypeCheckListBox.Size = new System.Drawing.Size(231, 385);
            this.TypeCheckListBox.TabIndex = 1;
            this.TypeCheckListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.TypeCheckListBox_ItemCheck);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(243, 8);
            this.Run.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(217, 29);
            this.Run.TabIndex = 0;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // ProvinceSelection
            // 
            this.ProvinceSelection.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProvinceSelection.Location = new System.Drawing.Point(4, 31);
            this.ProvinceSelection.Name = "ProvinceSelection";
            this.ProvinceSelection.Size = new System.Drawing.Size(792, 393);
            this.ProvinceSelection.TabIndex = 3;
            this.ProvinceSelection.Text = "ProvinceSelection";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(600, 467);
            this.Name = "GUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "GUI";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.DevTools.ResumeLayout(false);
            this.DevTools.PerformLayout();
            this.IdeaSelection.ResumeLayout(false);
            this.IdeaSelection.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Hack.ResumeLayout(false);
            this.Hack.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DevTools;
        private System.Windows.Forms.Button CreateCountryList;
        private System.Windows.Forms.Button CreateCountrySelectionSwitch;
        private System.Windows.Forms.TabPage IdeaSelection;
        private System.Windows.Forms.Label SelectedCountry;
        private System.Windows.Forms.TextBox SearchCountry;
        private System.Windows.Forms.Button CreateIdeaList;
        private System.Windows.Forms.CheckedListBox IdeaListBox;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private TabPage Hack;
        private Button Run;
        private TabPage ProvinceSelection;
        private CheckedListBox TypeCheckListBox;
        private SplitContainer splitContainer1;
        private Label SelectedTypesLabel;
    }
}