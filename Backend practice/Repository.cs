namespace Backend_practice
{
    public class Repository
    {
        //List of brand beers
        List<Brewery> brewery = new List<Brewery>()
        {
            new Brewery(){ Id = 1 , Name = "Minerva"},
            new Brewery(){ Id = 2 , Name = "Belching Bearver" },
            new Brewery(){ Id = 3 , Name = "Samichlaus" }
        };

        //method to get the beers
        public List<Brewery> GetBreweries() => brewery;

        //method to find a specific beer
        public Brewery? GetBrewery(int id) => brewery.Find(r => r.Id == id);//lambda expression
    }


    public class Brewery
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
