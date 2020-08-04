using System;
using HtmlAgilityPack;

namespace osurankedsscorescraper
{
    public enum Countries
    {
        Afghanistan,
        AlandIslands,
        Albania,
        Algeria,
        AmericanSamoa,
        Andorra,
        Angola,
        Anguilla,
        AntiguaandBarbuda,
        Argentina,
        Armenia,
        Aruba,
        AsiaPacificRegion,
        Australia,
        Austria,
        Azerbaijan,
        Bahamas,
        Bahrain,
        Bangladesh,
        Barbados,
        Belarus,
        Belgium,
        Belize,
        Benin,
        Bermuda,
        Bhutan,
        Bolivia,
        BosniaandHerzegovina,
        Botswana,
        Brazil,
        Brunei,
        Bulgaria,
        BurkinaFaso,
        Burundi,
        CaboVerde,
        Cambodia,
        Cameroon,
        Canada,
        CaymanIslands,
        CentralAfricanRepublic,
        Chad,
        Chile,
        China,
        ChristmasIsland,
        CocosKeelingIslands,
        Colombia,
        Comoros,
        Congo,
        CongoTheDemocraticRepublicofthe,
        CookIslands,
        CostaRica,
        CoteDIvoire,
        Croatia,
        Cuba,
        Curaçao,
        Cyprus,
        CzechRepublic,
        Denmark,
        Djibouti,
        Dominica,
        DominicanRepublic,
        Ecuador,
        Egypt,
        ElSalvador,
        EquatorialGuinea,
        Eritrea,
        Estonia,
        Eswatini,
        Ethiopia,
        Europe,
        FalklandIslandsMalvinas,
        FaroeIslands,
        Fiji,
        Finland,
        France,
        FrenchGuiana,
        FrenchPolynesia,
        Gabon,
        Gambia,
        Georgia,
        Germany,
        Ghana,
        Gibraltar,
        Greece,
        Greenland,
        Grenada,
        Guadeloupe,
        Guam,
        Guatemala,
        Guernsey,
        Guinea,
        Guyana,
        Haiti,
        HeardIslandandMcDonaldIslands,
        Honduras,
        HongKong,
        Hungary,
        Iceland,
        India,
        Indonesia,
        IranIslamicRepublicof,
        Iraq,
        Ireland,
        IsleofMan,
        Israel,
        Italy,
        Jamaica,
        Japan,
        Jersey,
        Jordan,
        Kazakhstan,
        Kenya,
        Kiribati,
        Kosovo,
        Kuwait,
        Kyrgyzstan,
        LaoPeoplesDemocraticRepublic,
        Latvia,
        Lebanon,
        Lesotho,
        Liberia,
        Libya,
        Liechtenstein,
        Lithuania,
        Luxembourg,
        Macau,
        Madagascar,
        Malawi,
        Malaysia,
        Maldives,
        Mali,
        Malta,
        MarshallIslands,
        Martinique,
        Mauritania,
        Mauritius,
        Mayotte,
        Mexico,
        MicronesiaFederatedStatesof,
        Moldova,
        Monaco,
        Mongolia,
        Montenegro,
        Montserrat,
        Morocco,
        Mozambique,
        Myanmar,
        Namibia,
        Nauru,
        Nepal,
        Netherlands,
        NetherlandsAntilles,
        NewCaledonia,
        NewZealand,
        Nicaragua,
        Niger,
        Nigeria,
        Niue,
        NorfolkIsland,
        NorthKorea,
        NorthernMarianaIslands,
        NorthMacedonia,
        Norway,
        Oman,
        Pakistan,
        Palau,
        PalestinianTerritoryOccupied,
        Panama,
        PapuaNewGuinea,
        Paraguay,
        Peru,
        Philippines,
        Pitcairn,
        Poland,
        Portugal,
        PuertoRico,
        Qatar,
        Reunion,
        Romania,
        RussianFederation,
        Rwanda,
        SaintBarthelemy,
        SaintHelena,
        SaintKittsandNevis,
        SaintLucia,
        SaintMartin,
        SaintPierreandMiquelon,
        SaintVincentandtheGrenadines,
        Samoa,
        SanMarino,
        SaoTomeandPrincipe,
        SaudiArabia,
        Senegal,
        Serbia,
        Seychelles,
        SierraLeone,
        Singapore,
        Slovakia,
        Slovenia,
        SolomonIslands,
        Somalia,
        SouthAfrica,
        SouthKorea,
        Spain,
        SriLanka,
        Sudan,
        Suriname,
        SvalbardandJanMayen,
        Sweden,
        Switzerland,
        SyrianArabRepublic,
        Taiwan,
        Tajikistan,
        TanzaniaUnitedRepublicof,
        Thailand,
        TimorLeste,
        Togo,
        Tokelau,
        Tonga,
        TrinidadandTobago,
        Tunisia,
        Turkey,
        Turkmenistan,
        TurksandCaicosIslands,
        Tuvalu,
        Uganda,
        Ukraine,
        UnitedArabEmirates,
        UnitedKingdom,
        UnitedStates,
        Uruguay,
        Uzbekistan,
        Vanuatu,
        VaticanCity,
        Venezuela,
        Vietnam,
        VirginIslandsBritish,
        VirginIslandsUS,
        Yemen,
        Zambia,
        Zimbabwe
    }

