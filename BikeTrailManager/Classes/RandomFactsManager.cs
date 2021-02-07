using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeTrailManager.Classes
{
    class RandomFactsManager
    {
        static List<string> randomFactsList = new List<string>();
        
        //returns random fact
        public static string GetRandomFact()
        {
            if (randomFactsList.Count < 1) return "Błąd, brak danych.";
            else return randomFactsList[new Random().Next(randomFactsList.Count)];
        }

        //adding random facts to list
        public static void LoadRandomFactsList()
        {
            randomFactsList.Add("Najlżejszy seryjnie produkowany rower na świecie waży zaledwie 4.56 kg. Jego nazwa to Merida Scultura Superelite, i kosztuje 55000 PLN.");
            randomFactsList.Add("Rekord prędkości na rowerze to 280.55 km/h. Ustanowił go Neil Campbell na lotnisku w Elvington poruszając się za specjalnym pojazdem niwelującym opór powietrza.");
            randomFactsList.Add("Pierwotne nazwy roweru to welocyped i bicykl.");
            randomFactsList.Add("Pierwszy prototyp roweru został zbudowany przez francuskiego hrabiego Mède de Sivrac w 1790 roku. Umożliwiał wyłącznie jazdę w jednym kierunku (nie dało się nim skręcać).");
            randomFactsList.Add("Twórcą współczesnego roweru jest niemiecki wynalazca Karl Drais. Pojazd, który opatentował w 1818 roku, nie posiadał pedałów (jechało się odpychając nogami od ziemi).");
            randomFactsList.Add("Rower górski powstał w latach 70. XX wieku, dzięki współpracy pięciu osób (Joe Breeze, Tom Ritchey, Charles Kelly, John Finnley Scott, Gary Fisher), a do produkcji został wypuszczony w 1978 roku.");
            randomFactsList.Add("Do 1888 roku jeżdżono na pełnych, gumowych oponach. Potem na pneumatycznych oponach rowerowych stanowiących wynalazek szkockiego lekarza John’a Boyd’a Dunlopa.");
            randomFactsList.Add("Handbike - rower dla osób niepełnosprawnych. Jak sama nazwa wskazuje – jest napędzany siłą rąk.");
            randomFactsList.Add("Monocykl to rodzaj roweru posiadający jedno koło. Jest bardzo często wykorzystywany przez cyrkowców.");
            randomFactsList.Add("Najdłuższym rowerem na świecie (42 m) jechało równocześnie 20 osób. Rekord ustanowiono w 2015 roku w Australii, pokonując dystans 100 metrów.");
            randomFactsList.Add("Najmniejszy rower świata ma koła o średnicy 1,9 cm. W 1988 roku Australijczyk Neville Patten przejechał na nim 4 metry.");
            randomFactsList.Add("Najwyższy dwukołowy rower na świecie liczy 5,5 metra wysokości. Stworzył go Kubańczyk Felix Guirola.");
            randomFactsList.Add("Największy rower na świecie liczy 3,7 m wysokości i 7,8 m długości. Jego twórcą jest Niemiec Didi Senft.");
            randomFactsList.Add("Od 2000 roku rower szosowy biorący udział w zawodach nie może ważyć mniej niż 6,8 kg.");
            randomFactsList.Add("Fairwheel Bikes to firma, która stworzyła najlżejszy rower na świecie. Waży zaledwie 2,7 kg.");
            randomFactsList.Add("Instalacja Ghost Bike – rower w całości pomalowany na biało, najczęściej umieszczony na stałe – ma upamiętniać rowerzystę zabitego w wyniku wypadku drogowego.");
            randomFactsList.Add("Aktualny rekord prędkości w jeździe na rowerze poziomym po płaskiej nawierzchni z oporem powietrza wynosi 132,5 km/h.");
            randomFactsList.Add("Corocznie zmniejsza się liczba dzieci w wieku szkolnym korzystających z rowerów. Na przestrzeni ostatnich 30 lat spadła z 82% do 14%.");
            randomFactsList.Add("W latach 1911-1931 trasa Tour de France liczyła nawet 5000 km. Obecnie kolarze pokonują 60-70% tego dystansu.");
            randomFactsList.Add("Samochód osobowy wytwarza 12 razy więcej gramów CO2 na pasażera, na każdy pokonany kilometr niż rower.");
            randomFactsList.Add("Energia, którą pochłania produkcja jednego samochodu wystarczy na wyprodukowanie ponad 100 rowerów.");
            randomFactsList.Add("25-letni mężczyzna o wadze 73 kg i wzroście 173 cm pokonując na rowerze 100 km ze średnią prędkością 20 km/h spali około 3400 kcal.");
            randomFactsList.Add("Trzy godziny jazdy tygodniowo na rowerze zmniejszają ryzyko zawału serca aż o 50%.");
            randomFactsList.Add("Najwyższe teoretyczne przewyższenie trasy to 9279m. Rowerzysta musiałby dotrzeć na szczyt Mount Everestu z Wybrzeża Morza Martwego");
        }
    }
}
