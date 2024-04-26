using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace BackEnd
{
    public class Program
    {
        static string conexion = "server = locarhost; database= tarea;intergrated segurity=true";
        SqlConnection connection = new SqlConnection(conexion);
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

             app.MapGet("/", () => "Hello World!");
               
            // esto silver para llamar todo el repositorio  que cree en Repository
             app.MapGet("/Viaje", () => new Repository().GetViajes());

            //ahora hare una llamada para solo un objecto
             app.MapGet("/Viaje/{id}", (int id) => 
             {
                 var viaje = new Repository().GetViajes(id);
                 return viaje == null? 
                 Results.NotFound():
                 Results.Ok(viaje);
             });


            app.Run();
        }
    }
}