    static class CountryHelpers
    {
        public static Countries ParseCountry(HtmlNode inputNode)
        {
            // PARSE FLAG
            string flagname = "";
            
            //BIG OL SWITCH STATEMENT TIME
            switch (flagname)
            {
                case "AD": return Countries.Andorra;
                case "AE": return Countries.UnitedArabEmirates;
                case "AF": return Countries.Afghanistan;
                case "AG": return Countries.AntiguaandBarbuda;
                case "AI": return Countries.Anguilla;
                case "AL": return Countries.Albania;
                case "AM": return Countries.Armenia;
                case "AN": return Countries.NetherlandsAntilles;
                case "AO": return Countries.Angola;
                case "AR": return Countries.Argentina;
                case "AS": return Countries.AmericanSamoa;
                case "AT": return Countries.Austria;
                case "AU": return Countries.Australia;
                case "AW": return Countries.Aruba;
                case "AX": return Countries.AlandIslands;
                case "AZ": return Countries.Azerbaijan;
                case "BA": return Countries.BosniaandHerzegovina;
                case "BB": return Countries.Barbados;
                case "BD": return Countries.Bangladesh;
                case "BE": return Countries.Belgium;
                case "BF": return Countries.BurkinaFaso;
                case "BG": return Countries.Bulgaria;
                case "BH": return Countries.Bahrain;
                case "BI": return Countries.Burundi;
                case "BJ": return Countries.Benin;
                case "BL": return Countries.SaintBarthelemy;
                case "BM": return Countries.Bermuda;
                case "BN": return Countries.Brunei;
                case "BO": return Countries.Bolivia;
                case "BR": return Countries.Brazil;
                case "BS": return Countries.Bahamas;
                case "BT": return Countries.Bhutan;
                case "BW": return Countries.Botswana;
                case "BY": return Countries.Belarus;
                case "BZ": return Countries.Belize;
                case "CA": return Countries.Canada;
                case "CD": return Countries.CongoTheDemocraticRepublicofthe;
                case "CF": return Countries.CentralAfricanRepublic;
                case "CG": return Countries.Congo;
                case "CH": return Countries.Switzerland;
                case "CI": return Countries.CoteDIvoire;
                case "CL": return Countries.Chile;
                case "CM": return Countries.Cameroon;
                case "CN": return Countries.China;
                case "CO": return Countries.Colombia;
                case "CR": return Countries.CostaRica;
                case "CU": return Countries.Cuba;
                case "CV": return Countries.CaboVerde;
                case "CX": return Countries.ChristmasIsland;
                case "CY": return Countries.Cyprus;
                case "CZ": return Countries.CzechRepublic;
                case "DE": return Countries.Germany;
                case "DJ": return Countries.Djibouti;
                case "DK": return Countries.Denmark;
                case "DM": return Countries.Dominica;
                case "DO": return Countries.DominicanRepublic;
                case "DZ": return Countries.Algeria;
                case "EC": return Countries.Ecuador;
                case "EE": return Countries.Estonia;
                case "EG": return Countries.Egypt;
                case "ER": return Countries.Eritrea;
                case "ES": return Countries.Spain;
                case "ET": return Countries.Ethiopia;
                case "EU": return Countries.Europe;
                case "FI": return Countries.Finland;
                case "FJ": return Countries.Fiji;
                case "FK": return Countries.FalklandIslandsMalvinas;
                case "FM": return Countries.MicronesiaFederatedStatesof;
                case "FO": return Countries.FaroeIslands;
                case "FR": return Countries.France;
                case "GA": return Countries.Gabon;
                case "GB": return Countries.UnitedKingdom;
                case "GD": return Countries.Grenada;
                case "GE": return Countries.Georgia;
                case "GF": return Countries.FrenchGuiana;
                case "GG": return Countries.Guernsey;
                case "GH": return Countries.Ghana;
                case "GI": return Countries.Gibraltar;
                case "GL": return Countries.Greenland;
                case "GM": return Countries.Gambia;
                case "GN": return Countries.Guinea;
                case "GP": return Countries.Guadeloupe;
                case "GQ": return Countries.EquatorialGuinea;
                case "GR": return Countries.Greece;
                case "GT": return Countries.Guatemala;
                case "GU": return Countries.Guam;
                case "GW": return Countries.Guinea;
                case "GY": return Countries.Guyana;
                case "HK": return Countries.HongKong;
                case "HM": return Countries.HeardIslandandMcDonaldIslands;
                case "HN": return Countries.Honduras;
                case "HR": return Countries.Croatia;
                case "HT": return Countries.Haiti;
                case "HU": return Countries.Hungary;
                case "ID": return Countries.Indonesia;
                case "IE": return Countries.Ireland;
                case "IL": return Countries.Israel;
                case "IM": return Countries.IsleofMan;
                case "IN": return Countries.India;
                case "IQ": return Countries.Iraq;
                case "IR": return Countries.IranIslamicRepublicof;
                case "IS": return Countries.Iceland;
                case "IT": return Countries.Italy;
                case "JE": return Countries.Jersey;
                case "JM": return Countries.Jamaica;
                case "JO": return Countries.Jordan;
                case "JP": return Countries.Japan;
                case "KE": return Countries.Kenya;
                case "KG": return Countries.Kyrgyzstan;
                case "KH": return Countries.Cambodia;
                case "KI": return Countries.Kiribati;
                case "KM": return Countries.Comoros;
                case "KN": return Countries.SaintKittsandNevis;
                case "KP": return Countries.NorthKorea;
                case "KR": return Countries.SouthKorea;
                case "KW": return Countries.Kuwait;
                case "KY": return Countries.CaymanIslands;
                case "KZ": return Countries.Kazakhstan;
                case "LA": return Countries.LaoPeoplesDemocraticRepublic;
                case "LB": return Countries.Lebanon;
                case "LC": return Countries.SaintLucia;
                case "LI": return Countries.Liechtenstein;
                case "LK": return Countries.SriLanka;
                case "LR": return Countries.Liberia;
                case "LS": return Countries.Lesotho;
                case "LT": return Countries.Lithuania;
                case "LU": return Countries.Luxembourg;
                case "LV": return Countries.Latvia;
                case "LY": return Countries.Libya;
                case "MA": return Countries.Morocco;
                case "MC": return Countries.Monaco;
                case "MD": return Countries.Moldova;
                case "ME": return Countries.Montenegro;
                case "MF": return Countries.SaintMartin;
                case "MG": return Countries.Madagascar;
                case "MH": return Countries.MarshallIslands;
                case "MK": return Countries.NorthMacedonia;
                case "ML": return Countries.Mali;
                case "MM": return Countries.Myanmar;
                case "MN": return Countries.Mongolia;
                case "MO": return Countries.Macau;
                case "MP": return Countries.NorthernMarianaIslands;
                case "MQ": return Countries.Martinique;
                case "MR": return Countries.Mauritania;
                case "MS": return Countries.Montserrat;
                case "MT": return Countries.Malta;
                case "MU": return Countries.Mauritius;
                case "MV": return Countries.Maldives;
                case "MW": return Countries.Malawi;
                case "MX": return Countries.Mexico;
                case "MY": return Countries.Malaysia;
                case "MZ": return Countries.Mozambique;
                case "NA": return Countries.Namibia;
                case "NC": return Countries.NewCaledonia;
                case "NE": return Countries.Niger;
                case "NF": return Countries.NorfolkIsland;
                case "NG": return Countries.Nigeria;
                case "NI": return Countries.Nicaragua;
                case "NL": return Countries.Netherlands;
                case "NO": return Countries.Norway;
                case "NP": return Countries.Nepal;
                case "NR": return Countries.Nauru;
                case "NU": return Countries.Niue;
                case "NZ": return Countries.NewZealand;
                case "OM": return Countries.Oman;
                case "PA": return Countries.Panama;
                case "PE": return Countries.Peru;
                case "PF": return Countries.FrenchPolynesia;
                case "PG": return Countries.PapuaNewGuinea;
                case "PH": return Countries.Philippines;
                case "PK": return Countries.Pakistan;
                case "PL": return Countries.Poland;
                case "PM": return Countries.SaintPierreandMiquelon;
                case "PN": return Countries.Pitcairn;
                case "PR": return Countries.PuertoRico;
                case "PS": return Countries.PalestinianTerritoryOccupied;
                case "PT": return Countries.Portugal;
                case "PW": return Countries.Palau;
                case "PY": return Countries.Paraguay;
                case "QA": return Countries.Qatar;
                case "RE": return Countries.Reunion;
                case "RO": return Countries.Romania;
                case "RS": return Countries.Serbia;
                case "RU": return Countries.RussianFederation;
                case "RW": return Countries.Rwanda;
                case "SA": return Countries.SaudiArabia;
                case "SB": return Countries.SolomonIslands;
                case "SC": return Countries.Seychelles;
                case "SD": return Countries.Sudan;
                case "SE": return Countries.Sweden;
                case "SG": return Countries.Singapore;
                case "SH": return Countries.SaintHelena;
                case "SI": return Countries.Slovenia;
                case "SJ": return Countries.SvalbardandJanMayen;
                case "SK": return Countries.Slovakia;
                case "SL": return Countries.SierraLeone;
                case "SM": return Countries.SanMarino;
                case "SN": return Countries.Senegal;
                case "SO": return Countries.Somalia;
                case "SR": return Countries.Suriname;
                case "ST": return Countries.SaoTomeandPrincipe;
                case "SV": return Countries.ElSalvador;
                case "SY": return Countries.SyrianArabRepublic;
                case "SZ": return Countries.Eswatini;
                case "TC": return Countries.TurksandCaicosIslands;
                case "TD": return Countries.Chad;
                case "TG": return Countries.Togo;
                case "TH": return Countries.Thailand;
                case "TJ": return Countries.Tajikistan;
                case "TL": return Countries.TimorLeste;
                case "TM": return Countries.Turkmenistan;
                case "TN": return Countries.Tunisia;
                case "TO": return Countries.Tonga;
                case "TR": return Countries.Turkey;
                case "TT": return Countries.TrinidadandTobago;
                case "TV": return Countries.Tuvalu;
                case "TW": return Countries.Taiwan;
                case "TZ": return Countries.TanzaniaUnitedRepublicof;
                case "UA": return Countries.Ukraine;
                case "UG": return Countries.Uganda;
                case "US": return Countries.UnitedStates;
                case "UY": return Countries.Uruguay;
                case "UZ": return Countries.Uzbekistan;
                case "VA": return Countries.VaticanCity;
                case "VC": return Countries.SaintVincentandtheGrenadines;
                case "VE": return Countries.Venezuela;
                case "VG": return Countries.VirginIslandsBritish;
                case "VI": return Countries.VirginIslandsUS;
                case "VN": return Countries.Vietnam;
                case "VU": return Countries.Vanuatu;
                case "WS": return Countries.Samoa;
                case "YE": return Countries.Yemen;
                case "YT": return Countries.Mayotte;
                case "ZA": return Countries.SouthAfrica;
                case "ZM": return Countries.Zambia;
                case "ZW": return Countries.Zimbabwe;
                default: throw new ArgumentOutOfRangeException(nameof(flagname), flagname, null);
            }
        }

