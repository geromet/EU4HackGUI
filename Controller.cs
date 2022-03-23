using System.Collections.Generic;

namespace Eu4HackGUI
{
	public class Controller
	{
		public static bool HackIsRunning = false;
		private static string countryTag;
		private static List<string> selectedIdeas = new();
		private static List<string> selectedTypes = new();

		public static List<string> GetSelectedIdeas() => selectedIdeas;
		public static void AddIdea(string idea) => selectedIdeas.Add(idea);
		public static void RemoveIdea(string idea) => selectedIdeas.Remove(idea);
		public static void AddType(string type) => selectedTypes.Add(type);
		public static List<string> GetSelectedTypes() => selectedTypes;
		public static void RemoveType(string type) => selectedTypes.Remove(type);
		public static string GetCountryTag() => countryTag;
		public static void SetCountryTag(string CountryName)
		{
			string CountryTag = "";
			switch (CountryName)
			{
				case "Sweden":
					{
						CountryTag = "SWE";
						break;
					}
				case "Denmark":
					{
						CountryTag = "DAN";
						break;
					}
				case "Finland":
					{
						CountryTag = "FIN";
						break;
					}
				case "Gotland":
					{
						CountryTag = "GOT";
						break;
					}
				case "Norway":
					{
						CountryTag = "NOR";
						break;
					}
				case "Holstein":
					{
						CountryTag = "SHL";
						break;
					}
				case "Scandinavia":
					{
						CountryTag = "SCA";
						break;
					}
				case "Estonia":
					{
						CountryTag = "EST";
						break;
					}
				case "Livonia":
					{
						CountryTag = "LVA";
						break;
					}
				case "Sapmi":
					{
						CountryTag = "SMI";
						break;
					}
				case "Karelia":
					{
						CountryTag = "KRL";
						break;
					}
				case "Iceland":
					{
						CountryTag = "ICE";
						break;
					}
				case "Achaea":
					{
						CountryTag = "ACH";
						break;
					}
				case "Albania":
					{
						CountryTag = "ALB";
						break;
					}
				case "Athens":
					{
						CountryTag = "ATH";
						break;
					}
				case "Bosnia":
					{
						CountryTag = "BOS";
						break;
					}
				case "Bulgaria":
					{
						CountryTag = "BUL";
						break;
					}
				case "Byzantium":
					{
						CountryTag = "BYZ";
						break;
					}
				case "Corfu":
					{
						CountryTag = "CEP";
						break;
					}
				case "Croatia":
					{
						CountryTag = "CRO";
						break;
					}
				case "Crete":
					{
						CountryTag = "CRT";
						break;
					}
				case "Cyprus":
					{
						CountryTag = "CYP";
						break;
					}
				case "Dalmatia":
					{
						CountryTag = "DAL";
						break;
					}
				case "Epirus":
					{
						CountryTag = "EPI";
						break;
					}
				case "Greece":
					{
						CountryTag = "GRE";
						break;
					}
				case "The Knights":
					{
						CountryTag = "KNI";
						break;
					}
				case "Morea":
					{
						CountryTag = "MOE";
						break;
					}
				case "Moldavia":
					{
						CountryTag = "MOL";
						break;
					}
				case "Montenegro":
					{
						CountryTag = "MON";
						break;
					}
				case "Naxos":
					{
						CountryTag = "NAX";
						break;
					}
				case "Ragusa":
					{
						CountryTag = "RAG";
						break;
					}
				case "Romania":
					{
						CountryTag = "RMN";
						break;
					}
				case "Serbia":
					{
						CountryTag = "SER";
						break;
					}
				case "Transylvania":
					{
						CountryTag = "TRA";
						break;
					}
				case "Wallachia":
					{
						CountryTag = "WAL";
						break;
					}
				case "Hungary":
					{
						CountryTag = "HUN";
						break;
					}
				case "Nitra":
					{
						CountryTag = "SLO";
						break;
					}
				case "Ottomans":
					{
						CountryTag = "TUR";
						break;
					}
				case "Clanricarde":
					{
						CountryTag = "CNN";
						break;
					}
				case "Cornwall":
					{
						CountryTag = "CRN";
						break;
					}
				case "England":
					{
						CountryTag = "ENG";
						break;
					}
				case "Leinster":
					{
						CountryTag = "LEI";
						break;
					}
				case "Ireland":
					{
						CountryTag = "IRE";
						break;
					}
				case "Thomond":
					{
						CountryTag = "MNS";
						break;
					}
				case "Scotland":
					{
						CountryTag = "SCO";
						break;
					}
				case "Tyrone":
					{
						CountryTag = "TYR";
						break;
					}
				case "Wales":
					{
						CountryTag = "WLS";
						break;
					}
				case "Northumberland":
					{
						CountryTag = "NOL";
						break;
					}
				case "Great Britain":
					{
						CountryTag = "GBR";
						break;
					}
				case "Meath":
					{
						CountryTag = "MTH";
						break;
					}
				case "Ulster":
					{
						CountryTag = "ULS";
						break;
					}
				case "Desmond":
					{
						CountryTag = "DMS";
						break;
					}
				case "Sligo":
					{
						CountryTag = "SLN";
						break;
					}
				case "Kildare":
					{
						CountryTag = "KID";
						break;
					}
				case "Gaeldom":
					{
						CountryTag = "HSC";
						break;
					}
				case "Ormond":
					{
						CountryTag = "ORD";
						break;
					}
				case "Tyrconnell":
					{
						CountryTag = "TRY";
						break;
					}
				case "Offaly":
					{
						CountryTag = "FLY";
						break;
					}
				case "Munster":
					{
						CountryTag = "MCM";
						break;
					}
				case "Mann":
					{
						CountryTag = "KOI";
						break;
					}
				case "The Isles":
					{
						CountryTag = "LOI";
						break;
					}
				case "Brazil":
					{
						CountryTag = "BRZ";
						break;
					}
				case "Canada":
					{
						CountryTag = "CAN";
						break;
					}
				case "Chile":
					{
						CountryTag = "CHL";
						break;
					}
				case "Colombia":
					{
						CountryTag = "COL";
						break;
					}
				case "Haiti":
					{
						CountryTag = "HAT";
						break;
					}
				case "La Plata":
					{
						CountryTag = "LAP";
						break;
					}
				case "Louisiana":
					{
						CountryTag = "LOU";
						break;
					}
				case "Mexico":
					{
						CountryTag = "MEX";
						break;
					}
				case "Peru":
					{
						CountryTag = "PEU";
						break;
					}
				case "Paraguay":
					{
						CountryTag = "PRG";
						break;
					}
				case "Quebec":
					{
						CountryTag = "QUE";
						break;
					}
				case "United Central America":
					{
						CountryTag = "CAM";
						break;
					}
				case "United States":
					{
						CountryTag = "USA";
						break;
					}
				case "Venezuela":
					{
						CountryTag = "VNZ";
						break;
					}
				case "Australia":
					{
						CountryTag = "AUS";
						break;
					}
				case "California":
					{
						CountryTag = "CAL";
						break;
					}
				case "Texas":
					{
						CountryTag = "TEX";
						break;
					}
				case "Cascadia":
					{
						CountryTag = "CSC";
						break;
					}
				case "Alaska":
					{
						CountryTag = "ALA";
						break;
					}
				case "Zealandia":
					{
						CountryTag = "NZL";
						break;
					}
				case "Illinois":
					{
						CountryTag = "ILI";
						break;
					}
				case "Florida":
					{
						CountryTag = "FLO";
						break;
					}
				case "Vermont":
					{
						CountryTag = "VRM";
						break;
					}
				case "Sonora":
					{
						CountryTag = "SNA";
						break;
					}
				case "West Indies":
					{
						CountryTag = "WSI";
						break;
					}
				case "Cuba":
					{
						CountryTag = "CUB";
						break;
					}
				case "Danzig":
					{
						CountryTag = "DNZ";
						break;
					}
				case "Krakow":
					{
						CountryTag = "KRA";
						break;
					}
				case "Lithuania":
					{
						CountryTag = "LIT";
						break;
					}
				case "Livonian Order":
					{
						CountryTag = "LIV";
						break;
					}
				case "Mazovia":
					{
						CountryTag = "MAZ";
						break;
					}
				case "Poland":
					{
						CountryTag = "POL";
						break;
					}
				case "Prussia":
					{
						CountryTag = "PRU";
						break;
					}
				case "Kurland":
					{
						CountryTag = "KUR";
						break;
					}
				case "Riga":
					{
						CountryTag = "RIG";
						break;
					}
				case "Teutonic Order":
					{
						CountryTag = "TEU";
						break;
					}
				case "Commonwealth":
					{
						CountryTag = "PLC";
						break;
					}
				case "Galicia–Volhynia":
					{
						CountryTag = "VOL";
						break;
					}
				case "Kiev":
					{
						CountryTag = "KIE";
						break;
					}
				case "Chernigov":
					{
						CountryTag = "CHR";
						break;
					}
				case "Odoyev":
					{
						CountryTag = "OKA";
						break;
					}
				case "Alençon":
					{
						CountryTag = "ALE";
						break;
					}
				case "Strasbourg":
					{
						CountryTag = "ALS";
						break;
					}
				case "Armagnac":
					{
						CountryTag = "AMG";
						break;
					}
				case "Auvergne":
					{
						CountryTag = "AUV";
						break;
					}
				case "Avignon":
					{
						CountryTag = "AVI";
						break;
					}
				case "Bourbonnais":
					{
						CountryTag = "BOU";
						break;
					}
				case "Brittany":
					{
						CountryTag = "BRI";
						break;
					}
				case "Burgundy":
					{
						CountryTag = "BUR";
						break;
					}
				case "Champagne":
					{
						CountryTag = "CHP";
						break;
					}
				case "Corsica":
					{
						CountryTag = "COR";
						break;
					}
				case "Dauphine":
					{
						CountryTag = "DAU";
						break;
					}
				case "Foix":
					{
						CountryTag = "FOI";
						break;
					}
				case "France":
					{
						CountryTag = "FRA";
						break;
					}
				case "Gascony":
					{
						CountryTag = "GUY";
						break;
					}
				case "Nevers":
					{
						CountryTag = "NEV";
						break;
					}
				case "Normandy":
					{
						CountryTag = "NRM";
						break;
					}
				case "Orleans":
					{
						CountryTag = "ORL";
						break;
					}
				case "Picardy":
					{
						CountryTag = "PIC";
						break;
					}
				case "Provence":
					{
						CountryTag = "PRO";
						break;
					}
				case "Sardinia-Piedmont":
					{
						CountryTag = "SPI";
						break;
					}
				case "Toulouse":
					{
						CountryTag = "TOU";
						break;
					}
				case "Berry":
					{
						CountryTag = "BER";
						break;
					}
				case "Aachen":
					{
						CountryTag = "AAC";
						break;
					}
				case "Anhalt":
					{
						CountryTag = "ANH";
						break;
					}
				case "Ansbach":
					{
						CountryTag = "ANS";
						break;
					}
				case "Augsburg":
					{
						CountryTag = "AUG";
						break;
					}
				case "Baden":
					{
						CountryTag = "BAD";
						break;
					}
				case "Bavaria":
					{
						CountryTag = "BAV";
						break;
					}
				case "Bohemia":
					{
						CountryTag = "BOH";
						break;
					}
				case "Brandenburg":
					{
						CountryTag = "BRA";
						break;
					}
				case "Bremen":
					{
						CountryTag = "BRE";
						break;
					}
				case "Brunswick":
					{
						CountryTag = "BRU";
						break;
					}
				case "East Frisia":
					{
						CountryTag = "EFR";
						break;
					}
				case "Frankfurt":
					{
						CountryTag = "FRN";
						break;
					}
				case "Germany":
					{
						CountryTag = "GER";
						break;
					}
				case "Austria":
					{
						CountryTag = "HAB";
						break;
					}
				case "Hamburg":
					{
						CountryTag = "HAM";
						break;
					}
				case "Hanover":
					{
						CountryTag = "HAN";
						break;
					}
				case "Hesse":
					{
						CountryTag = "HES";
						break;
					}
				case "Holy Roman Empire":
					{
						CountryTag = "HLR";
						break;
					}
				case "Cleves":
					{
						CountryTag = "KLE";
						break;
					}
				case "Cologne":
					{
						CountryTag = "KOL";
						break;
					}
				case "Saxe-Lauenburg":
					{
						CountryTag = "LAU";
						break;
					}
				case "Lorraine":
					{
						CountryTag = "LOR";
						break;
					}
				case "Lüneburg":
					{
						CountryTag = "LUN";
						break;
					}
				case "Magdeburg":
					{
						CountryTag = "MAG";
						break;
					}
				case "Mainz":
					{
						CountryTag = "MAI";
						break;
					}
				case "Meissen":
					{
						CountryTag = "MEI";
						break;
					}
				case "Mecklenburg":
					{
						CountryTag = "MKL";
						break;
					}
				case "Münster":
					{
						CountryTag = "MUN";
						break;
					}
				case "Moravia":
					{
						CountryTag = "MVA";
						break;
					}
				case "Oldenburg":
					{
						CountryTag = "OLD";
						break;
					}
				case "The Palatinate":
					{
						CountryTag = "PAL";
						break;
					}
				case "Pomerania":
					{
						CountryTag = "POM";
						break;
					}
				case "Saxony":
					{
						CountryTag = "SAX";
						break;
					}
				case "Silesia":
					{
						CountryTag = "SIL";
						break;
					}
				case "Salzburg":
					{
						CountryTag = "SLZ";
						break;
					}
				case "Styria":
					{
						CountryTag = "STY";
						break;
					}
				case "Switzerland":
					{
						CountryTag = "SWI";
						break;
					}
				case "Thuringia":
					{
						CountryTag = "THU";
						break;
					}
				case "Tirol":
					{
						CountryTag = "TIR";
						break;
					}
				case "Trier":
					{
						CountryTag = "TRI";
						break;
					}
				case "Ulm":
					{
						CountryTag = "ULM";
						break;
					}
				case "Wurzburg":
					{
						CountryTag = "WBG";
						break;
					}
				case "Westphalia":
					{
						CountryTag = "WES";
						break;
					}
				case "Wurttemberg":
					{
						CountryTag = "WUR";
						break;
					}
				case "Nuremberg":
					{
						CountryTag = "NUM";
						break;
					}
				case "Memmingen":
					{
						CountryTag = "MEM";
						break;
					}
				case "Verden":
					{
						CountryTag = "VER";
						break;
					}
				case "Nassau":
					{
						CountryTag = "NSA";
						break;
					}
				case "Dortmund":
					{
						CountryTag = "RVA";
						break;
					}
				case "Dithmarschen":
					{
						CountryTag = "DTT";
						break;
					}
				case "Aragon":
					{
						CountryTag = "ARA";
						break;
					}
				case "Castile":
					{
						CountryTag = "CAS";
						break;
					}
				case "Catalonia":
					{
						CountryTag = "CAT";
						break;
					}
				case "Granada":
					{
						CountryTag = "GRA";
						break;
					}
				case "Navarra":
					{
						CountryTag = "NAV";
						break;
					}
				case "Portugal":
					{
						CountryTag = "POR";
						break;
					}
				case "Spain":
					{
						CountryTag = "SPA";
						break;
					}
				case "Galicia":
					{
						CountryTag = "GAL";
						break;
					}
				case "León":
					{
						CountryTag = "LON";
						break;
					}
				case "Andalusia":
					{
						CountryTag = "ADU";
						break;
					}
				case "Valencia":
					{
						CountryTag = "VAL";
						break;
					}
				case "Asturias":
					{
						CountryTag = "ASU";
						break;
					}
				case "Majorca":
					{
						CountryTag = "MJO";
						break;
					}
				case "Aquileia":
					{
						CountryTag = "AQU";
						break;
					}
				case "Etruria":
					{
						CountryTag = "ETR";
						break;
					}
				case "Ferrara":
					{
						CountryTag = "FER";
						break;
					}
				case "Genoa":
					{
						CountryTag = "GEN";
						break;
					}
				case "Italy":
					{
						CountryTag = "ITA";
						break;
					}
				case "Mantua":
					{
						CountryTag = "MAN";
						break;
					}
				case "Milan":
					{
						CountryTag = "MLO";
						break;
					}
				case "Modena":
					{
						CountryTag = "MOD";
						break;
					}
				case "Naples":
					{
						CountryTag = "NAP";
						break;
					}
				case "The Papal State":
					{
						CountryTag = "PAP";
						break;
					}
				case "Parma":
					{
						CountryTag = "PAR";
						break;
					}
				case "Pisa":
					{
						CountryTag = "PIS";
						break;
					}
				case "Sardinia":
					{
						CountryTag = "SAR";
						break;
					}
				case "Savoy":
					{
						CountryTag = "SAV";
						break;
					}
				case "Sicily":
					{
						CountryTag = "SIC";
						break;
					}
				case "Siena":
					{
						CountryTag = "SIE";
						break;
					}
				case "Tuscany":
					{
						CountryTag = "TUS";
						break;
					}
				case "Urbino":
					{
						CountryTag = "URB";
						break;
					}
				case "Venice":
					{
						CountryTag = "VEN";
						break;
					}
				case "Montferrat":
					{
						CountryTag = "MFA";
						break;
					}
				case "Lucca":
					{
						CountryTag = "LUC";
						break;
					}
				case "Florence":
					{
						CountryTag = "LAN";
						break;
					}
				case "Malta":
					{
						CountryTag = "JAI";
						break;
					}
				case "Brabant":
					{
						CountryTag = "BRB";
						break;
					}
				case "Flanders":
					{
						CountryTag = "FLA";
						break;
					}
				case "Friesland":
					{
						CountryTag = "FRI";
						break;
					}
				case "Gelre":
					{
						CountryTag = "GEL";
						break;
					}
				case "Hainaut":
					{
						CountryTag = "HAI";
						break;
					}
				case "Holland":
					{
						CountryTag = "HOL";
						break;
					}
				case "Liege":
					{
						CountryTag = "LIE";
						break;
					}
				case "Luxembourg":
					{
						CountryTag = "LUX";
						break;
					}
				case "Netherlands":
					{
						CountryTag = "NED";
						break;
					}
				case "Utrecht":
					{
						CountryTag = "UTR";
						break;
					}
				case "Armenia":
					{
						CountryTag = "ARM";
						break;
					}
				case "Astrakhan":
					{
						CountryTag = "AST";
						break;
					}
				case "Crimea":
					{
						CountryTag = "CRI";
						break;
					}
				case "Georgia":
					{
						CountryTag = "GEO";
						break;
					}
				case "Kazan":
					{
						CountryTag = "KAZ";
						break;
					}
				case "Muscovy":
					{
						CountryTag = "MOS";
						break;
					}
				case "Novgorod":
					{
						CountryTag = "NOV";
						break;
					}
				case "Pskov":
					{
						CountryTag = "PSK";
						break;
					}
				case "Qasim":
					{
						CountryTag = "QAS";
						break;
					}
				case "Russia":
					{
						CountryTag = "RUS";
						break;
					}
				case "Ryazan":
					{
						CountryTag = "RYA";
						break;
					}
				case "Tver":
					{
						CountryTag = "TVE";
						break;
					}
				case "Ruthenia":
					{
						CountryTag = "UKR";
						break;
					}
				case "Yaroslavl":
					{
						CountryTag = "YAR";
						break;
					}
				case "Zaporozhie":
					{
						CountryTag = "ZAZ";
						break;
					}
				case "Nogai":
					{
						CountryTag = "NOG";
						break;
					}
				case "Sibir":
					{
						CountryTag = "SIB";
						break;
					}
				case "Polotsk":
					{
						CountryTag = "PLT";
						break;
					}
				case "Perm":
					{
						CountryTag = "PRM";
						break;
					}
				case "Theodoro":
					{
						CountryTag = "FEO";
						break;
					}
				case "Bashkiria":
					{
						CountryTag = "BSH";
						break;
					}
				case "Beloozero":
					{
						CountryTag = "BLO";
						break;
					}
				case "Rostov":
					{
						CountryTag = "RSO";
						break;
					}
				case "Great Horde":
					{
						CountryTag = "GOL";
						break;
					}
				case "Golden Horde":
					{
						CountryTag = "GLH";
						break;
					}
				case "Aden":
					{
						CountryTag = "ADE";
						break;
					}
				case "Haasa":
					{
						CountryTag = "ALH";
						break;
					}
				case "Anizah":
					{
						CountryTag = "ANZ";
						break;
					}
				case "Arabia":
					{
						CountryTag = "ARB";
						break;
					}
				case "Ardalan":
					{
						CountryTag = "ARD";
						break;
					}
				case "Soran":
					{
						CountryTag = "BHT";
						break;
					}
				case "Dawasir":
					{
						CountryTag = "DAW";
						break;
					}
				case "Eretna":
					{
						CountryTag = "ERE";
						break;
					}
				case "Fadl":
					{
						CountryTag = "FAD";
						break;
					}
				case "Germiyan":
					{
						CountryTag = "GRM";
						break;
					}
				case "Hadramut":
					{
						CountryTag = "HDR";
						break;
					}
				case "Hejaz":
					{
						CountryTag = "HED";
						break;
					}
				case "Lebanon":
					{
						CountryTag = "LEB";
						break;
					}
				case "Makuria":
					{
						CountryTag = "MAK";
						break;
					}
				case "Medina":
					{
						CountryTag = "MDA";
						break;
					}
				case "Mikhlaf":
					{
						CountryTag = "MFL";
						break;
					}
				case "Mahra":
					{
						CountryTag = "MHR";
						break;
					}
				case "Najd":
					{
						CountryTag = "NAJ";
						break;
					}
				case "Najran":
					{
						CountryTag = "NJR";
						break;
					}
				case "Oman":
					{
						CountryTag = "OMA";
						break;
					}
				case "Rassids":
					{
						CountryTag = "RAS";
						break;
					}
				case "Shammar":
					{
						CountryTag = "SHM";
						break;
					}
				case "Sharjah":
					{
						CountryTag = "SHR";
						break;
					}
				case "Shirvan":
					{
						CountryTag = "SRV";
						break;
					}
				case "Yas":
					{
						CountryTag = "YAS";
						break;
					}
				case "Yemen":
					{
						CountryTag = "YEM";
						break;
					}
				case "Hisn Kayfa":
					{
						CountryTag = "HSN";
						break;
					}
				case "Bitlis":
					{
						CountryTag = "BTL";
						break;
					}
				case "Aq Qoyunlu":
					{
						CountryTag = "AKK";
						break;
					}
				case "Aydin":
					{
						CountryTag = "AYD";
						break;
					}
				case "Candar":
					{
						CountryTag = "CND";
						break;
					}
				case "Dulkadir":
					{
						CountryTag = "DUL";
						break;
					}
				case "Iraq":
					{
						CountryTag = "IRQ";
						break;
					}
				case "Karaman":
					{
						CountryTag = "KAR";
						break;
					}
				case "Syria":
					{
						CountryTag = "SYR";
						break;
					}
				case "Trebizond":
					{
						CountryTag = "TRE";
						break;
					}
				case "Saruhan":
					{
						CountryTag = "SRU";
						break;
					}
				case "Mentese":
					{
						CountryTag = "MEN";
						break;
					}
				case "Ramazan":
					{
						CountryTag = "RAM";
						break;
					}
				case "Avaria":
					{
						CountryTag = "AVR";
						break;
					}
				case "Kharabakh":
					{
						CountryTag = "MLK";
						break;
					}
				case "Samtskhe":
					{
						CountryTag = "SME";
						break;
					}
				case "Ardabil":
					{
						CountryTag = "ARL";
						break;
					}
				case "Mushasha":
					{
						CountryTag = "MSY";
						break;
					}
				case "Rûm":
					{
						CountryTag = "RUM";
						break;
					}
				case "Algiers":
					{
						CountryTag = "ALG";
						break;
					}
				case "Fez":
					{
						CountryTag = "FEZ";
						break;
					}
				case "Mamluks":
					{
						CountryTag = "MAM";
						break;
					}
				case "Morocco":
					{
						CountryTag = "MOR";
						break;
					}
				case "Tripoli":
					{
						CountryTag = "TRP";
						break;
					}
				case "Tunis":
					{
						CountryTag = "TUN";
						break;
					}
				case "Egypt":
					{
						CountryTag = "EGY";
						break;
					}
				case "Kabylia":
					{
						CountryTag = "KBA";
						break;
					}
				case "Tafilalt":
					{
						CountryTag = "TFL";
						break;
					}
				case "Sus":
					{
						CountryTag = "SOS";
						break;
					}
				case "Tlemcen":
					{
						CountryTag = "TLC";
						break;
					}
				case "Touggourt":
					{
						CountryTag = "TGT";
						break;
					}
				case "Djerid":
					{
						CountryTag = "GHD";
						break;
					}
				case "Fezzan":
					{
						CountryTag = "FZA";
						break;
					}
				case "Mzab":
					{
						CountryTag = "MZB";
						break;
					}
				case "Salé":
					{
						CountryTag = "SLE";
						break;
					}
				case "Tétouan":
					{
						CountryTag = "TET";
						break;
					}
				case "Marrakesh":
					{
						CountryTag = "MRK";
						break;
					}
				case "Kazakh":
					{
						CountryTag = "KZH";
						break;
					}
				case "Khiva":
					{
						CountryTag = "KHI";
						break;
					}
				case "Uzbek":
					{
						CountryTag = "SHY";
						break;
					}
				case "Ferghana":
					{
						CountryTag = "KOK";
						break;
					}
				case "Bukhara":
					{
						CountryTag = "BUK";
						break;
					}
				case "Afghanistan":
					{
						CountryTag = "AFG";
						break;
					}
				case "Khorasan":
					{
						CountryTag = "KHO";
						break;
					}
				case "Persia":
					{
						CountryTag = "PER";
						break;
					}
				case "Qara Qoyunlu":
					{
						CountryTag = "QAR";
						break;
					}
				case "Timurids":
					{
						CountryTag = "TIM";
						break;
					}
				case "Transoxiana":
					{
						CountryTag = "TRS";
						break;
					}
				case "Gilan":
					{
						CountryTag = "KRY";
						break;
					}
				case "Circassia":
					{
						CountryTag = "CIR";
						break;
					}
				case "Gazikumukh":
					{
						CountryTag = "GAZ";
						break;
					}
				case "Imereti":
					{
						CountryTag = "IME";
						break;
					}
				case "Mazandaran":
					{
						CountryTag = "TAB";
						break;
					}
				case "Hormuz":
					{
						CountryTag = "ORM";
						break;
					}
				case "Luristan":
					{
						CountryTag = "LRI";
						break;
					}
				case "Sistan":
					{
						CountryTag = "SIS";
						break;
					}
				case "Biapas":
					{
						CountryTag = "BPI";
						break;
					}
				case "Fars":
					{
						CountryTag = "FRS";
						break;
					}
				case "Kerman":
					{
						CountryTag = "KRM";
						break;
					}
				case "Yazd":
					{
						CountryTag = "YZD";
						break;
					}
				case "Isfahan":
					{
						CountryTag = "ISF";
						break;
					}
				case "Tabriz":
					{
						CountryTag = "TBR";
						break;
					}
				case "Basra":
					{
						CountryTag = "BSR";
						break;
					}
				case "Maregheh":
					{
						CountryTag = "MGR";
						break;
					}
				case "Ajam":
					{
						CountryTag = "QOM";
						break;
					}
				case "Aztec":
					{
						CountryTag = "AZT";
						break;
					}
				case "Cherokee":
					{
						CountryTag = "CHE";
						break;
					}
				case "Chimu":
					{
						CountryTag = "CHM";
						break;
					}
				case "Creek":
					{
						CountryTag = "CRE";
						break;
					}
				case "Huron":
					{
						CountryTag = "HUR";
						break;
					}
				case "Inca":
					{
						CountryTag = "INC";
						break;
					}
				case "Iroquois":
					{
						CountryTag = "IRO";
						break;
					}
				case "Maya":
					{
						CountryTag = "MAY";
						break;
					}
				case "Shawnee":
					{
						CountryTag = "SHA";
						break;
					}
				case "Zapotec":
					{
						CountryTag = "ZAP";
						break;
					}
				case "Ashanti":
					{
						CountryTag = "ASH";
						break;
					}
				case "Benin":
					{
						CountryTag = "BEN";
						break;
					}
				case "Ethiopia":
					{
						CountryTag = "ETH";
						break;
					}
				case "Kongo":
					{
						CountryTag = "KON";
						break;
					}
				case "Mali":
					{
						CountryTag = "MAL";
						break;
					}
				case "Funj":
					{
						CountryTag = "NUB";
						break;
					}
				case "Songhai":
					{
						CountryTag = "SON";
						break;
					}
				case "Kilwa":
					{
						CountryTag = "ZAN";
						break;
					}
				case "Mutapa":
					{
						CountryTag = "ZIM";
						break;
					}
				case "Adal":
					{
						CountryTag = "ADA";
						break;
					}
				case "Hausa":
					{
						CountryTag = "HAU";
						break;
					}
				case "Kanem Bornu":
					{
						CountryTag = "KBO";
						break;
					}
				case "Loango":
					{
						CountryTag = "LOA";
						break;
					}
				case "Oyo":
					{
						CountryTag = "OYO";
						break;
					}
				case "Segu":
					{
						CountryTag = "SOF";
						break;
					}
				case "Sokoto":
					{
						CountryTag = "SOK";
						break;
					}
				case "Jolof":
					{
						CountryTag = "JOL";
						break;
					}
				case "Sofala":
					{
						CountryTag = "SFA";
						break;
					}
				case "Mombasa":
					{
						CountryTag = "MBA";
						break;
					}
				case "Malindi":
					{
						CountryTag = "MLI";
						break;
					}
				case "Ajuuraan":
					{
						CountryTag = "AJU";
						break;
					}
				case "Mogadishu":
					{
						CountryTag = "MDI";
						break;
					}
				case "Ennarea":
					{
						CountryTag = "ENA";
						break;
					}
				case "Aussa":
					{
						CountryTag = "AFA";
						break;
					}
				case "Alodia":
					{
						CountryTag = "ALO";
						break;
					}
				case "Darfur":
					{
						CountryTag = "DAR";
						break;
					}
				case "Geledi":
					{
						CountryTag = "GLE";
						break;
					}
				case "Harar":
					{
						CountryTag = "HAR";
						break;
					}
				case "Hobyo":
					{
						CountryTag = "HOB";
						break;
					}
				case "Kaffa":
					{
						CountryTag = "KAF";
						break;
					}
				case "Medri Bahri":
					{
						CountryTag = "MED";
						break;
					}
				case "Majeerteen":
					{
						CountryTag = "MJE";
						break;
					}
				case "Marehan":
					{
						CountryTag = "MRE";
						break;
					}
				case "Pate":
					{
						CountryTag = "PTE";
						break;
					}
				case "Warsangali":
					{
						CountryTag = "WAR";
						break;
					}
				case "Semien":
					{
						CountryTag = "BTI";
						break;
					}
				case "Beja":
					{
						CountryTag = "BEJ";
						break;
					}
				case "Jimma":
					{
						CountryTag = "JIM";
						break;
					}
				case "Welayta":
					{
						CountryTag = "WLY";
						break;
					}
				case "Damot":
					{
						CountryTag = "DAM";
						break;
					}
				case "Hadiya":
					{
						CountryTag = "HDY";
						break;
					}
				case "Shewa":
					{
						CountryTag = "SOA";
						break;
					}
				case "Janjiro":
					{
						CountryTag = "JJI";
						break;
					}
				case "Dongola":
					{
						CountryTag = "ABB";
						break;
					}
				case "Tyo":
					{
						CountryTag = "TYO";
						break;
					}
				case "Soyo":
					{
						CountryTag = "SYO";
						break;
					}
				case "Kasanje":
					{
						CountryTag = "KSJ";
						break;
					}
				case "Luba":
					{
						CountryTag = "LUB";
						break;
					}
				case "Lunda":
					{
						CountryTag = "LND";
						break;
					}
				case "Chokwe":
					{
						CountryTag = "CKW";
						break;
					}
				case "Kikondja":
					{
						CountryTag = "KIK";
						break;
					}
				case "Kazembe":
					{
						CountryTag = "KZB";
						break;
					}
				case "Yaka":
					{
						CountryTag = "YAK";
						break;
					}
				case "Kalundwe":
					{
						CountryTag = "KLD";
						break;
					}
				case "Kuba":
					{
						CountryTag = "KUB";
						break;
					}
				case "Rwanda":
					{
						CountryTag = "RWA";
						break;
					}
				case "Burundi":
					{
						CountryTag = "BUU";
						break;
					}
				case "Buganda":
					{
						CountryTag = "BUG";
						break;
					}
				case "Nkore":
					{
						CountryTag = "NKO";
						break;
					}
				case "Karagwe":
					{
						CountryTag = "KRW";
						break;
					}
				case "Bunyoro":
					{
						CountryTag = "BNY";
						break;
					}
				case "Busoga":
					{
						CountryTag = "BSG";
						break;
					}
				case "Buha":
					{
						CountryTag = "UBH";
						break;
					}
				case "Maravi":
					{
						CountryTag = "MRA";
						break;
					}
				case "Lundu":
					{
						CountryTag = "LDU";
						break;
					}
				case "Tumbuka":
					{
						CountryTag = "TBK";
						break;
					}
				case "Makua":
					{
						CountryTag = "MKU";
						break;
					}
				case "Butua":
					{
						CountryTag = "RZW";
						break;
					}
				case "Imerina":
					{
						CountryTag = "MIR";
						break;
					}
				case "Sakalava":
					{
						CountryTag = "SKA";
						break;
					}
				case "Betsimisaraka":
					{
						CountryTag = "BTS";
						break;
					}
				case "Mahafaly":
					{
						CountryTag = "MFY";
						break;
					}
				case "Antemoro":
					{
						CountryTag = "ANT";
						break;
					}
				case "Annam":
					{
						CountryTag = "ANN";
						break;
					}
				case "Arakan":
					{
						CountryTag = "ARK";
						break;
					}
				case "Aceh":
					{
						CountryTag = "ATJ";
						break;
					}
				case "Ayutthaya":
					{
						CountryTag = "AYU";
						break;
					}
				case "Bali":
					{
						CountryTag = "BLI";
						break;
					}
				case "Banten":
					{
						CountryTag = "BAN";
						break;
					}
				case "Brunei":
					{
						CountryTag = "BEI";
						break;
					}
				case "Champa":
					{
						CountryTag = "CHA";
						break;
					}
				case "Chagatai":
					{
						CountryTag = "CHG";
						break;
					}
				case "Champasak":
					{
						CountryTag = "CHK";
						break;
					}
				case "Dai Viet":
					{
						CountryTag = "DAI";
						break;
					}
				case "Japan":
					{
						CountryTag = "JAP";
						break;
					}
				case "Amago":
					{
						CountryTag = "AMA";
						break;
					}
				case "Asakura":
					{
						CountryTag = "ASA";
						break;
					}
				case "Chosokabe":
					{
						CountryTag = "CSK";
						break;
					}
				case "Date":
					{
						CountryTag = "DTE";
						break;
					}
				case "Hojo":
					{
						CountryTag = "HJO";
						break;
					}
				case "Hosokawa":
					{
						CountryTag = "HSK";
						break;
					}
				case "Hatakeyama":
					{
						CountryTag = "HTK";
						break;
					}
				case "Ikeda":
					{
						CountryTag = "IKE";
						break;
					}
				case "Imagawa":
					{
						CountryTag = "IMG";
						break;
					}
				case "Maeda":
					{
						CountryTag = "MAE";
						break;
					}
				case "Mori":
					{
						CountryTag = "MRI";
						break;
					}
				case "Oda":
					{
						CountryTag = "ODA";
						break;
					}
				case "Otomo":
					{
						CountryTag = "OTM";
						break;
					}
				case "Ouchi":
					{
						CountryTag = "OUC";
						break;
					}
				case "Shiba":
					{
						CountryTag = "SBA";
						break;
					}
				case "Shimazu":
					{
						CountryTag = "SMZ";
						break;
					}
				case "Takeda":
					{
						CountryTag = "TKD";
						break;
					}
				case "Tokugawa":
					{
						CountryTag = "TKG";
						break;
					}
				case "Uesugi":
					{
						CountryTag = "UES";
						break;
					}
				case "Yamana":
					{
						CountryTag = "YMN";
						break;
					}
				case "Nanbu":
					{
						CountryTag = "RFR";
						break;
					}
				case "Ashikaga":
					{
						CountryTag = "ASK";
						break;
					}
				case "Kitabatake":
					{
						CountryTag = "KTB";
						break;
					}
				case "Ainu":
					{
						CountryTag = "ANU";
						break;
					}
				case "Akamatsu":
					{
						CountryTag = "AKM";
						break;
					}
				case "Ando":
					{
						CountryTag = "AKT";
						break;
					}
				case "Chiba":
					{
						CountryTag = "CBA";
						break;
					}
				case "Isshiki":
					{
						CountryTag = "ISK";
						break;
					}
				case "Ito":
					{
						CountryTag = "ITO";
						break;
					}
				case "Kikuchi":
					{
						CountryTag = "KKC";
						break;
					}
				case "Kono":
					{
						CountryTag = "KNO";
						break;
					}
				case "Ogasawara":
					{
						CountryTag = "OGS";
						break;
					}
				case "Shoni":
					{
						CountryTag = "SHN";
						break;
					}
				case "Satake":
					{
						CountryTag = "STK";
						break;
					}
				case "Toki":
					{
						CountryTag = "TKI";
						break;
					}
				case "Utsunomiya":
					{
						CountryTag = "UTN";
						break;
					}
				case "Tsutsui":
					{
						CountryTag = "TTI";
						break;
					}
				case "Mongolia":
					{
						CountryTag = "KHA";
						break;
					}
				case "Khmer":
					{
						CountryTag = "KHM";
						break;
					}
				case "Korea":
					{
						CountryTag = "KOR";
						break;
					}
				case "Lan Na":
					{
						CountryTag = "LNA";
						break;
					}
				case "Luang Prabang":
					{
						CountryTag = "LUA";
						break;
					}
				case "Lan Xang":
					{
						CountryTag = "LXA";
						break;
					}
				case "Majapahit":
					{
						CountryTag = "MAJ";
						break;
					}
				case "Manchu":
					{
						CountryTag = "MCH";
						break;
					}
				case "Makassar":
					{
						CountryTag = "MKS";
						break;
					}
				case "Malacca":
					{
						CountryTag = "MLC";
						break;
					}
				case "Ming":
					{
						CountryTag = "MNG";
						break;
					}
				case "Mataram":
					{
						CountryTag = "MTR";
						break;
					}
				case "Oirat":
					{
						CountryTag = "OIR";
						break;
					}
				case "Pattani":
					{
						CountryTag = "PAT";
						break;
					}
				case "Pegu":
					{
						CountryTag = "PEG";
						break;
					}
				case "Qing":
					{
						CountryTag = "QNG";
						break;
					}
				case "Ryukyu":
					{
						CountryTag = "RYU";
						break;
					}
				case "Shan":
					{
						CountryTag = "SST";
						break;
					}
				case "Sukhothai":
					{
						CountryTag = "SUK";
						break;
					}
				case "Sulu":
					{
						CountryTag = "SUL";
						break;
					}
				case "Taungu":
					{
						CountryTag = "TAU";
						break;
					}
				case "Tibet":
					{
						CountryTag = "TIB";
						break;
					}
				case "Tonkin":
					{
						CountryTag = "TOK";
						break;
					}
				case "Vientiane":
					{
						CountryTag = "VIE";
						break;
					}
				case "Zhou":
					{
						CountryTag = "CZH";
						break;
					}
				case "Shun":
					{
						CountryTag = "CSH";
						break;
					}
				case "Xi":
					{
						CountryTag = "CXI";
						break;
					}
				case "Yuan":
					{
						CountryTag = "YUA";
						break;
					}
				case "Tungning":
					{
						CountryTag = "FRM";
						break;
					}
				case "Ilkhanate":
					{
						CountryTag = "ILK";
						break;
					}
				case "Kalmyk":
					{
						CountryTag = "KLM";
						break;
					}
				case "Mongol Empire":
					{
						CountryTag = "MGE";
						break;
					}
				case "So":
					{
						CountryTag = "SOO";
						break;
					}
				case "Nivkh":
					{
						CountryTag = "NVK";
						break;
					}
				case "Solon":
					{
						CountryTag = "SOL";
						break;
					}
				case "Donghai":
					{
						CountryTag = "EJZ";
						break;
					}
				case "Udege":
					{
						CountryTag = "NHX";
						break;
					}
				case "Yeren":
					{
						CountryTag = "MYR";
						break;
					}
				case "Haixi":
					{
						CountryTag = "MHX";
						break;
					}
				case "Jianzhou":
					{
						CountryTag = "MJZ";
						break;
					}
				case "Korchin":
					{
						CountryTag = "KRC";
						break;
					}
				case "Khalkha":
					{
						CountryTag = "KLK";
						break;
					}
				case "Kara Del":
					{
						CountryTag = "HMI";
						break;
					}
				case "Dzungar":
					{
						CountryTag = "ZUN";
						break;
					}
				case "Yarkand":
					{
						CountryTag = "KAS";
						break;
					}
				case "Chahar":
					{
						CountryTag = "CHH";
						break;
					}
				case "Khoshuud":
					{
						CountryTag = "KSD";
						break;
					}
				case "Sarig Yogir":
					{
						CountryTag = "SYG";
						break;
					}
				case "Tsang":
					{
						CountryTag = "UTS";
						break;
					}
				case "Kham":
					{
						CountryTag = "KAM";
						break;
					}
				case "Guge":
					{
						CountryTag = "GUG";
						break;
					}
				case "U":
					{
						CountryTag = "PHA";
						break;
					}
				case "Dali":
					{
						CountryTag = "CDL";
						break;
					}
				case "Yi":
					{
						CountryTag = "CYI";
						break;
					}
				case "Miao":
					{
						CountryTag = "CMI";
						break;
					}
				case "Min":
					{
						CountryTag = "MIN";
						break;
					}
				case "Yue":
					{
						CountryTag = "YUE";
						break;
					}
				case "Shu":
					{
						CountryTag = "SHU";
						break;
					}
				case "Ning":
					{
						CountryTag = "NNG";
						break;
					}
				case "Chu":
					{
						CountryTag = "CHC";
						break;
					}
				case "Tang":
					{
						CountryTag = "TNG";
						break;
					}
				case "Wu":
					{
						CountryTag = "WUU";
						break;
					}
				case "Qi":
					{
						CountryTag = "QIC";
						break;
					}
				case "Yan":
					{
						CountryTag = "YAN";
						break;
					}
				case "Jin":
					{
						CountryTag = "JIN";
						break;
					}
				case "Liang":
					{
						CountryTag = "LNG";
						break;
					}
				case "Qin":
					{
						CountryTag = "QIN";
						break;
					}
				case "Huai":
					{
						CountryTag = "HUA";
						break;
					}
				case "Changsheng":
					{
						CountryTag = "CGS";
						break;
					}
				case "Baluchistan":
					{
						CountryTag = "BAL";
						break;
					}
				case "Bengal":
					{
						CountryTag = "BNG";
						break;
					}
				case "Bijapur":
					{
						CountryTag = "BIJ";
						break;
					}
				case "Bahmanis":
					{
						CountryTag = "BAH";
						break;
					}
				case "Delhi":
					{
						CountryTag = "DLH";
						break;
					}
				case "Golkonda":
					{
						CountryTag = "GOC";
						break;
					}
				case "Deccan":
					{
						CountryTag = "DEC";
						break;
					}
				case "Marathas":
					{
						CountryTag = "MAR";
						break;
					}
				case "Mughals":
					{
						CountryTag = "MUG";
						break;
					}
				case "Mysore":
					{
						CountryTag = "MYS";
						break;
					}
				case "Vijayanagar":
					{
						CountryTag = "VIJ";
						break;
					}
				case "Ahmednagar":
					{
						CountryTag = "AHM";
						break;
					}
				case "Assam":
					{
						CountryTag = "ASS";
						break;
					}
				case "Gujarat":
					{
						CountryTag = "GUJ";
						break;
					}
				case "Jaunpur":
					{
						CountryTag = "JNP";
						break;
					}
				case "Madurai":
					{
						CountryTag = "MAD";
						break;
					}
				case "Malwa":
					{
						CountryTag = "MLW";
						break;
					}
				case "Marwar":
					{
						CountryTag = "MAW";
						break;
					}
				case "Mewar":
					{
						CountryTag = "MER";
						break;
					}
				case "Multan":
					{
						CountryTag = "MUL";
						break;
					}
				case "Nagpur":
					{
						CountryTag = "NAG";
						break;
					}
				case "Nepal":
					{
						CountryTag = "NPL";
						break;
					}
				case "Orissa":
					{
						CountryTag = "ORI";
						break;
					}
				case "Punjab":
					{
						CountryTag = "PUN";
						break;
					}
				case "Sindh":
					{
						CountryTag = "SND";
						break;
					}
				case "Berar":
					{
						CountryTag = "BRR";
						break;
					}
				case "Jangladesh":
					{
						CountryTag = "JAN";
						break;
					}
				case "Carnatic":
					{
						CountryTag = "KRK";
						break;
					}
				case "Garha":
					{
						CountryTag = "GDW";
						break;
					}
				case "Garjat":
					{
						CountryTag = "GRJ";
						break;
					}
				case "Gwalior":
					{
						CountryTag = "GWA";
						break;
					}
				case "Dhundhar":
					{
						CountryTag = "DHU";
						break;
					}
				case "Kashmir":
					{
						CountryTag = "KSH";
						break;
					}
				case "Keladi":
					{
						CountryTag = "KLN";
						break;
					}
				case "Khandesh":
					{
						CountryTag = "KHD";
						break;
					}
				case "Oudh":
					{
						CountryTag = "ODH";
						break;
					}
				case "Venad":
					{
						CountryTag = "VND";
						break;
					}
				case "Calicut":
					{
						CountryTag = "MAB";
						break;
					}
				case "Mewat":
					{
						CountryTag = "MEW";
						break;
					}
				case "Baroda":
					{
						CountryTag = "BDA";
						break;
					}
				case "Bastar":
					{
						CountryTag = "BST";
						break;
					}
				case "Bhutan":
					{
						CountryTag = "BHU";
						break;
					}
				case "Bundelkhand":
					{
						CountryTag = "BND";
						break;
					}
				case "Kotte":
					{
						CountryTag = "CEY";
						break;
					}
				case "Jaisalmer":
					{
						CountryTag = "JSL";
						break;
					}
				case "Kachar":
					{
						CountryTag = "KAC";
						break;
					}
				case "Koch":
					{
						CountryTag = "KMT";
						break;
					}
				case "Kangra":
					{
						CountryTag = "KGR";
						break;
					}
				case "Kutch":
					{
						CountryTag = "KAT";
						break;
					}
				case "Kochin":
					{
						CountryTag = "KOC";
						break;
					}
				case "Manipur":
					{
						CountryTag = "MLB";
						break;
					}
				case "Hadoti":
					{
						CountryTag = "HAD";
						break;
					}
				case "Nagaur":
					{
						CountryTag = "NGA";
						break;
					}
				case "Rohilkhand":
					{
						CountryTag = "RMP";
						break;
					}
				case "Ladakh":
					{
						CountryTag = "LDK";
						break;
					}
				case "Baghelkhand":
					{
						CountryTag = "BGL";
						break;
					}
				case "Jaffna":
					{
						CountryTag = "JFN";
						break;
					}
				case "Patiala":
					{
						CountryTag = "PTA";
						break;
					}
				case "Garhwal":
					{
						CountryTag = "GHR";
						break;
					}
				case "Chanda":
					{
						CountryTag = "CHD";
						break;
					}
				case "Jharkhand":
					{
						CountryTag = "NGP";
						break;
					}
				case "Habsan":
					{
						CountryTag = "JAJ";
						break;
					}
				case "Tirhut":
					{
						CountryTag = "TRT";
						break;
					}
				case "Rewa Kantha":
					{
						CountryTag = "CMP";
						break;
					}
				case "Baglana":
					{
						CountryTag = "BGA";
						break;
					}
				case "Tripura":
					{
						CountryTag = "TPR";
						break;
					}
				case "Sadiya":
					{
						CountryTag = "SDY";
						break;
					}
				case "Bharat":
					{
						CountryTag = "BHA";
						break;
					}
				case "Andhra":
					{
						CountryTag = "YOR";
						break;
					}
				case "Maldives":
					{
						CountryTag = "DGL";
						break;
					}
				case "Bishnupur":
					{
						CountryTag = "MBL";
						break;
					}
				case "Sikkim":
					{
						CountryTag = "SKK";
						break;
					}
				case "Idar":
					{
						CountryTag = "IDR";
						break;
					}
				case "Jhalavad":
					{
						CountryTag = "JLV";
						break;
					}
				case "Palitana":
					{
						CountryTag = "PTL";
						break;
					}
				case "Navanagar":
					{
						CountryTag = "NVR";
						break;
					}
				case "Rajkot":
					{
						CountryTag = "RJK";
						break;
					}
				case "Junagarh":
					{
						CountryTag = "JGD";
						break;
					}
				case "Porbandar":
					{
						CountryTag = "PRB";
						break;
					}
				case "Kalinjar":
					{
						CountryTag = "PAN";
						break;
					}
				case "Kalpi":
					{
						CountryTag = "KLP";
						break;
					}
				case "Sambalpur":
					{
						CountryTag = "SBP";
						break;
					}
				case "Patna":
					{
						CountryTag = "PTT";
						break;
					}
				case "Ratanpur":
					{
						CountryTag = "RTT";
						break;
					}
				case "Kalahandi":
					{
						CountryTag = "KLH";
						break;
					}
				case "Keonhjar":
					{
						CountryTag = "KJH";
						break;
					}
				case "Parlakhimidi":
					{
						CountryTag = "PRD";
						break;
					}
				case "Jeypore":
					{
						CountryTag = "JPR";
						break;
					}
				case "Surguja":
					{
						CountryTag = "SRG";
						break;
					}
				case "Kandy":
					{
						CountryTag = "KND";
						break;
					}
				case "Telingana":
					{
						CountryTag = "TLG";
						break;
					}
				case "Kolathunad":
					{
						CountryTag = "KLT";
						break;
					}
				case "Dang":
					{
						CountryTag = "DNG";
						break;
					}
				case "Doti":
					{
						CountryTag = "DTI";
						break;
					}
				case "Gorkha":
					{
						CountryTag = "GRK";
						break;
					}
				case "Jumla":
					{
						CountryTag = "JML";
						break;
					}
				case "Limbuwan":
					{
						CountryTag = "LWA";
						break;
					}
				case "Makwanpur":
					{
						CountryTag = "MKP";
						break;
					}
				case "Sirmur":
					{
						CountryTag = "SRM";
						break;
					}
				case "Kathmandu":
					{
						CountryTag = "KTU";
						break;
					}
				case "Kumaon":
					{
						CountryTag = "KMN";
						break;
					}
				case "Gingee":
					{
						CountryTag = "GNG";
						break;
					}
				case "Tanjore":
					{
						CountryTag = "TNJ";
						break;
					}
				case "Sirhind":
					{
						CountryTag = "SRH";
						break;
					}
				case "Rajputana":
					{
						CountryTag = "RJP";
						break;
					}
				case "Bar":
					{
						CountryTag = "BAR";
						break;
					}
				case "Lübeck":
					{
						CountryTag = "HSA";
						break;
					}
				case "Smolensk":
					{
						CountryTag = "SMO";
						break;
					}
				case "Nizhny Novgorod":
					{
						CountryTag = "NZH";
						break;
					}
				case "Jerusalem":
					{
						CountryTag = "KOJ";
						break;
					}
				case "Malaya":
					{
						CountryTag = "MSA";
						break;
					}
				case "Hindustan":
					{
						CountryTag = "HIN";
						break;
					}
				case "Abenaki":
					{
						CountryTag = "ABE";
						break;
					}
				case "Apache":
					{
						CountryTag = "APA";
						break;
					}
				case "Assiniboine":
					{
						CountryTag = "ASI";
						break;
					}
				case "Blackfoot":
					{
						CountryTag = "BLA";
						break;
					}
				case "Caddo":
					{
						CountryTag = "CAD";
						break;
					}
				case "Chickasaw":
					{
						CountryTag = "CHI";
						break;
					}
				case "Choctaw":
					{
						CountryTag = "CHO";
						break;
					}
				case "Cheyenne":
					{
						CountryTag = "CHY";
						break;
					}
				case "Comanche":
					{
						CountryTag = "COM";
						break;
					}
				case "Fox":
					{
						CountryTag = "FOX";
						break;
					}
				case "Illiniwek":
					{
						CountryTag = "ILL";
						break;
					}
				case "Lenape":
					{
						CountryTag = "LEN";
						break;
					}
				case "Mahican":
					{
						CountryTag = "MAH";
						break;
					}
				case "Mikmaq":
					{
						CountryTag = "MIK";
						break;
					}
				case "Miami":
					{
						CountryTag = "MMI";
						break;
					}
				case "Navajo":
					{
						CountryTag = "NAH";
						break;
					}
				case "Ojibwe":
					{
						CountryTag = "OJI";
						break;
					}
				case "Osage":
					{
						CountryTag = "OSA";
						break;
					}
				case "Ottawa":
					{
						CountryTag = "OTT";
						break;
					}
				case "Pawnee":
					{
						CountryTag = "PAW";
						break;
					}
				case "Pequot":
					{
						CountryTag = "PEQ";
						break;
					}
				case "Pima":
					{
						CountryTag = "PIM";
						break;
					}
				case "Potawatomi":
					{
						CountryTag = "POT";
						break;
					}
				case "Powhatan":
					{
						CountryTag = "POW";
						break;
					}
				case "Pueblo":
					{
						CountryTag = "PUE";
						break;
					}
				case "Shoshone":
					{
						CountryTag = "SHO";
						break;
					}
				case "Sioux":
					{
						CountryTag = "SIO";
						break;
					}
				case "Susquehannock":
					{
						CountryTag = "SUS";
						break;
					}
				case "Cree":
					{
						CountryTag = "WCR";
						break;
					}
				case "Air":
					{
						CountryTag = "AIR";
						break;
					}
				case "Bonoman":
					{
						CountryTag = "BON";
						break;
					}
				case "Dahomey":
					{
						CountryTag = "DAH";
						break;
					}
				case "Dagbon":
					{
						CountryTag = "DGB";
						break;
					}
				case "Fulo":
					{
						CountryTag = "FUL";
						break;
					}
				case "Jenné":
					{
						CountryTag = "JNN";
						break;
					}
				case "Kano":
					{
						CountryTag = "KAN";
						break;
					}
				case "Kaabu":
					{
						CountryTag = "KBU";
						break;
					}
				case "Kong":
					{
						CountryTag = "KNG";
						break;
					}
				case "Katsina":
					{
						CountryTag = "KTS";
						break;
					}
				case "Mossi":
					{
						CountryTag = "MSI";
						break;
					}
				case "Nupe":
					{
						CountryTag = "NUP";
						break;
					}
				case "Timbuktu":
					{
						CountryTag = "TMB";
						break;
					}
				case "Yao":
					{
						CountryTag = "YAO";
						break;
					}
				case "Yatenga":
					{
						CountryTag = "YAT";
						break;
					}
				case "Macina":
					{
						CountryTag = "ZAF";
						break;
					}
				case "Zazzau":
					{
						CountryTag = "ZZZ";
						break;
					}
				case "Ndongo":
					{
						CountryTag = "NDO";
						break;
					}
				case "Ava":
					{
						CountryTag = "AVA";
						break;
					}
				case "Hsenwi":
					{
						CountryTag = "HSE";
						break;
					}
				case "Johor":
					{
						CountryTag = "JOH";
						break;
					}
				case "Kedah":
					{
						CountryTag = "KED";
						break;
					}
				case "Ligor":
					{
						CountryTag = "LIG";
						break;
					}
				case "Muan Phuang":
					{
						CountryTag = "MPH";
						break;
					}
				case "Mong Yang":
					{
						CountryTag = "MYA";
						break;
					}
				case "Perak":
					{
						CountryTag = "PRK";
						break;
					}
				case "Mong Mao":
					{
						CountryTag = "MMA";
						break;
					}
				case "Mong Kawng":
					{
						CountryTag = "MKA";
						break;
					}
				case "Mong Pai":
					{
						CountryTag = "MPA";
						break;
					}
				case "Mong Nai":
					{
						CountryTag = "MNI";
						break;
					}
				case "Kale":
					{
						CountryTag = "KAL";
						break;
					}
				case "Hsipaw":
					{
						CountryTag = "HSI";
						break;
					}
				case "Prome":
					{
						CountryTag = "BPR";
						break;
					}
				case "Chukchi":
					{
						CountryTag = "CHU";
						break;
					}
				case "Khodynt":
					{
						CountryTag = "HOD";
						break;
					}
				case "Chavchuveny":
					{
						CountryTag = "CHV";
						break;
					}
				case "Kamchadals":
					{
						CountryTag = "KMC";
						break;
					}
				case "Buryatia":
					{
						CountryTag = "BRT";
						break;
					}
				case "Arapaho":
					{
						CountryTag = "ARP";
						break;
					}
				case "Colima":
					{
						CountryTag = "CLM";
						break;
					}
				case "Chinook":
					{
						CountryTag = "CNK";
						break;
					}
				case "Cocomes":
					{
						CountryTag = "COC";
						break;
					}
				case "Haida":
					{
						CountryTag = "HDA";
						break;
					}
				case "Itza":
					{
						CountryTag = "ITZ";
						break;
					}
				case "Kiche":
					{
						CountryTag = "KIC";
						break;
					}
				case "Kiowa":
					{
						CountryTag = "KIO";
						break;
					}
				case "Mixtec":
					{
						CountryTag = "MIX";
						break;
					}
				case "Salish":
					{
						CountryTag = "SAL";
						break;
					}
				case "Tarascan":
					{
						CountryTag = "TAR";
						break;
					}
				case "Tlapanec":
					{
						CountryTag = "TLA";
						break;
					}
				case "Tlaxcala":
					{
						CountryTag = "TLX";
						break;
					}
				case "Totonac":
					{
						CountryTag = "TOT";
						break;
					}
				case "Wichita":
					{
						CountryTag = "WIC";
						break;
					}
				case "Xiu":
					{
						CountryTag = "XIU";
						break;
					}
				case "Blambangan":
					{
						CountryTag = "BLM";
						break;
					}
				case "Buton":
					{
						CountryTag = "BTN";
						break;
					}
				case "Cirebon":
					{
						CountryTag = "CRB";
						break;
					}
				case "Demak":
					{
						CountryTag = "DMK";
						break;
					}
				case "Pagarruyung":
					{
						CountryTag = "PGR";
						break;
					}
				case "Palembang":
					{
						CountryTag = "PLB";
						break;
					}
				case "Pasai":
					{
						CountryTag = "PSA";
						break;
					}
				case "Siak":
					{
						CountryTag = "SAK";
						break;
					}
				case "Sunda":
					{
						CountryTag = "SUN";
						break;
					}
				case "Kutai":
					{
						CountryTag = "KUT";
						break;
					}
				case "Banjar":
					{
						CountryTag = "BNJ";
						break;
					}
				case "Lanfang":
					{
						CountryTag = "LFA";
						break;
					}
				case "Lanao":
					{
						CountryTag = "LNO";
						break;
					}
				case "Luwu":
					{
						CountryTag = "LUW";
						break;
					}
				case "Maguindanao":
					{
						CountryTag = "MGD";
						break;
					}
				case "Ternate":
					{
						CountryTag = "TER";
						break;
					}
				case "Tidore":
					{
						CountryTag = "TID";
						break;
					}
				case "Madyas":
					{
						CountryTag = "MAS";
						break;
					}
				case "Pangasinan":
					{
						CountryTag = "PGS";
						break;
					}
				case "Tondo":
					{
						CountryTag = "TDO";
						break;
					}
				case "Maynila":
					{
						CountryTag = "MNA";
						break;
					}
				case "Cebu":
					{
						CountryTag = "CEB";
						break;
					}
				case "Butuan":
					{
						CountryTag = "BTU";
						break;
					}
				case "Cusco":
					{
						CountryTag = "CSU";
						break;
					}
				case "Calchaqui":
					{
						CountryTag = "CCQ";
						break;
					}
				case "Mapuche":
					{
						CountryTag = "MPC";
						break;
					}
				case "Muisca":
					{
						CountryTag = "MCA";
						break;
					}
				case "Quito":
					{
						CountryTag = "QTO";
						break;
					}
				case "Cajamarca":
					{
						CountryTag = "CJA";
						break;
					}
				case "Huyla":
					{
						CountryTag = "HJA";
						break;
					}
				case "Potiguara":
					{
						CountryTag = "PTG";
						break;
					}
				case "Tupiniquim":
					{
						CountryTag = "TPQ";
						break;
					}
				case "Tupinamba":
					{
						CountryTag = "TPA";
						break;
					}
				case "Tapuia":
					{
						CountryTag = "TUA";
						break;
					}
				case "Guarani":
					{
						CountryTag = "GUA";
						break;
					}
				case "Charrua":
					{
						CountryTag = "CUA";
						break;
					}
				case "Wanka":
					{
						CountryTag = "WKA";
						break;
					}
				case "Chachapoya":
					{
						CountryTag = "CYA";
						break;
					}
				case "Colla":
					{
						CountryTag = "CLA";
						break;
					}
				case "Charca":
					{
						CountryTag = "CRA";
						break;
					}
				case "Pacajes":
					{
						CountryTag = "PCJ";
						break;
					}
				case "Arawak":
					{
						CountryTag = "ARW";
						break;
					}
				case "Carib":
					{
						CountryTag = "CAB";
						break;
					}
				case "Ichma":
					{
						CountryTag = "ICM";
						break;
					}
				case "Matlatzinca":
					{
						CountryTag = "MAT";
						break;
					}
				case "Coixtlahuaca":
					{
						CountryTag = "COI";
						break;
					}
				case "Teotitlan":
					{
						CountryTag = "TEO";
						break;
					}
				case "Xalisco":
					{
						CountryTag = "XAL";
						break;
					}
				case "Guamar":
					{
						CountryTag = "GAM";
						break;
					}
				case "Huastec":
					{
						CountryTag = "HST";
						break;
					}
				case "Chichimeca":
					{
						CountryTag = "CCM";
						break;
					}
				case "Otomi":
					{
						CountryTag = "OTO";
						break;
					}
				case "Yokotan":
					{
						CountryTag = "YOK";
						break;
					}
				case "Tzotzil":
					{
						CountryTag = "LAC";
						break;
					}
				case "Kaqchikel":
					{
						CountryTag = "KAQ";
						break;
					}
				case "Chactemal":
					{
						CountryTag = "CTM";
						break;
					}
				case "Keres":
					{
						CountryTag = "KER";
						break;
					}
				case "Zuni":
					{
						CountryTag = "ZNI";
						break;
					}
				case "Mescalero":
					{
						CountryTag = "MSC";
						break;
					}
				case "Lipan":
					{
						CountryTag = "LIP";
						break;
					}
				case "Chorti":
					{
						CountryTag = "CHT";
						break;
					}
				case "Miskito":
					{
						CountryTag = "MIS";
						break;
					}
				case "Tairona":
					{
						CountryTag = "TAI";
						break;
					}
				case "Can Pech":
					{
						CountryTag = "CNP";
						break;
					}
				case "Tonala":
					{
						CountryTag = "TON";
						break;
					}
				case "Yaqui":
					{
						CountryTag = "YAQ";
						break;
					}
				case "Yokuts":
					{
						CountryTag = "YKT";
						break;
					}
				case "New Providence":
					{
						CountryTag = "NSS";
						break;
					}
				case "Port Royal":
					{
						CountryTag = "PRY";
						break;
					}
				case "Tortuga":
					{
						CountryTag = "TOR";
						break;
					}
				case "Libertatia":
					{
						CountryTag = "LIB";
						break;
					}
				case "Munich":
					{
						CountryTag = "UBV";
						break;
					}
				case "Landshut":
					{
						CountryTag = "LBV";
						break;
					}
				case "Ingolstadt":
					{
						CountryTag = "ING";
						break;
					}
				case "Passau":
					{
						CountryTag = "PSS";
						break;
					}
				case "Bregenz":
					{
						CountryTag = "MBZ";
						break;
					}
				case "Konstanz":
					{
						CountryTag = "KNZ";
						break;
					}
				case "Rothenburg":
					{
						CountryTag = "ROT";
						break;
					}
				case "Bayreuth":
					{
						CountryTag = "BYT";
						break;
					}
				case "Regensburg":
					{
						CountryTag = "REG";
						break;
					}
				case "Geneva":
					{
						CountryTag = "GNV";
						break;
					}
				case "Three Leagues":
					{
						CountryTag = "TTL";
						break;
					}
				case "Opole":
					{
						CountryTag = "OPL";
						break;
					}
				case "Glogow":
					{
						CountryTag = "GLG";
						break;
					}
				case "Bologna":
					{
						CountryTag = "BLG";
						break;
					}
				case "Padua":
					{
						CountryTag = "PDV";
						break;
					}
				case "Saluzzo":
					{
						CountryTag = "SZO";
						break;
					}
				case "Spoleto":
					{
						CountryTag = "SPL";
						break;
					}
				case "Wolgast":
					{
						CountryTag = "WOL";
						break;
					}
				case "Stettin":
					{
						CountryTag = "STE";
						break;
					}
				case "Goslar":
					{
						CountryTag = "GOS";
						break;
					}
				case "Lusatia":
					{
						CountryTag = "SOR";
						break;
					}
				case "Rügen":
					{
						CountryTag = "RUG";
						break;
					}
				case "Cilli":
					{
						CountryTag = "CLI";
						break;
					}
				case "Herzegovina":
					{
						CountryTag = "HRZ";
						break;
					}
				case "Trent":
					{
						CountryTag = "TNT";
						break;
					}
				case "Berg":
					{
						CountryTag = "BRG";
						break;
					}
				case "Mulhouse":
					{
						CountryTag = "MLH";
						break;
					}
				case "Bamberg":
					{
						CountryTag = "BAM";
						break;
					}
				case "Ruppin":
					{
						CountryTag = "RUP";
						break;
					}
				case "Lippe":
					{
						CountryTag = "LPP";
						break;
					}
				case "Paderborn":
					{
						CountryTag = "PAD";
						break;
					}
				case "Calenberg":
					{
						CountryTag = "CLB";
						break;
					}
				case "Donauwörth":
					{
						CountryTag = "DWT";
						break;
					}
				case "Osnabrück":
					{
						CountryTag = "OSN";
						break;
					}
				case "Verona":
					{
						CountryTag = "VRN";
						break;
					}
				case "Coburg":
					{
						CountryTag = "COB";
						break;
					}
				case "Lotharingia":
					{
						CountryTag = "LOT";
						break;
					}
				case "Perugia":
					{
						CountryTag = "PGA";
						break;
					}
				case "Two Sicilies":
					{
						CountryTag = "TTS";
						break;
					}
				case "Franconia":
					{
						CountryTag = "FKN";
						break;
					}
				case "Swabia":
					{
						CountryTag = "SWA";
						break;
					}
				case "Jan Mayen":
					{
						CountryTag = "JMN";
						break;
					}
				case "Roman Empire":
					{
						CountryTag = "ROM";
						break;
					}
				case "Synthetics":
					{
						CountryTag = "SYN";
						break;
					}
				case "Jomsvikings":
					{
						CountryTag = "JOM";
						break;
					}
				case "Hashashin":
					{
						CountryTag = "HAH";
						break;
					}
				case "Israel":
					{
						CountryTag = "ISR";
						break;
					}
				case "Knights Templar":
					{
						CountryTag = "TEM";
						break;
					}
				case "Trapalanda":
					{
						CountryTag = "TRL";
						break;
					}
				default:
					{
						break;
					}
			}
			countryTag = CountryTag;
		}	
	}
}
