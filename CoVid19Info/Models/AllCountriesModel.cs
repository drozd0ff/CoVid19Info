namespace CoVid19Info.Models
{
    public class AllCountriesModel
    {
        public int Id { get; set; }
        public long Updated { get; set; }
        public string Country { get; set; }
        //public CountryInfo CountryInfo { get; set; }
        public int Cases { get; set; }
        public int TodayCases { get; set; }
        public int Deaths { get; set; }
        public int TodayDeaths { get; set; }
        public int Recovered { get; set; }
        public int TodayRecovered { get; set; }
        public int Active { get; set; }
        public int Critical { get; set; }
        public double CasesPerOneMillion { get; set; }
        public double DeathsPerOneMillion { get; set; }
        public int Tests { get; set; }
        public double TestsPerOneMillion { get; set; }
        public int Population { get; set; }
        public string Continent { get; set; }
        public int OneCasePerPeople { get; set; }
        public int OneDeathPerPeople { get; set; }
        public int OneTestPerPeople { get; set; }
        public double ActivePerOneMillion { get; set; }
        public double RecoveredPerOneMillion { get; set; }
        public double CriticalPerOneMillion { get; set; }
    }
}