        public static string GetFancyText(Countries country)
        {
            switch (country)
            {
                case Countries.Afghanistan: return "Afghanistan";
                case Countries.AlandIslands: return "Aland Islands";
                case Countries.Albania: return "Albania";
                case Countries.Algeria: return "Algeria";
                case Countries.AmericanSamoa: return "American Samoa";
                case Countries.Andorra: return "Andorra";
                case Countries.Angola: return "Angola";
                case Countries.Anguilla: return "Anguilla";
                case Countries.AntiguaandBarbuda: return "Antigua and Barbuda";
                case Countries.Argentina: return "Argentina";
                case Countries.Armenia: return "Armenia";
                case Countries.Aruba: return "Aruba";
                case Countries.AsiaPacificRegion: return "Asia/Pacific Region";
                case Countries.Australia: return "Australia";
                case Countries.Austria: return "Austria";
                case Countries.Azerbaijan: return "Azerbaijan";
                case Countries.Bahamas: return "Bahamas";
                case Countries.Bahrain: return "Bahrain";
                case Countries.Bangladesh: return "Bangladesh";
                case Countries.Barbados: return "Barbados";
                case Countries.Belarus: return "Belarus";
                case Countries.Belgium: return "Belgium";
                case Countries.Belize: return "Belize";
                case Countries.Benin: return "Benin";
                case Countries.Bermuda: return "Bermuda";
                case Countries.Bhutan: return "Bhutan";
                case Countries.Bolivia: return "Bolivia";
                case Countries.BosniaandHerzegovina: return "Bosnia and Herzegovina";
                case Countries.Botswana: return "Botswana";
                case Countries.Brazil: return "Brazil";
                case Countries.Brunei: return "Brunei";
                case Countries.Bulgaria: return "Bulgaria";
                case Countries.BurkinaFaso: return "Burkina Faso";
                case Countries.Burundi: return "Burundi";
                case Countries.CaboVerde: return "Cabo Verde";
                case Countries.Cambodia: return "Cambodia";
                case Countries.Cameroon: return "Cameroon";
                case Countries.Canada: return "Canada";
                case Countries.CaymanIslands: return "Cayman Islands";
                case Countries.CentralAfricanRepublic: return "Central African Republic";
                case Countries.Chad: return "Chad";
                case Countries.Chile: return "Chile";
                case Countries.China: return "China";
                case Countries.ChristmasIsland: return "Christmas Island";
                case Countries.CocosKeelingIslands: return "Cocos (Keeling) Islands";
                case Countries.Colombia: return "Colombia";
                case Countries.Comoros: return "Comoros";
                case Countries.Congo: return "Congo";
                case Countries.CongoTheDemocraticRepublicofthe: return "Congo, The Democratic Republic of the";
                case Countries.CookIslands: return "Cook Islands";
                case Countries.CostaRica: return "Costa Rica";
                case Countries.CoteDIvoire: return "Cote D'Ivoire";
                case Countries.Croatia: return "Croatia";
                case Countries.Cuba: return "Cuba";
                case Countries.Curaçao: return "Curaçao";
                case Countries.Cyprus: return "Cyprus";
                case Countries.CzechRepublic: return "Czech Republic";
                case Countries.Denmark: return "Denmark";
                case Countries.Djibouti: return "Djibouti";
                case Countries.Dominica: return "Dominica";
                case Countries.DominicanRepublic: return "Dominican Republic";
                case Countries.Ecuador: return "Ecuador";
                case Countries.Egypt: return "Egypt";
                case Countries.ElSalvador: return "El Salvador";
                case Countries.EquatorialGuinea: return "Equatorial Guinea";
                case Countries.Eritrea: return "Eritrea";
                case Countries.Estonia: return "Estonia";
                case Countries.Eswatini: return "Eswatini";
                case Countries.Ethiopia: return "Ethiopia";
                case Countries.Europe: return "Europe";
                case Countries.FalklandIslandsMalvinas: return "Falkland Islands (Malvinas)";
                case Countries.FaroeIslands: return "Faroe Islands";
                case Countries.Fiji: return "Fiji";
                case Countries.Finland: return "Finland";
                case Countries.France: return "France";
                case Countries.FrenchGuiana: return "French Guiana";
                case Countries.FrenchPolynesia: return "French Polynesia";
                case Countries.Gabon: return "Gabon";
                case Countries.Gambia: return "Gambia";
                case Countries.Georgia: return "Georgia";
                case Countries.Germany: return "Germany";
                case Countries.Ghana: return "Ghana";
                case Countries.Gibraltar: return "Gibraltar";
                case Countries.Greece: return "Greece";
                case Countries.Greenland: return "Greenland";
                case Countries.Grenada: return "Grenada";
                case Countries.Guadeloupe: return "Guadeloupe";
                case Countries.Guam: return "Guam";
                case Countries.Guatemala: return "Guatemala";
                case Countries.Guernsey: return "Guernsey";
                case Countries.Guinea: return "Guinea";
                case Countries.Guyana: return "Guyana";
                case Countries.Haiti: return "Haiti";
                case Countries.HeardIslandandMcDonaldIslands: return "Heard Island and McDonald Islands";
                case Countries.Honduras: return "Honduras";
                case Countries.HongKong: return "Hong Kong";
                case Countries.Hungary: return "Hungary";
                case Countries.Iceland: return "Iceland";
                case Countries.India: return "India";
                case Countries.Indonesia: return "Indonesia";
                case Countries.IranIslamicRepublicof: return "Iran, Islamic Republic of";
                case Countries.Iraq: return "Iraq";
                case Countries.Ireland: return "Ireland";
                case Countries.IsleofMan: return "Isle of Man";
                case Countries.Israel: return "Israel";
                case Countries.Italy: return "Italy";
                case Countries.Jamaica: return "Jamaica";
                case Countries.Japan: return "Japan";
                case Countries.Jersey: return "Jersey";
                case Countries.Jordan: return "Jordan";
                case Countries.Kazakhstan: return "Kazakhstan";
                case Countries.Kenya: return "Kenya";
                case Countries.Kiribati: return "Kiribati";
                case Countries.Kosovo: return "Kosovo";
                case Countries.Kuwait: return "Kuwait";
                case Countries.Kyrgyzstan: return "Kyrgyzstan";
                case Countries.LaoPeoplesDemocraticRepublic: return "Lao People's Democratic Republic";
                case Countries.Latvia: return "Latvia";
                case Countries.Lebanon: return "Lebanon";
                case Countries.Lesotho: return "Lesotho";
                case Countries.Liberia: return "Liberia";
                case Countries.Libya: return "Libya";
                case Countries.Liechtenstein: return "Liechtenstein";
                case Countries.Lithuania: return "Lithuania";
                case Countries.Luxembourg: return "Luxembourg";
                case Countries.Macau: return "Macau";
                case Countries.Madagascar: return "Madagascar";
                case Countries.Malawi: return "Malawi";
                case Countries.Malaysia: return "Malaysia";
                case Countries.Maldives: return "Maldives";
                case Countries.Mali: return "Mali";
                case Countries.Malta: return "Malta";
                case Countries.MarshallIslands: return "Marshall Islands";
                case Countries.Martinique: return "Martinique";
                case Countries.Mauritania: return "Mauritania";
                case Countries.Mauritius: return "Mauritius";
                case Countries.Mayotte: return "Mauritius";
                case Countries.Mexico: return "Mexico";
                case Countries.MicronesiaFederatedStatesof: return "Micronesia, Federated States of";
                case Countries.Moldova: return "Moldova";
                case Countries.Monaco: return "Monaco";
                case Countries.Mongolia: return "Mongolia";
                case Countries.Montenegro: return "Montenegro";
                case Countries.Montserrat: return "Montserrat";
                case Countries.Morocco: return "Morocco";
                case Countries.Mozambique: return "Mozambique";
                case Countries.Myanmar: return "Myanmar";
                case Countries.Namibia: return "Namibia";
                case Countries.Nauru: return "Nauru";
                case Countries.Nepal: return "Nepal";
                case Countries.Netherlands: return "Netherlands";
                case Countries.NetherlandsAntilles: return "Netherlands Antilles";
                case Countries.NewCaledonia: return "New Caledonia";
                case Countries.NewZealand: return "New Zealand";
                case Countries.Nicaragua: return "Nicaragua";
                case Countries.Niger: return "Niger";
                case Countries.Nigeria: return "Nigeria";
                case Countries.Niue: return "Niue";
                case Countries.NorfolkIsland: return "Norfolk Island";
                case Countries.NorthKorea: return "North Korea";
                case Countries.NorthernMarianaIslands: return "Northern Mariana Islands";
                case Countries.NorthMacedonia: return "North Macedonia";
                case Countries.Norway: return "Norway";
                case Countries.Oman: return "Oman";
                case Countries.Pakistan: return "Pakistan";
                case Countries.Palau: return "Palau";
                case Countries.PalestinianTerritoryOccupied: return "Palestinian Territory Occupied";
                case Countries.Panama: return "Panama";
                case Countries.PapuaNewGuinea: return "Papua New Guinea";
                case Countries.Paraguay: return "Paraguay";
                case Countries.Peru: return "Peru";
                case Countries.Philippines: return "Philippines";
                case Countries.Pitcairn: return "Pitcairn";
                case Countries.Poland: return "Poland";
                case Countries.Portugal: return "Portugal";
                case Countries.PuertoRico: return "Puerto Rico";
                case Countries.Qatar: return "Qatar";
                case Countries.Reunion: return "Reunion";
                case Countries.Romania: return "Romania";
                case Countries.RussianFederation: return "Russian Federation";
                case Countries.Rwanda: return "Rwanda";
                case Countries.SaintBarthelemy: return "Saint Barthelemy";
                case Countries.SaintHelena: return "Saint Helena";
                case Countries.SaintKittsandNevis: return "Saint Kitts and Nevis";
                case Countries.SaintLucia: return "Saint Lucia";
                case Countries.SaintMartin: return "Saint Martin";
                case Countries.SaintPierreandMiquelon: return "Saint Pierre and Miquelon";
                case Countries.SaintVincentandtheGrenadines: return "Saint Vincent and the Grenadines";
                case Countries.Samoa: return "Samoa";
                case Countries.SanMarino: return "San Marino";
                case Countries.SaoTomeandPrincipe: return "Sao Tome and Principe";
                case Countries.SaudiArabia: return "Saudi Arabia";
                case Countries.Senegal: return "Senegal";
                case Countries.Serbia: return "Serbia";
                case Countries.Seychelles: return "Seychelles";
                case Countries.SierraLeone: return "Sierra Leone";
                case Countries.Singapore: return "Singapore";
                case Countries.Slovakia: return "Slovakia";
                case Countries.Slovenia: return "Slovenia";
                case Countries.SolomonIslands: return "Solomon Islands";
                case Countries.Somalia: return "Somalia";
                case Countries.SouthAfrica: return "South Africa";
                case Countries.SouthKorea: return "South Korea";
                case Countries.Spain: return "Spain";
                case Countries.SriLanka: return "Sri Lanka";
                case Countries.Sudan: return "Sudan";
                case Countries.Suriname: return "Suriname";
                case Countries.SvalbardandJanMayen: return "Svalbard and Jan Mayen";
                case Countries.Sweden: return "Sweden";
                case Countries.Switzerland: return "Switzerland";
                case Countries.SyrianArabRepublic: return "Syrian Arab Republic";
                case Countries.Taiwan: return "Taiwan";
                case Countries.Tajikistan: return "Tajikistan";
                case Countries.TanzaniaUnitedRepublicof: return "Tanzania, United Republic of";
                case Countries.Thailand: return "Thailand";
                case Countries.TimorLeste: return "Timor-Leste";
                case Countries.Togo: return "Togo";
                case Countries.Tokelau: return "Tokelau";
                case Countries.Tonga: return "Tonga";
                case Countries.TrinidadandTobago: return "Tonga";
                case Countries.Tunisia: return "Tunisia";
                case Countries.Turkey: return "Turkey";
                case Countries.Turkmenistan: return "Turkmenistan";
                case Countries.TurksandCaicosIslands: return "Turks and Caicos Islands";
                case Countries.Tuvalu: return "Tuvalu";
                case Countries.Uganda: return "Uganda";
                case Countries.Ukraine: return "Ukraine";
                case Countries.UnitedArabEmirates: return "United Arab Emirates";
                case Countries.UnitedKingdom: return "United Kingdom";
                case Countries.UnitedStates: return "United States of America";
                case Countries.Uruguay: return "Uruguay";
                case Countries.Uzbekistan: return "Uzbekistan";
                case Countries.Vanuatu: return "Vanuatu";
                case Countries.VaticanCity: return "Vatican City";
                case Countries.Venezuela: return "Venezuela";
                case Countries.Vietnam: return "Vietnam";
                case Countries.VirginIslandsBritish: return "Virgin Islands, British";
                case Countries.VirginIslandsUS: return "Virgin Islands, U.S.";
                case Countries.Yemen: return "Yemen";
                case Countries.Zambia: return "Zambia";
                case Countries.Zimbabwe: return "Zimbabwe";
                default: throw new ArgumentOutOfRangeException(nameof(country), country, null);
            }
        }
    }
}