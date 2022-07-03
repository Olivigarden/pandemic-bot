using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandemicBot.Game
{
    class StandardBoard : IBoard
    {
        public List<Location> Locations;
        public StandardBoard()
        {
            GenerateMap();
        }

        private void GenerateMap()
        {
            var sanFrancisco = new Location("San Francisco");
            var chicago = new Location("Chicago");
            var montreal = new Location("Montreal");
            var newYork = new Location("New York");
            var london = new Location("London");
            var essen = new Location("Essen");
            var stPetersburg = new Location("St. Petersburg");
            var moscow = new Location("Moscow");
            var tehran = new Location("Tehran");
            var delhi = new Location("Delhi");
            var kolkata = new Location("Kolkata");
            var hongKong = new Location("Hong Kong");
            var shanghai = new Location("Shanghai");
            var beijing = new Location("Beijing");
            var seoul = new Location("Seoul");
            var tokyo = new Location("Tokyo");
            var osaka = new Location("Osaka");
            var taipei = new Location("Taipei");
            var manila = new Location("Manila");
            var sydney = new Location("Sydney");
            var jakarta = new Location("Jakarta");
            var chennai = new Location("Chennai");
            var mumbai = new Location("Mumbai");
            var karachi = new Location("Karachi");
            var riyadh = new Location("Riyadh");
            var cairo = new Location("Cairo");
            var khartoum = new Location("Khartoum");
            var johannesburg = new Location("Johannesburg");
            var kinshasa = new Location("Kinshasa");
            var lagos = new Location("Lagos");
            var saoPaulo = new Location("Sao Paulo");
            var buenosAires = new Location("Buenos Aires");
            var bogota = new Location("Bogota");
            var lima = new Location("Lima");
            var santiago = new Location("Santiago");
            var mexicoCity = new Location("Mexico City");
            var losAngeles = new Location("Los Angeles");
            var atlanta = new Location("Atlanta");
            var washington = new Location("Washington");
            var minmi = new Location("Minmi");
            var madrid = new Location("Madrid");
            var paris = new Location("Paris");
            var milan = new Location("Milan");
            var istanbul = new Location("Istanbul");
            var baghdad = new Location("Baghdad");
            var algiers = new Location("Algiers");
            var bangkok = new Location("Bangkok");
            var hoChiMinh = new Location("Ho Chi Minh City");

            sanFrancisco.AdjacentLocations.AddRange(new List<Location>() { tokyo, manila, chicago });
            chicago.AdjacentLocations.AddRange(new List<Location>() { sanFrancisco, losAngeles, mexicoCity, atlanta, montreal });
            montreal.AdjacentLocations.AddRange(new List<Location>() { chicago, washington, newYork });
            newYork.AdjacentLocations.AddRange(new List<Location>() { montreal, washington, london, madrid });
            london.AdjacentLocations.AddRange(new List<Location>() { newYork, madrid, paris, essen });
            essen.AdjacentLocations.AddRange(new List<Location>() { london, paris, milan, stPetersburg });
            stPetersburg.AdjacentLocations.AddRange(new List<Location>() { essen, istanbul, moscow });
            moscow.AdjacentLocations.AddRange(new List<Location>() { stPetersburg, istanbul, tehran });
            tehran.AdjacentLocations.AddRange(new List<Location>() { moscow, baghdad, karachi, delhi });
            delhi.AdjacentLocations.AddRange(new List<Location>() { tehran, karachi, mumbai, chennai, kolkata });
            kolkata.AdjacentLocations.AddRange(new List<Location>() { delhi, chennai, bangkok, hongKong });
            hongKong.AdjacentLocations.AddRange(new List<Location>() { kolkata, bangkok, hoChiMinh, manila, taipei, shanghai });
            shanghai.AdjacentLocations.AddRange(new List<Location>() { hongKong, taipei, tokyo, seoul, beijing });
            beijing.AdjacentLocations.AddRange(new List<Location>() { shanghai, seoul });
            seoul.AdjacentLocations.AddRange(new List<Location>() { beijing, shanghai, tokyo });
            tokyo.AdjacentLocations.AddRange(new List<Location>() { seoul, shanghai, osaka });
            osaka.AdjacentLocations.AddRange(new List<Location>() { tokyo, taipei });
            taipei.AdjacentLocations.AddRange(new List<Location>() { osaka, manila, hongKong, shanghai });
            manila.AdjacentLocations.AddRange(new List<Location>() { taipei, sanFrancisco, sydney, hoChiMinh, hongKong });
            sydney.AdjacentLocations.AddRange(new List<Location>() { manila, losAngeles, jakarta });
            jakarta.AdjacentLocations.AddRange(new List<Location>() { sydney, chennai, bangkok, hoChiMinh });
            chennai.AdjacentLocations.AddRange(new List<Location>() { jakarta, mumbai, delhi, kolkata, bangkok });
            mumbai.AdjacentLocations.AddRange(new List<Location>() { chennai, karachi, delhi });
            karachi.AdjacentLocations.AddRange(new List<Location>() { mumbai, riyadh, baghdad, tehran, delhi });
            sanFrancisco.AdjacentLocations.AddRange(new List<Location>() { tokyo, manila, chicago });
            sanFrancisco.AdjacentLocations.AddRange(new List<Location>() { tokyo, manila, chicago });
            sanFrancisco.AdjacentLocations.AddRange(new List<Location>() { tokyo, manila, chicago });
            sanFrancisco.AdjacentLocations.AddRange(new List<Location>() { tokyo, manila, chicago });
            sanFrancisco.AdjacentLocations.AddRange(new List<Location>() { tokyo, manila, chicago });
            sanFrancisco.AdjacentLocations.AddRange(new List<Location>() { tokyo, manila, chicago });
            sanFrancisco.AdjacentLocations.AddRange(new List<Location>() { tokyo, manila, chicago });
            sanFrancisco.AdjacentLocations.AddRange(new List<Location>() { tokyo, manila, chicago });
            sanFrancisco.AdjacentLocations.AddRange(new List<Location>() { tokyo, manila, chicago });
            sanFrancisco.AdjacentLocations.AddRange(new List<Location>() { tokyo, manila, chicago });
            sanFrancisco.AdjacentLocations.AddRange(new List<Location>() { tokyo, manila, chicago });
        }
    }
}
