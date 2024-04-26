
namespace BackEnd
{
    public class Repository
    {
        List<Viajes> Viajes = new List<Viajes>()
        {
            new(){ Id = 1, Name = "vladi"},
            new(){ Id = 2, Name = "lucas"},
            new(){ Id = 3, Name = "Steven"}
        };

        public List<Viajes> GetViajes() => Viajes;
        public Viajes? GetViajes(int id) => Viajes.Find(r => r.Id == id);



    }

    public class Viajes 
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
