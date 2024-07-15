using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment2
{
    public class Airports
    {

        
        /*async void _ImportAirportData()
        {
            //List <Airports> AirportObjList = new List<Airports>();

            //var path = Path.Combine(FileSystem.AppDataDirectory, "todo.json");
            
            var path = Path.Combine(FileSystem.OpenAppPackageFileAsync, "airports.csv");
            if (!File.Exists(path))
                return;
            var contents = File.ReadAllText(path);
            var savedItems = JsonSerializer.Deserialize<List<AirportObjList>>(contents);
            Airports.Clear();
            Airports.AddRange(savedItems);

            // Source: https://stackoverflow.com/a/74981885
            /*using var stream = await FileSystem.OpenAppPackageFileAsync("airports.csv");
            using var reader = new StreamReader(stream);

            var contents = reader.ReadToEnd();
            Console.WriteLine(contents);
        }*/

        /*public List<Airport> AirportList { get; private set; }

        private void Airports()
        {
            Airports = new List<Airport>();
        }

        private async void _ImportAirportData()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("airports.csv");
            using var reader = new StreamReader(stream);

            var contents = reader.ReadToEnd();
            Console.WriteLine(contents);
        }*/
    }
}
