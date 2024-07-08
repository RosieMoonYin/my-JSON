using System.Text.Json;


//serialize and deserialise and reads JSON file
public class Program 
{
    public static void Main (string []args)
    {
        // let's say this is not empty we got data from a source
            var alien = new Alien 
            {
                Id = 213,
                FirstName = "Bob",
                LastName = "D89564//",
                Planet = "Mars",
            };
            var alien2 = new Alien
            {
                Id = 21263,
                FirstName = "Stargirl",
                LastName = "TD892//",
                Planet = "Saturns Moon",
            };
            //serialize SAVE/CREATE JSON FILE alien2
            string fileName = "Alien.json";
            string jsonString = JsonSerializer.Serialize(alien);
            string jsonString2 = JsonSerializer.Serialize(alien2);
            //Console.WriteLine(jsonString);
            File.WriteAllText(fileName, jsonString);
            File.WriteAllText(fileName, jsonString2);
            Console.WriteLine(File.ReadAllText(fileName));

            //deserialize OPEN/READ JSON FILE alien1
            string fileNameread = "Alien.json";
            string jsonStringread = File.ReadAllText(fileNameread);
            Alien alienread = JsonSerializer.Deserialize<Alien>(jsonString)!;

            Console.WriteLine($"Id: {alien.Id}");
            Console.WriteLine($"Name: {alien.FirstName}");
            Console.WriteLine($"Planet: {alien.Planet}");
    }
}
//The JSON output is minified (whitespace, indentation, and new-line characters are removed) by default