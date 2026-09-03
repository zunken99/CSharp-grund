using System.Collections;

namespace Dictionary;

class Program
{
    static void Main()
    {
        /*
        // Hashtable...
        Hashtable vehicles = new Hashtable();
        // Hashtable hash = [];
        vehicles.Add("ABC123", "Volvo");
        vehicles.Add("DEF456", "FIAT");

        Console.WriteLine(vehicles["DEF456"]);
        Console.WriteLine(vehicles.Contains("ABC124"));
        Console.WriteLine(vehicles.ContainsKey("ABC123"));
        Console.WriteLine(vehicles.ContainsValue("FIAT"));

        foreach (var item in vehicles)
        {
            Console.WriteLine(item);
        }
        */

        /*
        // SortedList<TKey,TValue>
        SortedList<string, string> vehicles = new SortedList<string, string>();
        // SortedList<string,string> vehicles = [];
        vehicles.Add("ABC123", "Volvo");
        vehicles.Add("DEF456", "FIAT");
        vehicles.Add("AAA123", "KIA");
        vehicles.Add("CCC222", "Renault");

        Console.WriteLine(vehicles["CCC222"]);

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle);
        }
        */

        // Dictionary
        Dictionary<string, string> vehicles = new Dictionary<string, string>();
        // Dictionary<string,string> vehicles = [];

        vehicles.Add("ABC123", "Volvo");
        vehicles.Add("DEF456", "FIAT");
        vehicles.Add("AAA123", "KIA");
        vehicles.Add("CCC222", "Renault");

        Console.WriteLine(vehicles["AAA123"]);

        // Undvik detta sätt att arbeta med Dictionary listor
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle);
        }

        foreach (KeyValuePair<string, string> vehicle in vehicles)
        {
            Console.WriteLine($"Key: {vehicle.Key}");
            Console.WriteLine($"Value:  {vehicle.Value}");
        }
    }
}
